using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entitiess
{
    internal class Patient
    {
        public int Id { get; set; }
        public string P_name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Dept_id { get; set; }
        public int Dr_id { get; set; }
        public bool Is_assigned {get; set;}
        public int Assigned_to_dr_id { get; set; }

    }
}
