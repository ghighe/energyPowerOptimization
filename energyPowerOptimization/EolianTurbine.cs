using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace energyPowerOptimization
{
    class EolianTurbine
    {
        public int NumberOfTurbines { get; set; }
        public double RatedPowerWatts { get; set; }
        public double PeakDailyWindSpeed { get; set; }

        public EolianTurbine(int NumberOfTurbines, double RatedPowerWatts, double PeakDailyWindSpeed)
        {
            this.NumberOfTurbines = NumberOfTurbines;
            this.RatedPowerWatts = RatedPowerWatts;
            this.PeakDailyWindSpeed = PeakDailyWindSpeed;
        }

        public double CalculateEstimatedOutputKWh()
        {
            double totalRatedPowerWatts = this.NumberOfTurbines * this.RatedPowerWatts;
            double outputWh = totalRatedPowerWatts * this.PeakDailyWindSpeed * 0.75;

            return outputWh / 1000; // Convert watt-hours to kilowatt-hours 
        }
    }
}
