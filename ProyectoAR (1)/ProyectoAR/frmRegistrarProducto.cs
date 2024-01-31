/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 29/10/2022
 * Time: 02:28 p. m.
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
	/// Description of frmRegistrarProducto.
	/// </summary>
	public partial class frmRegistrarProducto : Form
	{
		public frmRegistrarProducto(int usuario)
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
        int n,i,exist;
		DataTable x = new DataTable();
		DataTable y = new DataTable();
		
		void limpiarCajas(){

            txtIdIngrediente.Clear();

            lblNombreIngrediente.Text="";

            txtCantidadIngrediente.Clear();
            
		}
		void limpiarCajas2(){

            txtIdIngrediente.Clear();

            lblNombreIngrediente.Text="";

            txtCantidadIngrediente.Clear();
            
           txtDescripcion.Clear();
            
           txtPrecio.Clear();
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
                	"select id_producto from producto order by id_producto desc limit 1";
                IDataReader reader = dbcmd.ExecuteReader();
                if (reader.Read())
                {

                    sigue = 
                    	Convert.ToInt32
                    	(reader.GetInt32(reader.GetOrdinal("id_producto")) + 1);
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
		int j=1,idreceta;
		public void genera2(){
			try
            {
                //int idreceta;
                 NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                        "Database=BaseDatos;" +
                        "User ID=alan;" + "Port=5344");
                dbcon.Open();
                IDbCommand dbcmdReceta = dbcon.CreateCommand();
                dbcmdReceta.CommandText = 
                	"select id_receta_producto from receta_producto order by id_receta_producto desc limit 1";
                IDataReader reader = dbcmdReceta.ExecuteReader();
                if (reader.Read())
                {

                    idreceta = 
                    	Convert.ToInt32
                    	(reader.GetInt32(reader.GetOrdinal("id_receta_producto")) + j);
                    dtaNombre.Rows[i].Cells[0].Value = idreceta;
                    j++;
                    dbcon.Close();
                    
                }
                else
                {
                    
                    dtaNombre.Rows[i].Cells[0].Value = j++;
                }
  
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
		}
		
		void TxtIdIngredienteKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)){
				
				MessageBox.Show("El dato ingresado no es un numero");
				e.Handled=true;
			}else{
			if (e.KeyChar == 13)
            {
				if (txtIdIngrediente.Text == "")
                {
                    MessageBox.Show("DEBES INTRODUCIR EL ID " +
                	                "DEL INGREDIENTE");
                    txtIdIngrediente.Focus();
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
                         n = Convert.ToInt32(txtIdIngrediente.Text);
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        
                        dbcmd.CommandText = "select * from " +
                        	"ingrediente where id_ingrediente=" + n + "";
                        IDataReader reader = dbcmd.ExecuteReader();
                        if (reader.Read())
                        {
                            lblNombreIngrediente.Text = 
                            	reader.GetString
                            	(reader.GetOrdinal("nombre_ingrediente"));
                            
                            exist = reader.GetInt32
                            	(reader.GetOrdinal("inventario"));
                            dbcon.Close();
                        }
                        else
                        {
                        	limpiarCajas();
                            MessageBox.Show
                            	("Producto no encontrado");
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
		int banderas,cuenta;
		public void BuscarEnGrid()
		{
		 cuenta=0;
		 banderas=0;
			do
			{
				int h= Convert.ToInt16(dtaProductos.Rows[cuenta].Cells[0].Value);
				if(h==n)
				{
					banderas=1;
					break;
					
				}
				cuenta++;
			}
			while(cuenta<i);
		}
		
		void TxtCantidadIngredienteKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)){
				
				MessageBox.Show("El dato ingresado no es un numero");
				e.Handled=true;
			}else{
			if (e.KeyChar == 13)
            {
			 	if(txtCantidadIngrediente.Text=="")
			 	{
			 		MessageBox.Show("DEBES INTRODUCIR UNA CANTIDAD");
			 	}
			 		else{
			 	if (Convert.ToInt16( txtCantidadIngrediente.Text )<=0   )
                {
                    MessageBox.Show("DEBES INTRODUCIR UNA CANTIDAD VÁLIDA");
                    txtCantidadIngrediente.Clear();
                    txtCantidadIngrediente.Focus();
                }
			 	else
                {
                	BuscarEnGrid();
                	if (Convert.ToInt32(txtCantidadIngrediente.Text) <= exist)
                    {
              

                        if (MessageBox.Show("Deseas agregar este ingrediente al producto?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                        	
                        	n=Convert.ToInt32(txtIdIngrediente.Text);
                        	if(banderas==1)
                        	{
                        		if((Convert.ToInt32(txtCantidadIngrediente.Text)+Convert.ToInt32(dtaProductos.Rows[cuenta].Cells[2].Value))<=exist)
                        		{
                        			
                        			dtaProductos.Rows[cuenta].Cells[2].Value = Convert.ToInt16(dtaProductos.Rows[cuenta].Cells[2].Value)+
                        			Convert.ToInt16(txtCantidadIngrediente.Text);
                        			banderas=0;
                        		}
                        		else
                        		{
                        			MessageBox.Show("Se supera la existencia disponible");
                        		}
                        		
                        	}
                        	else
                        	{
                            x.Rows.Add();
                            y.Rows.Add();
                            genera2();
                            dtaProductos.Rows[i].Cells[0].Value = 
                            	txtIdIngrediente.Text;
                            dtaProductos.Rows[i].Cells[1].Value = 
                            	lblNombreIngrediente.Text;
                            dtaProductos.Rows[i].Cells[2].Value =
                            	txtCantidadIngrediente.Text;
                            dtaProductos.Refresh();
                            txtCantidadIngrediente.Text = "";
                            lblNombreIngrediente.Text = "";
                            txtIdIngrediente.Focus();
                            i++;
                        	}
                        }
                        limpiarCajas();
                        txtIdIngrediente.Focus();
                	}
                	else
                    {
                        MessageBox.Show("Excedes las existencias, la disponibilidad es de " + exist + " porciones del ingrediente");
                        txtCantidadIngrediente.Text = "";
                        txtCantidadIngrediente.Focus();
                	}
			 	}
			 	}
			}
			}
		}
                            
		void TxtPrecioKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)){
				
				MessageBox.Show("El dato ingresado no es un numero");
				e.Handled=true;
			}
			 	
		}

		
		
		//Carga de formulario
		void FrmRegistrarProductoLoad(object sender, EventArgs e)
		{
            x.Columns.Add("ID INGREDIENTE");
            x.Columns.Add("INGREDIENTE");
            x.Columns.Add("CANTIDAD");
            y.Columns.Add("id det");
            dtaProductos.DataSource = x.DefaultView;
            dtaNombre.DataSource = y.DefaultView;
            genera();
            txtDescripcion.Focus();
            
		}
		
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			if(txtDescripcion.Text=="" || txtPrecio.Text=="" ){
				MessageBox.Show("Antes rellena los campos faltantes");
			}else{
			if (MessageBox.Show("Deseas guardar el producto?", "Confirmación", 
        	                    MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == 
        	                    System.Windows.Forms.DialogResult.Yes)
            {
                if (i > 0)
                {
                    try
                    {
                        int contador = 0;
                        NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                        "Database=BaseDatos;" +
                        "User ID=alan;" + "Port=5344");
                        dbcon.Open();
                        
                        IDbCommand dbcmdRegistrarProducto =dbcon.CreateCommand();
                    dbcmdRegistrarProducto.CommandText = 
                    	"insert into producto values("+ Convert.ToInt16(lblID.Text)+", '" + txtDescripcion.Text+"', '" + txtPrecio.Text + "')";
                     IDataReader reader = dbcmdRegistrarProducto.ExecuteReader();
                     MessageBox.Show("Producto registrado exitosamente");
                     txtDescripcion.Focus();
                        dbcon.Close();
                        contador = 0;
                        while (i != contador)
                        {
                         IDbConnection dbconDetalle = new NpgsqlConnection
                        ("Server=localhost;" +
                    "Database=BaseDatos;" +
                    "User ID=alan;"+ "port=5344;");
                    dbconDetalle.Open();   
                    IDbCommand dbcmdRecetaProducto =dbconDetalle.CreateCommand();
                   dbcmdRecetaProducto.CommandText = 
                    	"insert into  receta_producto  (id_receta_producto,id_producto,id_ingrediente,cantidad_receta_producto) values("+ Convert.ToInt32(dtaNombre.Rows[contador].Cells[0].Value) + " , " + Convert.ToInt16(lblID.Text)+ ", " + Convert.ToDecimal(dtaProductos.Rows[contador].Cells[0].Value) + ", " + Convert.ToInt32(dtaProductos.Rows[contador].Cells[2].Value) + "   )";
                     IDataReader reader2 = dbcmdRecetaProducto.ExecuteReader();
                        contador++;
                        }
                        limpiarCajas2();
                        genera();
       			 		i = 0;
       			 		x.Rows.Clear(); 
       			 		y.Rows.Clear();
                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                  	}
                    
                }
                else
                	{
                    MessageBox.Show("Primero debes introducir ingredientes");
               	 	}
			}
			}
		}
		
		
		void FrmRegistrarProductoFormClosing(object sender, FormClosingEventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}
		void BtnRegresarClick(object sender, EventArgs e)
		{
			this.Visible=false;
			frmMenuPrincipal x=new frmMenuPrincipal(usuario);
			x.Show();
		}
		
	}
}
