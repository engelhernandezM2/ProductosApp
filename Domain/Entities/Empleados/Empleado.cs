using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Empleados
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class Empleado
    {
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public int Codigo { get; set; }
        [JsonProperty]
        public string Cedula { get; set; }
        [JsonProperty]
        public string Nombres { get; set; }
        [JsonProperty]
        public string Apellidos { get; set; }
        [JsonProperty]
        public decimal Salario { get; set; }
        [JsonProperty]
        public DateTime FechaContratacion { get; set; }

        protected Empleado(int codigo, string cedula, string nombres, string apellidos, decimal salario, DateTime fechaContratacion)
        {
            Codigo = codigo;
            Cedula = cedula;
            Nombres = nombres;
            Apellidos = apellidos;
            Salario = salario;
            FechaContratacion = fechaContratacion;
        }

        public abstract string GetEmpleadoAsString();
    }
}
