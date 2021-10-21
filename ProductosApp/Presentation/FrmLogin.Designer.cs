
namespace ProductosApp.Presentation
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.Remember = new System.Windows.Forms.CheckBox();
            this.Footer = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(109, 274);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(316, 37);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Log In";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.Color.Silver;
            this.TxtUser.Location = new System.Drawing.Point(12, 108);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(511, 22);
            this.TxtUser.TabIndex = 1;
            this.TxtUser.Text = "  UserName :";
            this.TxtUser.Enter += new System.EventHandler(this.TxtUser_Enter);
            this.TxtUser.Leave += new System.EventHandler(this.TxtUser_Leave);
            // 
            // TxtPass
            // 
            this.TxtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPass.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.ForeColor = System.Drawing.Color.Silver;
            this.TxtPass.Location = new System.Drawing.Point(12, 136);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(511, 22);
            this.TxtPass.TabIndex = 2;
            this.TxtPass.Text = "  PassWord :";
            this.TxtPass.Enter += new System.EventHandler(this.TxtPass_Enter);
            this.TxtPass.Leave += new System.EventHandler(this.TxtPass_Leave);
            // 
            // Remember
            // 
            this.Remember.AutoSize = true;
            this.Remember.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remember.ForeColor = System.Drawing.Color.DarkGray;
            this.Remember.Location = new System.Drawing.Point(12, 164);
            this.Remember.Name = "Remember";
            this.Remember.Size = new System.Drawing.Size(154, 21);
            this.Remember.TabIndex = 4;
            this.Remember.Text = "Remember PassWord";
            this.Remember.UseVisualStyleBackColor = true;
            // 
            // Footer
            // 
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 376);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(535, 10);
            this.Footer.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.Location = new System.Drawing.Point(203, 353);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Olvido la Contraseña ?";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 100);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(529, 94);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(341, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Image = global::ProductosApp.Properties.Resources.cerrar;
            this.BtnCerrar.Location = new System.Drawing.Point(512, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(535, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.Remember);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.BtnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.CheckBox Remember;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox BtnCerrar;
    }
}