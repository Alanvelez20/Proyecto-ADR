/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 30/10/2022
 * Time: 04:06 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoAR
{
	partial class frmRegistrarPedido
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.TextBox txtIdEmpleado;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCantidadIngrediente;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtIdIngrediente;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtIdProveedor;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblNombreProveedor;
		private System.Windows.Forms.DataGridView dtaPedido;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblNombreEmpleado;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lblNombreIngrediente;
		private System.Windows.Forms.DataGridView dtaIdDetalle;
		//private System.Windows.Forms.Label lblFecha;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarPedido));
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.lblID = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.txtIdEmpleado = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCantidadIngrediente = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtIdIngrediente = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtIdProveedor = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.lblNombreProveedor = new System.Windows.Forms.Label();
			this.dtaPedido = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.lblNombreEmpleado = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lblNombreIngrediente = new System.Windows.Forms.Label();
			this.dtaIdDetalle = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dtaPedido)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtaIdDetalle)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.AutoSize = true;
			this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegistrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Location = new System.Drawing.Point(145, 416);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(112, 63);
			this.btnRegistrar.TabIndex = 4;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.AutoSize = true;
			this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegresar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(407, 416);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(112, 63);
			this.btnRegresar.TabIndex = 5;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.ForeColor = System.Drawing.Color.Black;
			this.lblID.Location = new System.Drawing.Point(84, 18);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(19, 18);
			this.lblID.TabIndex = 89;
			this.lblID.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(43, 18);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 18);
			this.label8.TabIndex = 88;
			this.label8.Text = "ID:";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.ForeColor = System.Drawing.Color.Black;
			this.lblFecha.Location = new System.Drawing.Point(84, 53);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(0, 18);
			this.lblFecha.TabIndex = 91;
			// 
			// txtIdEmpleado
			// 
			this.txtIdEmpleado.BackColor = System.Drawing.SystemColors.Window;
			this.txtIdEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIdEmpleado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdEmpleado.Location = new System.Drawing.Point(127, 113);
			this.txtIdEmpleado.Name = "txtIdEmpleado";
			this.txtIdEmpleado.Size = new System.Drawing.Size(88, 23);
			this.txtIdEmpleado.TabIndex = 0;
			this.txtIdEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdEmpleadoKeyPress);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(33, 115);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 16);
			this.label10.TabIndex = 92;
			this.label10.Text = "ID empleado: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(446, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(163, 16);
			this.label4.TabIndex = 100;
			this.label4.Text = "Agregar Ingredientes";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(346, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 16);
			this.label3.TabIndex = 98;
			this.label3.Text = "Ingrediente: ";
			// 
			// txtCantidadIngrediente
			// 
			this.txtCantidadIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCantidadIngrediente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidadIngrediente.Location = new System.Drawing.Point(446, 195);
			this.txtCantidadIngrediente.Name = "txtCantidadIngrediente";
			this.txtCantidadIngrediente.Size = new System.Drawing.Size(171, 23);
			this.txtCantidadIngrediente.TabIndex = 3;
			this.txtCantidadIngrediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadIngredienteKeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(285, 199);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(155, 16);
			this.label5.TabIndex = 96;
			this.label5.Text = "Cantidad ingrediente: ";
			// 
			// txtIdIngrediente
			// 
			this.txtIdIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIdIngrediente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdIngrediente.Location = new System.Drawing.Point(446, 111);
			this.txtIdIngrediente.Name = "txtIdIngrediente";
			this.txtIdIngrediente.Size = new System.Drawing.Size(171, 23);
			this.txtIdIngrediente.TabIndex = 2;
			this.txtIdIngrediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdIngredienteKeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(306, 113);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(134, 16);
			this.label6.TabIndex = 94;
			this.label6.Text = "ID de Ingrediente: ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(48, 224);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 16);
			this.label7.TabIndex = 103;
			this.label7.Text = "Proveedor: ";
			// 
			// txtIdProveedor
			// 
			this.txtIdProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIdProveedor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdProveedor.Location = new System.Drawing.Point(129, 178);
			this.txtIdProveedor.Name = "txtIdProveedor";
			this.txtIdProveedor.Size = new System.Drawing.Size(86, 23);
			this.txtIdProveedor.TabIndex = 1;
			this.txtIdProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdProveedorKeyPress);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(29, 180);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(104, 16);
			this.label9.TabIndex = 101;
			this.label9.Text = "ID proveedor: ";
			// 
			// lblNombreProveedor
			// 
			this.lblNombreProveedor.AutoSize = true;
			this.lblNombreProveedor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreProveedor.Location = new System.Drawing.Point(130, 224);
			this.lblNombreProveedor.Name = "lblNombreProveedor";
			this.lblNombreProveedor.Size = new System.Drawing.Size(20, 16);
			this.lblNombreProveedor.TabIndex = 104;
			this.lblNombreProveedor.Text = "? ";
			// 
			// dtaPedido
			// 
			this.dtaPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtaPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtaPedido.Location = new System.Drawing.Point(56, 259);
			this.dtaPedido.Name = "dtaPedido";
			this.dtaPedido.Size = new System.Drawing.Size(553, 137);
			this.dtaPedido.TabIndex = 105;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(12, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 18);
			this.label1.TabIndex = 106;
			this.label1.Text = "Fecha:";
			// 
			// lblNombreEmpleado
			// 
			this.lblNombreEmpleado.AutoSize = true;
			this.lblNombreEmpleado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreEmpleado.Location = new System.Drawing.Point(130, 150);
			this.lblNombreEmpleado.Name = "lblNombreEmpleado";
			this.lblNombreEmpleado.Size = new System.Drawing.Size(20, 16);
			this.lblNombreEmpleado.TabIndex = 108;
			this.lblNombreEmpleado.Text = "? ";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(48, 150);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(81, 16);
			this.label11.TabIndex = 107;
			this.label11.Text = "Empleado: ";
			// 
			// lblNombreIngrediente
			// 
			this.lblNombreIngrediente.AutoSize = true;
			this.lblNombreIngrediente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreIngrediente.Location = new System.Drawing.Point(446, 154);
			this.lblNombreIngrediente.Name = "lblNombreIngrediente";
			this.lblNombreIngrediente.Size = new System.Drawing.Size(15, 16);
			this.lblNombreIngrediente.TabIndex = 109;
			this.lblNombreIngrediente.Text = "?";
			// 
			// dtaIdDetalle
			// 
			this.dtaIdDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtaIdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtaIdDetalle.Location = new System.Drawing.Point(186, 298);
			this.dtaIdDetalle.Name = "dtaIdDetalle";
			this.dtaIdDetalle.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dtaIdDetalle.Size = new System.Drawing.Size(109, 73);
			this.dtaIdDetalle.TabIndex = 110;
			// 
			// frmRegistrarPedido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(678, 517);
			this.Controls.Add(this.lblNombreIngrediente);
			this.Controls.Add(this.lblNombreEmpleado);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtaPedido);
			this.Controls.Add(this.lblNombreProveedor);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtIdProveedor);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCantidadIngrediente);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtIdIngrediente);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtIdEmpleado);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.dtaIdDetalle);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmRegistrarPedido";
			this.Text = "Registrar Pedido";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRegistrarPedidoFormClosing);
			this.Load += new System.EventHandler(this.FrmRegistrarPedidoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtaPedido)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtaIdDetalle)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
