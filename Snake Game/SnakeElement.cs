using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Snake_Game
{
    class SnakeElement
    {
        public UIElement UiElement { get; set; }
        public Point Position { get; set; }
        public bool IsHead { get; set; }
    }
}
