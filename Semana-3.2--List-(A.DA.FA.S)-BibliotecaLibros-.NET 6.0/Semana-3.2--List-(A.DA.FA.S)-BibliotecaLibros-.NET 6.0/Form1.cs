namespace Semana_3._2__List__A.DA.FA.S__BibliotecaLibros_.NET_6._0
{
    public partial class Form1 : Form
    {
        List<Libro> libros = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void mostrar(List<Libro> lista)
        {
            listViewLibros.Items.Clear();
            int stockTotal = 0;

            foreach (Libro libro in lista)
            {
                ListViewItem fila = new(libro.Codigo);
                fila.SubItems.Add(libro.Autor);
                fila.SubItems.Add(libro.Titulo);
                fila.SubItems.Add(libro.Genero);
                fila.SubItems.Add(libro.Stock.ToString());
                fila.SubItems.Add(libro.FechaPublicacion);
                listViewLibros.Items.Add(fila);
                stockTotal += libro.Stock;
            }

            labelTotalRegistros.Text = lista.Count.ToString();
            labelTotalStock.Text = stockTotal.ToString();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text == "" || textBoxAutor.Text == "" || textBoxTitulo.Text == "" || comboBoxGenero.Text == "" || numericUpDownStock.Text == "0")
            {
                MessageBox.Show("Ingrese todos los campos necesarios");
                return;
            }

            bool exists = libros.Exists(elemento => elemento.Codigo.Equals(textBoxCodigo.Text));
            if (exists)
            {
                MessageBox.Show("El código ya existe en el sistema");
                return;
            }

            Libro libro = new()
            {
                Codigo = textBoxCodigo.Text,
                Autor = textBoxAutor.Text,
                Titulo = textBoxTitulo.Text,
                Genero = comboBoxGenero.Text,
                Stock = (int)numericUpDownStock.Value,
                FechaPublicacion = dateTimePickerFecha.Text
            };

            libros.Add(libro);

            mostrar(libros);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listViewLibros.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un libro registrado");
                return;
            }

            String codigo = listViewLibros.SelectedItems[0].Text;

            libros.RemoveAll(elemento => elemento.Codigo.Equals(codigo));

            mostrar(libros);
        }

        private void buttonEliminarTodo_Click(object sender, EventArgs e)
        {
            libros.Clear();

            mostrar(libros);
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            libros.Sort((e1, e2) =>
            {
                if (e1.Stock < e2.Stock) return -1;
                else return 1;
            });

            mostrar(libros);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            mostrar(libros);

            if (textBoxBuscar.Text != "")
            {
                textBoxBuscar.Clear();
                return;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text == "")
            {
                MessageBox.Show("Ingresa el código del libro");
                return;
            }

            List<Libro> libroTemp = libros.FindAll(elemento => elemento.Codigo.Contains(textBoxBuscar.Text));

            mostrar(libroTemp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList;

        }
    }
}