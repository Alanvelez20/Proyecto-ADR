/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 30/09/2022
 * Time: 05:09 p. m.
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
	/// Description of frmRegistrarIngrediente.
	/// </summary>
	public partial class frmRegistrarIngrediente : Form
	{
		public frmRegistrarIngrediente(int usuario)
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

            txtNombre.Clear();
            
            txtProveedor.Clear();

            txtCantidad.Clear();
            lblProv.Text="";
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
                	"select id_ingrediente from ingrediente order by id_ingrediente desc limit 1";
                IDataReader reader = dbcmd.ExecuteReader();
                if (reader.Read())
                {

                    sigue = 
                    	Convert.ToInt32
                    	(reader.GetInt32(reader.GetOrdinal("id_ingrediente")) + 1);
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
			if ( txtNombre.Text == ""|| txtProveedor.Text==""|| txtCantidad.Text=="")

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

                    	"insert into ingrediente values(" + Convert.ToInt16(lblID.Text) + ",'" + txtNombre.Text + "', " + Convert.ToInt16(txtProveedor.Text) + ", " + Convert.ToInt16(txtCantidad.Text) + ");";

                    IDataReader reader = dbcmd.ExecuteReader();

                    dbcon.Close();
                    
                    limpiarCajas();
                    genera();
                    MessageBox.Show("Ingrediente guardado correctamente");

                }

                catch (Exception msg)

                {

                    MessageBox.Show("error\n\n" + msg.ToString());

                }

            }
		}
		void FrmRegistrarIngredienteFormClosing(object sender, FormClosingEventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}
		void FrmRegistrarIngredienteLoad(object sender, EventArgs e)
		{
			genera();
		}
		void TxtProveedorKeyPress(object sender, KeyPressEventArgs e)
		{
			//MessageBox.Show("hola");
			if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)){
				
				MessageBox.Show("El dato ingresado no es un numero");
				e.Handled=true;
			}else{
			int n;
			if (e.KeyChar == 13)
            {
				if (txtProveedor.Text == "")
                {
                    MessageBox.Show("DEBES INTRODUCIR EL ID " +
                	                "DEL PROVEEDOR");
					lblProv.Text="";
                    txtProveedor.Focus();
                }
                else
                {
                	 try
                    {
                        IDbConnection dbcon = new 
                        	NpgsqlConnection("Server=localhost;" +
                     "Database=BaseDatos;" +
                     "User ID=alan;" + "Port=5344");
                        dbcon.Open();
                         n = Convert.ToInt32(txtProveedor.Text);
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        
                        dbcmd.CommandText = "select nombre_proveedor from " +
                        	"proveedor where id_proveedor=" + n + "";
                        IDataReader reader = dbcmd.ExecuteReader();
                        if (reader.Read())
                        {
                            lblProv.Text = 
                            	reader.GetString
                            	(reader.GetOrdinal("nombre_proveedor"));
                            
                            dbcon.Close();
                        }
                        else
                        {
                        	limpiarCajas();
                            MessageBox.Show
                            	("Proveedor no encontrado");
                        }
                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                	}
				}
			}
			}
		}
		
	}
}
