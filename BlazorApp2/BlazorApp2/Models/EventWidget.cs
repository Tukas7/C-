using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Models
{
    public class EventWidget
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime EventDate { get; set; }
        public string PhotoUrl { get; set; }
        public int EventMonth => EventDate.Month;
        public int EventDay => EventDate.Day;
        public int EventYear => EventDate.Year;
    }
}