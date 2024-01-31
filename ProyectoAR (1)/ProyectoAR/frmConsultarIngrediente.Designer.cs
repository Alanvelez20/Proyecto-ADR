/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 30/09/2022
 * Time: 05:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoAR
{
	partial class frmConsultarIngrediente
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.DataGridView dgvDatosIngrediente;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarIngrediente));
			this.btnRegresar = new System.Windows.Forms.Button();
			this.dgvDatosIngrediente = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatosIngrediente)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.AutoSize = true;
			this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegresar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(288, 334);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(112, 63);
			this.btnRegresar.TabIndex = 4;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// dgvDatosIngrediente
			// 
			this.dgvDatosIngrediente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDatosIngrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDatosIngrediente.Location = new System.Drawing.Point(79, 55);
			this.dgvDatosIngrediente.Name = "dgvDatosIngrediente";
			this.dgvDatosIngrediente.Size = new System.Drawing.Size(534, 207);
			this.dgvDatosIngrediente.TabIndex = 5;
			// 
			// frmConsultarIngrediente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(690, 482);
			this.Controls.Add(this.dgvDatosIngrediente);
			this.Controls.Add(this.btnRegresar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmConsultarIngrediente";
			this.Text = "Consultar Ingrediente";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConsultarIngredienteFormClosing);
			this.Load += new System.EventHandler(this.FrmConsultarIngredienteLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvDatosIngrediente)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
