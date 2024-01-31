/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 07/11/2022
 * Time: 12:26 p. m.
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
	/// Description of frmLogin.
	/// </summary>
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
		int usuario=0;
		void BtnIniciarSesionClick(object sender, EventArgs e)
		{
			//string rol;
			if(txtID.Text=="" || txtNombre.Text==""){
				 MessageBox.Show("Primero introduce valores");
			}else if(Convert.ToInt16( txtID.Text )<=0){
					MessageBox.Show("Ingresa un ID válido");
				}else{
			try
            {
				IDbConnection dbcon = new NpgsqlConnection
               	("Server=localhost;Database=BaseDatos;User ID=alan;Port=5344");
                dbcon.Open();
                IDbCommand dbcmd = dbcon.CreateCommand();
                dbcmd.CommandText = "select id_empleado,nombre_empleado,rol from empleado where id_empleado=" + txtID.Text + "";
                
                IDataReader reader = dbcmd.ExecuteReader();
                if (reader.Read())
                {
                	if (txtID.Text==Convert.ToString(reader.GetInt32(reader.GetOrdinal("id_empleado"))) && txtNombre.Text==reader.GetString(reader.GetOrdinal("nombre_empleado"))){
                		//MessageBox.Show("Messirve" );
                		if(reader.GetString(reader.GetOrdinal("rol"))=="Gerente"){
                			usuario=1;
                			this.Visible=false;
							frmMenuPrincipal x=new frmMenuPrincipal(usuario);
							x.Show();
                		}else if(reader.GetString(reader.GetOrdinal("rol"))=="Mesero"){
                			usuario=2;
                			this.Visible=false;
							frmMenuMesero x=new frmMenuMesero(usuario);
							x.Show();
                		}else if(reader.GetString(reader.GetOrdinal("rol"))=="Cocinero"){
                			usuario=3;
                			//MessageBox.Show("Chef" );
                			this.Visible=false;
							frmMenuCocinero x=new frmMenuCocinero(usuario);
							x.Show();
                		}
                	}else{
                		MessageBox.Show("ALGUN DATO ES INCORRECTO, INDTRODUCE TU ID Y NOMBRE DE NUEVO" );
                		txtID.Clear();
                		txtNombre.Clear();
                	}
                	usuario=0;
					//lblNumMesa.Text=Convert.ToString(reader.GetInt32
                    //(reader.GetOrdinal("num_mesa")));
                	
                }
                reader.Close();
                dbcon.Close();
                
                
                
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
			}
			
			/*this.Visible=false;
			frmMenuPrincipal x=new frmMenuPrincipal();
			x.Show();*/
		}
		void FrmLoginFormClosing(object sender, FormClosingEventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}
		void FrmLoginLoad(object sender, EventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("arranque.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();
		}
	}
}
