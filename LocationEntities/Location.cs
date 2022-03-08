using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocationEntities
{
    public class Location
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string id { get; set; }
        public string LocationName { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Address { get; set; }
        public DateTime OpeningTime { get; set; }
        
        public DateTime ClosingTime { get; set; }
    }
}
