/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 30/09/2022
 * Time: 05:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoAR
{
	partial class frmRegistrarFactura
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.TextBox txtRFC;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtRegimen;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.TextBox txtConcepto;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dtaConsultarOrden;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarFactura));
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.txtRFC = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtRegimen = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtConcepto = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtaConsultarOrden = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dtaConsultarOrden)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.AutoSize = true;
			this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegresar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(413, 398);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(112, 63);
			this.btnRegresar.TabIndex = 7;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.AutoSize = true;
			this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegistrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Location = new System.Drawing.Point(149, 398);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(112, 63);
			this.btnRegistrar.TabIndex = 6;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// txtRFC
			// 
			this.txtRFC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtRFC.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRFC.Location = new System.Drawing.Point(288, 62);
			this.txtRFC.Name = "txtRFC";
			this.txtRFC.Size = new System.Drawing.Size(180, 23);
			this.txtRFC.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(238, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 16);
			this.label3.TabIndex = 60;
			this.label3.Text = "RFC: ";
			// 
			// txtNombre
			// 
			this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombre.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(288, 21);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(180, 23);
			this.txtNombre.TabIndex = 0;
			// 
			// txtRegimen
			// 
			this.txtRegimen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtRegimen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRegimen.Location = new System.Drawing.Point(288, 105);
			this.txtRegimen.Name = "txtRegimen";
			this.txtRegimen.Size = new System.Drawing.Size(180, 23);
			this.txtRegimen.TabIndex = 2;
			// 
			// txtDireccion
			// 
			this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDireccion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDireccion.Location = new System.Drawing.Point(288, 151);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(180, 23);
			this.txtDireccion.TabIndex = 3;
			// 
			// txtConcepto
			// 
			this.txtConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtConcepto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConcepto.Location = new System.Drawing.Point(288, 193);
			this.txtConcepto.Name = "txtConcepto";
			this.txtConcepto.Size = new System.Drawing.Size(180, 23);
			this.txtConcepto.TabIndex = 4;
			// 
			// txtId
			// 
			this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtId.Location = new System.Drawing.Point(288, 237);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(180, 23);
			this.txtId.TabIndex = 5;
			this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOrdenKeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(184, 239);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 16);
			this.label6.TabIndex = 53;
			this.label6.Text = "ID de Orden: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(200, 195);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 16);
			this.label5.TabIndex = 52;
			this.label5.Text = "Concepto: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(161, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 16);
			this.label4.TabIndex = 51;
			this.label4.Text = "Direccion Fiscal: ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(209, 107);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 16);
			this.label8.TabIndex = 50;
			this.label8.Text = "Regimen: ";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(143, 23);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(139, 16);
			this.label9.TabIndex = 49;
			this.label9.Text = "Nombre Autónomo: ";
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.ForeColor = System.Drawing.Color.Black;
			this.lblID.Location = new System.Drawing.Point(99, 21);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(19, 18);
			this.lblID.TabIndex = 80;
			this.lblID.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(39, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 18);
			this.label1.TabIndex = 79;
			this.label1.Text = "ID:";
			// 
			// dtaConsultarOrden
			// 
			this.dtaConsultarOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtaConsultarOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtaConsultarOrden.Location = new System.Drawing.Point(71, 288);
			this.dtaConsultarOrden.Name = "dtaConsultarOrden";
			this.dtaConsultarOrden.Size = new System.Drawing.Size(514, 104);
			this.dtaConsultarOrden.TabIndex = 100;
			// 
			// frmRegistrarFactura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(678, 487);
			this.Controls.Add(this.dtaConsultarOrden);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtRFC);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtRegimen);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtConcepto);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnRegistrar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmRegistrarFactura";
			this.Text = "Registrar Factura";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRegistrarFacturaFormClosing);
			this.Load += new System.EventHandler(this.FrmRegistrarFacturaLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtaConsultarOrden)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
