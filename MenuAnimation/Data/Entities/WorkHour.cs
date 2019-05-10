using Data.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Entities
{
    class WorkHour: BaseIdEntity
    {
        [MaxLength(100)]
        public string Rank { get; set; }

        public int? HoursOfQuorum { get; set; }

        public bool? AcademicOrVirtual { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }




    }
}
