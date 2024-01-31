/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 07/11/2022
 * Time: 01:40 p. m.
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
	/// Description of frmLoginCocinero.
	/// </summary>
	public partial class frmMenuCocinero : Form
	{
		public frmMenuCocinero(int usuario)
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
		void BtnCerrarSesionClick(object sender, EventArgs e)
		{
			MessageBox.Show("Haz salido de la sesión");
			//MessageBox.Show(""+usuario);
			this.Visible=false;
			frmLogin x=new frmLogin();
			x.Show();
		}
		void BtnSalirClick(object sender, EventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}
		void FrmMenuCocineroFormClosing(object sender, FormClosingEventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}
		void FrmMenuCocineroLoad(object sender, EventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("arranque.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();
		}

        private void btnEditarOrden_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmEditarOrden x = new frmEditarOrden(usuario);
            x.Show();
        }

        private void btnConsultarOrden_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsultarOrden x = new frmConsultarOrden(usuario);
            x.Show();
        }
    }
}
