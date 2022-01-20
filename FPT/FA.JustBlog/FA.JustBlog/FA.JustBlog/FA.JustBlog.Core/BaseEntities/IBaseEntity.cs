using FA.JustBlog.Core.Enums;
using System;

namespace FA.JustBlog.Core.BaseEntities
{
    public interface IBaseEntity
    {
        //Status Status { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime UpdatedOn { get; set; }
    }
}
