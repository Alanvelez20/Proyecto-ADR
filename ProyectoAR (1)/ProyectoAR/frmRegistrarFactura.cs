/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 30/09/2022
 * Time: 05:41 p. m.
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
	/// Description of frmRegistrarFactura.
	/// </summary>
	public partial class frmRegistrarFactura : Form
	{
		public frmRegistrarFactura(int usuario)
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

            txtNombre.Clear();

            txtRFC.Clear();

            txtRegimen.Clear();
            
            txtDireccion.Clear();
            	
            txtConcepto.Clear();
            
            txtId.Clear();
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
                	"select id_factura from factura order by id_factura desc limit 1";
                IDataReader reader = dbcmd.ExecuteReader();
                if (reader.Read())
                {

                    sigue = 
                    	Convert.ToInt32
                    	(reader.GetInt32(reader.GetOrdinal("id_factura")) + 1);
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
        }
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			string estatus = "";
			if (txtNombre.Text == ""|| txtRFC.Text==""|| txtRegimen.Text=="" || txtDireccion.Text=="" || txtConcepto.Text==""|| txtId.Text=="")

            {
                MessageBox.Show("Debes introducir valores");
            }
            else
            {
            	
                try
                {
                	int BUSCADO = Convert.ToInt32(txtId.Text);
                	int band=0;

                    IDbConnection dbcon = new NpgsqlConnection

                        ("Server=localhost;" +

                    "Database=BaseDatos;" +

                    "User ID=alan;"+ "port=5344;");

                    dbcon.Open();
                    
                    IDbCommand dbcmd2 = dbcon.CreateCommand();
	                dbcmd2.CommandText = "select estatus from orden where id_orden=" + txtId.Text + "";
	                
	                IDataReader reader2 = dbcmd2.ExecuteReader();
	                if (reader2.Read())
	                {
						estatus=reader2.GetString
                        	(reader2.GetOrdinal("estatus"));
	                	band = 1;
	                	
	                }
	                reader2.Close();
	                
	                if (band==1){
	                
	                if ( estatus=="Facturada"){
	                	MessageBox.Show("Esta orden ya tiene una factura registrada, no puede facturarse de nuevo");
	                }else{

                    IDbCommand dbcmd = dbcon.CreateCommand();

                    dbcmd.CommandText = 

                    	"insert into factura values(" + Convert.ToInt16(lblID.Text) + ",'" + txtNombre.Text + "', '" + txtRFC.Text + "', '" + txtRegimen.Text + "', '" + txtDireccion.Text + "', '" + txtConcepto.Text + "', " +  + Convert.ToInt16(txtId.Text) +  ");";

                    IDataReader reader = dbcmd.ExecuteReader();
                    
                    
                    NpgsqlConnection dbcon1 = new NpgsqlConnection("Server=localhost;" +
                    "Database=BaseDatos;" +
                    "User ID=alan;Port=5344");
                    dbcon1.Open();
                    NpgsqlCommand cmdUp = new NpgsqlCommand
                        ("update orden set  estatus='Facturada'  where id_orden=" + BUSCADO + "", dbcon1);
                    cmdUp.ExecuteNonQuery();
                    
                    dbcon.Close();
                    dbcon1.Close();

                      
                    x.Rows.Clear();
                    limpiarCajas();
                    genera();

                    MessageBox.Show("Factura creada correctamente");
	                }

                
	                }else{
	                	MessageBox.Show("Orden no encontrada");
	                }
            	}

                catch (Exception msg)

                {

                    MessageBox.Show("error\n\n" + msg.ToString());

                }
            	

            }
		}
		void FrmRegistrarFacturaFormClosing(object sender, FormClosingEventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}
		void FrmRegistrarFacturaLoad(object sender, EventArgs e)
		{
            x.Columns.Add("ID PRODUCTO");
            x.Columns.Add("PRODUCTO");
            x.Columns.Add("CANTIDAD");
            x.Columns.Add("PRECIO");
            x.Columns.Add("IMPORTE");
            genera();
            dtaConsultarOrden.DataSource = x.DefaultView;
            txtId.Focus();
		}
		DataTable x = new DataTable();
		int i;
		
		void TxtOrdenKeyPress(object sender, KeyPressEventArgs e)
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
						string estatus="";
						IDbConnection dbcon = new NpgsqlConnection
	                	("Server=localhost;Database=BaseDatos;User ID=alan;Port=5344");
	                dbcon.Open();
	                
	                IDbCommand dbcmd = dbcon.CreateCommand();
	                dbcmd.CommandText = "select estatus from orden where id_orden=" + txtId.Text + "";
	                
	                IDataReader reader = dbcmd.ExecuteReader();
	                if (reader.Read())
	                {
						estatus=reader.GetString
                        	(reader.GetOrdinal("estatus"));
	                	band = 1;
	                	
	                }
	                reader.Close();
	                if (estatus=="Facturada"){
	                	MessageBox.Show("Esta orden ya tiene una factura registrada, no puede facturarse de nuevo");
	                }else{
	               
	           		IDbCommand comRecetaProducto = dbcon.CreateCommand();
	                comRecetaProducto.CommandText = "select id_detalle_orden, id_producto, cantidad_detalle_orden, precio_actual from detalle_orden where id_orden=" +Convert.ToInt16(txtId.Text) + "";
	                IDataReader readerDetalleOrden = comRecetaProducto.ExecuteReader();
	                i=0;
	                while(readerDetalleOrden.Read())
	                	{
	                	x.Rows.Add();
	                	dtaConsultarOrden.Rows[i].Cells[0].Value =readerDetalleOrden.GetInt32(readerDetalleOrden.GetOrdinal("id_producto"));
	                	dtaConsultarOrden.Rows[i].Cells[2].Value =readerDetalleOrden.GetInt32(readerDetalleOrden.GetOrdinal("cantidad_detalle_orden"));
	                	dtaConsultarOrden.Rows[i].Cells[3].Value =readerDetalleOrden.GetInt32(readerDetalleOrden.GetOrdinal("precio_actual"));
	                	dtaConsultarOrden.Rows[i].Cells[4].Value = Convert.ToInt32(dtaConsultarOrden.Rows[i].Cells[3].Value) * Convert.ToInt32(dtaConsultarOrden.Rows[i].Cells[2].Value);
	                	band = 1;
	                	i++;
	                	}
	                readerDetalleOrden.Close();
	                
	                int contador=0;
	                IDbCommand comandoConsultaProducto = dbcon.CreateCommand();
	                
	                while(contador!=i)
	                {
	                	comandoConsultaProducto.CommandText = "select descripcion_producto from producto where id_producto=" +Convert.ToInt16(dtaConsultarOrden.Rows[contador].Cells[0].Value) + "";
	                	IDataReader readerProducto = comandoConsultaProducto.ExecuteReader();
	                	if(readerProducto.Read())
	                	{
	                		dtaConsultarOrden.Rows[contador].Cells[1].Value =readerProducto.GetString(readerProducto.GetOrdinal("descripcion_producto"));
	                	    contador++;
	                	    readerProducto.Close();
	                	}
	                	
	                }
	                }
	                
					
					dbcon.Close();
	                if (band == 0)
	                {
	                    MessageBox.Show("Orden no encontrada");
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
