/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 30/10/2022
 * Time: 07:33 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoAR
{
	partial class frmConsultarPedido
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridView dtaConsultarPedido;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Label lblNombreEmpleado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblNombreProveedor;
		private System.Windows.Forms.Label label5;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarPedido));
			this.lblFecha = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.dtaConsultarPedido = new System.Windows.Forms.DataGridView();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.lblNombreEmpleado = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblNombreProveedor = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dtaConsultarPedido)).BeginInit();
			this.SuspendLayout();
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.ForeColor = System.Drawing.Color.Black;
			this.lblFecha.Location = new System.Drawing.Point(482, 82);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(0, 18);
			this.lblFecha.TabIndex = 93;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(405, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 18);
			this.label4.TabIndex = 92;
			this.label4.Text = "Fecha:";
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.ForeColor = System.Drawing.Color.Black;
			this.lblID.Location = new System.Drawing.Point(491, 46);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(19, 18);
			this.lblID.TabIndex = 91;
			this.lblID.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(436, 46);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 18);
			this.label8.TabIndex = 90;
			this.label8.Text = "ID:";
			// 
			// txtId
			// 
			this.txtId.BackColor = System.Drawing.SystemColors.Window;
			this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtId.Location = new System.Drawing.Point(145, 60);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(88, 23);
			this.txtId.TabIndex = 0;
			this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdKeyPress);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(57, 62);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(95, 16);
			this.label10.TabIndex = 88;
			this.label10.Text = "ID a buscar: ";
			// 
			// dtaConsultarPedido
			// 
			this.dtaConsultarPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtaConsultarPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtaConsultarPedido.Location = new System.Drawing.Point(71, 212);
			this.dtaConsultarPedido.Name = "dtaConsultarPedido";
			this.dtaConsultarPedido.Size = new System.Drawing.Size(514, 162);
			this.dtaConsultarPedido.TabIndex = 94;
			// 
			// btnConsultar
			// 
			this.btnConsultar.AutoSize = true;
			this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConsultar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultar.Location = new System.Drawing.Point(117, 401);
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
			this.btnRegresar.Location = new System.Drawing.Point(405, 401);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(112, 63);
			this.btnRegresar.TabIndex = 2;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// lblNombreEmpleado
			// 
			this.lblNombreEmpleado.AutoSize = true;
			this.lblNombreEmpleado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreEmpleado.ForeColor = System.Drawing.Color.Black;
			this.lblNombreEmpleado.Location = new System.Drawing.Point(244, 136);
			this.lblNombreEmpleado.Name = "lblNombreEmpleado";
			this.lblNombreEmpleado.Size = new System.Drawing.Size(0, 18);
			this.lblNombreEmpleado.TabIndex = 98;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(88, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 18);
			this.label2.TabIndex = 97;
			this.label2.Text = "Registrado por:";
			// 
			// lblNombreProveedor
			// 
			this.lblNombreProveedor.AutoSize = true;
			this.lblNombreProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreProveedor.ForeColor = System.Drawing.Color.Black;
			this.lblNombreProveedor.Location = new System.Drawing.Point(244, 170);
			this.lblNombreProveedor.Name = "lblNombreProveedor";
			this.lblNombreProveedor.Size = new System.Drawing.Size(0, 18);
			this.lblNombreProveedor.TabIndex = 100;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(126, 170);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(107, 18);
			this.label5.TabIndex = 99;
			this.label5.Text = "Proveedor:";
			// 
			// frmConsultarPedido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(676, 509);
			this.Controls.Add(this.lblNombreProveedor);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblNombreEmpleado);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.dtaConsultarPedido);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label10);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmConsultarPedido";
			this.Text = "Consultar Pedido";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConsultarPedidoFormClosing);
			this.Load += new System.EventHandler(this.FrmConsultarPedidoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtaConsultarPedido)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
