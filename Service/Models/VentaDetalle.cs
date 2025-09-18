using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class VentaDetalle
    {
        public int Id { get; set; }
        public Venta venta { get; set; }
        public Producto producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioTotal => Cantidad * PrecioUnitario;
        public bool IsDeleted { get; set; } = false;


        public override string ToString()
        {
            return $"Se vendio: {producto}, Cant: {Cantidad} al precio de: {PrecioUnitario:C}, en total seria: {PrecioTotal}";
        }
    }
}
