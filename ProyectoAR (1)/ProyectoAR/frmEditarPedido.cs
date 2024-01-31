/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 31/10/2022
 * Time: 11:46 a. m.
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
	/// Description of frmEditarPedido.
	/// </summary>
	public partial class frmEditarPedido : Form
	{
		public frmEditarPedido(int usuario)
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
		int i,em,p;//z,
		
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
	                dbcmd.CommandText = "select * from pedido_stock where id_pedido_stock=" + txtId.Text + "";
	                
	                IDataReader reader = dbcmd.ExecuteReader();
	                if (reader.Read())
	                {
	                    lblID.Text=txtId.Text;
						lblFecha.Text=reader.GetString
                        	(reader.GetOrdinal("fecha_pedido"));	
						em=reader.GetInt32
                        	(reader.GetOrdinal("id_empleado"));
						p=reader.GetInt32
                        	(reader.GetOrdinal("id_proveedor"));
	                	band = 1;
	                	
	                }
	                reader.Close();
	                //Manda a llamar al nombre del empleado de la BD
	                IDbCommand dbcmdEmpleado = dbcon.CreateCommand();
	                dbcmdEmpleado.CommandText = "select nombre_empleado from empleado where id_empleado=" + em + "";
	                IDataReader readerEmpleado = dbcmdEmpleado.ExecuteReader();
	                if (readerEmpleado.Read())
	                {
	                    lblNombreEmpleado.Text = readerEmpleado.GetString
	                        (readerEmpleado.GetOrdinal("nombre_empleado"));
	                    //band = 1;
	                }
	                readerEmpleado.Close();
	                //Manda a llamar al nombre del proveedor de la BD
	                IDbCommand dbcmdProveedor = dbcon.CreateCommand();
	                dbcmdProveedor.CommandText = "select nombre_proveedor from proveedor where id_proveedor=" + p + "";
	                IDataReader readerProveedor = dbcmdProveedor.ExecuteReader();
	                if (readerProveedor.Read())
	                {
	                    lblNombreProveedor.Text = readerProveedor.GetString
	                        (readerProveedor.GetOrdinal("nombre_proveedor"));
	                    //band = 1;
	                }
	                readerProveedor.Close();
	                if (band==1)
	                {
	                	 IDbCommand comRecetaProducto = dbcon.CreateCommand();
	                	 comRecetaProducto.CommandText = "select id_detalle_pedido_stock, id_ingrediente, cantidad_ingredientes_pedido from detalle_pedido_stock where id_pedido_stock=" +Convert.ToInt16(txtId.Text) + "";
	                IDataReader readerRecetaProducto = comRecetaProducto.ExecuteReader();
	                i=0;
	                while(readerRecetaProducto.Read())
	                	{
	                	x.Rows.Add();
	                	y.Rows.Add();
	                	dtaIdDetalle.Rows[i].Cells[0].Value =readerRecetaProducto.GetInt32(readerRecetaProducto.GetOrdinal("id_detalle_pedido_stock"));
	                	dtaEditarPedido.Rows[i].Cells[0].Value =readerRecetaProducto.GetInt32(readerRecetaProducto.GetOrdinal("id_ingrediente"));
	                	dtaEditarPedido.Rows[i].Cells[2].Value =readerRecetaProducto.GetInt32(readerRecetaProducto.GetOrdinal("cantidad_ingredientes_pedido"));
	                	//z=readerRecetaProducto.GetInt32(readerRecetaProducto.GetOrdinal("id_detalle_pedido_stock"))-i;
	                	
	                	i++;
	                	}
	                readerRecetaProducto.Close();
	                
	                int contador=0;
	                IDbCommand comandoConsultaProducto = dbcon.CreateCommand();
	                
	                while(contador!=i)
	                {
	                	comandoConsultaProducto.CommandText = "select nombre_ingrediente from ingrediente where id_ingrediente=" +Convert.ToInt16(dtaEditarPedido.Rows[contador].Cells[0].Value) + "";
	                	IDataReader readerProducto = comandoConsultaProducto.ExecuteReader();
	                	if(readerProducto.Read())
	                	{
	                		dtaEditarPedido.Rows[contador].Cells[1].Value =readerProducto.GetString(readerProducto.GetOrdinal("nombre_ingrediente"));
	                	    contador++;
	                	    readerProducto.Close();
	                	}
	                	
	                }
	                
	                }
					
					dbcon.Close();
	                if (band == 0)
	                {
	                    MessageBox.Show("Pedido no encontrado");
	                    y.Rows.Clear();
	                    lblID.Text="";
                    lblNombreEmpleado.Text="";
                    lblFecha.Text="";
                    lblNombreProveedor.Text="";
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
		void BtnRegresarClick(object sender, EventArgs e)
		{
			this.Visible=false;
			frmMenuPrincipal x=new frmMenuPrincipal(usuario);
			x.Show();
		}
		void FrmEditarPedidoLoad(object sender, EventArgs e)
		{
            x.Columns.Add("ID INGREDIENTE");
            x.Columns.Add("INGREDIENTE");
            x.Columns.Add("CANTIDAD");
            y.Columns.Add("id det");
            dtaEditarPedido.DataSource = x.DefaultView;
            dtaIdDetalle.DataSource = y.DefaultView;
		}
		void FrmEditarPedidoFormClosing(object sender, FormClosingEventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}
		
		int cuenta,n,bandera;
		public void BuscarEnGrid()
		{
		 cuenta=0;
		 bandera=0;
			do
			{
				int f= Convert.ToInt16(dtaEditarPedido.Rows[cuenta].Cells[0].Value);
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
				int l= Convert.ToInt16(dtaEditarPedido.Rows[cuenta2].Cells[0].Value);
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
			//Un update a los datos de id de ingrediente y de cantidad sin sumar ni restar nada, solo actualizar
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
				                           	dtaEditarPedido.Rows[cuenta2].Cells[2].Value = 
				                           		txtCantidadIngrediente.Text;
				                			dtaEditarPedido.Refresh();
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
                }
            }   
		}
		void BtnConfirmarClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseas actualizar el pedido?", "Confirmación", 
        	                    MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == 
        	                    System.Windows.Forms.DialogResult.Yes)
            {
                if (i > 0)
                {
                    try
                    {
			
						int contador = 0;
                        while (i != contador)
                        {
                         IDbConnection dbconDetalle = new NpgsqlConnection
                        ("Server=localhost;" +
	                   "Database=BaseDatos;" +
	                   "User ID=alan;"+ "port=5344;");
	                   dbconDetalle.Open();   
	                   IDbCommand dbcmdDetallePedido =dbconDetalle.CreateCommand();
	                   dbcmdDetallePedido.CommandText =
	                   "update detalle_pedido_stock set id_ingrediente="+ Convert.ToDecimal(dtaEditarPedido.Rows[contador].Cells[0].Value) + ", cantidad_ingredientes_pedido= "+ Convert.ToInt32(dtaEditarPedido.Rows[contador].Cells[2].Value)+"where id_detalle_pedido_stock= " + Convert.ToInt32(dtaIdDetalle.Rows[contador].Cells[0].Value) + " ;";
	                   IDataReader reader2 = dbcmdDetallePedido.ExecuteReader();
                      
                     
                        contador++;
                        }
                        MessageBox.Show("Pedido registrado exitosamente");
                        lblID.Text="";
       			 		lblFecha.Text ="";
       			 		lblNombreEmpleado.Text="";
       			 		lblNombreProveedor.Text="";
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
		void TxtCantidadIngredienteKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)){
				
				MessageBox.Show("El dato ingresado no es un numero");
				e.Handled=true;
			}
		}
	}
}
