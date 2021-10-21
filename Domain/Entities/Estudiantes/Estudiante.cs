using Domain.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Estudiantes
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Estudiante
    {
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string Nombres { get; set; }
        [JsonProperty]
        public string Apellidos { get; set; }
        [JsonProperty]
        public byte Edad { get; set; }
        [JsonProperty]
        public DateTime FechaNacimineto { get; set; }
        [JsonProperty]
        public string Cedula { get; set; }
        [JsonProperty]
        public Carrera Carrera { get; set; }
    }
}
