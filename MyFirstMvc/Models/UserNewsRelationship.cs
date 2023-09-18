namespace MyFirstMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserNewsRelationship
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int NewsId { get; set; }

        public virtual News News { get; set; }

        public virtual User User { get; set; }
    }
}
