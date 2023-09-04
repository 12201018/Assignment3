using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment3.Models
{
    public class Registration
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }

        // Foreign keys
        public int MemberId { get; set; }
        public int ClassId { get; set; }
        public int TrainingSessionId { get; set; }

        // Navigation properties
        public Member Members { get; set; }
        public Class Classs { get; set; }
        public Session Sessions { get; set; }
    }
}