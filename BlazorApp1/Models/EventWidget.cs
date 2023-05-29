using System;
namespace BlazorApp1.Models
{
    public class EventWidget
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset EventDate { get; set; }
        public string PhotoUrl { get; set; }
        public int EventMonth => EventDate.Month;
        public int EventDay => EventDate.Day;

    }
}
