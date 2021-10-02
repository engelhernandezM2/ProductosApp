using Domain.Entities.Empleados;
using Domain.Enums;
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
    public partial class NuevoDocente : Form
    {
        EmpleadoModel eModel { get; set; }
        public NuevoDocente()
        {
            eModel = new EmpleadoModel();
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || 
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text) ||
                string.IsNullOrWhiteSpace(CmbCategoria.Text))
            {
                MessageBox.Show("Debe de ingresar todos los valores ", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            CategoriaDocente cat = (CategoriaDocente)CmbCategoria.SelectedIndex;
            
            Empleado emp = new Docente()
            {
                Id = eModel.GetLastEmpleadoId() + 1,
                Codigo = Convert.ToInt32(txtCodigo.Text),
                Cedula = txtCedula.Text,
                Nombres = txtNombre.Text,
                Apellidos = txtApellido.Text,
                Salario = Convert.ToInt32(txtSalario.Text),
                FechaContratacion = dtpContratacion.Value,
                CategoriaDocente = cat
            };

            eModel.Create(emp);

            MessageBox.Show("Nuevo Docente Agregado ID : "+emp.Id,"NUEVO",MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            if (MessageBox.Show("Desea Crear un nuevo docente ","Nuevo",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                FrmGestionEmpleado f1 = new FrmGestionEmpleado();
                f1.Show();
            }
           
        }

        
        }
    }

