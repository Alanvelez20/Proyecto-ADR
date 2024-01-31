/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 28/09/2022
 * Time: 11:15 p. m.
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
	/// Description of frmConsultarEmpleado.
	/// </summary>
	public partial class frmConsultarEmpleado : Form
	{
		public frmConsultarEmpleado(int usario)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.usuario = usario;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		int usuario;
		void Button1Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmMenuPrincipal x=new frmMenuPrincipal(usuario);
			x.Show();
		
		}
		void FrmConsultarEmpleadoLoad(object sender, EventArgs e)
		{
			DataTable memoria = new DataTable();

            try

            {



                NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"

                        + "Database=BaseDatos;" +

                    "User ID=alan;" + "Port=5344");

                NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select * from empleado", conexion);

                datosConsulta.Fill(memoria);

                dgvDatosEmpleado.DataSource = memoria.DefaultView;

            }

            catch (Exception msg)

            {

                MessageBox.Show(msg.ToString());

            }		 
		}
		void FrmConsultarEmpleadoFormClosing(object sender, FormClosingEventArgs e)
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
