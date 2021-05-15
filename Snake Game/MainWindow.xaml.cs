using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.InkML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Snake_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int snakeSquareSize = 15;
        const int startLength = 3;
        const int startSpeed = 350;
        const int speedTreshold = 100;

        private int snakeLength;
        private int currentScore = 0;

        private SolidColorBrush snakeBody = Brushes.Green;
        private SolidColorBrush snakeHead = Brushes.DarkGreen;
        private List<SnakeElement> snakeElements = new List<SnakeElement>();
        private UIElement food = null;
        private SolidColorBrush foodColor = Brushes.Orange;

       
        private Random rnd = new Random();
        public enum CurrentSnakeDirection { Up, Down, Right, Left};
        private CurrentSnakeDirection currentSnakeDirection = CurrentSnakeDirection.Right;
        private System.Windows.Threading.DispatcherTimer gameTimer = new System.Windows.Threading.DispatcherTimer();
        
        public MainWindow()
        {
           
           InitializeComponent();
            gameTimer.Tick += GameTimer_Tick;
        }



        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Movement();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            CurrentSnakeDirection originalDirection = currentSnakeDirection;

            switch(e.Key)
            {
                case Key.Up:
                    if (currentSnakeDirection != CurrentSnakeDirection.Down)
                        currentSnakeDirection = CurrentSnakeDirection.Up;
                            break;

                case Key.Down:
                    if (currentSnakeDirection != CurrentSnakeDirection.Up)
                        currentSnakeDirection = CurrentSnakeDirection.Down;    
                    break;

                case Key.Left:
                    if (currentSnakeDirection != CurrentSnakeDirection.Right)
                        currentSnakeDirection = CurrentSnakeDirection.Left;
                            break;

                case Key.Right:
                    if (currentSnakeDirection != CurrentSnakeDirection.Left)
                        currentSnakeDirection = CurrentSnakeDirection.Right;
                            break;

                case Key.Space:
                    StartNewGame();
                    break;
            }


            if (currentSnakeDirection != originalDirection)
                Movement();
        }


        private void StartNewGame()
        {
            foreach(SnakeElement snakeBodyElement in snakeElements)
            {
                if (snakeBodyElement.UiElement != null)
                    GameBoard.Children.Remove(snakeBodyElement.UiElement);
            }
            snakeElements.Clear();
            if (food != null)
                GameBoard.Children.Remove(food);
             
            //Reset 
            currentScore = 0;
            ImagePanel.Source = null;
            snakeLength = startLength;
            currentSnakeDirection = CurrentSnakeDirection.Right;
            snakeElements.Add(new SnakeElement() {Position = new System.Windows.Point(snakeSquareSize * 5, snakeSquareSize * 5)});
            gameTimer.Interval = TimeSpan.FromMilliseconds(startSpeed);

            SpawnSnake();
            SpawnFood();
            
            UpdateGame();
            gameTimer.IsEnabled = true;
        }


        private void UpdateGame()
        {
            Score.Content = currentScore;
        }

        private void EndGame()
        {
            gameTimer.IsEnabled = false;
            MessageBox.Show("You lost!\n\nPress Spacebar to start again!", "Snake Game");
        }


        private void SpawnSnake()
        {
            foreach (SnakeElement snakeElement in snakeElements)
            {
                if (snakeElement.UiElement == null)
                {
                    snakeElement.UiElement = new System.Windows.Shapes.Rectangle()
                    {
                    Width = snakeSquareSize,
                    Height = snakeSquareSize,
                    Fill = (snakeElement.IsHead ? snakeHead : snakeBody)
                    };

                    GameBoard.Children.Add(snakeElement.UiElement);
                    System.Windows.Controls.Canvas.SetTop(snakeElement.UiElement, snakeElement.Position.Y);
                    System.Windows.Controls.Canvas.SetLeft(snakeElement.UiElement, snakeElement.Position.X);
            }
        }
      
        }


        private void Movement()
        {
            while(snakeElements.Count >= snakeLength)
            {
                GameBoard.Children.Remove(snakeElements[0].UiElement);
                snakeElements.RemoveAt(0);
            }

            foreach (SnakeElement snakeElement in snakeElements)
            {
                (snakeElement.UiElement as System.Windows.Shapes.Rectangle).Fill = snakeBody;
                snakeElement.IsHead = false;
            }


            SnakeElement head = snakeElements[snakeElements.Count - 1];
            double nextXPosition = head.Position.X;
            double nextYPosition = head.Position.Y;

            switch (currentSnakeDirection)
            {
                case CurrentSnakeDirection.Up:
                    nextYPosition -= snakeSquareSize;
                    break;

                case CurrentSnakeDirection.Down:
                    nextYPosition += snakeSquareSize;
                    break;

                case CurrentSnakeDirection.Right:
                    nextXPosition += snakeSquareSize;
                    break;

                case CurrentSnakeDirection.Left:
                    nextXPosition -= snakeSquareSize;
                    break;                    
            }

            snakeElements.Add(new SnakeElement() 
            { 
            Position = new System.Windows.Point(nextXPosition,nextYPosition),
            IsHead = true
            });

            SpawnSnake();
            CheckCollision();
        }




        private System.Windows.Point NextFoodPosition()
        {
            int maximumX = (int)((GameBoard.ActualWidth - ScoreBoard.ActualWidth) / snakeSquareSize);
            int maximumY = (int)((GameBoard.ActualHeight) / snakeSquareSize);

            int foodX = rnd.Next(0, maximumX) * snakeSquareSize;
            int foodY = rnd.Next(0, maximumY) * snakeSquareSize;

            foreach(SnakeElement snakeElement in snakeElements)
            {
                if((snakeElement.Position.X == foodX) && (snakeElement.Position.Y == foodY))
                return NextFoodPosition();
                
            }

            return new System.Windows.Point(foodX, foodY);
        }



        private void SpawnFood()
        {
            System.Windows.Point foodPosition = NextFoodPosition();
            food = new System.Windows.Shapes.Rectangle()
            {
                Height = snakeSquareSize,
                Width = snakeSquareSize,
                Fill = foodColor
            };
            GameBoard.Children.Add(food);
            System.Windows.Controls.Canvas.SetTop(food, foodPosition.Y);
            System.Windows.Controls.Canvas.SetLeft(food, foodPosition.X);
            

        }


        private void GetRandomImage()
        {
            
             string[] images = { "http://cdn.pixabay.com/photo/2015/02/28/15/25/snake-653639_1280.jpg",
               "http://cdn.pixabay.com/photo/2014/12/25/14/54/snake-579682_1280.jpg",
                "http://cdn.pixabay.com/photo/2015/02/28/15/25/rattlesnake-653642_1280.jpg",
                "http://cdn.pixabay.com/photo/2012/10/10/05/07/grass-snake-60546_1280.jpg",
            "http://cdn.pixabay.com/photo/2010/12/14/16/46/snake-3237_1280.jpg"};

            BitmapImage bitmapImage = new BitmapImage(new Uri(images[rnd.Next(images.Length)]));



            //ImagePanel.Source = bitmapImage;
            
            ImagePanel.Dispatcher.BeginInvoke(new Action(() => ImagePanel.Source = bitmapImage));


        }

        private void Eat()
        {
            snakeLength++;
            currentScore++;
            int timerInterval = Math.Max(speedTreshold, (int)gameTimer.Interval.TotalMilliseconds - (currentScore * 2));
            gameTimer.Interval = TimeSpan.FromMilliseconds(timerInterval);
            GameBoard.Children.Remove(food);
            SpawnFood();
            UpdateGame();
        }



        private void CheckCollision()
        {
            SnakeElement head = snakeElements[snakeElements.Count - 1];

            if((head.Position.X == System.Windows.Controls.Canvas.GetLeft(food)) && (head.Position.Y == System.Windows.Controls.Canvas.GetTop(food)))
            {
                Eat();
                GetRandomImage();
                return;
            }
        
           if((head.Position.Y < 0) || (head.Position.Y >= GameBoard.ActualHeight) || (head.Position.X < 0) || (head.Position.X >= (GameBoard.Width - ScoreBoard.Width)-14))
            {
                EndGame();
            }
        
            foreach(SnakeElement snakeBodyElement in snakeElements.Take(snakeElements.Count-1))
            {
                if((head.Position.X == snakeBodyElement.Position.X) && (head.Position.Y == snakeBodyElement.Position.Y))
                {
                    EndGame();
                }
            }
        }



    }








}
