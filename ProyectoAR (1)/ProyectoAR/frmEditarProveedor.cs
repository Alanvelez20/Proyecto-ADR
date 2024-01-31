/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 30/09/2022
 * Time: 04:48 p. m.
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
	/// Description of frmEditarProveedor.
	/// </summary>
	public partial class frmEditarProveedor : Form
	{
		public frmEditarProveedor(int usuario)
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
            
            txtTelefono.Clear();
		}
		void BtnRegresarClick(object sender, EventArgs e)
		{
			this.Visible=false;
			frmMenuPrincipal x=new frmMenuPrincipal(usuario);
			x.Show();
		}
		//Boton Buscar
		void BtnBuscarClick(object sender, EventArgs e)
		{
			try
            {
                int BUSCADO = Convert.ToInt32(txtID.Text);
                int band = 0;
                IDbConnection dbcon = new NpgsqlConnection
                    ("Server=localhost;Database=BaseDatos;User ID=alan;Port=5344");
                dbcon.Open();
                IDbCommand dbcmd = dbcon.CreateCommand();
                dbcmd.CommandText = "select * from proveedor where id_proveedor=" + BUSCADO + "";
                
                IDataReader reader = dbcmd.ExecuteReader();
                if (reader.Read())
                {
                    txtNombre.Text = reader.GetString
                        (reader.GetOrdinal("nombre_proveedor"));
                    txtTelefono.Text = reader.GetString
                        (reader.GetOrdinal("telefono_proveedor"));
                    
                    
                    band = 1;
                }
                dbcon.Close();
                if (band == 0)
                {
                    MessageBox.Show("Proveedor no encontrado.");
                    limpiarCajas();
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
            txtID.Focus();
		}
		void BtnModificarClick(object sender, EventArgs e)
		{
			if (txtID.Text == "" || txtNombre.Text == "" || txtTelefono.Text=="")
            {
                MessageBox.Show("Debes introducir los valores para modificar");
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
                        ("update proveedor set  nombre_proveedor='" + txtNombre.Text + "' , telefono_proveedor= '" + txtTelefono.Text + "'  where id_proveedor=" + BUSCADO + "", dbcon);
                    if (MessageBox.Show("Deseas modificar el proveedor: "
                                        +txtNombre.Text + "?", 
                                        "CONFIRMA", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) 
                                        == DialogResult.Yes)
                    {
                    cmdUp.ExecuteNonQuery();
                    MessageBox.Show("Los datos del proveedor se han actualizado");
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
		void FrmEditarProveedorFormClosing(object sender, FormClosingEventArgs e)
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
	}
}
