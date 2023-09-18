namespace MyFirstMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Photo
    {
        public int ID { get; set; }

        public int RoomID { get; set; }

        public int RoomTypeID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string URL { get; set; }

        public virtual Room Room { get; set; }

        public virtual Roomtype Roomtype { get; set; }
    }
}
