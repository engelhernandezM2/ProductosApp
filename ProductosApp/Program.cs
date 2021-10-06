using AppCore.Interfaces;
using AppCore.Services;
using Autofac;
using Domain.Interfaces;
using Infraestructure.Empleados;
using ProductosApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var builder = new ContainerBuilder();

            //builder.RegisterType<EmpleadoModel>().As<IEmpleadoModel>();
            //builder.RegisterType<EmpleadoServices>().As<IEmpleadoServicio>();

            //var container = builder.Build();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmGestionEmpleado(container.Resolve<IEmpleadoServicio>()));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmProductManage());
        }
    }
}
