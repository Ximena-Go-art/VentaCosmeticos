using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public Usuario usuario { get; set;} // ID del usuario que realiza la venta
        public DateTime Fecha { get; set; } = DateTime.Now;//muestra la fecha a la hora de realizar la venta
        public decimal PrecioTotal { get; set; }
        public string Estado { get; set; } = "pendiente"; // pendiente, pagada, enviada, cancelada
        public bool IsDeleted { get; set; } = false;

        public override string ToString()
        {
            return $"Venta #{Id} - Total: {PrecioTotal:C} - Estado: {Estado} - Realizada por: {usuario}";
        }
    }
}
