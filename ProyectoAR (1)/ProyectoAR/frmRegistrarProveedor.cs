/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 30/09/2022
 * Time: 02:25 p. m.
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
	/// Description of frmRegistrarProveedor.
	/// </summary>
	public partial class frmRegistrarProveedor : Form
	{
		public frmRegistrarProveedor(int usuario)
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
		//Limpiar cajas de texto
		void limpiarCajas(){

            txtNombre.Clear();
            
            txtTelefono.Clear();
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
                	"select id_proveedor from proveedor order by id_proveedor desc limit 1";
                IDataReader reader = dbcmd.ExecuteReader();
                if (reader.Read())
                {

                    sigue = 
                    	Convert.ToInt32
                    	(reader.GetInt32(reader.GetOrdinal("id_proveedor")) + 1);
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
		//Boton Regresar
		void Button1Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmMenuPrincipal x=new frmMenuPrincipal(usuario);
			x.Show();
		}
		
		//Boton registrar
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			if (txtNombre.Text == ""|| txtTelefono.Text=="")

            {

                MessageBox.Show("Debes introducir valores");

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

                    	"insert into proveedor values(" + Convert.ToInt16(lblID.Text) + ",'" + txtNombre.Text + "', '" + txtTelefono.Text + "');";

                    IDataReader reader = dbcmd.ExecuteReader();

                    dbcon.Close();
                    
                    limpiarCajas();
                    
                    genera();
                    MessageBox.Show("Proveedor registrado correctamente");

                }

                catch (Exception msg)

                {

                    MessageBox.Show("error.....\n\n" + msg.ToString());

                }

            }
			
		}
		void FrmRegistrarProveedorFormClosing(object sender, FormClosingEventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}
		void FrmRegistrarProveedorLoad(object sender, EventArgs e)
		{
			genera();
		}
	}
}
