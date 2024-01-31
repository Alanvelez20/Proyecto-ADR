/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 30/10/2022
 * Time: 02:22 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoAR
{
	partial class frmEditarProducto
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnConfirmar;
		private System.Windows.Forms.DataGridView dtaEditarProducto;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtIdIngrediente;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCantidadIngrediente;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblNombreIngrediente;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblProducto;
		private System.Windows.Forms.Label label4;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarProducto));
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnConfirmar = new System.Windows.Forms.Button();
			this.dtaEditarProducto = new System.Windows.Forms.DataGridView();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtIdIngrediente = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCantidadIngrediente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblNombreIngrediente = new System.Windows.Forms.Label();
			this.btnModificar = new System.Windows.Forms.Button();
			this.lblID = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblProducto = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dtaIdDetalle = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dtaEditarProducto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtaIdDetalle)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.AutoSize = true;
			this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegresar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(397, 417);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(112, 63);
			this.btnRegresar.TabIndex = 5;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.AutoSize = true;
			this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConfirmar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfirmar.Location = new System.Drawing.Point(160, 417);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Size = new System.Drawing.Size(112, 63);
			this.btnConfirmar.TabIndex = 4;
			this.btnConfirmar.Text = "Confirmar";
			this.btnConfirmar.UseVisualStyleBackColor = true;
			this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmarClick);
			// 
			// dtaEditarProducto
			// 
			this.dtaEditarProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtaEditarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtaEditarProducto.Location = new System.Drawing.Point(54, 245);
			this.dtaEditarProducto.Name = "dtaEditarProducto";
			this.dtaEditarProducto.Size = new System.Drawing.Size(571, 150);
			this.dtaEditarProducto.TabIndex = 38;
			// 
			// txtId
			// 
			this.txtId.BackColor = System.Drawing.SystemColors.Window;
			this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtId.Location = new System.Drawing.Point(185, 21);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(88, 23);
			this.txtId.TabIndex = 0;
			this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdKeyPress);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(12, 23);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(180, 16);
			this.label10.TabIndex = 82;
			this.label10.Text = "ID de producto a buscar: ";
			// 
			// txtIdIngrediente
			// 
			this.txtIdIngrediente.BackColor = System.Drawing.SystemColors.Window;
			this.txtIdIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIdIngrediente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdIngrediente.Location = new System.Drawing.Point(347, 144);
			this.txtIdIngrediente.Name = "txtIdIngrediente";
			this.txtIdIngrediente.Size = new System.Drawing.Size(88, 23);
			this.txtIdIngrediente.TabIndex = 1;
			this.txtIdIngrediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdIngredienteKeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(222, 146);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 16);
			this.label2.TabIndex = 86;
			this.label2.Text = "ID de ingrediente: ";
			// 
			// txtCantidadIngrediente
			// 
			this.txtCantidadIngrediente.BackColor = System.Drawing.SystemColors.Window;
			this.txtCantidadIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCantidadIngrediente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidadIngrediente.Location = new System.Drawing.Point(347, 183);
			this.txtCantidadIngrediente.Name = "txtCantidadIngrediente";
			this.txtCantidadIngrediente.Size = new System.Drawing.Size(88, 23);
			this.txtCantidadIngrediente.TabIndex = 2;
			this.txtCantidadIngrediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadIngredienteKeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(176, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(176, 16);
			this.label3.TabIndex = 88;
			this.label3.Text = "Cantidad de ingrediente: ";
			// 
			// lblNombreIngrediente
			// 
			this.lblNombreIngrediente.AutoSize = true;
			this.lblNombreIngrediente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreIngrediente.Location = new System.Drawing.Point(441, 146);
			this.lblNombreIngrediente.Name = "lblNombreIngrediente";
			this.lblNombreIngrediente.Size = new System.Drawing.Size(15, 16);
			this.lblNombreIngrediente.TabIndex = 90;
			this.lblNombreIngrediente.Text = "?";
			// 
			// btnModificar
			// 
			this.btnModificar.AutoSize = true;
			this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModificar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Location = new System.Drawing.Point(515, 183);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(110, 40);
			this.btnModificar.TabIndex = 3;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.ForeColor = System.Drawing.Color.Black;
			this.lblID.Location = new System.Drawing.Point(606, 21);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(19, 18);
			this.lblID.TabIndex = 93;
			this.lblID.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(546, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 18);
			this.label8.TabIndex = 92;
			this.label8.Text = "ID:";
			// 
			// lblProducto
			// 
			this.lblProducto.AutoSize = true;
			this.lblProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProducto.ForeColor = System.Drawing.Color.Black;
			this.lblProducto.Location = new System.Drawing.Point(197, 63);
			this.lblProducto.Name = "lblProducto";
			this.lblProducto.Size = new System.Drawing.Size(0, 18);
			this.lblProducto.TabIndex = 95;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(87, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 18);
			this.label4.TabIndex = 94;
			this.label4.Text = "Producto:";
			// 
			// dtaIdDetalle
			// 
			this.dtaIdDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtaIdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtaIdDetalle.Location = new System.Drawing.Point(128, 282);
			this.dtaIdDetalle.Name = "dtaIdDetalle";
			this.dtaIdDetalle.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dtaIdDetalle.Size = new System.Drawing.Size(109, 73);
			this.dtaIdDetalle.TabIndex = 113;
			// 
			// frmEditarProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(684, 512);
			this.Controls.Add(this.lblProducto);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.lblNombreIngrediente);
			this.Controls.Add(this.txtCantidadIngrediente);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtIdIngrediente);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.dtaEditarProducto);
			this.Controls.Add(this.btnConfirmar);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.dtaIdDetalle);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEditarProducto";
			this.Text = "Editar Producto";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditarProductoFormClosing);
			this.Load += new System.EventHandler(this.FrmEditarProductoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtaEditarProducto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtaIdDetalle)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
