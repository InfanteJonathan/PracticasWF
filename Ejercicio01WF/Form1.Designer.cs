namespace Ejercicio01WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txbRuta = new TextBox();
            btnRuta = new Button();
            groupBox1 = new GroupBox();
            lblListas = new ListBox();
            btnFiltrar = new Button();
            btnLimpiar = new Button();
            cmbArchivos = new ComboBox();
            errorDatos = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 36);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Ruta Especificada";
            // 
            // txbRuta
            // 
            txbRuta.Location = new Point(132, 32);
            txbRuta.Name = "txbRuta";
            txbRuta.ReadOnly = true;
            txbRuta.Size = new Size(300, 23);
            txbRuta.TabIndex = 1;
            // 
            // btnRuta
            // 
            btnRuta.Location = new Point(453, 32);
            btnRuta.Name = "btnRuta";
            btnRuta.Size = new Size(54, 23);
            btnRuta.TabIndex = 2;
            btnRuta.Text = "...";
            btnRuta.UseVisualStyleBackColor = true;
            btnRuta.Click += btnRuta_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblListas);
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(cmbArchivos);
            groupBox1.Location = new Point(34, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 283);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda de Archivos";
            // 
            // lblListas
            // 
            lblListas.FormattingEnabled = true;
            lblListas.ItemHeight = 15;
            lblListas.Location = new Point(73, 123);
            lblListas.Name = "lblListas";
            lblListas.Size = new Size(336, 139);
            lblListas.TabIndex = 6;
            lblListas.DoubleClick += MostrarArchivo;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(138, 76);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(240, 76);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // cmbArchivos
            // 
            cmbArchivos.FormattingEnabled = true;
            cmbArchivos.Location = new Point(43, 38);
            cmbArchivos.Name = "cmbArchivos";
            cmbArchivos.Size = new Size(373, 23);
            cmbArchivos.TabIndex = 0;
            // 
            // errorDatos
            // 
            errorDatos.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 389);
            Controls.Add(groupBox1);
            Controls.Add(btnRuta);
            Controls.Add(txbRuta);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbRuta;
        private Button btnRuta;
        private GroupBox groupBox1;
        private Button btnFiltrar;
        private Button btnLimpiar;
        private ComboBox cmbArchivos;
        private ListBox lblListas;
        private ErrorProvider errorDatos;
    }
}