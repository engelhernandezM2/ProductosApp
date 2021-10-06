using Domain.Entities.Empleados;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IEmpleadoServicio :IService<Empleado>
    {
        Empleado FindbyId(int id);
        int GetLastEmpleadoid();
    }
}
