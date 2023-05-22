using System.Diagnostics;

namespace Ejercicio01WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<TipoArchivo> lArchivo = new List<TipoArchivo>
            {
                new TipoArchivo {extension= ".txt",nombreArchivo="Archivos txt"},
                new TipoArchivo {extension= ".docx",nombreArchivo="Archivos word"},
                new TipoArchivo {extension= ".xlsx",nombreArchivo="Archivos excel"},
            };

            cmbArchivos.DataSource = lArchivo;
            cmbArchivos.DisplayMember = "nombreArchivo";
            cmbArchivos.ValueMember = "extension";
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            //seleccionar un directorio y mostrarlo en ventana
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog().Equals(DialogResult.OK))
            {
                txbRuta.Text = fbd.SelectedPath;

            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txbRuta.Text.Equals(""))
            {
                errorDatos.SetError(txbRuta, "Tiene que ingresar una ruta");
                return;
            }
            else
            {
                errorDatos.SetError(txbRuta, "");
            }

            string rutaDirectorio = txbRuta.Text;
            string extension = cmbArchivos.SelectedValue.ToString();
            lblListas.DataSource = Directory.GetFiles(rutaDirectorio, "*" + extension);


        }
        private void MostrarArchivo(object sender, EventArgs e)
        {
            if (lblListas.Items.Count > 0)
            {
                string selectedFilePath = lblListas.SelectedItem.ToString();
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = selectedFilePath,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
        }
    }
}