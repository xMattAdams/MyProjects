using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        
        public void getWeatherData()
        {
            WeatherDataInfo data = ProvideData();
                for (int i = 0; i < data.hourly.time.Count; i++)
                {
                    DateTime dt = DateTime.ParseExact(data.hourly.time[i], "yyyy-MM-dd'T'HH:mm", CultureInfo.InvariantCulture);
                    string result = dt.ToString("d/M/yyyy HH:mm");
                    timeAndTempList.Items.Add(result + "   " + data.hourly.temperature_2m[i].ToString() + data.hourly_units.temperature_2m);
                }
            
        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            Regex ValidateText = new Regex(@"^[0-9.]+$");

            if (ValidateText.IsMatch(latitudeTextBox.Text) && ValidateText.IsMatch(longTextBox.Text)) {

                getWeatherData();
                validationLabel.Visible = false;
            }
            else
            {
                validationLabel.Visible = true;
            }
        
            if (timeAndTempList.Items != null)
            {
                avgButton.Enabled = true;
            }
        }
  
    
         public Dictionary<string, float> CalculateAverageTemp(WeatherDataInfo Data)
        {
            Dictionary<string, float> DayAndAvgTemp = new Dictionary<string, float>();
            List<float> TempList = Data.hourly.temperature_2m.ToList();
            List<string> TimeList = Data.hourly.time.ToList();
            

            for (int i = 0; i <= TimeList.Count - 24; i++) {

                List<float> TempListForCalc = TempList.GetRange(i, 24);
                List<string> TimeListForCalc = TimeList.GetRange(i, 24);

                float AverageTemp = TempListForCalc.Sum()/TempListForCalc.Count;
                DayAndAvgTemp.Add(TimeListForCalc.FirstOrDefault(), AverageTemp);
                
                TempListForCalc.Clear();
                TimeListForCalc.Clear();
   
                i += 23;
            }
            return DayAndAvgTemp;
        }

        private void avgButton_Click(object sender, EventArgs e)
        {
            WeatherDataInfo Data = ProvideData();
            var CalcData = CalculateAverageTemp(Data);
            
            foreach(var element in CalcData)
            {
                DateTime dt = DateTime.ParseExact(element.Key, "yyyy-MM-dd'T'HH:mm", CultureInfo.InvariantCulture);
                string result = dt.ToString("d/M/yyyy");
                avgListBox.Items.Add(result + "  " + element.Value.ToString() + Data.hourly_units.temperature_2m);
            }
        }
    }
}
