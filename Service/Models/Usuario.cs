namespace Service.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty; // Hash recomendado
        public Rol rol { get; set; }
        public bool IsDeleted { get; set; } = false;

        public override string ToString()
        {
            return $"{Nombre} ({rol}) - {Correo}";
        }
    }
}

