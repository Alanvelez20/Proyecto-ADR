/*
 * Created by SharpDevelop.
 * User: PC PANTHERA
 * Date: 05/11/2022
 * Time: 12:42 a. m.
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
	/// Description of frmEditarOrden.
	/// </summary>
	public partial class frmEditarOrden : Form
	{
		public frmEditarOrden(int usuario)
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
		int i,em;
		
		void limpircajas(){
			lblID.Text = "";
			lblFecha.Text= "";
			lblNombreEmpleado.Text= "";
			lblNumMesa.Text= "";
			cmbEstatus.Text= "";
			lblTotal.Text= "";
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
		void FrmEditarOrdenFormClosing(object sender, FormClosingEventArgs e)
		{
			Process proceso = new Process();
			proceso.StartInfo = new
            	ProcessStartInfo("cierre.bat");
            proceso.StartInfo.WindowStyle = 
            	ProcessWindowStyle.Minimized;
            proceso.Start();	
			Application.Exit();
		}
		void FrmEditarOrdenLoad(object sender, EventArgs e)
		{
			
            x.Columns.Add("ID PRODUCTO");
            x.Columns.Add("PRODUCTO");
            x.Columns.Add("CANTIDAD");
            x.Columns.Add("PRECIO");
            x.Columns.Add("IMPORTE");
            dtaEditarOrden.DataSource = x.DefaultView;
		}
		double subtotal,total;
		string estatus;
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
						estatus="";
						IDbConnection dbcon = new NpgsqlConnection
	                	("Server=localhost;Database=BaseDatos;User ID=alan;Port=5344");
	                dbcon.Open();
	                IDbCommand dbcmd = dbcon.CreateCommand();
	                dbcmd.CommandText = "select * from orden where id_orden=" + txtId.Text + "";
	                
	                IDataReader reader = dbcmd.ExecuteReader();
	                if (reader.Read())
	                {
	                    lblID.Text=txtId.Text;
						lblFecha.Text=reader.GetString
                        	(reader.GetOrdinal("fecha_orden"));	
						em=reader.GetInt32
                        	(reader.GetOrdinal("id_empleado"));
						lblNumMesa.Text=Convert.ToString(reader.GetInt32
                        (reader.GetOrdinal("num_mesa")));
						estatus=reader.GetString
                        	(reader.GetOrdinal("estatus"));
	                	band = 1;
	                	
	                }
	                reader.Close();
	                 //If para decir que una orden esta terminada si la encuentra como facturada
	                if (estatus=="Facturada"){
	                	cmbEstatus.Text="Terminada";
	                }else{
	                	cmbEstatus.Text=estatus;
	                }
	                //Cambiar color de la letra según su estatus
	                if(cmbEstatus.Text=="Pendiente"){
	                	cmbEstatus.BackColor = System.Drawing.Color.Red;
	                }else if (cmbEstatus.Text=="Servida") {
	                	cmbEstatus.BackColor = System.Drawing.Color.Orange;
	                }else if (cmbEstatus.Text=="Terminada") {
	                	cmbEstatus.BackColor = System.Drawing.Color.Green;
	                }
	                //Manda a llamar al nombre del empleado de la BD
	                IDbCommand dbcmdEmpleado = dbcon.CreateCommand();
	                dbcmdEmpleado.CommandText = "select nombre_empleado from empleado where id_empleado=" + em + "";
	                IDataReader readerEmpleado = dbcmdEmpleado.ExecuteReader();
	                if (readerEmpleado.Read())
	                {
	                    lblNombreEmpleado.Text = readerEmpleado.GetString
	                        (readerEmpleado.GetOrdinal("nombre_empleado"));
	                    
	                }
	                readerEmpleado.Close();
	               
	                if (band==1)
	                {
	                	 IDbCommand comRecetaProducto = dbcon.CreateCommand();
	                	 comRecetaProducto.CommandText = "select id_detalle_orden, id_producto, cantidad_detalle_orden, precio_actual from detalle_orden where id_orden=" +Convert.ToInt16(txtId.Text) + "";
	                IDataReader readerDetalleOrden = comRecetaProducto.ExecuteReader();
	                i=0;
	                while(readerDetalleOrden.Read())
	                	{
	                	x.Rows.Add();
	                	dtaEditarOrden.Rows[i].Cells[0].Value =readerDetalleOrden.GetInt32(readerDetalleOrden.GetOrdinal("id_producto"));
	                	dtaEditarOrden.Rows[i].Cells[2].Value =readerDetalleOrden.GetInt32(readerDetalleOrden.GetOrdinal("cantidad_detalle_orden"));
	                	dtaEditarOrden.Rows[i].Cells[3].Value =readerDetalleOrden.GetInt32(readerDetalleOrden.GetOrdinal("precio_actual"));
	                	dtaEditarOrden.Rows[i].Cells[4].Value = Convert.ToInt32(dtaEditarOrden.Rows[i].Cells[3].Value) * Convert.ToInt32(dtaEditarOrden.Rows[i].Cells[2].Value);
	                	subtotal= Convert.ToDouble(dtaEditarOrden.Rows[i].Cells[3].Value) * Convert.ToDouble(dtaEditarOrden.Rows[i].Cells[2].Value);
	                	total=subtotal + total;
	                	band = 1;
	                	i++;
	                	}
	                readerDetalleOrden.Close();
	                
	                int contador=0;
	                IDbCommand comandoConsultaProducto = dbcon.CreateCommand();
	                
	                while(contador!=i)
	                {
	                	comandoConsultaProducto.CommandText = "select descripcion_producto from producto where id_producto=" +Convert.ToInt16(dtaEditarOrden.Rows[contador].Cells[0].Value) + "";
	                	IDataReader readerProducto = comandoConsultaProducto.ExecuteReader();
	                	if(readerProducto.Read())
	                	{
	                		dtaEditarOrden.Rows[contador].Cells[1].Value =readerProducto.GetString(readerProducto.GetOrdinal("descripcion_producto"));
	                	    contador++;
	                	    readerProducto.Close();
	                	}
	                	
	                }
	                lblTotal.Text = Convert.ToString(total);
	                subtotal=0;
	                total=0;
	                }
					
					dbcon.Close();
	                if (band == 0)
	                {
	                    MessageBox.Show("Orden no encontrada");
	                    limpircajas();
	                }
						
					}
					 catch (Exception msg)
	                    {
	                        MessageBox.Show(msg.ToString());
	                    }
					 //txtId.Clear();
					 txtId.Focus();
				}
			}
			}
		}
		void BtnActEstatusClick(object sender, EventArgs e)
		{
			if (i <= 0 )
            {
                MessageBox.Show("Debes elegir una orden para actualizar su estatus");
                txtId.Focus();
			}else if( cmbEstatus.Text == ""){
				MessageBox.Show("El estatus no puede estar vacío, ingresa un valor");
                cmbEstatus.Focus();
			}
			
			else if(estatus=="Facturada"){
				MessageBox.Show("El estatus de la orden no puede ser actualizado porque ya esta facturado");
			}else
            {
                try
                {
                    int BUSCADO = Convert.ToInt16(txtId.Text);
                    NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                    "Database=BaseDatos;" +
                    "User ID=alan;Port=5344");
                    dbcon.Open();
                    NpgsqlCommand cmdUp = new NpgsqlCommand
                        ("update orden set  estatus='" + cmbEstatus.Text + "'  where id_orden=" + BUSCADO + "", dbcon);
                    if (MessageBox.Show("Deseas modificar el estatus?", 
                                        "CONFIRMA", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) 
                                        == DialogResult.Yes)
                    {
                    cmdUp.ExecuteNonQuery();
                    MessageBox.Show("Estatus actualizado");
                    if(cmbEstatus.Text=="Pendiente"){
	                	cmbEstatus.BackColor = System.Drawing.Color.Red;
	                }else if (cmbEstatus.Text=="Servida") {
	                	cmbEstatus.BackColor = System.Drawing.Color.Orange;
	                }else if (cmbEstatus.Text=="Terminada") {
	                	cmbEstatus.BackColor = System.Drawing.Color.Green;
	                }
                    }
                    //limpiarCajas();
                    dbcon.Close();

                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString());
                }
            }        
		}
		
	}
}
