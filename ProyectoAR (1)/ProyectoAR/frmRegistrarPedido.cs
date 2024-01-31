/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 30/10/2022
 * Time: 04:06 p. m.
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
	/// Description of frmRegistrarPedido.
	/// </summary>
	public partial class frmRegistrarPedido : Form
	{
		public frmRegistrarPedido(int usuario)
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
        int n,i;
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
            
           txtIdEmpleado.Clear();
            
           txtIdProveedor.Clear();
           
           lblNombreEmpleado.Text="";
           lblNombreProveedor.Text="";
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
                	"select id_pedido_stock from pedido_stock order by id_pedido_stock desc limit 1";
                IDataReader reader = dbcmd.ExecuteReader();
                if (reader.Read())
                {

                    sigue = 
                    	Convert.ToInt32
                    	(reader.GetInt32(reader.GetOrdinal("id_pedido_stock")) + 1);
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
		int j=1,idDetalle;
		public void genera2(){
			try
            {
                
                 NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                        "Database=BaseDatos;" +
                        "User ID=alan;" + "Port=5344");
                dbcon.Open();
                IDbCommand dbcmdReceta = dbcon.CreateCommand();
                dbcmdReceta.CommandText = 
                	"select id_detalle_pedido_stock from detalle_pedido_stock order by id_detalle_pedido_stock desc limit 1";
                IDataReader reader = dbcmdReceta.ExecuteReader();
                if (reader.Read())
                {

                    idDetalle = 
                    	Convert.ToInt32
                    	(reader.GetInt32(reader.GetOrdinal("id_detalle_pedido_stock")) + j);
                    dtaIdDetalle.Rows[i].Cells[0].Value = idDetalle;
                    j++;
                    dbcon.Close();
                    
                }
                else
                {
                    
                    dtaIdDetalle.Rows[i].Cells[0].Value = j++;
                }
  
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
		}
		
		int cuenta,banderas;
		public void BuscarEnGrid()
		{
		 cuenta=0;
			do
			{
				int h= Convert.ToInt16(dtaPedido.Rows[cuenta].Cells[0].Value);
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
                	if (Convert.ToInt32(txtCantidadIngrediente.Text) >= 1)
                    {
              

                        if (MessageBox.Show("Deseas agregar este ingrediente al producto?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                        	
                        	n=Convert.ToInt32(txtIdIngrediente.Text);
                        	if(banderas==1)
                        	{		
                    			dtaPedido.Rows[cuenta].Cells[2].Value = Convert.ToInt16(dtaPedido.Rows[cuenta].Cells[2].Value)+
                    			Convert.ToInt16(txtCantidadIngrediente.Text);	
                    			banderas=0;
                        	
                        	}else{
                            x.Rows.Add();
                            y.Rows.Add();
                            genera2();
                            dtaPedido.Rows[i].Cells[0].Value = 
                            	txtIdIngrediente.Text;
                            dtaPedido.Rows[i].Cells[1].Value = 
                            	lblNombreIngrediente.Text;
                            dtaPedido.Rows[i].Cells[2].Value =
                            	txtCantidadIngrediente.Text;
                            dtaPedido.Refresh();
                            txtCantidadIngrediente.Text = "";
                            lblNombreIngrediente.Text = "";
                            txtIdIngrediente.Focus();
                            i++;
                        	
                        }
                        limpiarCajas();
                        txtIdIngrediente.Focus();
                        }
                	}
                	else
                    {
                        MessageBox.Show("Introduce una cantidad valida, mayor a cero");
                        txtCantidadIngrediente.Text = "";
                        txtCantidadIngrediente.Focus();
                	}
			 	}
			 	}
			}
			}
		}
		void FrmRegistrarPedidoLoad(object sender, EventArgs e)
		{
            x.Columns.Add("ID INGREDIENTE");
            x.Columns.Add("INGREDIENTE");
            x.Columns.Add("CANTIDAD");
            y.Columns.Add("id det");
            dtaPedido.DataSource = x.DefaultView;
            dtaIdDetalle.DataSource = y.DefaultView;
            genera();
			lblFecha.Text=DateTime.Now.ToString("dd/MM/yyyy");
		}
		void FrmRegistrarPedidoFormClosing(object sender, FormClosingEventArgs e)
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
		void TxtIdProveedorKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)){
				
				MessageBox.Show("El dato ingresado no es un numero");
				e.Handled=true;
			}else{
			if (e.KeyChar == 13)
            {
				if (txtIdProveedor.Text == "")
                {
                    MessageBox.Show("DEBES INTRODUCIR EL ID " +
                	                "DEL PROVEEDOR");
                    txtIdProveedor.Focus();
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
                         n = Convert.ToInt32(txtIdProveedor.Text);
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        
                        dbcmd.CommandText = "select nombre_proveedor from " +
                        	"proveedor where id_proveedor=" + n + "";
                        IDataReader reader = dbcmd.ExecuteReader();
                        if (reader.Read())
                        {
                            lblNombreProveedor.Text = 
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
		void TxtIdEmpleadoKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)){
				
				MessageBox.Show("El dato ingresado no es un numero");
				e.Handled=true;
			}else{
			if (e.KeyChar == 13)
            {
				if (txtIdEmpleado.Text == "")
                {
                    MessageBox.Show("DEBES INTRODUCIR EL ID " +
                	                "DEL EMPLEADO");
                    txtIdEmpleado.Focus();
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
                         n = Convert.ToInt32(txtIdEmpleado.Text);
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        
                        dbcmd.CommandText = "select nombre_empleado from " +
                        	"empleado where id_empleado=" + n + "";
                        IDataReader reader = dbcmd.ExecuteReader();
                        if (reader.Read())
                        {
                            lblNombreEmpleado.Text = 
                            	reader.GetString
                            	(reader.GetOrdinal("nombre_empleado"));
                            
                            dbcon.Close();
                        }
                        else
                        {
                        	limpiarCajas();
                            MessageBox.Show
                            	("Empleado no encontrado");
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
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			if(txtIdEmpleado.Text=="" || txtIdProveedor.Text=="" ){
				MessageBox.Show("Antes rellena los campos faltantes");
			}else{
			if (MessageBox.Show("Deseas guardar el pedido?", "Confirmación", 
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
                        
                       	IDbCommand dbcmdRegistrarPedido =dbcon.CreateCommand();
                   		dbcmdRegistrarPedido.CommandText = 
                    	"insert into pedido_stock values("+ Convert.ToInt16(lblID.Text)+", '" + lblFecha.Text+"', '" + txtIdProveedor.Text +"', '" + txtIdEmpleado.Text + "')";
                    	IDataReader reader = dbcmdRegistrarPedido.ExecuteReader();
                   		MessageBox.Show("Pedido registrado exitosamente");
                     	txtIdEmpleado.Focus();
                        dbcon.Close();
                        contador = 0;
                        while (i != contador)
                        {
                         IDbConnection dbconDetalle = new NpgsqlConnection
                        ("Server=localhost;" +
                    "Database=BaseDatos;" +
                    "User ID=alan;"+ "port=5344;");
                    dbconDetalle.Open();   
                    IDbCommand dbcmdDetallePedido =dbconDetalle.CreateCommand();
                   dbcmdDetallePedido.CommandText = 
                    	"insert into  detalle_pedido_stock  (id_detalle_pedido_stock,id_pedido_stock,id_ingrediente,cantidad_ingredientes_pedido) values("+ Convert.ToInt32(dtaIdDetalle.Rows[contador].Cells[0].Value) + " , " + Convert.ToInt16(lblID.Text)+ ", " + Convert.ToDecimal(dtaPedido.Rows[contador].Cells[0].Value) + ", " + Convert.ToInt32(dtaPedido.Rows[contador].Cells[2].Value) + "   )";
                     IDataReader reader2 = dbcmdDetallePedido.ExecuteReader();
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
	}
}
