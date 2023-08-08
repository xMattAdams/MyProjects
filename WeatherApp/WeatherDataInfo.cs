﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class WeatherDataInfo
    {
            public float latitude { get; set; }
            public float longitude { get; set; }
            public float generationtime_ms { get; set; }
            public int utc_offset_seconds { get; set; }
            public string timezone { get; set; }
            public string timezone_abbreviation { get; set; }
            public float elevation { get; set; }
            public Hourly_Units hourly_units { get; set; }
            public Hourly hourly { get; set; }
        
             
        public class Hourly_Units
        {
            public string time { get; set; }
            public string temperature_2m { get; set; }
        }

        public class Hourly
        {
            public IList<string> time { get; set; } = new List<string>();
            public IList<float> temperature_2m { get; set; } = new List<float>();
        }

    }
}
