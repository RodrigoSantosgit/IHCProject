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
        }
    }
}
