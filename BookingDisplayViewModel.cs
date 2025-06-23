namespace EventEaseBookingSystem.ViewModels
{
    public class BookingDisplayViewModel
    {
        public int BookingId { get; set; }
        public string EventName { get; set; }
        public string VenueName { get; set; }
        public string EventTypeName { get; set; }
        public DateTime Date { get; set; }
        public bool VenueAvailable { get; set; }

        // Filters/Search
        public string SearchTerm { get; set; }
        public int? SelectedEventTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
