using FA.JustBlog.Core.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FA.JustBlog.Core.BaseEntities
{
    public abstract class BaseEntity : IBaseEntity
    {
        //[Required]
        //public Status Status { get ; set ; }

        [Required]
        [Column(TypeName = "DateTime2")]
        public DateTime CreatedOn { get ; set ; }

        [Required]
        [Column(TypeName = "DateTime2")]
        public DateTime UpdatedOn { get ; set ; }
    }
}
