/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 07/11/2022
 * Time: 01:22 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoAR
{
	/// <summary>
	/// Description of frmMenuMesero.
	/// </summary>
	public partial class frmMenuMesero : Form
	{
		public frmMenuMesero(int usuario)
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
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Haz salido de la sesión");
			this.Visible=false;
			frmLogin x=new frmLogin();
			x.Show();
		}
		void SalirToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}
		void FrmMenuMeseroLoad(object sender, EventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("arranque.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();
		}
		void FrmMenuMeseroFormClosing(object sender, FormClosingEventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsultarOrden x = new frmConsultarOrden(usuario);
            x.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmEditarOrden x = new frmEditarOrden(usuario);
            x.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmRegistrarOrden x = new frmRegistrarOrden(usuario);
            x.Show();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmRegistrarFactura x = new frmRegistrarFactura(usuario);
            x.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsultarFactura x = new frmConsultarFactura(usuario);
            x.Show();
        }
    }
}
