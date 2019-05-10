using Data.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Entities
{
    class Section: BaseEntity
    {
        [ForeignKey("Branch")]
        public int? IdBranch { get; set; }
        public virtual Branch Branch { get; set; }


    }
}
