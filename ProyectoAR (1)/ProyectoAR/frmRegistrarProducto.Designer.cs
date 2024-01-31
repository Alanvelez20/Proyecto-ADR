/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 29/10/2022
 * Time: 02:28 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoAR
{
	partial class frmRegistrarProducto
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtIdIngrediente;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtCantidadIngrediente;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.DataGridView dtaProductos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dtaNombre;
		private System.Windows.Forms.Label lblNombreIngrediente;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarProducto));
			this.btnRegresar = new System.Windows.Forms.Button();
			this.lblID = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtIdIngrediente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtCantidadIngrediente = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.dtaProductos = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dtaNombre = new System.Windows.Forms.DataGridView();
			this.lblNombreIngrediente = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dtaProductos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtaNombre)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.AutoSize = true;
			this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegresar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(413, 421);
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
			this.lblID.Location = new System.Drawing.Point(121, 20);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(19, 18);
			this.lblID.TabIndex = 76;
			this.lblID.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(61, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 18);
			this.label8.TabIndex = 75;
			this.label8.Text = "ID:";
			// 
			// txtIdIngrediente
			// 
			this.txtIdIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIdIngrediente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdIngrediente.Location = new System.Drawing.Point(464, 93);
			this.txtIdIngrediente.Name = "txtIdIngrediente";
			this.txtIdIngrediente.Size = new System.Drawing.Size(171, 23);
			this.txtIdIngrediente.TabIndex = 2;
			this.txtIdIngrediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdIngredienteKeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(324, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 16);
			this.label3.TabIndex = 81;
			this.label3.Text = "ID de Ingrediente: ";
			// 
			// txtPrecio
			// 
			this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPrecio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecio.Location = new System.Drawing.Point(121, 139);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(142, 23);
			this.txtPrecio.TabIndex = 1;
			this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioKeyPress);
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
			this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescripcion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcion.Location = new System.Drawing.Point(121, 98);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(142, 23);
			this.txtDescripcion.TabIndex = 0;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(56, 139);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(59, 16);
			this.label9.TabIndex = 78;
			this.label9.Text = "Precio: ";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(22, 100);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(94, 16);
			this.label10.TabIndex = 77;
			this.label10.Text = "Descripción: ";
			// 
			// txtCantidadIngrediente
			// 
			this.txtCantidadIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCantidadIngrediente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidadIngrediente.Location = new System.Drawing.Point(464, 177);
			this.txtCantidadIngrediente.Name = "txtCantidadIngrediente";
			this.txtCantidadIngrediente.Size = new System.Drawing.Size(171, 23);
			this.txtCantidadIngrediente.TabIndex = 3;
			this.txtCantidadIngrediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadIngredienteKeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(303, 181);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 16);
			this.label1.TabIndex = 83;
			this.label1.Text = "Cantidad ingrediente: ";
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.AutoSize = true;
			this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegistrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Location = new System.Drawing.Point(151, 421);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(112, 63);
			this.btnRegistrar.TabIndex = 4;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// dtaProductos
			// 
			this.dtaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtaProductos.Location = new System.Drawing.Point(89, 246);
			this.dtaProductos.Name = "dtaProductos";
			this.dtaProductos.Size = new System.Drawing.Size(498, 137);
			this.dtaProductos.TabIndex = 86;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(364, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 16);
			this.label2.TabIndex = 87;
			this.label2.Text = "Ingrediente: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(464, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(163, 16);
			this.label4.TabIndex = 89;
			this.label4.Text = "Agregar Ingredientes";
			// 
			// dtaNombre
			// 
			this.dtaNombre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtaNombre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtaNombre.Location = new System.Drawing.Point(151, 281);
			this.dtaNombre.Name = "dtaNombre";
			this.dtaNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dtaNombre.Size = new System.Drawing.Size(109, 73);
			this.dtaNombre.TabIndex = 90;
			// 
			// lblNombreIngrediente
			// 
			this.lblNombreIngrediente.AutoSize = true;
			this.lblNombreIngrediente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreIngrediente.Location = new System.Drawing.Point(464, 136);
			this.lblNombreIngrediente.Name = "lblNombreIngrediente";
			this.lblNombreIngrediente.Size = new System.Drawing.Size(15, 16);
			this.lblNombreIngrediente.TabIndex = 91;
			this.lblNombreIngrediente.Text = "?";
			// 
			// frmRegistrarProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(674, 496);
			this.Controls.Add(this.lblNombreIngrediente);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtaProductos);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.txtCantidadIngrediente);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtIdIngrediente);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.dtaNombre);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmRegistrarProducto";
			this.Text = "Registrar Producto";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRegistrarProductoFormClosing);
			this.Load += new System.EventHandler(this.FrmRegistrarProductoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtaProductos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtaNombre)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
