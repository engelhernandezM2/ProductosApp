using AppCore.Interfaces;
using AppCore.Services;
using Autofac;
using Domain.Interfaces;
using Infraestructure.Empleados;
using ProductosApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Presentation
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        #region "Usuario y Contra"
        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUser.Text == "  UserName :")
            {
                TxtUser.Text = "";
                TxtUser.ForeColor = Color.LightGray;
            }
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (TxtUser.Text == "")
            {
                TxtUser.Text = "  UserName :";
                TxtUser.ForeColor = Color.Silver;
            }
        }

        private void TxtPass_Enter(object sender, EventArgs e)
        {
            if (TxtPass.Text == "  PassWord :")
            {
                TxtPass.Text = "";
                TxtPass.ForeColor = Color.LightGray;
                TxtPass.UseSystemPasswordChar = true;
            }
        }

        private void TxtPass_Leave(object sender, EventArgs e)
        {
            if (TxtPass.Text == "")
            {
                TxtPass.Text = "  PassWord :";
                TxtPass.ForeColor = Color.Silver;
                TxtPass.UseSystemPasswordChar = false;
            }
        }
        #endregion

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string u = TxtUser.Text, c = TxtPass.Text;
            Validar(u, c);
        }
        #region "Metodos Privados"
        private void Validar(string u, string c)
        {
            string user = "engelh", Contraseña = "170705";
            if (TxtUser.Text == "  UserName :")
            {
                errorProvider1.SetError(TxtUser, "Debe ingresar un usuario");
                return;
            }
            errorProvider1.SetError(TxtUser, "  UserName :");

            if (TxtPass.Text == "  PassWord :")
            {
                errorProvider1.SetError(TxtPass, "Debe ingresar una contraseña");
                return;
            }
            errorProvider1.SetError(TxtPass, "  PassWord :");
            if (user != u)
            {
                MessageBox.Show("Ingrese Un Nombre se Usuario Correcto ",
                    "Nombre de Usuario no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Contraseña != c)
            {
                MessageBox.Show("Contraseña Incorrecta ", "Contraseña Incorrecta ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (user == TxtUser.Text && Contraseña == TxtPass.Text)
            {
                MessageBox.Show("Bienvenido");
                FrmInterfazPresentation f1 = new FrmInterfazPresentation();
                f1.Show();
                this.Hide();
            }
            }
        }
       
        #endregion
    }

