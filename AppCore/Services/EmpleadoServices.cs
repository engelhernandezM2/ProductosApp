using AppCore.Interfaces;
using Domain.Entities.Empleados;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class EmpleadoServices : IEmpleadoServicio
    {

        private IEmpleadoModel eModel;

        public EmpleadoServices(IEmpleadoModel eModel)
        {
            this.eModel = eModel;
        }

        public void Create (Empleado t)
        {
            eModel.Create(t);
        }

        public bool Delete (Empleado t)
        {
            return eModel.Delete(t);
        }

        public Empleado[] FindAll()
        {
            return eModel.FindAll();
        }

        public Empleado FindbyId(int id)
        {
            return eModel.FindById(id);
        }

        public int GetLastEmpleadoid()
        {
            return eModel.GetLastEmpleadoId();
        }

        public int Update(Empleado t)
        {
            return eModel.Update(t);
        }
    }
}
