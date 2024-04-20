

namespace energyPowerOptimization
{
    class SolarPanel
    {
    public int numberOfPanels { get; set; }
    public double ratedPowerWatts { get; set; }
    public double sunlightHours { get; set; }
        

    public SolarPanel(int numberOfPanels, double ratedPowerWatts, double sunlightHours)
        {
            this.numberOfPanels = numberOfPanels;
            this.ratedPowerWatts = ratedPowerWatts;
            this.sunlightHours = sunlightHours;
        }
    
    public double calculateEstimatedOutputKWh()
        {
            double totalRatedPowerWatts = this.numberOfPanels * this.ratedPowerWatts;
            double outputWh = totalRatedPowerWatts * this.sunlightHours * .75;
            return outputWh / 1000; //convert to kilowatt-hours
        }
    }
}
