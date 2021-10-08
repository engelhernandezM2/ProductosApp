
namespace ProductosApp.Forms
{
    partial class FrmGestionEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionEmpleado));
            this.rtbEmpleados = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCrearDocente = new System.Windows.Forms.Button();
            this.PnlEmpleado = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.PnlEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbEmpleados
            // 
            this.rtbEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.rtbEmpleados.ForeColor = System.Drawing.Color.White;
            this.rtbEmpleados.Location = new System.Drawing.Point(12, 63);
            this.rtbEmpleados.Name = "rtbEmpleados";
            this.rtbEmpleados.Size = new System.Drawing.Size(581, 326);
            this.rtbEmpleados.TabIndex = 5;
            this.rtbEmpleados.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel2.Location = new System.Drawing.Point(329, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 34);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel1.Location = new System.Drawing.Point(41, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(21, 34);
            this.panel1.TabIndex = 1;
            // 
            // btnCrearDocente
            // 
            this.btnCrearDocente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCrearDocente.FlatAppearance.BorderSize = 2;
            this.btnCrearDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCrearDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearDocente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearDocente.ForeColor = System.Drawing.Color.White;
            this.btnCrearDocente.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearDocente.Image")));
            this.btnCrearDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearDocente.Location = new System.Drawing.Point(59, 12);
            this.btnCrearDocente.Name = "btnCrearDocente";
            this.btnCrearDocente.Size = new System.Drawing.Size(218, 34);
            this.btnCrearDocente.TabIndex = 0;
            this.btnCrearDocente.Text = "Crear Docente ";
            this.btnCrearDocente.UseVisualStyleBackColor = true;
            this.btnCrearDocente.Click += new System.EventHandler(this.btnCrearDocente_Click);
            // 
            // PnlEmpleado
            // 
            this.PnlEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.PnlEmpleado.Controls.Add(this.panel2);
            this.PnlEmpleado.Controls.Add(this.btnAdmin);
            this.PnlEmpleado.Controls.Add(this.panel1);
            this.PnlEmpleado.Controls.Add(this.btnCrearDocente);
            this.PnlEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlEmpleado.Location = new System.Drawing.Point(0, 0);
            this.PnlEmpleado.Name = "PnlEmpleado";
            this.PnlEmpleado.Size = new System.Drawing.Size(593, 57);
            this.PnlEmpleado.TabIndex = 4;
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnAdmin.FlatAppearance.BorderSize = 2;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = global::ProductosApp.Properties.Resources.clientes;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(346, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(236, 34);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "      Crear Administrativo";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // FrmGestionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(593, 390);
            this.Controls.Add(this.rtbEmpleados);
            this.Controls.Add(this.PnlEmpleado);
            this.Name = "FrmGestionEmpleado";
            this.Text = "Gestion De Empleaos";
            this.Load += new System.EventHandler(this.FrmGestionEmpleado_Load);
            this.PnlEmpleado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbEmpleados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrearDocente;
        private System.Windows.Forms.Panel PnlEmpleado;
        private System.Windows.Forms.Button btnAdmin;
    }
}