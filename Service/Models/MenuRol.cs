using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class MenuRol
    {
        public int Id { get; set; }
        public int IdMenu { get; set; }
        public int IdRol { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}

