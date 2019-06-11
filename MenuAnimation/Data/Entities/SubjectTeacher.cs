using Data.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Entities
{
    class SubjectTeacher: BaseIdEntity
    {
        [ForeignKey("Branch")]
        public int? IdBranch { get; set; }
        [ForeignKey("Subject")]
        public int? IdSubject { get; set; }
        [ForeignKey("Teacher")]
        public int? hoursAca { get; set; }
        public int? hoursExp { get; set; }
        public int? hoursVirt { get; set; }



        public int? IdTeacher { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
         

    }
}
