using System;
using System.Collections.Generic;
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
        public List<byte[]> Images { get; set; }
    }

}