using System;

namespace sistemaDeAlarmasGym
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public DateTime? Ingreso { get; set; }
        public DateTime? Salida { get; set; }

        public string TipoEjercicio { get; set; } // ← ¡Nuevo campo!
    }
}
