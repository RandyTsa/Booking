namespace MyFirstMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            UserQuestionRelationships = new HashSet<UserQuestionRelationship>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Tilte { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public DateTime CreateTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserQuestionRelationship> UserQuestionRelationships { get; set; }
    }
}
