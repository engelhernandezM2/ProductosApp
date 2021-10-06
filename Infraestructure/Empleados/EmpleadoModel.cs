using Domain.Entities.Empleados;
using Domain.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Empleados
{
    public class EmpleadoModel : IEmpleadoModel
    {
        private Empleado[] empleados;
        public void Create(Empleado e)
        {
            if(empleados == null)
            {
                empleados = new Empleado[1];
                empleados[0] = e;
                return;
            }

            Empleado[] temp = new Empleado[empleados.Length + 1];
            Array.Copy(empleados,temp,empleados.Length);
            temp[temp.Length - 1] = e;

            empleados = temp;
        }

        public int GetLastEmpleadoId()
        {
            return empleados == null ? 0 : empleados[empleados.Length - 1].Id;
        }

        public Empleado [] FindAll()
        {
            return empleados;
        }

       /*private int GetIndexById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El id no puede ser negativo");
            }
            int index = int.MinValue;
            if (empleados == null)
            {
                return index;
            }
            for (int i =0; i == empleados.Length; i++)
            {
                if (id == empleados[i].Id)
                {
                    index = i;
                    //return index;
                }
            }
            return index;
        }
       */
        public string GetEmpleadosAsJson()
        {
            return JsonConvert.SerializeObject(empleados);
        }

        public Empleado FindById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Empleado t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Empleado t)
        {
            throw new NotImplementedException();
        }
    }
}
