/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 05/11/2022
 * Time: 01:08 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoAR
{
	partial class frmConsultarOrden
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.DataGridView dtaConsultarOrden;
		private System.Windows.Forms.Label lblNumMesa;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblNombreEmpleado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblEstatus;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label12;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarOrden));
			this.btnConsultar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.dtaConsultarOrden = new System.Windows.Forms.DataGridView();
			this.lblNumMesa = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblNombreEmpleado = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.lblEstatus = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dtaConsultarOrden)).BeginInit();
			this.SuspendLayout();
			// 
			// btnConsultar
			// 
			this.btnConsultar.AutoSize = true;
			this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConsultar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultar.Location = new System.Drawing.Point(75, 385);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(112, 63);
			this.btnConsultar.TabIndex = 1;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.AutoSize = true;
			this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegresar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(250, 385);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(112, 63);
			this.btnRegresar.TabIndex = 2;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// dtaConsultarOrden
			// 
			this.dtaConsultarOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtaConsultarOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtaConsultarOrden.Location = new System.Drawing.Point(75, 242);
			this.dtaConsultarOrden.Name = "dtaConsultarOrden";
			this.dtaConsultarOrden.Size = new System.Drawing.Size(514, 122);
			this.dtaConsultarOrden.TabIndex = 99;
			// 
			// lblNumMesa
			// 
			this.lblNumMesa.AutoSize = true;
			this.lblNumMesa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumMesa.ForeColor = System.Drawing.Color.Black;
			this.lblNumMesa.Location = new System.Drawing.Point(231, 153);
			this.lblNumMesa.Name = "lblNumMesa";
			this.lblNumMesa.Size = new System.Drawing.Size(0, 18);
			this.lblNumMesa.TabIndex = 110;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(57, 153);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(163, 18);
			this.label5.TabIndex = 109;
			this.label5.Text = "Numero de mesa:";
			// 
			// lblNombreEmpleado
			// 
			this.lblNombreEmpleado.AutoSize = true;
			this.lblNombreEmpleado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreEmpleado.ForeColor = System.Drawing.Color.Black;
			this.lblNombreEmpleado.Location = new System.Drawing.Point(231, 110);
			this.lblNombreEmpleado.Name = "lblNombreEmpleado";
			this.lblNombreEmpleado.Size = new System.Drawing.Size(0, 18);
			this.lblNombreEmpleado.TabIndex = 108;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(75, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 18);
			this.label2.TabIndex = 107;
			this.label2.Text = "Registrado por:";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.ForeColor = System.Drawing.Color.Black;
			this.lblFecha.Location = new System.Drawing.Point(469, 60);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(0, 18);
			this.lblFecha.TabIndex = 106;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(392, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 18);
			this.label4.TabIndex = 105;
			this.label4.Text = "Fecha:";
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.ForeColor = System.Drawing.Color.Black;
			this.lblID.Location = new System.Drawing.Point(478, 24);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(19, 18);
			this.lblID.TabIndex = 104;
			this.lblID.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(423, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 18);
			this.label8.TabIndex = 103;
			this.label8.Text = "ID:";
			// 
			// txtId
			// 
			this.txtId.BackColor = System.Drawing.SystemColors.Window;
			this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtId.Location = new System.Drawing.Point(132, 38);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(88, 23);
			this.txtId.TabIndex = 0;
			this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdKeyPress);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(44, 40);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(95, 16);
			this.label10.TabIndex = 101;
			this.label10.Text = "ID a buscar: ";
			// 
			// lblEstatus
			// 
			this.lblEstatus.AutoSize = true;
			this.lblEstatus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEstatus.ForeColor = System.Drawing.Color.Black;
			this.lblEstatus.Location = new System.Drawing.Point(231, 193);
			this.lblEstatus.Name = "lblEstatus";
			this.lblEstatus.Size = new System.Drawing.Size(0, 18);
			this.lblEstatus.TabIndex = 112;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(141, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 18);
			this.label3.TabIndex = 111;
			this.label3.Text = "Estatus:";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.ForeColor = System.Drawing.Color.Red;
			this.lblTotal.Location = new System.Drawing.Point(540, 407);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(18, 18);
			this.lblTotal.TabIndex = 140;
			this.lblTotal.Text = "?";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(455, 407);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(79, 18);
			this.label12.TabIndex = 139;
			this.label12.Text = "TOTAL: ";
			// 
			// frmConsultarOrden
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(677, 512);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.lblEstatus);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblNumMesa);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblNombreEmpleado);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.dtaConsultarOrden);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.btnRegresar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmConsultarOrden";
			this.Text = "Consultar Orden";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConsultarOrdenFormClosing);
			this.Load += new System.EventHandler(this.FrmConsultarOrdenLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtaConsultarOrden)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
