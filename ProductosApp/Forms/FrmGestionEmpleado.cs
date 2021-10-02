using Domain.Entities.Empleados;
using Infraestructure.Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Forms
{
    public partial class FrmGestionEmpleado : Form
    {

        private EmpleadoModel eModel;
        public FrmGestionEmpleado()
        {
            eModel = new EmpleadoModel();
            InitializeComponent();
        }

        private void btnCrearDocente_Click(object sender, EventArgs e)
        {
            Empleado emp = new Docente()
            {
                Id = eModel.GetLastEmpleadoId() + 1,
                Codigo = 11012,
                Cedula = "001-170705-1012X",
                Nombres = "Engel Alexander",
                Apellidos = "Hernandez Baca",
                Salario = 37000.99M,
                FechaContratacion = DateTime.Now,
                CategoriaDocente = Domain.Enums.CategoriaDocente.Titular
            };

            eModel.Create(emp);
            PrintEmpleado();
            rtbEmpleados.Text += eModel.GetEmpleadosAsJson();
        }



        private void rtbEmpleados_TextChanged(object sender, EventArgs e)
        {

        }

        public void PrintEmpleado()
        {
            Empleado[] empleados = eModel.GetEmpleados();

            if (empleados == null)
            {
                rtbEmpleados.Text = "No hay elementos a mostrar.";
                return;
            }

            rtbEmpleados.Text = "";

            foreach (Empleado e in empleados)
            {
                rtbEmpleados.AppendText(e.GetEmpleadoAsString());
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Empleado emp = new Administrativo()
            {
                Id = eModel.GetLastEmpleadoId() + 1,
                Codigo = 1000,
                Cedula = "001-000000-0000X",
                Nombres = "Ana Cecilia",
                Apellidos = "Conda Jimenez",
                Salario = 24000.99M,
                FechaContratacion = DateTime.Now,
                HorasExtras = 10.5f
            };

            eModel.Create(emp);
            PrintEmpleado();
            rtbEmpleados.Text += eModel.GetEmpleadosAsJson();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
