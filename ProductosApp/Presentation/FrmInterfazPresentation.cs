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
    public partial class FrmInterfazPresentation : Form
    {
        public FrmInterfazPresentation()
        {
            InitializeComponent();
        }
        private void FrmInterfazPresentation_Load(object sender, EventArgs e)
        {
        }

        private void AbrirFrmHijo(object FrmHijo)
        {
            if (panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form f1 = FrmHijo as Form;
            f1.TopLevel = false;
            f1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(f1);
            this.panelContenedor.Tag = f1;
            f1.Show();
        }
        private void HoraYFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yy");
        }
        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmProductManage());
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EmpleadoModel>().As<IEmpleadoModel>();
            builder.RegisterType<EmpleadoServices>().As<IEmpleadoServicio>();
            var container = builder.Build();
            AbrirFrmHijo(new FrmGestionEmpleado(container.Resolve<IEmpleadoServicio>()));
        }

        private void BtnEstudiantes_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmEStudiantes());
        }
    }
}
