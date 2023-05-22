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
                new TipoArchivo {extension= ".xlxs",nombreArchivo="Archivos excel"},
            };

            cmbArchivos.DataSource = lArchivo;
            cmbArchivos.DisplayMember = "nombreArchivo";
            cmbArchivos.ValueMember = "extension";
        }

        
    }
}