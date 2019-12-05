using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HealthTracker.Data
{
    public class HealthData
    {
        public List<ChartData> Calories { get; set; }
        public List<ChartData> BreakFast { get; set; } = new List<ChartData>();
        public List<ChartData> Lunch { get; set; } = new List<ChartData>();
        public List<ChartData> Snack { get; set; } = new List<ChartData>();
        public List<ChartData> Dinner { get; set; } = new List<ChartData>();
    }

    public class ChartData: INotifyPropertyChanged
    {
        public string X { get; set; }
        public double Y
        {
            get { return y; }
            set
            {
                y = value;
                NotifyPropertyChanged("Y");
            }
        }
        public double y { get; set; }
        public string R { get; set; } = "";
        public string Text { get; set; } = "";

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Data
    {
        public string Day { get; set; }
        public double Value { get; set; }
        public double Size { get; set; } = 0;
    }
}
