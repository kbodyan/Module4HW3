﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEF.Entities
{
    public class EmployeeProject
    {
        public int Id { get; set; }
        public decimal Rate { get; set; }
        public DateTime StartedDate { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
