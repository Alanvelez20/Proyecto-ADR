/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 31/10/2022
 * Time: 11:46 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoAR
{
	partial class frmEditarPedido
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnConfirmar;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.DataGridView dtaEditarPedido;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Label lblNombreIngrediente;
		private System.Windows.Forms.TextBox txtCantidadIngrediente;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtIdIngrediente;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblNombreProveedor;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblNombreEmpleado;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dtaIdDetalle;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarPedido));
			this.btnConfirmar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.dtaEditarPedido = new System.Windows.Forms.DataGridView();
			this.lblID = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnModificar = new System.Windows.Forms.Button();
			this.lblNombreIngrediente = new System.Windows.Forms.Label();
			this.txtCantidadIngrediente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtIdIngrediente = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblNombreProveedor = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblNombreEmpleado = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dtaIdDetalle = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dtaEditarPedido)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtaIdDetalle)).BeginInit();
			this.SuspendLayout();
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.AutoSize = true;
			this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConfirmar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfirmar.Location = new System.Drawing.Point(164, 431);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Size = new System.Drawing.Size(112, 63);
			this.btnConfirmar.TabIndex = 4;
			this.btnConfirmar.Text = "Confirmar";
			this.btnConfirmar.UseVisualStyleBackColor = true;
			this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmarClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.AutoSize = true;
			this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegresar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(401, 431);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(112, 63);
			this.btnRegresar.TabIndex = 5;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// dtaEditarPedido
			// 
			this.dtaEditarPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtaEditarPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtaEditarPedido.Location = new System.Drawing.Point(70, 282);
			this.dtaEditarPedido.Name = "dtaEditarPedido";
			this.dtaEditarPedido.Size = new System.Drawing.Size(532, 125);
			this.dtaEditarPedido.TabIndex = 40;
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.ForeColor = System.Drawing.Color.Black;
			this.lblID.Location = new System.Drawing.Point(68, 68);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(19, 18);
			this.lblID.TabIndex = 97;
			this.lblID.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(27, 68);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 18);
			this.label8.TabIndex = 96;
			this.label8.Text = "ID:";
			// 
			// txtId
			// 
			this.txtId.BackColor = System.Drawing.SystemColors.Window;
			this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtId.Location = new System.Drawing.Point(188, 20);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(88, 23);
			this.txtId.TabIndex = 0;
			this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdKeyPress);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(27, 22);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(164, 16);
			this.label10.TabIndex = 94;
			this.label10.Text = "ID de pedido a buscar: ";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.ForeColor = System.Drawing.Color.Black;
			this.lblFecha.Location = new System.Drawing.Point(197, 68);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(19, 18);
			this.lblFecha.TabIndex = 99;
			this.lblFecha.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(125, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 18);
			this.label2.TabIndex = 98;
			this.label2.Text = "Fecha:";
			// 
			// btnModificar
			// 
			this.btnModificar.AutoSize = true;
			this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModificar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Location = new System.Drawing.Point(492, 236);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(110, 40);
			this.btnModificar.TabIndex = 3;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// lblNombreIngrediente
			// 
			this.lblNombreIngrediente.AutoSize = true;
			this.lblNombreIngrediente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreIngrediente.Location = new System.Drawing.Point(417, 157);
			this.lblNombreIngrediente.Name = "lblNombreIngrediente";
			this.lblNombreIngrediente.Size = new System.Drawing.Size(15, 16);
			this.lblNombreIngrediente.TabIndex = 106;
			this.lblNombreIngrediente.Text = "?";
			// 
			// txtCantidadIngrediente
			// 
			this.txtCantidadIngrediente.BackColor = System.Drawing.SystemColors.Window;
			this.txtCantidadIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCantidadIngrediente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidadIngrediente.Location = new System.Drawing.Point(323, 194);
			this.txtCantidadIngrediente.Name = "txtCantidadIngrediente";
			this.txtCantidadIngrediente.Size = new System.Drawing.Size(88, 23);
			this.txtCantidadIngrediente.TabIndex = 2;
			this.txtCantidadIngrediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadIngredienteKeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(152, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(176, 16);
			this.label3.TabIndex = 104;
			this.label3.Text = "Cantidad de ingrediente: ";
			// 
			// txtIdIngrediente
			// 
			this.txtIdIngrediente.BackColor = System.Drawing.SystemColors.Window;
			this.txtIdIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIdIngrediente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdIngrediente.Location = new System.Drawing.Point(323, 155);
			this.txtIdIngrediente.Name = "txtIdIngrediente";
			this.txtIdIngrediente.Size = new System.Drawing.Size(88, 23);
			this.txtIdIngrediente.TabIndex = 1;
			this.txtIdIngrediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdIngredienteKeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(198, 157);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 16);
			this.label1.TabIndex = 102;
			this.label1.Text = "ID de ingrediente: ";
			// 
			// lblNombreProveedor
			// 
			this.lblNombreProveedor.AutoSize = true;
			this.lblNombreProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreProveedor.ForeColor = System.Drawing.Color.Black;
			this.lblNombreProveedor.Location = new System.Drawing.Point(479, 58);
			this.lblNombreProveedor.Name = "lblNombreProveedor";
			this.lblNombreProveedor.Size = new System.Drawing.Size(0, 18);
			this.lblNombreProveedor.TabIndex = 111;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(361, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(107, 18);
			this.label5.TabIndex = 110;
			this.label5.Text = "Proveedor:";
			// 
			// lblNombreEmpleado
			// 
			this.lblNombreEmpleado.AutoSize = true;
			this.lblNombreEmpleado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreEmpleado.ForeColor = System.Drawing.Color.Black;
			this.lblNombreEmpleado.Location = new System.Drawing.Point(479, 20);
			this.lblNombreEmpleado.Name = "lblNombreEmpleado";
			this.lblNombreEmpleado.Size = new System.Drawing.Size(0, 18);
			this.lblNombreEmpleado.TabIndex = 109;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(323, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(145, 18);
			this.label6.TabIndex = 108;
			this.label6.Text = "Registrado por:";
			// 
			// dtaIdDetalle
			// 
			this.dtaIdDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtaIdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtaIdDetalle.Location = new System.Drawing.Point(139, 317);
			this.dtaIdDetalle.Name = "dtaIdDetalle";
			this.dtaIdDetalle.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dtaIdDetalle.Size = new System.Drawing.Size(109, 73);
			this.dtaIdDetalle.TabIndex = 112;
			// 
			// frmEditarPedido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(673, 515);
			this.Controls.Add(this.lblNombreProveedor);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblNombreEmpleado);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.lblNombreIngrediente);
			this.Controls.Add(this.txtCantidadIngrediente);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtIdIngrediente);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.dtaEditarPedido);
			this.Controls.Add(this.btnConfirmar);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.dtaIdDetalle);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEditarPedido";
			this.Text = "Editar Pedido";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditarPedidoFormClosing);
			this.Load += new System.EventHandler(this.FrmEditarPedidoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtaEditarPedido)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtaIdDetalle)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
