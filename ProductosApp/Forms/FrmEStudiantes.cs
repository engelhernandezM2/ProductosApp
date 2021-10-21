using Domain.Entities.Estudiantes;
using Domain.Enums;
using Infraestructure.Estudiantes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Forms
{
    public partial class FrmEStudiantes : Form
    {
        public int id { get; set; }
        EstudiantesModel sModel;
        public FrmEStudiantes()
        {
            sModel = new EstudiantesModel();
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string patternDni = @"\d{3}-\d{6}-\d{4}[A-Z]{1}";
            if (TxtNombre.Text == "Nombres :")
            {
                errorProvider1.SetError(TxtNombre, "Vacio");
                return;
            }
            errorProvider1.SetError(TxtNombre, "Nombres :");

            if (TxtApellidos.Text == "Apellidos :")
            {
                errorProvider1.SetError(TxtApellidos, "Vacio");
                return;
            }
            errorProvider1.SetError(TxtApellidos, "Apellidos :");
            if (TxtCedula.Text == "Cedula :")
            {
                errorProvider1.SetError(TxtCedula, "Vacio");
                return;
            }
            errorProvider1.SetError(TxtCedula, "Cedula :");
            if (!Regex.Match(TxtCedula.Text, patternDni).Success)
            {
                MessageBox.Show("Malo");
                return;
            }
            errorProvider1.SetError(TxtCedula, "Cedula :");
            Estudiante est = new Estudiante()
            {
                Id = sModel.GetLastIdEstudent()+1,
                Nombres = TxtNombre.Text,
                Apellidos = TxtApellidos.Text,
                Edad = (byte)NupEdad.Value,
                FechaNacimineto = (DateTime)dtpNacimineto.Value,
                Cedula = TxtCedula.Text,
                Carrera = (Carrera)CmbCarrera.SelectedIndex
            };
            sModel.Create(est);
            MessageBox.Show("Nuevo estudiante Creado", "Nuevo Estudiante",MessageBoxButtons.OK, MessageBoxIcon.Information);
            RtbEstudiante.Text = sModel.GetProductosAsJson();
            Clean();
        }
        #region Validacion Y Mas
        private void Clean()
        {
            TxtNombre.Text = "Nombres :" ;
            TxtApellidos.Text = "Apellidos :";
            TxtCedula.Text = "Cedula :";

        }
        private void FrmEStudiantes_Load(object sender, EventArgs e)
        {
            CmbCarrera.Items.AddRange(Enum.GetValues(typeof(Carrera)).Cast<object>().ToArray());
        }
        #endregion



        #region CambiosdeTextBoxs
        private void TxtNombre_Enter(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "Nombres :")
            {
                TxtNombre.Text = "";
                TxtNombre.BackColor = Color.MediumBlue;
            }
        }

        private void TxtApellidos_Enter(object sender, EventArgs e)
        {
            if (TxtApellidos.Text == "Apellidos :")
            {
                TxtApellidos.Text = "";
                TxtApellidos.BackColor = Color.MediumBlue;
            }
        }
        private void TxtCedula_Enter(object sender, EventArgs e)
        {
            if (TxtCedula.Text == "Cedula :")
            {
                TxtCedula.Text = "";
                TxtCedula.BackColor = Color.MediumBlue;
            }
        }


        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "")
            {
                TxtNombre.Text = "Nombres :";
                TxtNombre.BackColor = Color.Navy;
            }
        }

        private void TxtApellidos_Leave(object sender, EventArgs e)
        {
            if (TxtApellidos.Text == "")
            {
                TxtApellidos.Text = "Apellidos :";
                TxtApellidos.BackColor = Color.Navy;
            }
        }

        private void TxtCedula_Leave(object sender, EventArgs e)
        {
            if (TxtCedula.Text == "")
            {
                TxtCedula.Text = "Cedula :";
                TxtCedula.BackColor = Color.Navy;
            }
        }
        #endregion

    }
}
