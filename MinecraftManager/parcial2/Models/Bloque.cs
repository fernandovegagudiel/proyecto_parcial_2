using System;

namespace MinecraftManager.Models
{
    public class Bloque
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Rareza { get; set; }
        public int Cantidad { get; set; }
        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Tipo: {Tipo}, Rareza: {Rareza},Cantidad: {Cantidad}" ;
        }
        public class InventarioBloqueViewModel
        {
            public int? Id { get; set; }
            public string? Nombre { get; set; }
            public string? Tipo { get; set; }

           
            // Agrega aquí las demás propiedades que quieras mostrar
        }
    }
}