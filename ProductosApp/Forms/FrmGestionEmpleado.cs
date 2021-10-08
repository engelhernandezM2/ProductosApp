using AppCore.Interfaces;
using AppCore.Procesosss;
using AppCore.Services;
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
        private IEmpleadoServicio eService;
        // private EmpleadoModel eModel;
        private SalaryCalculator salaryCalculator;
        public FrmGestionEmpleado(IEmpleadoServicio eService)
        {
            this.eService = eService;
            salaryCalculator = new SalaryCalculator();
            //eModel = new EmpleadoModel();
            InitializeComponent();
        }

        private void btnCrearDocente_Click(object sender, EventArgs e)
        {
            Empleado emp = new Docente(11012, "001-170705-1012X", "Engel Alexander", "Hernandez Baca",
                37000.99M, DateTime.Now)
            {
                Id = eService.GetLastEmpleadoid() + 1,
                CategoriaDocente = Domain.Enums.CategoriaDocente.Titular
            };

            eService.Create(emp);
            PrintEmpleado();
           // rtbEmpleados.Text += eService.GetEmpleadosAsJson();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Empleado emp = new Administrativo(1000, "001-000000-0000X", "Cristhel Lucia " +""
               , "Hernandez Elizondo ",
                24000.99M, DateTime.Now)
            {
                Id = eService.GetLastEmpleadoid() + 1,
                HorasExtras = 10.5f
            };

            eService.Create(emp);
            PrintEmpleado();
            //rtbEmpleados.Text += eService.GetEmpleadosAsJson();
        }
        public void PrintEmpleado()
        {
            Empleado[] empleados = eService.FindAll();

            if (empleados == null)
            {
                rtbEmpleados.Text = "No Hay Empleados para Mostrar";
                return;
            }
            rtbEmpleados.Text = "";

            foreach (Empleado e in empleados)
            {
                rtbEmpleados.AppendText(e.GetEmpleadoAsString());
                rtbEmpleados.AppendText($"Salario neto: {salaryCalculator.CalcularSalary(e)} \n");
            }
        }
        private void FrmGestionEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
