using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthTracker.Data
{
    public class ThursdayService
    {

        public List<ChartData> Calory()
        {
            List<ChartData> Data = new List<ChartData> {
               new ChartData { X = "Protein", Y = 32 } ,
                new ChartData { X = "Fat", Y = 18 } ,
                new ChartData { X = "Fiber", Y = 19 } ,
                new ChartData { X = "Calcium", Y = 15 } ,
                new ChartData { X = "Vitamins", Y = 30 } ,
                new ChartData { X = "Carbs", Y = 31 }
            };
            return (Data);

        }

        public List<ChartData> BreakFast()
        {
            List<ChartData> Data = new List<ChartData> {
                new ChartData { X = "Protein", Y = 5 } ,
                new ChartData { X = "Fat", Y = 2 } ,
                new ChartData { X = "Fiber", Y = 1 } ,
                new ChartData { X = "Calcium", Y = 15 } ,
                new ChartData { X = "Vitamins", Y = 30 } ,
                new ChartData { X = "Carbs", Y = 10 }
            };
            return (Data);
        }

        public List<ChartData> Lunch()
        {
            List<ChartData> Data = new List<ChartData> {
                new ChartData { X = "Protein", Y = 10 } ,
                new ChartData { X = "Fat", Y = 5.5 } ,
                new ChartData { X = "Fiber", Y = 2.5 } ,
                new ChartData { X = "Calcium", Y = 15 } ,
                new ChartData { X = "Vitamins", Y = 30 } ,
                new ChartData { X = "Carbs", Y = 20 }
            };
            return (Data);
        }

        public List<ChartData> Snack()
        {
            List<ChartData> Data = new List<ChartData> {
                new ChartData { X = "Protein", Y = 5 } ,
                new ChartData { X = "Fat", Y = 1 } ,
                new ChartData { X = "Fiber", Y = 1 } ,
                new ChartData { X = "Calcium", Y = 15 } ,
                new ChartData { X = "Vitamins", Y = 30 } ,
                new ChartData { X = "Carbs", Y = 8 }
            };
            return (Data);
        }

        public List<ChartData> Dinner()
        {
            List<ChartData> Data = new List<ChartData> {
                new ChartData { X = "Protein", Y = 10 } ,
                new ChartData { X = "Fat", Y = 12.5 } ,
                new ChartData { X = "Fiber", Y = 12.5 } ,
                new ChartData { X = "Calcium", Y = 15 } ,
                new ChartData { X = "Vitamins", Y = 30 } ,
                new ChartData { X = "Carbs", Y = 12 }
            };
            return (Data);
        }

        public ObservableCollection<ChartData> Water()
        {
            ObservableCollection<ChartData> Data = new ObservableCollection<ChartData>
            {
                new ChartData { X = "00.00", Y = 0.3, Text = "00:00 - 03:00"},
                new ChartData { X = "3.00", Y = 0, Text = "03:00 - 6:00"},
                new ChartData { X = "06.00", Y = 1, Text = "06:00 - 09:00"},
                new ChartData { X = "09.00", Y = 0.7, Text = "09:00 - 12:00"},
                new ChartData { X = "12.00", Y = 1.5, Text = "12:00 - 15:00"},
                new ChartData { X = "15.00", Y = 2, Text = "15:00 - 18:00"},
                new ChartData { X = "18.00", Y = 0.7, Text = "18:00 - 21:00"},
                new ChartData { X = "21.00", Y = 1, Text = "21:00 - 24:00"},
            };
            return (Data);
        }

        public List<ChartData> StepsStepData()
        {
            List<ChartData> Data = new List<ChartData>
                {
                    new ChartData { X = "Taken", Y = 7000 },
                    new ChartData { X = "Left", Y = 1700 }
                };
            return (Data);
        }

        public List<ChartData> StepsExcerciseData()
        {
            List<ChartData> Data = new List<ChartData>
                {
                    new ChartData { X = "Taken", Y = 5200 },
                    new ChartData { X = "Left", Y = 1200 }
                };
            return (Data);
        }

        public List<ChartData> StepsHoursData()
        {
            List<ChartData> Data = new List<ChartData>
                {
                    new ChartData { X = "Taken", Y = 7200 },
                    new ChartData { X = "Left", Y = 2000 }
                };
            return (Data);
        }
        public List<ChartData> Sleep()
        {
            List<ChartData> Data = new List<ChartData>
                {
                    new ChartData { X = "Light Sleep", Y = 20, Text = "10:30 pm - 11:24 pm" },
                    new ChartData { X = "Deep Sleep", Y = 15, Text = "11:24 am - 1:12 am" },
                    new ChartData { X = "Awake", Y = 3, Text = "1:12 am - 1:25 am" },
                    new ChartData { X = "REM", Y = 3, Text = "1:25 am - 1:52 am" },
                    new ChartData { X = "Deep Sleep", Y = 20, Text = "1:52 am - 3:45 am" },
                    new ChartData { X = "Awake", Y = 2, Text = "3:45 am - 3.58am" },
                    new ChartData { X = "Light sleep", Y = 10, Text = "3:58 am - 5.20am" },
                    new ChartData { X = "REM", Y = 2, Text = "5.20am - 5.47am" },
                    new ChartData { X = "Deep Sleep", Y = 25, Text = "5.47am - 7.30am" },

                };
            return (Data);

        }
        public HealthData Thursday()
        {
            return (new HealthData { Calories = this.Calory() });
        }
    }
}
