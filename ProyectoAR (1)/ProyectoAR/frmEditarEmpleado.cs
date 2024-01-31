/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 28/09/2022
 * Time: 11:12 p. m.
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
	/// Description of frmEditarEmpleado.
	/// </summary>
	public partial class frmEditarEmpleado : Form
	{
		public frmEditarEmpleado(int usuario)
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

            txtID.Clear();

            txtNombre.Clear();

            txtCURP.Clear();

            txtRFC.Clear();
            
            txtDireccion.Clear();
            	
            txtTelefono.Clear();
            
            cmbRol.Text="";
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Visible=false;
			frmMenuPrincipal x=new frmMenuPrincipal(usuario);
			x.Show();
		
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			if (txtID.Text == "" || txtNombre.Text == ""|| txtCURP.Text==""|| txtRFC.Text=="" || txtDireccion.Text=="" || txtTelefono.Text==""|| cmbRol.Text=="")
            {
                MessageBox.Show("Debes introducir datos para modificar");
                txtNombre.Focus();
            }
            else
            {
                try
                {
                    int BUSCADO = Convert.ToInt16(txtID.Text);
                    NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                    "Database=BaseDatos;" +
                    "User ID=alan;Port=5344");
                    dbcon.Open();
                    NpgsqlCommand cmdUp = new NpgsqlCommand
                        ("update empleado set  nombre_empleado='" + txtNombre.Text + "' , rol = '" + cmbRol.Text + "' , curp= '" + txtCURP.Text + "' , rfc_empleado= '" + txtRFC.Text + "' , direccion= '" + txtDireccion.Text + "' , telefono= '" + txtTelefono.Text + "'  where id_empleado=" + BUSCADO + "", dbcon);
                    if (MessageBox.Show("Deseas modificar el empleado: "
                                        +txtNombre.Text + "?", 
                                        "CONFIRMA", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) 
                                        == DialogResult.Yes)
                    {
                    cmdUp.ExecuteNonQuery();
                    MessageBox.Show("Registro de empleado modificado");
                    }
                    limpiarCajas();
                    txtID.Focus();
                    dbcon.Close();

                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString());
                }
            }            

		}
		void FrmEditarEmpleadoFormClosing(object sender, FormClosingEventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}
		void TxtIDKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)){
				
				MessageBox.Show("El dato ingresado no es un numero");
				e.Handled=true;
			
			}
		}
		void BtnBuscarClick(object sender, EventArgs e)
		{	
				 try
	            {
	                
	                int id = Convert.ToInt32(txtID.Text);
	                int band = 0;
	                IDbConnection dbcon = new NpgsqlConnection
	                    ("Server=localhost;Database=BaseDatos;User ID=alan;Port=5344");
	                dbcon.Open();
	                IDbCommand dbcmd = dbcon.CreateCommand();
	                dbcmd.CommandText = "select * from empleado where id_empleado=" + id + "";
	                
	                IDataReader reader = dbcmd.ExecuteReader();
	                if (reader.Read())
	                {
	                    txtNombre.Text = reader.GetString
	                        (reader.GetOrdinal("nombre_empleado"));
	                    cmbRol.Text = reader.GetString
	                        (reader.GetOrdinal("rol"));
	                    txtCURP.Text = reader.GetString
	                        (reader.GetOrdinal("curp"));
	                    txtRFC.Text = reader.GetString
	                        (reader.GetOrdinal("rfc_empleado"));
	                    txtDireccion.Text = reader.GetString
	                        (reader.GetOrdinal("direccion"));
	                    txtTelefono.Text = reader.GetString
	                        (reader.GetOrdinal("telefono"));
	                    
	                    
	                    band = 1;
	                }
	                dbcon.Close();
	                if (band == 0)
	                {
	                    MessageBox.Show("Empleado no encontrado");
	                    limpiarCajas();
	                }
	            }
	            catch (Exception msg)
	            {
	                MessageBox.Show(msg.ToString());
	            }
			
            txtID.Focus();
		}
		
	}
}
