using Data.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Entities
{
    class Subject: BaseEntity
    {
        public int Code { get; set; }
        [MaxLength(100)]
        public string Academic { get; set; }
        [MaxLength(100)]
        public string Virtual { get; set; }
        public int? TotalHours { get; set; }
        public virtual ICollection<StudentStatment> StudentStatments { get; set; }
        public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; }

    }
}
