/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 05/11/2022
 * Time: 12:16 a. m.
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
	/// Description of frmRegistrarOrden.
	/// </summary>
	public partial class frmRegistrarOrden : Form
	{
		public frmRegistrarOrden(int usuario)
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
		double total;
		DataTable x = new DataTable();
		DataTable y = new DataTable();
		DataTable z = new DataTable();
		DataTable q = new DataTable();
		
		void limpiarCajas(){

            txtIdProducto.Clear();

            txtCantidadProducto.Clear();
            
            lblPrecioActual.Text="";
            lblNombreProducto.Text="";
            
		}
		
		void limpiarCajas2(){

            txtIdProducto.Clear();

            lblNombreEmpleado.Text= "";

            txtCantidadProducto.Clear();
            
            lblPrecioActual.Text="";
            
           txtIdEmpleado.Clear();
            
           
           cmbEstatus.Text="";
           cmbMesa.Text="";
           cmbEstatus.BackColor=System.Drawing.Color.White;
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
                	"select id_orden from orden order by id_orden desc limit 1";
                IDataReader reader = dbcmd.ExecuteReader();
                if (reader.Read())
                {

                    sigue = 
                    	Convert.ToInt32
                    	(reader.GetInt32(reader.GetOrdinal("id_orden")) + 1);
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
                	"select id_detalle_orden from detalle_orden order by id_detalle_orden desc limit 1";
                IDataReader reader = dbcmdReceta.ExecuteReader();
                if (reader.Read())
                {

                    idDetalle = 
                    	Convert.ToInt32
                    	(reader.GetInt32(reader.GetOrdinal("id_detalle_orden"))+j);
                    dtaIdDetalle.Rows[i].Cells[0].Value = idDetalle;
                    j++;
                    dbcon.Close();
                   
                   
                }else{
                	dtaIdDetalle.Rows[i].Cells[0].Value = j++;
                    	
                }
  
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
		}
		
		int banderas,cuenta;
		public void BuscarEnGrid()
		{
		 cuenta=0;
			do
			{
				int h= Convert.ToInt16(dtaRegistrarOrden.Rows[cuenta].Cells[0].Value);
				if(h==n)
				{
					banderas=1;
					break;
					
				}
				cuenta++;
			}
			while(cuenta<i);
		}
		
		
		void FrmRegistrarOrdenFormClosing(object sender, FormClosingEventArgs e)
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
            if (usuario == 1)
            {
                this.Visible = false;
                frmMenuPrincipal x = new frmMenuPrincipal(usuario);
                x.Show();
            }
            else if (usuario == 2)
            {
                this.Visible = false;
                frmMenuMesero x = new frmMenuMesero(usuario);
                x.Show();
            }
            else if (usuario == 3)
            {
                this.Visible = false;
                frmMenuCocinero x = new frmMenuCocinero(usuario);
                x.Show();
            }
        }
		void FrmRegistrarOrdenLoad(object sender, EventArgs e)
		{
            x.Columns.Add("ID PRODUCTO");
            x.Columns.Add("PRODUCTO");
            x.Columns.Add("CANTIDAD");
            x.Columns.Add("PRECIO");
            x.Columns.Add("IMPORTE");
            y.Columns.Add("id ing");
            y.Columns.Add("can Ing");
            y.Columns.Add("can pro");
            y.Columns.Add("inven");
            z.Columns.Add("id det");
            q.Columns.Add("id ing");
            q.Columns.Add("can Ing");
            q.Columns.Add("can pro");
            dtaRegistrarOrden.DataSource = x.DefaultView;
            dtaIngredientes.DataSource = y.DefaultView;
            dtaIdDetalle.DataSource = z.DefaultView;
            dtaIngredientes2.DataSource = q.DefaultView;
            genera();
            lblFecha.Text=DateTime.Now.ToString("dd/MM/yyyy");
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
		int ing;
		void TxtIdProductoKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)){
				
				MessageBox.Show("El dato ingresado no es un numero");
				e.Handled=true;
			}else{
			int band=0;
			if (e.KeyChar == 13)
            {
				if (txtIdProducto.Text == "")
                {
                    MessageBox.Show("DEBES INTRODUCIR EL ID " +
                	                "DEL PRODUCTO");
                    txtIdProducto.Focus();
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
                         n = Convert.ToInt32(txtIdProducto.Text);
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        
                        dbcmd.CommandText = "select descripcion_producto,precio_producto from " +
                        	"producto where id_producto=" + n + "";
                        IDataReader reader = dbcmd.ExecuteReader();
                        if (reader.Read())
                        {
                            lblNombreProducto.Text = 
                            	reader.GetString
                            	(reader.GetOrdinal("descripcion_producto"));
                            lblPrecioActual.Text = Convert.ToString(
                            	reader.GetInt32
                            	(reader.GetOrdinal("precio_producto")));
                            
                            band=1;
                            
                            //dbcon.Close();
                        }
                        reader.Close();
                        dbcon.Close();
                        
		                if (band == 0)
		                {
		                	limpiarCajas();
		                    MessageBox.Show("Producto no encontrado");
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
		
	void LeerInventario(){
			try
                    {
                        NpgsqlConnection dbcon2 = new NpgsqlConnection("Server=localhost;" +
                        "Database=BaseDatos;" +
                        "User ID=alan;" + "Port=5344");
                        dbcon2.Open();
                        
			                if (bande == 1){
		                	IDbCommand dbcmdReceta = dbcon2.CreateCommand();
			                dbcmdReceta.CommandText = 
			                	"select inventario from ingrediente where id_ingrediente=" +iding;
			                IDataReader reader2 = dbcmdReceta.ExecuteReader();
			                if (reader2.Read())
			                {
			                    inve = reader2.GetInt32(reader2.GetOrdinal("inventario"));
			                    //bande=2;
			                    
			                }
			                reader2.Close();
		                	}
                        dbcon2.Close();
			                
			          }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                  	}
		}
		double subtotal;
		int bande,inve,iding,ing2;
		void Button1Click(object sender, EventArgs e)
		{
			if (txtIdProducto.Text == "" || txtCantidadProducto.Text == "" )
                {
                    MessageBox.Show("Primero introduce datos en las cajas de texto");
                    txtIdProducto.Focus();
                }
			 		else{
			 	if (Convert.ToInt16( txtCantidadProducto.Text )<=0   )
                {
                    MessageBox.Show("DEBES INTRODUCIR UNA CANTIDAD VÁLIDA");
                    txtCantidadProducto.Clear();
                    txtCantidadProducto.Focus();
                }
			 	else
                {
                	
                	if (Convert.ToInt32(txtCantidadProducto.Text) >= 1)
                    {
                		if(lblNombreProducto.Text == "" || lblNombreProducto.Text =="?" || lblPrecioActual.Text == "" || lblPrecioActual.Text =="?"){
                			MessageBox.Show("Elige el ID del producto u oprime 'ENTER' en el ID del producto para mostrar su nombre");
                		}else{
                		if (MessageBox.Show("Deseas agregar este producto a la orden?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                	
                        {
                			try
                    	{
                        IDbConnection dbcon = new 
                        	NpgsqlConnection("Server=localhost;" +
                     "Database=BaseDatos;" +
                     "User ID=alan;" + "Port=5344");
                        dbcon.Open();
                        
                     
                        
		                    //Lee las cantidades del producto 
		                    bande=0; 
		                	IDbCommand comRecetaProducto = dbcon.CreateCommand();
		                	comRecetaProducto.CommandText = "select id_ingrediente,cantidad_receta_producto from receta_producto where id_producto=" + Convert.ToInt32(txtIdProducto.Text) + "";
			                IDataReader readerRecetaProducto = comRecetaProducto.ExecuteReader();
			                
			                while(readerRecetaProducto.Read())
		                	{
		                	y.Rows.Add();
		                	dtaIngredientes.Rows[ing].Cells[0].Value =readerRecetaProducto.GetInt32(readerRecetaProducto.GetOrdinal("id_ingrediente"));
		                	iding= readerRecetaProducto.GetInt32(readerRecetaProducto.GetOrdinal("id_ingrediente"));
		                	dtaIngredientes.Rows[ing].Cells[1].Value =readerRecetaProducto.GetInt32(readerRecetaProducto.GetOrdinal("cantidad_receta_producto"));
		                	dtaIngredientes.Rows[ing].Cells[2].Value = txtCantidadProducto.Text;
		                	bande=1;
		                	LeerInventario();
		                	dtaIngredientes.Rows[ing].Cells[3].Value = inve;
		                	ing++;
			                }
		                	readerRecetaProducto.Close();
                        
                        dbcon.Close();
                        
                        int multi,contador=0;
                        
                        while ( contador != ing) {
                        	multi=Convert.ToInt32(dtaIngredientes.Rows[contador].Cells[1].Value) * Convert.ToInt32(dtaIngredientes.Rows[contador].Cells[2].Value);
                        	if (multi<=Convert.ToInt32(dtaIngredientes.Rows[contador].Cells[3].Value)){
                        		bande=2;
                        	}else{
                        		
                        		bande=3;
                        		break;
                        	}
                        	contador++;
                        }
                        
                        if(bande==3){
                        	MessageBox.Show("La cantidad del producto supera las existencias en los ingredientes");
                        	y.Rows.Clear();
                        	ing=0;
                        }
                        
                        
                        
                        
                        if (bande==2){
                        	y.Rows.Clear();
                        	ing=0;
                        	IDbConnection dbcon2 = new 
                        	NpgsqlConnection("Server=localhost;" +
                     "Database=BaseDatos;" +
                     "User ID=alan;" + "Port=5344");
                        dbcon.Open();
                        	IDbCommand comRecetaProducto2 = dbcon.CreateCommand();
		                	comRecetaProducto2.CommandText = "select id_ingrediente,cantidad_receta_producto from receta_producto where id_producto=" + Convert.ToInt32(txtIdProducto.Text) + "";
			                IDataReader readerRecetaProducto2 = comRecetaProducto2.ExecuteReader();
			                
			                while(readerRecetaProducto2.Read())
		                	{
		                	q.Rows.Add();
		                	dtaIngredientes2.Rows[ing2].Cells[0].Value =readerRecetaProducto2.GetInt32(readerRecetaProducto2.GetOrdinal("id_ingrediente"));
		                	iding= readerRecetaProducto2.GetInt32(readerRecetaProducto2.GetOrdinal("id_ingrediente"));
		                	dtaIngredientes2.Rows[ing2].Cells[1].Value =readerRecetaProducto2.GetInt32(readerRecetaProducto2.GetOrdinal("cantidad_receta_producto"));
		                	dtaIngredientes2.Rows[ing2].Cells[2].Value = txtCantidadProducto.Text;
		                	ing2++;
		                	
			                }
		                	readerRecetaProducto2.Close();
		                	dbcon.Close();
		                	
		                	
		                	BuscarEnGrid();
                			n=Convert.ToInt32(txtIdProducto.Text);
                			if(banderas==1)
                        	{	
                    			dtaRegistrarOrden.Rows[cuenta].Cells[2].Value = Convert.ToInt16(dtaRegistrarOrden.Rows[cuenta].Cells[2].Value)+
                    			Convert.ToInt16(txtCantidadProducto.Text);
                            	
                    			dtaRegistrarOrden.Rows[cuenta].Cells[4].Value = Convert.ToInt32(dtaRegistrarOrden.Rows[cuenta].Cells[2].Value) * Convert.ToInt32(dtaRegistrarOrden.Rows[cuenta].Cells[3].Value);
                    			
								subtotal = 
                            	Convert.ToDouble(lblPrecioActual.Text)
                            	* Convert.ToDouble(txtCantidadProducto.Text);
	                            total = total + subtotal;
	                            subtotal=0;                    			
								
	                            lblPrecioActual.Text = "";
	                            banderas=0;
                        		
                        		
                			}else{
                			
                            x.Rows.Add();
                            z.Rows.Add();
                            genera2();
                            dtaRegistrarOrden.Rows[i].Cells[0].Value = 
                            	txtIdProducto.Text;
                            dtaRegistrarOrden.Rows[i].Cells[1].Value = 
                            	lblNombreProducto.Text;
                            dtaRegistrarOrden.Rows[i].Cells[2].Value =
                            	txtCantidadProducto.Text;
                            dtaRegistrarOrden.Rows[i].Cells[3].Value =
                            	lblPrecioActual.Text;
                            
                            dtaRegistrarOrden.Rows[i].Cells[4].Value = Convert.ToInt32(dtaRegistrarOrden.Rows[i].Cells[3].Value) * Convert.ToInt32(dtaRegistrarOrden.Rows[i].Cells[2].Value);
                            
                            subtotal = 
                            	Convert.ToDouble(lblPrecioActual.Text)
                            	* Convert.ToDouble(txtCantidadProducto.Text);
                            total = total + subtotal;
                            
                            subtotal=0;
                            dtaRegistrarOrden.Refresh();
                            txtCantidadProducto.Text = "";
                            lblNombreProducto.Text = "";
                            lblPrecioActual.Text = "";
                            txtIdProducto.Focus();
                            i++;
                        	
                        	}
                        	}
                			
				
                               			
                		
                        
		                
                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                	}
                			
                			
                			
                		
                		lblTotal.Text = Convert.ToString(total);
                		}
                        limpiarCajas();
                        txtIdProducto.Focus();
                	}
                	}
                	else
                    {
                        MessageBox.Show("Introduce una cantidad valida, mayor a cero");
                        txtCantidadProducto.Text = "";
                        txtCantidadProducto.Focus();
                	}
			 	}
			 	}
		}
		//double multi;
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			if(txtIdEmpleado.Text=="" || cmbMesa.Text=="" || cmbEstatus.Text==""){
				MessageBox.Show("Antes rellena los campos faltantes");
			}else{
			if (MessageBox.Show("Deseas guardar la orden?", "Confirmación", 
        	                    MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == 
        	                    System.Windows.Forms.DialogResult.Yes)
            {
                if (i > 0)
                {
                    try
                    {
                        int contador = 0, existnew;
                        
                        NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                        "Database=BaseDatos;" +
                        "User ID=alan;" + "Port=5344");
                        dbcon.Open();
                        
                        while (ing2 != contador)
                        //int contador = 0,existnew;//PONER ESTO EN EL INT DE ARRIBA
                        {
                            	n =
                            	Convert.ToInt32
                            	(dtaIngredientes2.Rows[contador].Cells[0].Value);//ID de ingrediente
                            existnew = 
                            	Convert.ToInt32(dtaIngredientes2.Rows[contador].Cells[1].Value)*Convert.ToInt32(dtaIngredientes2.Rows[contador].Cells[2].Value);
                            //MessageBox.Show("a");
                            string queryUp = 
                            	"update ingrediente set inventario=inventario-" + existnew +
                            	" where id_ingrediente=" + n + "";
                            NpgsqlCommand cmdUp = 
                            	new NpgsqlCommand(queryUp, dbcon);
                            cmdUp.ExecuteNonQuery();
                            contador++;
			                
			                
                        }
                        existnew=0;
                        
                        IDbCommand dbcmdRegistrarProducto =dbcon.CreateCommand();
                    dbcmdRegistrarProducto.CommandText = 
                    	"insert into orden values("+ Convert.ToInt16(lblID.Text)+", '" + lblFecha.Text+"', " + Convert.ToInt32(txtIdEmpleado.Text) + ", " + Convert.ToInt32(cmbMesa.Text) +", '" + cmbEstatus.Text +"')";
                     IDataReader reader = dbcmdRegistrarProducto.ExecuteReader();
                     MessageBox.Show("Orden registrada exitosamente");
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
                    IDbCommand dbcmdRecetaProducto =dbconDetalle.CreateCommand();
                   dbcmdRecetaProducto.CommandText = 
                    	"insert into  detalle_orden  (id_detalle_orden,id_orden,id_producto,cantidad_detalle_orden,precio_actual) values("+ dtaIdDetalle.Rows[contador].Cells[0].Value + " , " + Convert.ToInt16(lblID.Text)+ ", " + Convert.ToDecimal(dtaRegistrarOrden.Rows[contador].Cells[0].Value) + ", " + Convert.ToInt32(dtaRegistrarOrden.Rows[contador].Cells[2].Value)+ ", " + Convert.ToInt32(dtaRegistrarOrden.Rows[contador].Cells[3].Value) + "   )";
                     IDataReader reader2 = dbcmdRecetaProducto.ExecuteReader();
                        contador++;
                        }
                        limpiarCajas2();
                        genera();
       			 		i = 0;
       			 		ing=0;
       			 		ing2=0;
       			 		subtotal=0;
                		total=0;
                		lblTotal.Text="";
       			 		x.Rows.Clear(); 
       			 		y.Rows.Clear();	
       			 		z.Rows.Clear(); 
       			 		q.Rows.Clear();
       			 		
                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                  	}
                    
                }
                else
                	{
                    MessageBox.Show("Primero debes introducir productos");
               	 	}
			}
			}
		}
		
		
		void TxtCantidadProductoKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)){
				
				MessageBox.Show("El dato ingresado no es un numero");
				e.Handled=true;
			}
		}
		
		
	}
}
