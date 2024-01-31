/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 30/09/2022
 * Time: 05:19 p. m.
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
	/// Description of frmEditarIngrediente.
	/// </summary>
	public partial class frmEditarIngrediente : Form
	{
		public frmEditarIngrediente(int usuario)
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
		void limpiarCajas(){

            txtID.Clear();

            txtNombre.Clear();
            
            txtProveedor.Clear();

            txtCantidad.Clear();
		}
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
                dbcmd.CommandText = "select * from ingrediente where id_ingrediente=" + BUSCADO + "";
                
                IDataReader reader = dbcmd.ExecuteReader();
                if (reader.Read())
                {
                    txtNombre.Text = reader.GetString
                        (reader.GetOrdinal("nombre_ingrediente"));
                    txtProveedor.Text = Convert.ToString(reader.GetInt32
                        (reader.GetOrdinal("id_proveedor")));
                    txtCantidad.Text = Convert.ToString(reader.GetInt32
                        (reader.GetOrdinal("inventario")));
                    btnBuscar.Enabled=false;
                    
                    band = 1;
                }
                dbcon.Close();
                if (band == 0)
                {
                    MessageBox.Show("Ingrediente no encontrado");
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
			if (txtID.Text == "" || txtNombre.Text == "" || txtProveedor.Text=="" || txtCantidad.Text=="")
            {
                MessageBox.Show("Debes introducir todos los datos para modificar");
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
                    	("update ingrediente set  nombre_ingrediente='" + txtNombre.Text + "' , id_proveedor= " + Convert.ToInt32(txtProveedor.Text) + " , inventario= " + Convert.ToInt32(txtCantidad.Text) + "  where id_ingrediente=" + BUSCADO + "", dbcon);
                    if (MessageBox.Show("Deseas modificar el ingrediente: "
                                        +txtNombre.Text + "?", 
                                        "CONFIRMA", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) 
                                        == DialogResult.Yes)
                    {
                    cmdUp.ExecuteNonQuery();
                    MessageBox.Show("Ingrediente modificado");
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
		void FrmEditarIngredienteFormClosing(object sender, FormClosingEventArgs e)
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
            txtID.Focus();
		}
		void TxtProveedorKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)){
				
				MessageBox.Show("El dato ingresado no es un numero");
				e.Handled=true;
			}
		}
		void TxtCantidadKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)){
				
				MessageBox.Show("El dato ingresado no es un numero");
				e.Handled=true;
			}
		}
		
	}
}
