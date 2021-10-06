using AppCore.Interfaces;
using AppCore.Services;
using Autofac;
using Domain.Enums;
using Domain.Interfaces;
using Infraestructure.Empleados;
using Infraestructure.Productos;
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
    public partial class FrmProductManage : Form
    {
        private ProductoModel pModel;
        public FrmProductManage()
        {
            pModel = new ProductoModel();
            InitializeComponent();
        }

        private void CmbFinder_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFinder.SelectedIndex)
            {
                case 0:
                    pnlFindById.Visible = true;
                    pnlCaducity.Visible = false;
                    pnlMeasureUnit.Visible = false;
                    pnlRangePrice.Visible = false;
                    break;
                case 1:
                    pnlFindById.Visible = false;
                    pnlCaducity.Visible = false;
                    pnlMeasureUnit.Visible = true;
                    pnlRangePrice.Visible = false;
                    break;
                case 2:
                    pnlFindById.Visible = false;
                    pnlCaducity.Visible = false;
                    pnlMeasureUnit.Visible = false;
                    pnlRangePrice.Visible = true;
                    break;
                case 3:
                    pnlFindById.Visible = false;
                    pnlCaducity.Visible = true;
                    pnlMeasureUnit.Visible = false;
                    pnlRangePrice.Visible = false;
                    break;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.PModel = pModel;
            frmProducto.ShowDialog();

            rtbProductView.Text = pModel.GetProductosAsJson();
        }

        private void FrmProductManage_Load(object sender, EventArgs e)
        {
         
        }

        private void dtpCaducity_ValueChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    var builder = new ContainerBuilder();

        //    builder.RegisterType<EmpleadoModel>().As<IEmpleadoModel>();
        //    builder.RegisterType<EmpleadoServices>().As<IEmpleadoServicio>();
        //    var container = builder.Build();
        //    FrmGestionEmpleado f1 = new FrmGestionEmpleado(container.Resolve<IEmpleadoServicio>());
        //    f1.ShowDialog();
        //}
    }
}
