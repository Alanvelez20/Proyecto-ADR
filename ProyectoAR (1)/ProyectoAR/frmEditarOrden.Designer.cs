/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 05/11/2022
 * Time: 12:42 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoAR
{
	partial class frmEditarOrden
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblNumMesa;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblNombreEmpleado;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridView dtaEditarOrden;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnActEstatus;
		private System.Windows.Forms.ComboBox cmbEstatus;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarOrden));
			this.lblNumMesa = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblNombreEmpleado = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.dtaEditarOrden = new System.Windows.Forms.DataGridView();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.btnActEstatus = new System.Windows.Forms.Button();
			this.cmbEstatus = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dtaEditarOrden)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNumMesa
			// 
			this.lblNumMesa.AutoSize = true;
			this.lblNumMesa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumMesa.ForeColor = System.Drawing.Color.Black;
			this.lblNumMesa.Location = new System.Drawing.Point(558, 57);
			this.lblNumMesa.Name = "lblNumMesa";
			this.lblNumMesa.Size = new System.Drawing.Size(0, 18);
			this.lblNumMesa.TabIndex = 132;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(487, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 18);
			this.label5.TabIndex = 131;
			this.label5.Text = "Mesa:";
			// 
			// lblNombreEmpleado
			// 
			this.lblNombreEmpleado.AutoSize = true;
			this.lblNombreEmpleado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreEmpleado.ForeColor = System.Drawing.Color.Black;
			this.lblNombreEmpleado.Location = new System.Drawing.Point(558, 19);
			this.lblNombreEmpleado.Name = "lblNombreEmpleado";
			this.lblNombreEmpleado.Size = new System.Drawing.Size(0, 18);
			this.lblNombreEmpleado.TabIndex = 130;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(402, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(145, 18);
			this.label6.TabIndex = 129;
			this.label6.Text = "Registrado por:";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.ForeColor = System.Drawing.Color.Black;
			this.lblFecha.Location = new System.Drawing.Point(247, 67);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(19, 18);
			this.lblFecha.TabIndex = 120;
			this.lblFecha.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(175, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 18);
			this.label2.TabIndex = 119;
			this.label2.Text = "Fecha:";
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.ForeColor = System.Drawing.Color.Black;
			this.lblID.Location = new System.Drawing.Point(118, 67);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(19, 18);
			this.lblID.TabIndex = 118;
			this.lblID.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(77, 67);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 18);
			this.label8.TabIndex = 117;
			this.label8.Text = "ID:";
			// 
			// txtId
			// 
			this.txtId.BackColor = System.Drawing.SystemColors.Window;
			this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtId.Location = new System.Drawing.Point(238, 19);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(88, 23);
			this.txtId.TabIndex = 0;
			this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdKeyPress);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(77, 21);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(158, 16);
			this.label10.TabIndex = 115;
			this.label10.Text = "ID de orden a buscar: ";
			// 
			// dtaEditarOrden
			// 
			this.dtaEditarOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtaEditarOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtaEditarOrden.Location = new System.Drawing.Point(77, 274);
			this.dtaEditarOrden.Name = "dtaEditarOrden";
			this.dtaEditarOrden.Size = new System.Drawing.Size(619, 139);
			this.dtaEditarOrden.TabIndex = 114;
			// 
			// btnRegresar
			// 
			this.btnRegresar.AutoSize = true;
			this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegresar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(338, 452);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(112, 63);
			this.btnRegresar.TabIndex = 3;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(266, 171);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 16);
			this.label7.TabIndex = 133;
			this.label7.Text = "Estatus: ";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.ForeColor = System.Drawing.Color.Red;
			this.lblTotal.Location = new System.Drawing.Point(668, 474);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(18, 18);
			this.lblTotal.TabIndex = 138;
			this.lblTotal.Text = "?";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(583, 474);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(79, 18);
			this.label12.TabIndex = 137;
			this.label12.Text = "TOTAL: ";
			// 
			// btnActEstatus
			// 
			this.btnActEstatus.AutoSize = true;
			this.btnActEstatus.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnActEstatus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActEstatus.Location = new System.Drawing.Point(313, 200);
			this.btnActEstatus.Name = "btnActEstatus";
			this.btnActEstatus.Size = new System.Drawing.Size(150, 34);
			this.btnActEstatus.TabIndex = 2;
			this.btnActEstatus.Text = "Actualizar Estatus";
			this.btnActEstatus.UseVisualStyleBackColor = true;
			this.btnActEstatus.Click += new System.EventHandler(this.BtnActEstatusClick);
			// 
			// cmbEstatus
			// 
			this.cmbEstatus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbEstatus.FormattingEnabled = true;
			this.cmbEstatus.Items.AddRange(new object[] {
			"Pendiente",
			"Servida",
			"Terminada"});
			this.cmbEstatus.Location = new System.Drawing.Point(338, 170);
			this.cmbEstatus.Name = "cmbEstatus";
			this.cmbEstatus.Size = new System.Drawing.Size(100, 24);
			this.cmbEstatus.TabIndex = 1;
			// 
			// frmEditarOrden
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(787, 559);
			this.Controls.Add(this.cmbEstatus);
			this.Controls.Add(this.btnActEstatus);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblNumMesa);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblNombreEmpleado);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.dtaEditarOrden);
			this.Controls.Add(this.btnRegresar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEditarOrden";
			this.Text = "Editar Orden";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditarOrdenFormClosing);
			this.Load += new System.EventHandler(this.FrmEditarOrdenLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtaEditarOrden)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
