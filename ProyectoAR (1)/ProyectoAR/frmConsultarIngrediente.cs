/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 30/09/2022
 * Time: 05:35 p. m.
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
	/// Description of frmConsultarIngrediente.
	/// </summary>
	public partial class frmConsultarIngrediente : Form
	{
		public frmConsultarIngrediente(int usuario)
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
			this.Visible=false;
			frmMenuPrincipal x=new frmMenuPrincipal(usuario);
			x.Show();
		}
		void FrmConsultarIngredienteLoad(object sender, EventArgs e)
		{
			DataTable memoria = new DataTable();

            try

            {



                NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"

                        + "Database=BaseDatos;" +

                    "User ID=alan;" + "Port=5344");

                NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select * from ingrediente", conexion);

                datosConsulta.Fill(memoria);

                dgvDatosIngrediente.DataSource = memoria.DefaultView;

            }

            catch (Exception msg)

            {

                MessageBox.Show(msg.ToString());

            }
		}
		void FrmConsultarIngredienteFormClosing(object sender, FormClosingEventArgs e)
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
