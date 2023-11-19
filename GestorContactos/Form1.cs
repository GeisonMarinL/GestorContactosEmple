using MySql.Data.MySqlClient;
using System.Drawing.Imaging;

namespace GestorContactos
{
    public partial class Form1 : Form
    {
        private MySqlConnection conexion;
        private Byte[] bytesImagen = new byte[0];
        public Form1()
        {
            InitializeComponent();
            conexion = new MySqlConnection("Data Source=localhost;Initial Catalog=directorio_telefonico;User ID=Geison;Password=981015");

        }

        private void btnExaminarImg_Click(object sender, EventArgs e)
        {
            // Crea un objeto OpenFileDialog
            OpenFileDialog selectorImagen = new OpenFileDialog();

            // Filtra los resultados a imágenes PNG
            selectorImagen.Filter = "Imágenes PNG (*.png)|*.png";

            // Abre el cuadro de diálogo Abrir archivo
            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                // Obtiene la ruta del archivo seleccionado
                string rutaImagen = selectorImagen.FileName;

                // Carga la imagen en el picturebox
                picFotografia.Image = Image.FromStream(selectorImagen.OpenFile());

                // Convierte la imagen a un arreglo de bytes
                MemoryStream memoria = new MemoryStream();
                picFotografia.Image.Save(memoria, ImageFormat.Png);
                bytesImagen = memoria.ToArray();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene los datos de los campos
                string documento = txtDocumento.Text;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string cargo = txtCargo.Text;
                int numeroOficina = int.Parse(txtNumeroOficina.Text);
                int telefonoMovil = int.Parse(txtTelefonoMovil.Text);


                // Validar que los datos sean correctos
                if (documento == "" || nombre == "" || apellido == "" || cargo == "" || numeroOficina == 0 || telefonoMovil == 0 || bytesImagen == null)
                {
                    // Mostrar un mensaje de error
                    MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Crea una conexión a la base de datos
                MySqlConnection conexion = new MySqlConnection("Data Source=localhost;Initial Catalog=directorio_telefonico;User ID=Geison;Password=981015");
                conexion.Open();

                // Prepara una consulta SQL
                MySqlCommand comando = new MySqlCommand("INSERT INTO empleados (documento, nombre, apellido, cargo, numeroOficina, telefonoMovil, fotografia) VALUES (@documento, @nombre, @apellido, @cargo, @numeroOficina, @telefonoMovil, @fotografia)", conexion);

                // Asigna los valores a los parámetros de la consulta
                comando.Parameters.AddWithValue("@documento", documento);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@cargo", cargo);
                comando.Parameters.AddWithValue("@numeroOficina", numeroOficina);
                comando.Parameters.AddWithValue("@telefonoMovil", telefonoMovil);
                comando.Parameters.AddWithValue("@fotografia", bytesImagen);



                // Ejecuta la consulta
                comando.ExecuteNonQuery();

                // Cierra la conexión
                conexion.Close();

                // Muestra un mensaje de confirmación
                MessageBox.Show("Los datos se guardaron correctamente.");
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene los datos del formulario
                string documento = txtDocumento.Text;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string cargo = txtCargo.Text;
                int numeroOficina = int.Parse(txtNumeroOficina.Text);
                int telefonoMovil = int.Parse(txtTelefonoMovil.Text);


                // Validar que los datos sean correctos
                if (documento == "" || nombre == "" || apellido == "" || cargo == "" || numeroOficina == 0 || telefonoMovil == 0 || bytesImagen == null)
                {
                    // Mostrar un mensaje de error
                    MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtiene el documento del empleado de la base de datos
                // Obtiene el documento del empleado de la base de datos
                string? documentoBD = null;

                using (MySqlConnection connection = new MySqlConnection("Data Source=localhost;Initial Catalog=directorio_telefonico;User ID=Geison;Password=981015"))
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand("SELECT documento FROM empleados WHERE documento=@documento", connection);
                    command.Parameters.AddWithValue("@documento", documento);

                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        documentoBD = reader["documento"].ToString();
                    }

                    connection.Close();
                }

                // Comprueba si el documento se encuentra en la base de datos
                if (documentoBD is null)
                {
                    // El documento no se encuentra en la base de datos
                    Console.WriteLine("El documento no se encuentra en la base de datos.");
                }
                else
                {
                    // El documento se encuentra en la base de datos
                    Console.WriteLine("El documento es: {0}", documentoBD);
                }



                // Compara los documentos
                if (documento != documentoBD)
                {
                    // Muestra un mensaje de error
                    MessageBox.Show("El documento no coincide con el empleado que desea actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Crea una conexión a la base de datos
                MySqlConnection conexion = new MySqlConnection("Data Source=localhost;Initial Catalog=directorio_telefonico;User ID=Geison;Password=981015");
                conexion.Open();

                // Prepara una consulta SQL
                MySqlCommand comando = new MySqlCommand("UPDATE empleados SET nombre=@nombre, apellido=@apellido, cargo=@cargo, numeroOficina=@numeroOficina, telefonoMovil=@telefonoMovil, fotografia=@fotografia WHERE documento=@documento", conexion);

                // Asigna los valores a los parámetros de la consulta
                comando.Parameters.AddWithValue("@documento", documento);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@cargo", cargo);
                comando.Parameters.AddWithValue("@numeroOficina", numeroOficina);
                comando.Parameters.AddWithValue("@telefonoMovil", telefonoMovil);
                comando.Parameters.AddWithValue("@fotografia", bytesImagen);



                // Ejecuta la consulta
                comando.ExecuteNonQuery();

                // Cierra la conexión
                conexion.Close();

                // Muestra un mensaje de confirmación
                MessageBox.Show("Los datos se actualizaron correctamente.");
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene el documento del empleado de la base de datos
                string documento = txtDocumento.Text;

                // Valida que el documento no esté vacío
                if (documento == "")
                {
                    // Muestra un mensaje de error
                    MessageBox.Show("Debe ingresar el documento del empleado que desea borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crea una conexión a la base de datos
                MySqlConnection conexion = new MySqlConnection("Data Source=localhost;Initial Catalog=directorio_telefonico;User ID=Geison;Password=981015");
                conexion.Open();

                // Prepara una consulta SQL
                MySqlCommand comando = new MySqlCommand("SELECT documento FROM empleados WHERE documento=@documento", conexion);
                comando.Parameters.AddWithValue("@documento", documento);

                // Ejecuta la consulta
                var reader = comando.ExecuteReader();

                // Valida que el empleado exista
                if (!reader.Read())
                {
                    // Muestra un mensaje de error
                    MessageBox.Show("No se puede eliminar al empleado. El documento no está registrado en la base de datos. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Cierra el primer DataReader
                reader.Close();

                // Ejecuta la consulta para eliminar el empleado
                comando = new MySqlCommand("DELETE FROM empleados WHERE documento=@documento", conexion);
                comando.Parameters.AddWithValue("@documento", documento);
                comando.ExecuteNonQuery();

                // Cierra la conexión
                conexion.Close();

                // Muestra un mensaje de confirmación
                MessageBox.Show("El empleado se borró correctamente.");


            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia los campos del formulario
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCargo.Text = "";
            txtNumeroOficina.Text = "";
            txtTelefonoMovil.Text = "";
            picFotografia.Image = null;
            bytesImagen = new byte[0];
        }
    }
}