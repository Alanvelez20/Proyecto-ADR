/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 30/10/2022
 * Time: 02:22 p. m.
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
	/// Description of frmEditarProducto.
	/// </summary>
	public partial class frmEditarProducto : Form
	{
		public frmEditarProducto(int usuario)
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
		DataTable y = new DataTable();
		int i,z;
		void BtnRegresarClick(object sender, EventArgs e)
		{
			this.Visible=false;
			frmMenuPrincipal x=new frmMenuPrincipal(usuario);
			x.Show();
		}
		void FrmEditarProductoFormClosing(object sender, FormClosingEventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}
		//exist = reader.GetInt32
                            //	(reader.GetOrdinal("inventario"));
		void TxtIdKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)){
				
				MessageBox.Show("El dato ingresado no es un numero");
				e.Handled=true;
			}else{
			if (e.KeyChar == 13)
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
	                    
	                	band = 1;
	                }
	                reader.Close();
	                if (band==1)
	                {
	                	 IDbCommand comRecetaProducto = dbcon.CreateCommand();
	                	 comRecetaProducto.CommandText = "select id_receta_producto, id_ingrediente, cantidad_receta_producto from receta_producto where id_producto=" +Convert.ToInt16(txtId.Text) + "";
	                IDataReader readerRecetaProducto = comRecetaProducto.ExecuteReader();
	                i=0;
	                while(readerRecetaProducto.Read())
	                	{
	                	x.Rows.Add();
	                	y.Rows.Add();
	                	dtaIdDetalle.Rows[i].Cells[0].Value =readerRecetaProducto.GetInt32(readerRecetaProducto.GetOrdinal("id_receta_producto"));
	                	dtaEditarProducto.Rows[i].Cells[0].Value =readerRecetaProducto.GetInt32(readerRecetaProducto.GetOrdinal("id_ingrediente"));
	                	dtaEditarProducto.Rows[i].Cells[2].Value =readerRecetaProducto.GetInt32(readerRecetaProducto.GetOrdinal("cantidad_receta_producto"));
	                	z=readerRecetaProducto.GetInt32(readerRecetaProducto.GetOrdinal("id_receta_producto"))-i;
	                	
	                	
	                	i++;
	                	}
	                readerRecetaProducto.Close();
	                
	                int contador=0;
	                IDbCommand comandoConsultaProducto = dbcon.CreateCommand();
	                
	                while(contador!=i)
	                {
	                	comandoConsultaProducto.CommandText = "select nombre_ingrediente from ingrediente where id_ingrediente=" +Convert.ToInt16(dtaEditarProducto.Rows[contador].Cells[0].Value) + "";
	                	IDataReader readerProducto = comandoConsultaProducto.ExecuteReader();
	                	if(readerProducto.Read())
	                	{
	                		dtaEditarProducto.Rows[contador].Cells[1].Value =readerProducto.GetString(readerProducto.GetOrdinal("nombre_ingrediente"));
	                	    contador++;
	                	    readerProducto.Close();
	                	}
	                	
	                }
	               	
	                
	                }
					
					dbcon.Close();
	                if (band == 0)
	                {
	                    MessageBox.Show("Producto no encontrado");
	                    y.Rows.Clear();
	                    lblID.Text="0";
	                    lblProducto.Text="";
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
			}
		}
		void FrmEditarProductoLoad(object sender, EventArgs e)
		{
            x.Columns.Add("ID INGREDIENTE");
            x.Columns.Add("INGREDIENTE");
            x.Columns.Add("CANTIDAD");
			y.Columns.Add("id det");
            dtaEditarProducto.DataSource = x.DefaultView;
            dtaIdDetalle.DataSource = y.DefaultView;
		}
		
		
		int cuenta,n,exist,bandera;
		public void BuscarEnGrid()
		{
		 cuenta=0;
		 bandera=0;
			do
			{
				int f= Convert.ToInt16(dtaEditarProducto.Rows[cuenta].Cells[0].Value);
				if(f==Convert.ToInt16(txtIdIngrediente.Text))
				{
					bandera=1;
					break;
					
				}
				cuenta++;
			}
			while(cuenta<i);
		}
		
		int cuenta2;
		public void BuscarEnGrid2()
		{
		 cuenta2=0;
			do
			{
				int l= Convert.ToInt16(dtaEditarProducto.Rows[cuenta2].Cells[0].Value);
				if(l==Convert.ToInt16(txtIdIngrediente.Text))
				{
					break;
					
				}
				cuenta2++;
			}
			while(cuenta2<i);
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			if (txtIdIngrediente.Text == ""|| txtCantidadIngrediente.Text=="")
            {
                MessageBox.Show("DEBES INTRODUCIR TODOS LOS DATOS PARA MODIFICAR");
            }
            else
            {
                if (Convert.ToInt16( txtCantidadIngrediente.Text )<=0   )
                {
                    MessageBox.Show("DEBES INTRODUCIR UNA CANTIDAD VÁLIDA");
                    txtCantidadIngrediente.Clear();
                    txtCantidadIngrediente.Focus();
                }
			 	else
                {
                	BuscarEnGrid();
                	//Encuentra el inventario del ingrediente
                	try{
                	IDbConnection dbcon = new NpgsqlConnection
	                	("Server=localhost;Database=BaseDatos;User ID=alan;Port=5344");
                	dbcon.Open();
	                IDbCommand dbcmd2 = dbcon.CreateCommand();
	                dbcmd2.CommandText = "select inventario from ingrediente where id_ingrediente=" + txtIdIngrediente.Text + "";
	                
	                IDataReader reader2 = dbcmd2.ExecuteReader();
	                if (reader2.Read())
	                {
	                   	exist=reader2.GetInt32
                        (reader2.GetOrdinal("inventario"));
	                }
	                reader2.Close();
	                
	                
                	if (Convert.ToInt32(txtCantidadIngrediente.Text) <= exist)
                	{
	                	if (Convert.ToInt32(txtCantidadIngrediente.Text) >= 1)
	                	{	
                		if(lblID.Text == "" || lblID.Text == "0"){
                				MessageBox.Show("Primero debes elegir un pedido para modififcarlo");
                			}else{
	                			if(lblNombreIngrediente.Text == "" || lblNombreIngrediente.Text == "?"){
	                				MessageBox.Show("Elige el ID del ingrediente a modificar u oprime 'ENTER' en el ID del ingrediente para mostrar su nombre");
	                			}else{
                					BuscarEnGrid();
                					if(bandera==1){
				                		if (MessageBox.Show("Deseas actualizar este ingrediente del pedido?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
				                        {
				                			BuscarEnGrid2();
				                           	dtaEditarProducto.Rows[cuenta2].Cells[2].Value = 
				                           		txtCantidadIngrediente.Text;
				                			dtaEditarProducto.Refresh();
				                           	txtIdIngrediente.Text = "";
				                           	txtCantidadIngrediente.Text = "";
				                           	lblNombreIngrediente.Text ="";
					                        txtIdIngrediente.Focus();
				                		}
                					}else{
                						MessageBox.Show("Elige un ingrediente que se encuentre en el pedido");
                					}
                				}
                        	
                        	}
                		}
	                        	
                	
	                	dbcon.Close();
                	}
                	
                	else{
                		MessageBox.Show("Excedes las existencias, la disponibilidad es de " + exist + " porciones del ingrediente");
                        txtCantidadIngrediente.Text = "";
                        txtCantidadIngrediente.Focus();
                	}
                	
                	}catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                	}
                	
			 	}
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
                        
                        dbcmd.CommandText = "select nombre_ingrediente from " +
                        	"ingrediente where id_ingrediente=" + n + "";
                        IDataReader reader = dbcmd.ExecuteReader();
                        if (reader.Read())
                        {
                            lblNombreIngrediente.Text = 
                            	reader.GetString
                            	(reader.GetOrdinal("nombre_ingrediente"));
                            
                            
                            dbcon.Close();
                        }
                        else
                        {
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
		void BtnConfirmarClick(object sender, EventArgs e)
		{
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
                        
                        
                        while (i != contador)
                        {
                         IDbConnection dbconDetalle = new NpgsqlConnection
                        ("Server=localhost;" +
	                   "Database=BaseDatos;" +
	                   "User ID=alan;"+ "port=5344;");
	                   dbconDetalle.Open();   
	                   IDbCommand dbcmdDetallePedido =dbconDetalle.CreateCommand();
	                   dbcmdDetallePedido.CommandText =
	                   "update receta_producto set id_ingrediente="+ Convert.ToDecimal(dtaEditarProducto.Rows[contador].Cells[0].Value) + ", cantidad_receta_producto= "+ Convert.ToInt32(dtaEditarProducto.Rows[contador].Cells[2].Value)+"where id_receta_producto= " + Convert.ToInt32(dtaIdDetalle.Rows[contador].Cells[0].Value) + " ;";
	                   IDataReader reader2 = dbcmdDetallePedido.ExecuteReader();
                      
                     	
                        contador++;
                        }
                        MessageBox.Show("Producto actualizado exitosamente");
                        lblID.Text="";
       			 		lblProducto.Text="";
       			 		lblNombreIngrediente.Text="";
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
                    MessageBox.Show("Primero debes modificar algun dato");
               	 	}
			}
		}
		void TxtCantidadIngredienteKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)){
				
				MessageBox.Show("El dato ingresado no es un numero");
				e.Handled=true;
			}
		}
	}
}
