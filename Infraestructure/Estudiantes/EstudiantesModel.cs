using Domain.Entities.Estudiantes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Estudiantes
{
    public class EstudiantesModel
    {
        private Estudiante[] estudiantes;
        public void Create(Estudiante e)
        {
            if(estudiantes == null)
            {
                estudiantes = new Estudiante[1];
                estudiantes[0] = e;
                return;
            }
            Estudiante[] tmp = new Estudiante[estudiantes.Length + 1];
            Array.Copy(estudiantes, tmp, estudiantes.Length);
            tmp[tmp.Length - 1] = e;
            estudiantes = tmp;
        } 
        public Estudiante[] GetEstudiantes()
        {
            return this.estudiantes;
        }
        public int GetLastIdEstudent()
        {
            return estudiantes == null ? 0 : estudiantes[estudiantes.Length - 1].Id;
        }
        public string GetProductosAsJson()
        {
            return JsonConvert.SerializeObject(estudiantes);
        }
    }
}
