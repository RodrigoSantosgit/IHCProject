using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHCProject
{
    public class ViewModel
    {
        public List<TempValues> Data { get; set; }
        public List<HumValues> DataHumidity { get; set; }
        public List<EEValues> DataEE { get; set; }
        public List<CO2Values> DataCO2 { get; set; }
        public ViewModel()
        {
            Data = new List<TempValues>()
            {
                new TempValues {Month = "JAN", Value = 18},
                new TempValues {Month = "FEB", Value = 18.5},
                new TempValues {Month = "MAR", Value = 19},
                new TempValues {Month = "APR", Value = 20.3},
                new TempValues {Month = "MAY", Value = 22}
            };

            DataHumidity = new List<HumValues>()
            {
                new HumValues {Month = "JAN", Value = 40},
                new HumValues {Month = "FEB", Value = 49},
                new HumValues {Month = "MAR", Value = 47},
                new HumValues {Month = "APR", Value = 39},
                new HumValues {Month = "MAY", Value = 35}
            };

            DataEE = new List<EEValues>()
            {
                new EEValues {Month = "JAN", Value = 350},
                new EEValues {Month = "FEB", Value = 362},
                new EEValues {Month = "MAR", Value = 359},
                new EEValues {Month = "APR", Value = 380},
                new EEValues {Month = "MAY", Value = 420}
            };

            DataCO2 = new List<CO2Values>()
            {
                new CO2Values {Month = "JAN", Value = 950},
                new CO2Values {Month = "FEB", Value = 980},
                new CO2Values {Month = "MAR", Value = 925},
                new CO2Values {Month = "APR", Value = 1022},
                new CO2Values {Month = "MAY", Value = 1005}
            };
        }
    }
}
