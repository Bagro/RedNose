namespace Updater.Entities
{
    public class OpenHours
    {
        public bool Closed { get; set; }
        
        public string Date { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public string SpecialDayName { get; set; }
    }
}