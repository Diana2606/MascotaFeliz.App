using System.Collections.Generic;

namespace MascotaFeliz.App.Dominio
{
    public class Consulta
    {
        public int IdConsulta { get; set; }
        public int IdVeterinario { get; set; }
        public string FechaVisita { get; set; }
        public int FrecuenciaRespiratoria { get; set; }
        public int FrecuenciaCardiaca { get; set; }
        public float Temperatura { get; set; }
        public float Peso { get; set; }
        public string EstadoAnimo { get; set; }
        public string Diagnostico  { get; set; }
        public string Recomendaciones { get; set; }
    }
}