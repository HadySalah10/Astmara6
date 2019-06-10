
using Data.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    class Branch : BaseIdEntity
    {
        public String TypeOfBranch { get; set; }

        public virtual ICollection<Section> Sections { get; set; }
        public virtual ICollection<StudentStatment> StudentStatments { get; set; }
        public virtual ICollection<SubjectTeacherLoad> StudentStatmentLoads { get; set; }

        public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; }
    }
}
