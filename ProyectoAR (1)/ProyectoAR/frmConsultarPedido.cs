/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 30/10/2022
 * Time: 07:33 p. m.
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
	/// Description of frmConsultarPedido.
	/// </summary>
	public partial class frmConsultarPedido : Form
	{
		public frmConsultarPedido(int usuario)
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
		int i,em,p;
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			this.Visible=false;
			frmMenuPrincipal x=new frmMenuPrincipal(usuario);
			x.Show();
		}
		void FrmConsultarPedidoFormClosing(object sender, FormClosingEventArgs e)
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
                dbcmd.CommandText = "select * from pedido_stock where id_pedido_stock=" + txtId.Text + "";
                
                IDataReader reader = dbcmd.ExecuteReader();
                if (reader.Read())
                {
                	lblID.Text=txtId.Text;
                    lblFecha.Text = reader.GetString
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
                //Manda a llamar los datos a la tabla
                if (band==1)
                {
                	 IDbCommand comDetallePedido = dbcon.CreateCommand();
                	 comDetallePedido.CommandText = "select id_ingrediente, cantidad_ingredientes_pedido from detalle_pedido_stock where id_pedido_stock=" +Convert.ToInt16(txtId.Text) + "";
                IDataReader readerDetallePedido = comDetallePedido.ExecuteReader();
                i=0;
                while(readerDetallePedido.Read())
                	{
                	x.Rows.Add();
                	dtaConsultarPedido.Rows[i].Cells[0].Value =readerDetallePedido.GetInt32(readerDetallePedido.GetOrdinal("id_ingrediente"));
                	dtaConsultarPedido.Rows[i].Cells[2].Value =readerDetallePedido.GetInt32(readerDetallePedido.GetOrdinal("cantidad_ingredientes_pedido"));
                	//band=1;
                	i++;
                	}
                readerDetallePedido.Close();
                
                int contador=0;
                IDbCommand comandoConsultaPedido = dbcon.CreateCommand();
                
                while(contador!=i)
                {
                	comandoConsultaPedido.CommandText = "select nombre_ingrediente from ingrediente where id_ingrediente=" +Convert.ToInt16(dtaConsultarPedido.Rows[contador].Cells[0].Value) + "";
                	IDataReader readerProducto = comandoConsultaPedido.ExecuteReader();
                	if(readerProducto.Read())
                	{
                		dtaConsultarPedido.Rows[contador].Cells[1].Value =readerProducto.GetString(readerProducto.GetOrdinal("nombre_ingrediente"));
                	    contador++;
                	    readerProducto.Close();
                	}
                	
                }
                
                }
				
				dbcon.Close();
                if (band == 0)
                {
                    MessageBox.Show("Pedido no encontrado");
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
		
		
		void FrmConsultarPedidoLoad(object sender, EventArgs e)
		{
            x.Columns.Add("ID INGREDIENTE");
            x.Columns.Add("INGREDIENTE");
            x.Columns.Add("CANTIDAD");
            dtaConsultarPedido.DataSource = x.DefaultView;
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
