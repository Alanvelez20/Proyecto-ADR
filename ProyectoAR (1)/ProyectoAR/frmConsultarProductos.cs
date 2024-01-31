/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 29/10/2022
 * Time: 09:29 p. m.
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
	/// Description of frmConsultarProductos.
	/// </summary>
	public partial class frmConsultarProductos : Form
	{
		public frmConsultarProductos(int usuario)
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
		DataTable x = new DataTable();
		int i;
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			this.Visible=false;
			frmMenuPrincipal x=new frmMenuPrincipal(usuario);
			x.Show();
		}
		void FrmConsultarProductosFormClosing(object sender, FormClosingEventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}
		
		void BtnConsultarClick(object sender, EventArgs e)
		{
			if(txtId.Text=="")
			{
				MessageBox.Show("Debes introducir un ID a buscar");
				txtId.Focus();
			}
			else
			{
				try{
					x.Rows.Clear();
					int band=0;
					IDbConnection dbcon = new NpgsqlConnection
                	("Server=localhost;Database=BaseDatos;User ID=alan;Port=5344");
                dbcon.Open();
                IDbCommand dbcmd = dbcon.CreateCommand();
                dbcmd.CommandText = "select * from producto where id_producto=" + txtId.Text + "";
                
                IDataReader reader = dbcmd.ExecuteReader();
                if (reader.Read())
                {
                	lblID.Text=txtId.Text;
                    lblProducto.Text=reader.GetString
                        (reader.GetOrdinal("descripcion_producto"));
                    lblPrecio.Text=Convert.ToString(reader.GetInt32
                        (reader.GetOrdinal("precio_producto")));
                    band = 1;
                }
                reader.Close();
                if (band==1)
                {
                	 IDbCommand comRecetaProducto = dbcon.CreateCommand();
                	 comRecetaProducto.CommandText = "select id_ingrediente, cantidad_receta_producto from receta_producto where id_producto=" +Convert.ToInt16(txtId.Text) + "";
                IDataReader readerRecetaProducto = comRecetaProducto.ExecuteReader();
                i=0;
                while(readerRecetaProducto.Read())
                	{
                	x.Rows.Add();
                	dtaConsultaProducto.Rows[i].Cells[0].Value =readerRecetaProducto.GetInt32(readerRecetaProducto.GetOrdinal("id_ingrediente"));
                	dtaConsultaProducto.Rows[i].Cells[2].Value =readerRecetaProducto.GetInt32(readerRecetaProducto.GetOrdinal("cantidad_receta_producto"));
                	
                	i++;
                	}
                readerRecetaProducto.Close();
                
                int contador=0;
                IDbCommand comandoConsultaProducto = dbcon.CreateCommand();
                
                while(contador!=i)
                {
                	comandoConsultaProducto.CommandText = "select nombre_ingrediente from ingrediente where id_ingrediente=" +Convert.ToInt16(dtaConsultaProducto.Rows[contador].Cells[0].Value) + "";
                	IDataReader readerProducto = comandoConsultaProducto.ExecuteReader();
                	if(readerProducto.Read())
                	{
                		dtaConsultaProducto.Rows[contador].Cells[1].Value =readerProducto.GetString(readerProducto.GetOrdinal("nombre_ingrediente"));
                	    contador++;
                	    readerProducto.Close();
                	}
                	
                }
                
                }
				
				dbcon.Close();
                if (band == 0)
                {
                    MessageBox.Show("Producto no encontrado");
                }
					
				}
				 catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                    }
				 txtId.Clear();
				 txtId.Focus();
			}
		}
		
		void FrmConsultarProductosLoad(object sender, EventArgs e)
		{
            x.Columns.Add("ID INGREDIENTE");
            x.Columns.Add("INGREDIENTE");
            x.Columns.Add("CANTIDAD");
            dtaConsultaProducto.DataSource = x.DefaultView;
		}
		void TxtIdKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)){
				
				MessageBox.Show("El dato ingresado no es un numero");
				e.Handled=true;
			}
		}
	}
}

