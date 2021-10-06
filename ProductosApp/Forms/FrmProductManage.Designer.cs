﻿namespace ProductosApp.Forms
{
    partial class FrmProductManage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmbFinder = new System.Windows.Forms.ComboBox();
            this.pnlFindById = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlMeasureUnit = new System.Windows.Forms.Panel();
            this.cmbMeasureUnit = new System.Windows.Forms.ComboBox();
            this.pnlRangePrice = new System.Windows.Forms.Panel();
            this.nudToPrice = new System.Windows.Forms.NumericUpDown();
            this.nudFromPrice = new System.Windows.Forms.NumericUpDown();
            this.pnlCaducity = new System.Windows.Forms.Panel();
            this.dtpCaducity = new System.Windows.Forms.DateTimePicker();
            this.rtbProductView = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlFindById.SuspendLayout();
            this.pnlMeasureUnit.SuspendLayout();
            this.pnlRangePrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromPrice)).BeginInit();
            this.pnlCaducity.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 327);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(582, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(505, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(426, 2);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 24);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(347, 2);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 24);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // cmbFinder
            // 
            this.cmbFinder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinder.FormattingEnabled = true;
            this.cmbFinder.Items.AddRange(new object[] {
            "Id",
            "Unidad Medida",
            "Rango Precio",
            "Fecha Vencimiento"});
            this.cmbFinder.Location = new System.Drawing.Point(8, 7);
            this.cmbFinder.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFinder.Name = "cmbFinder";
            this.cmbFinder.Size = new System.Drawing.Size(146, 21);
            this.cmbFinder.TabIndex = 1;
            this.cmbFinder.SelectedIndexChanged += new System.EventHandler(this.CmbFinder_SelectedIndexChanged);
            // 
            // pnlFindById
            // 
            this.pnlFindById.Controls.Add(this.txtId);
            this.pnlFindById.Location = new System.Drawing.Point(158, 8);
            this.pnlFindById.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFindById.Name = "pnlFindById";
            this.pnlFindById.Size = new System.Drawing.Size(322, 26);
            this.pnlFindById.TabIndex = 2;
            this.pnlFindById.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(2, 2);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(318, 20);
            this.txtId.TabIndex = 0;
            // 
            // pnlMeasureUnit
            // 
            this.pnlMeasureUnit.Controls.Add(this.cmbMeasureUnit);
            this.pnlMeasureUnit.Location = new System.Drawing.Point(158, 8);
            this.pnlMeasureUnit.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMeasureUnit.Name = "pnlMeasureUnit";
            this.pnlMeasureUnit.Size = new System.Drawing.Size(322, 26);
            this.pnlMeasureUnit.TabIndex = 3;
            this.pnlMeasureUnit.Visible = false;
            // 
            // cmbMeasureUnit
            // 
            this.cmbMeasureUnit.FormattingEnabled = true;
            this.cmbMeasureUnit.Location = new System.Drawing.Point(4, 2);
            this.cmbMeasureUnit.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMeasureUnit.Name = "cmbMeasureUnit";
            this.cmbMeasureUnit.Size = new System.Drawing.Size(318, 21);
            this.cmbMeasureUnit.TabIndex = 0;
            // 
            // pnlRangePrice
            // 
            this.pnlRangePrice.Controls.Add(this.nudToPrice);
            this.pnlRangePrice.Controls.Add(this.nudFromPrice);
            this.pnlRangePrice.Location = new System.Drawing.Point(158, 6);
            this.pnlRangePrice.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRangePrice.Name = "pnlRangePrice";
            this.pnlRangePrice.Size = new System.Drawing.Size(322, 26);
            this.pnlRangePrice.TabIndex = 4;
            this.pnlRangePrice.Visible = false;
            // 
            // nudToPrice
            // 
            this.nudToPrice.Location = new System.Drawing.Point(170, 2);
            this.nudToPrice.Margin = new System.Windows.Forms.Padding(2);
            this.nudToPrice.Name = "nudToPrice";
            this.nudToPrice.Size = new System.Drawing.Size(150, 20);
            this.nudToPrice.TabIndex = 1;
            // 
            // nudFromPrice
            // 
            this.nudFromPrice.Location = new System.Drawing.Point(2, 2);
            this.nudFromPrice.Margin = new System.Windows.Forms.Padding(2);
            this.nudFromPrice.Name = "nudFromPrice";
            this.nudFromPrice.Size = new System.Drawing.Size(150, 20);
            this.nudFromPrice.TabIndex = 0;
            // 
            // pnlCaducity
            // 
            this.pnlCaducity.Controls.Add(this.dtpCaducity);
            this.pnlCaducity.Location = new System.Drawing.Point(159, 6);
            this.pnlCaducity.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCaducity.Name = "pnlCaducity";
            this.pnlCaducity.Size = new System.Drawing.Size(322, 26);
            this.pnlCaducity.TabIndex = 4;
            this.pnlCaducity.Visible = false;
            // 
            // dtpCaducity
            // 
            this.dtpCaducity.Location = new System.Drawing.Point(2, 4);
            this.dtpCaducity.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCaducity.Name = "dtpCaducity";
            this.dtpCaducity.Size = new System.Drawing.Size(209, 20);
            this.dtpCaducity.TabIndex = 0;
            this.dtpCaducity.ValueChanged += new System.EventHandler(this.dtpCaducity_ValueChanged);
            // 
            // rtbProductView
            // 
            this.rtbProductView.Location = new System.Drawing.Point(9, 39);
            this.rtbProductView.Margin = new System.Windows.Forms.Padding(2);
            this.rtbProductView.Name = "rtbProductView";
            this.rtbProductView.ReadOnly = true;
            this.rtbProductView.Size = new System.Drawing.Size(583, 284);
            this.rtbProductView.TabIndex = 3;
            this.rtbProductView.Text = "";
            // 
            // FrmProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pnlCaducity);
            this.Controls.Add(this.pnlMeasureUnit);
            this.Controls.Add(this.pnlRangePrice);
            this.Controls.Add(this.rtbProductView);
            this.Controls.Add(this.pnlFindById);
            this.Controls.Add(this.cmbFinder);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProductManage";
            this.Text = "FrmProductManage";
            this.Load += new System.EventHandler(this.FrmProductManage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlFindById.ResumeLayout(false);
            this.pnlFindById.PerformLayout();
            this.pnlMeasureUnit.ResumeLayout(false);
            this.pnlRangePrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudToPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromPrice)).EndInit();
            this.pnlCaducity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbFinder;
        private System.Windows.Forms.Panel pnlFindById;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel pnlMeasureUnit;
        private System.Windows.Forms.ComboBox cmbMeasureUnit;
        private System.Windows.Forms.Panel pnlRangePrice;
        private System.Windows.Forms.NumericUpDown nudToPrice;
        private System.Windows.Forms.NumericUpDown nudFromPrice;
        private System.Windows.Forms.Panel pnlCaducity;
        private System.Windows.Forms.DateTimePicker dtpCaducity;
        private System.Windows.Forms.RichTextBox rtbProductView;
    }
}