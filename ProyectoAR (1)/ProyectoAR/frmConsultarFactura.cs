/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 30/09/2022
 * Time: 05:50 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using Mono.Security;
using System.Diagnostics;
using System.Data;

namespace ProyectoAR
{
	/// <summary>
	/// Description of frmConsultarFactura.
	/// </summary>
	public partial class frmConsultarFactura : Form
	{
		public frmConsultarFactura(int usuario)
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
        void BtnRegresarClick(object sender, EventArgs e)
		{
            if (usuario == 1)
            {
                this.Visible = false;
                frmMenuPrincipal x = new frmMenuPrincipal(usuario);
                x.Show();
            }
            else if (usuario == 2)
            {
                this.Visible = false;
                frmMenuMesero x = new frmMenuMesero(usuario);
                x.Show();
            }
        }
		void FrmConsultarFacturaLoad(object sender, EventArgs e)
		{
			DataTable memoria = new DataTable();

            try

            {



                NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"

                        + "Database=BaseDatos;" +

                    "User ID=alan;" + "Port=5344");

                NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select * from factura", conexion);

                datosConsulta.Fill(memoria);

                dgvDatosFactura.DataSource = memoria.DefaultView;

            }

            catch (Exception msg)

            {

                MessageBox.Show(msg.ToString());

            }
		}
		void FrmConsultarFacturaFormClosing(object sender, FormClosingEventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}
	}
}
