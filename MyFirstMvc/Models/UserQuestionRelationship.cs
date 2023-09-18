namespace MyFirstMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserQuestionRelationship")]
    public partial class UserQuestionRelationship
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }

        public virtual User User { get; set; }
    }
}
