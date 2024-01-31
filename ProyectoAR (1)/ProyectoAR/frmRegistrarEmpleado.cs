/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 28/09/2022
 * Time: 10:31 p. m.
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
	/// Description of frmRegistrarEmpleado.
	/// </summary>
	public partial class frmRegistrarEmpleado : Form
	{
		public frmRegistrarEmpleado(int usuario)
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
        void limpiarCajas(){

            //lblID.Text="";

            txtNombre.Clear();

            txtCURP.Clear();

            txtRFC.Clear();
            
            txtDireccion.Clear();
            	
            txtTelefono.Clear();
            
            cmbRol.Text="";
		}
		
		public void genera(){
			try
            {
                int sigue;
                 NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                        "Database=BaseDatos;" +
                        "User ID=alan;" + "Port=5344");
                dbcon.Open();
                IDbCommand dbcmd = dbcon.CreateCommand();
                dbcmd.CommandText = 
                	"select id_empleado from empleado order by id_empleado desc limit 1";
                IDataReader reader = dbcmd.ExecuteReader();
                if (reader.Read())
                {

                    sigue = 
                    	Convert.ToInt32
                    	(reader.GetInt32(reader.GetOrdinal("id_empleado")) + 1);
                    lblID.Text=Convert.ToString(sigue);
                    dbcon.Close();
                    
                }
                else
                {
                    lblID.Text = "1";
                }
  
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
		}
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			if ( txtNombre.Text == ""|| txtCURP.Text==""|| txtRFC.Text=="" || txtDireccion.Text=="" || txtTelefono.Text==""|| cmbRol.Text=="")

            {

                MessageBox.Show("Debes introducir datos");

            }

            else

            {

                try

                {
                	

                   

                    IDbConnection dbcon = new NpgsqlConnection

                        ("Server=localhost;" +

                    "Database=BaseDatos;" +

                    "User ID=alan;"+ "port=5344;");

                    dbcon.Open();

                    IDbCommand dbcmd = dbcon.CreateCommand();

                    dbcmd.CommandText = 

                    	"insert into empleado values(" + Convert.ToInt16(lblID.Text) + ",'" + txtNombre.Text + "', '" + cmbRol.Text + "', '" + txtCURP.Text + "', '" + txtRFC.Text + "', '" + txtDireccion.Text + "', '" + txtTelefono.Text +  "');";

                    IDataReader reader = dbcmd.ExecuteReader();

                    dbcon.Close();
                    
                    limpiarCajas();
                    
                    genera();


                    MessageBox.Show("Registro Guardado correctamente");

                }

                catch (Exception msg)

                {

                    MessageBox.Show("error\n\n" + msg.ToString());

                }

            }
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmMenuPrincipal x=new frmMenuPrincipal(usuario);
			x.Show();
		}
		void FrmRegistrarEmpleadoFormClosing(object sender, FormClosingEventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}
		void FrmRegistrarEmpleadoLoad(object sender, EventArgs e)
		{
			genera();
		}
	}
}
