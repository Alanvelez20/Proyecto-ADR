/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 07/11/2022
 * Time: 01:40 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoAR
{
	partial class frmMenuCocinero
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnCerrarSesion;
		private System.Windows.Forms.Button btnConsultarOrden;
		private System.Windows.Forms.Button btnEditarOrden;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuCocinero));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnConsultarOrden = new System.Windows.Forms.Button();
            this.btnEditarOrden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(516, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 41);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(364, 12);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(82, 41);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesionClick);
            // 
            // btnConsultarOrden
            // 
            this.btnConsultarOrden.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConsultarOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarOrden.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarOrden.ForeColor = System.Drawing.Color.Red;
            this.btnConsultarOrden.Location = new System.Drawing.Point(203, 12);
            this.btnConsultarOrden.Name = "btnConsultarOrden";
            this.btnConsultarOrden.Size = new System.Drawing.Size(92, 41);
            this.btnConsultarOrden.TabIndex = 4;
            this.btnConsultarOrden.Text = "Consultar Orden";
            this.btnConsultarOrden.UseVisualStyleBackColor = false;
            this.btnConsultarOrden.Click += new System.EventHandler(this.btnConsultarOrden_Click);
            // 
            // btnEditarOrden
            // 
            this.btnEditarOrden.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditarOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarOrden.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarOrden.Location = new System.Drawing.Point(41, 12);
            this.btnEditarOrden.Name = "btnEditarOrden";
            this.btnEditarOrden.Size = new System.Drawing.Size(92, 41);
            this.btnEditarOrden.TabIndex = 5;
            this.btnEditarOrden.Text = "Editar Orden";
            this.btnEditarOrden.UseVisualStyleBackColor = false;
            this.btnEditarOrden.Click += new System.EventHandler(this.btnEditarOrden_Click);
            // 
            // frmMenuCocinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(635, 513);
            this.Controls.Add(this.btnEditarOrden);
            this.Controls.Add(this.btnConsultarOrden);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnSalir);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuCocinero";
            this.Text = "Menú de Cocinero";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuCocineroFormClosing);
            this.Load += new System.EventHandler(this.FrmMenuCocineroLoad);
            this.ResumeLayout(false);

		}
	}
}
