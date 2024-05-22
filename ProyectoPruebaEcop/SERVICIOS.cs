using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Common;
using System.Data;


namespace ProyectoPruebaEcop
{
    class SERVICIOS
    {
        private string cadena;

        public SERVICIOS()
        {
            cadena = "Server=localhost\\SQLEXPRESS;Database=PruebaEcop;Trusted_Connection=True;";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(cadena);
        }

    }

    public class CLIENTES
    {
        private string nro_documento;
        private string razon_social;
        private string direccion;
        private string correo;
        private string telefono;
        private int tipodoc;
        private int clienteId;

        private SERVICIOS cadena;
        public CLIENTES(int clienteId, string nro_documento, string razon_social, string direccion, string correo, string telefono, int tipodoc)
        {
            this.clienteId = clienteId;
            this.nro_documento = nro_documento;
            this.razon_social = razon_social;           
            this.direccion = direccion;
            this.correo = correo;
            this.telefono = telefono;
            this.tipodoc = tipodoc;
        }

        public CLIENTES() { }

        public  CLIENTES(int clienteId)
        {
            this.clienteId = clienteId;
        }

        public int AgregarCliente()
        {
            try
            {
                cadena = new SERVICIOS();
                using (SqlConnection connection = cadena.GetConnection())
                {
                    connection.Open();
                    SqlCommand query = new SqlCommand("INSERT INTO CLIENTE VALUES(@nro_documento, @tipodoc, @razon_social, @direccion, @telefono, @correo)", connection);
                    query.Parameters.AddWithValue("@nro_documento", nro_documento);
                    query.Parameters.AddWithValue("@tipodoc", tipodoc);
                    query.Parameters.AddWithValue("@razon_social", razon_social);
                    query.Parameters.AddWithValue("@direccion", direccion);
                    query.Parameters.AddWithValue("@telefono", telefono);
                    query.Parameters.AddWithValue("@correo", correo);
                    
                    int result = query.ExecuteNonQuery();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error " + ex.Message);
            }

        }

        public void ListarClientes(DataGridView grid)
        {
            try
            {
                cadena = new SERVICIOS();
                SqlConnection connection = cadena.GetConnection();
                string query = "SELECT * FROM CLIENTE";
                connection.Open();

                SqlDataAdapter data = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                data.Fill(dt);
                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error " + ex.Message);
            }
        }
        public int EliminarCliente()
        {
            try
            {
                cadena = new SERVICIOS();
                SqlConnection connection = cadena.GetConnection();
                connection.Open();
                SqlCommand query = new SqlCommand("DELETE FROM CLIENTE WHERE CLIENTE_ID = @clienteId)", connection);
                query.Parameters.AddWithValue("@clienteId", clienteId);

                int result = query.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrió un error " + ex.Message);
            }
        }

        public int ModificarCliente()
        {
            try
            {
                cadena = new SERVICIOS();
                SqlConnection connection = cadena.GetConnection();
                connection.Open();
                SqlCommand query = new SqlCommand("UPDATE CLIENTE SET NRO_DOCUMENTO = @nro_documento, " +
                    "                           TIPO_DOCUMENTO = @tipodoc, RAZON_SOCIAL = @razon_social, " +
                    "                           DIRECCION = @direccion, TELEFONO = @telefono, CORREO = @correo" +
                    "                           WHERE CLIENTE_ID = @clienteId", connection);
                query.Parameters.AddWithValue("@clienteId", clienteId);
                query.Parameters.AddWithValue("@nro_documento", nro_documento);
                query.Parameters.AddWithValue("@tipodoc", tipodoc);
                query.Parameters.AddWithValue("@razon_social", razon_social);
                query.Parameters.AddWithValue("@direccion", direccion);
                query.Parameters.AddWithValue("@telefono", telefono);
                query.Parameters.AddWithValue("@correo", correo);

                int result = query.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrió un error " + ex.Message);
            }
        }
    }

    public class UNIDAD_MEDIDA
    {
        private SERVICIOS cadena;
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public UNIDAD_MEDIDA()
        {
            cadena = new SERVICIOS();
        }

        public List<UNIDAD_MEDIDA> ListarUnidadMedida()
        {
            try
            {
                List<UNIDAD_MEDIDA> unidadMedida = new List<UNIDAD_MEDIDA>();

                using (SqlConnection connection = cadena.GetConnection())
                {
                    connection.Open();
                    SqlCommand query = new SqlCommand("SELECT ID, CODIGO, DESCRIPCION FROM UNIDAD_MEDIDA", connection);
                    SqlDataReader reader = query.ExecuteReader();

                    while (reader.Read())
                    {
                        UNIDAD_MEDIDA unidad = new UNIDAD_MEDIDA
                        {
                            Id = reader.GetInt32(0),
                            Codigo = reader.GetString(1),
                            Descripcion = reader.GetString(2)
                        };

                        unidadMedida.Add(unidad);
                    }
                }

                return unidadMedida;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error " + ex.Message);
            }
        }
    }

