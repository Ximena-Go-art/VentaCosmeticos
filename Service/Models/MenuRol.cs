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
        public Menu menu { get; set; }
        public Rol rol { get; set; } 
        public bool IsDeleted { get; set; } = false;

    }
}

