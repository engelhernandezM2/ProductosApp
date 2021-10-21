
namespace ProductosApp.Forms
{
    partial class FrmEStudiantes
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
            this.components = new System.ComponentModel.Container();
            this.CmbCarrera = new System.Windows.Forms.ComboBox();
            this.RtbEstudiante = new System.Windows.Forms.RichTextBox();
            this.PnlBotones = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FotoEstudiante = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNacimineto = new System.Windows.Forms.DateTimePicker();
            this.lbledad = new System.Windows.Forms.Label();
            this.NupEdad = new System.Windows.Forms.NumericUpDown();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PnlBotones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NupEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbCarrera
            // 
            this.CmbCarrera.BackColor = System.Drawing.Color.Navy;
            this.CmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCarrera.ForeColor = System.Drawing.Color.White;
            this.CmbCarrera.FormattingEnabled = true;
            this.CmbCarrera.Location = new System.Drawing.Point(178, 141);
            this.CmbCarrera.Name = "CmbCarrera";
            this.CmbCarrera.Size = new System.Drawing.Size(132, 21);
            this.CmbCarrera.TabIndex = 2;
            // 
            // RtbEstudiante
            // 
            this.RtbEstudiante.BackColor = System.Drawing.Color.MediumBlue;
            this.RtbEstudiante.ForeColor = System.Drawing.Color.White;
            this.RtbEstudiante.Location = new System.Drawing.Point(12, 206);
            this.RtbEstudiante.Name = "RtbEstudiante";
            this.RtbEstudiante.Size = new System.Drawing.Size(420, 129);
            this.RtbEstudiante.TabIndex = 3;
            this.RtbEstudiante.Text = "";
            // 
            // PnlBotones
            // 
            this.PnlBotones.BackColor = System.Drawing.Color.MediumBlue;
            this.PnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlBotones.Controls.Add(this.BtnGuardar);
            this.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlBotones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PnlBotones.Location = new System.Drawing.Point(438, 0);
            this.PnlBotones.Name = "PnlBotones";
            this.PnlBotones.Size = new System.Drawing.Size(81, 347);
            this.PnlBotones.TabIndex = 4;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Navy;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.BtnGuardar.FlatAppearance.BorderSize = 2;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(4, 10);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(70, 36);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Controls.Add(this.FotoEstudiante);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCedula);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpNacimineto);
            this.groupBox1.Controls.Add(this.lbledad);
            this.groupBox1.Controls.Add(this.NupEdad);
            this.groupBox1.Controls.Add(this.TxtApellidos);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.CmbCarrera);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 188);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Estudiantes";
            // 
            // FotoEstudiante
            // 
            this.FotoEstudiante.Image = global::ProductosApp.Properties.Resources.clientes;
            this.FotoEstudiante.Location = new System.Drawing.Point(284, 19);
            this.FotoEstudiante.Name = "FotoEstudiante";
            this.FotoEstudiante.Size = new System.Drawing.Size(130, 50);
            this.FotoEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FotoEstudiante.TabIndex = 12;
            this.FotoEstudiante.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Carrera Universitaria :  :";
            // 
            // TxtCedula
            // 
            this.TxtCedula.BackColor = System.Drawing.Color.Navy;
            this.TxtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCedula.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.ForeColor = System.Drawing.Color.White;
            this.TxtCedula.Location = new System.Drawing.Point(16, 109);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(235, 22);
            this.TxtCedula.TabIndex = 9;
            this.TxtCedula.Text = "Cedula :";
            this.TxtCedula.Enter += new System.EventHandler(this.TxtCedula_Enter);
            this.TxtCedula.Leave += new System.EventHandler(this.TxtCedula_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha de Nacimiento : ";
            // 
            // dtpNacimineto
            // 
            this.dtpNacimineto.Location = new System.Drawing.Point(284, 83);
            this.dtpNacimineto.Name = "dtpNacimineto";
            this.dtpNacimineto.Size = new System.Drawing.Size(130, 20);
            this.dtpNacimineto.TabIndex = 7;
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.BackColor = System.Drawing.Color.Navy;
            this.lbledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(13, 82);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(49, 17);
            this.lbledad.TabIndex = 6;
            this.lbledad.Text = "Edad :";
            // 
            // NupEdad
            // 
            this.NupEdad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.NupEdad.ForeColor = System.Drawing.Color.White;
            this.NupEdad.Location = new System.Drawing.Point(68, 83);
            this.NupEdad.Name = "NupEdad";
            this.NupEdad.Size = new System.Drawing.Size(54, 20);
            this.NupEdad.TabIndex = 5;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.BackColor = System.Drawing.Color.Navy;
            this.TxtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtApellidos.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.ForeColor = System.Drawing.Color.White;
            this.TxtApellidos.Location = new System.Drawing.Point(16, 54);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(235, 22);
            this.TxtApellidos.TabIndex = 4;
            this.TxtApellidos.Text = "Apellidos :";
            this.TxtApellidos.Enter += new System.EventHandler(this.TxtApellidos_Enter);
            this.TxtApellidos.Leave += new System.EventHandler(this.TxtApellidos_Leave);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.Navy;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombre.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.White;
            this.TxtNombre.Location = new System.Drawing.Point(16, 26);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(235, 22);
            this.TxtNombre.TabIndex = 3;
            this.TxtNombre.Text = "Nombres :";
            this.TxtNombre.Enter += new System.EventHandler(this.TxtNombre_Enter);
            this.TxtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEStudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(519, 347);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PnlBotones);
            this.Controls.Add(this.RtbEstudiante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEStudiantes";
            this.Text = "FrmEStudiantes";
            this.Load += new System.EventHandler(this.FrmEStudiantes_Load);
            this.PnlBotones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NupEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbCarrera;
        private System.Windows.Forms.RichTextBox RtbEstudiante;
        private System.Windows.Forms.Panel PnlBotones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.NumericUpDown NupEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNacimineto;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.PictureBox FotoEstudiante;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}