using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VacationPlanner.Models
{
    public class Vacation
    {
        [Key]
        public int VacationId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime RegDate { get; set; }


        public int EmpId { get; set; }
        public Employee Employee { get; set; }
        
    }
}
