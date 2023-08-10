using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        public WeatherDataInfo ProvideData()
        {
            using (WebClient wc = new WebClient())
            {
                string url = string.Format("https://api.open-meteo.com/v1/forecast?latitude={0}&longitude={1}&hourly=temperature_2m", latitudeTextBox.Text, longTextBox.Text);
                var json = wc.DownloadString(url);
                WeatherDataInfo data = JsonConvert.DeserializeObject<WeatherDataInfo>(json);
                return data;
            }  
        }

        
        public void GetWeatherData()
        {
            WeatherDataInfo Data = ProvideData();
            
            string beforeEncode = Data.hourly_units.temperature_2m;
            byte[] bytes = Encoding.Default.GetBytes(beforeEncode);
            string afterEncode = Encoding.UTF8.GetString(bytes);

            for (int i = 0; i < Data.hourly.time.Count; i++)
                {
                    DateTime dt = DateTime.ParseExact(Data.hourly.time[i], "yyyy-MM-dd'T'HH:mm", CultureInfo.InvariantCulture);
                    string result = dt.ToString("d/M/yyyy HH:mm");
                   
                    timeAndTempList.Items.Add(result + "   " + Data.hourly.temperature_2m[i].ToString() + " " + afterEncode);
                }

            var CalcData = CalculateAverageTemp(Data);

            foreach (var element in CalcData)
            {
                DateTime dt = DateTime.ParseExact(element.Key, "yyyy-MM-dd'T'HH:mm", CultureInfo.InvariantCulture);
                string result = dt.ToString("d/M/yyyy");
                
                avgListBox.Items.Add(result + "  " + element.Value.ToString() + " " + afterEncode);
            }

        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            Regex ValidateText = new Regex(@"^[0-9.]+$");

            if (ValidateText.IsMatch(latitudeTextBox.Text) && ValidateText.IsMatch(longTextBox.Text)) {

                GetWeatherData();
                validationLabel.Visible = false;
            }
            else
            {
                validationLabel.Visible = true;
            }

            saveToFileButton.Enabled = true;
        }
  
    
         public Dictionary<string, float> CalculateAverageTemp(WeatherDataInfo Data)
        {
            Dictionary<string, float> DayAndAvgTemp = new Dictionary<string, float>();
            List<float> TempList = Data.hourly.temperature_2m.ToList();
            List<string> TimeList = Data.hourly.time.ToList();
            

            for (int i = 0; i <= TimeList.Count - 24; i++) {

                List<float> TempListForCalc = TempList.GetRange(i, 24);
                List<string> TimeListForCalc = TimeList.GetRange(i, 24);

                float AverageTemp = (TempListForCalc.Sum()/TempListForCalc.Count);
                var RoundedValue = Math.Round(AverageTemp, 2, MidpointRounding.ToEven);
                DayAndAvgTemp.Add(TimeListForCalc.FirstOrDefault(), (float)RoundedValue);
                
                TempListForCalc.Clear();
                TimeListForCalc.Clear();
   
                i += 23;
            }
            return DayAndAvgTemp;
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Title = "Save file";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = File.Create(saveFileDialog.FileName))
                using (StreamWriter streamWriter = new StreamWriter(stream))
                {
                    streamWriter.WriteLine("Hourly temperature for each day: ");
                    foreach(var listItem in timeAndTempList.Items)
                    {
                        streamWriter.WriteLine(listItem.ToString());
                    }
                    streamWriter.WriteLine("Average temperature for each day: ");

                    foreach(var avgListItem in avgListBox.Items)
                    {
                        streamWriter.WriteLine(avgListItem.ToString());
                    }
                }
                   
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop)
            {
                Application.Exit();
            }
        }
    }
}