    public class PRODUCTOS
    {
        private SERVICIOS cadena;
        public int ProductoId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public double Cantidad { get; set; }
        public PRODUCTOS(int productoId, string codigo, string descripcion, decimal precio, double cantidad)
        {
            ProductoId = productoId;
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
        }
        public PRODUCTOS(){ }
        public PRODUCTOS(int productoId)
        {
            this.ProductoId = productoId;
        }

        public int AgregarProducto()
        {
            try
            {
                cadena = new SERVICIOS();
                DateTime fecha = DateTime.Now;
                using (SqlConnection connection = cadena.GetConnection())
                {
                    connection.Open();
                    SqlCommand query = new SqlCommand("INSERT INTO PRODUCTO VALUES(@codigo, @descripcion, @cantidad, @precio, @fecha)", connection);
                    query.Parameters.AddWithValue("@codigo", Codigo);
                    query.Parameters.AddWithValue("@descripcion", Descripcion);
                    query.Parameters.AddWithValue("@precio", Precio);
                    query.Parameters.AddWithValue("@cantidad", Cantidad);
                    query.Parameters.AddWithValue("@fecha", fecha);

                    int result = query.ExecuteNonQuery();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error " + ex.Message);
            }
        }

        public void ListarProductos(DataGridView grid)
        {
            try
            {
                cadena = new SERVICIOS();
                SqlConnection connection = cadena.GetConnection();
                string query = "SELECT * FROM PRODUCTO";
                connection.Open();

                SqlDataAdapter data = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                data.Fill(dt);
                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error " + ex.Message);
            }
        }
        public int EliminarProducto()
        {
            try
            {
                cadena = new SERVICIOS();
                SqlConnection connection = cadena.GetConnection();
                connection.Open();
                SqlCommand query = new SqlCommand("DELETE FROM PRODUCTO WHERE PRODUCTO_ID = @productoId)", connection);
                query.Parameters.AddWithValue("@productoId", ProductoId);

                int result = query.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrió un error " + ex.Message);
            }
        }
        public int ModificarProducto()
        {
            try
            {
                cadena = new SERVICIOS();
                SqlConnection connection = cadena.GetConnection();
                connection.Open();
                SqlCommand query = new SqlCommand("UPDATE PRODUCTO SET CODIGO = @codigo, " +
                    "                           DESCRIPCION = @descripcion, CANTIDAD = @cantidad" +
                    "                           PRECIO_UNITARIO = @precio" +
                    "                           WHERE CLIENTE_ID = @productoId", connection);
                query.Parameters.AddWithValue("@productoId", ProductoId);
                query.Parameters.AddWithValue("@codigo", Codigo);
                query.Parameters.AddWithValue("@descripcion", Descripcion);
                query.Parameters.AddWithValue("@precio", Precio);
                query.Parameters.AddWithValue("@cantidad", Cantidad);

                int result = query.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrió un error " + ex.Message);
            }
        }
    }

    public class PEDIDOS
    {
        private SERVICIOS cadena;
        public int ProductoId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public double Cantidad { get; set; }
        public decimal PrecioTotal { get; set; }
        public double CantidadTotal { get; set; }

        public PEDIDOS() { }

        public int InsertarPedido(int clienteId, DateTime fechaEntrega, string descripcion,
            double cantidadtotal, decimal preciototal)
        {
            cadena = new SERVICIOS();
            using (SqlConnection connection = cadena.GetConnection())
            {
                string query = "INSERT INTO PEDIDO_CABECERA (CLIENTE_ID, DESCRIPCION, CANTIDAD_TOTAL," +
                    "PRECIO_TOTAL) OUTPUT INSERTED.PEDIDO_ID VALUES (@ClienteId, @Descripcion, @CantidadTotal, @PrecioTotal)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClienteId", clienteId);
                command.Parameters.AddWithValue("@FechaEntrega", fechaEntrega);
                command.Parameters.AddWithValue("@Descripcion", descripcion);
                command.Parameters.AddWithValue("@CantidadTotal", cantidadtotal);
                command.Parameters.AddWithValue("@PrecioTotal", preciototal);
                connection.Open();
                int pedidoId = (int)command.ExecuteScalar();
                return pedidoId;
            }
        }

        public void InsertarDetallePedido(int pedidoId, string producto, decimal precio, int cantidad, string productodescripcion)
        {
            cadena = new SERVICIOS();
            using (SqlConnection connection = cadena.GetConnection())
            {
                string query = "INSERT INTO PEDIDO_DETALLE (PEDIDO_ID, PRODUCTO_ID, PRECIO, CANTIDAD, PRODUCTO_DESCRIPCION)" +
                    " VALUES (@PedidoId, @Producto, @Precio, @Cantidad, @ProductoDescripcion)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PedidoId", pedidoId);
                command.Parameters.AddWithValue("@Producto", producto);
                command.Parameters.AddWithValue("@Precio", precio);
                command.Parameters.AddWithValue("@Cantidad", cantidad);
                command.Parameters.AddWithValue("@ProductoDescripcion", productodescripcion);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }


    }
}
