/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 23/09/2022
 * Time: 03:27 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoAR
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class frmMenuPrincipal : Form
	{
		public frmMenuPrincipal(int usuario)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.usuario = usuario;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		int usuario;
		void AgregarToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Visible=false;
			frmRegistrarEmpleado x=new frmRegistrarEmpleado(usuario);
			x.Show();
		}
		void EditarToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Visible=false;
			frmEditarEmpleado x=new frmEditarEmpleado(usuario);
			x.Show();
		}
		void ConsultarToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Visible=false;
			frmConsultarEmpleado x=new frmConsultarEmpleado(usuario);
			x.Show();
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}
		void AgregarToolStripMenuItem1Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmRegistrarProveedor x=new frmRegistrarProveedor(usuario);
			x.Show();
		}
		void EditarToolStripMenuItem1Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmEditarProveedor x=new frmEditarProveedor(usuario);
			x.Show();
		}
		void ConsultarToolStripMenuItem1Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmConsultarProveedor x=new frmConsultarProveedor(usuario);
			x.Show();
		}
		void RegistrarToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Visible=false;
			frmRegistrarIngrediente x=new frmRegistrarIngrediente(usuario);
			x.Show();
		}
		void EditarToolStripMenuItem2Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmEditarIngrediente x=new frmEditarIngrediente(usuario);
			x.Show();
		}
		void ConsultarToolStripMenuItem2Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmConsultarIngrediente x=new frmConsultarIngrediente(usuario);
			x.Show();
		}
		void RegistrarToolStripMenuItem2Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmRegistrarFactura x=new frmRegistrarFactura(usuario);
			x.Show();
		}
		void ConsultarToolStripMenuItem4Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmConsultarFactura x=new frmConsultarFactura(usuario);
			x.Show();
		}
		void RegistrarToolStripMenuItem1Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmRegistrarProducto x=new frmRegistrarProducto(usuario);
			x.Show();
		}
		void FrmMenuPrincipalLoad(object sender, EventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("arranque.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();
		}
		void FrmMenuPrincipalFormClosing(object sender, FormClosingEventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}
		void ConsultarToolStripMenuItem3Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmConsultarProductos x=new frmConsultarProductos(usuario);
			x.Show();
		}
		void EditarToolStripMenuItem3Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmEditarProducto x=new frmEditarProducto(usuario);
			x.Show();
		}
		void RegistrarToolStripMenuItem3Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmRegistrarPedido x=new frmRegistrarPedido(usuario);
			x.Show();
		}
		void ConsultarToolStripMenuItem5Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmConsultarPedido x=new frmConsultarPedido(usuario);
			x.Show();
		}
		void EditarToolStripMenuItem4Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmEditarPedido x=new frmEditarPedido(usuario);
			x.Show();
		}
		void RegistrarToolStripMenuItem4Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmRegistrarOrden x=new frmRegistrarOrden(usuario);
			x.Show();
		}
		void EditarToolStripMenuItem5Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmEditarOrden x=new frmEditarOrden(usuario);
			x.Show();
		}
		void ConsultarToolStripMenuItem6Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmConsultarOrden x=new frmConsultarOrden(usuario);
			x.Show();
		}
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Haz salido de la sesión");
			this.Visible=false;
			frmLogin x=new frmLogin();
			x.Show();
		}
		
	}
}
