namespace WindowsFormsApp7
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GestionLibrosTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaLibrosTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarLibroPorTítuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionUsuariosTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unloginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarTituloGB = new System.Windows.Forms.GroupBox();
            this.btnSalirBuscar = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.BuscarTituloDGV = new System.Windows.Forms.DataGridView();
            this.GestionLibrosGB = new System.Windows.Forms.GroupBox();
            this.btnSalirGestion = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.GestionLibrosDGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.BuscarTituloGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarTituloDGV)).BeginInit();
            this.GestionLibrosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GestionLibrosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GestionLibrosTSM,
            this.ConsultaLibrosTSM,
            this.GestionUsuariosTSM,
            this.unloginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GestionLibrosTSM
            // 
            this.GestionLibrosTSM.Name = "GestionLibrosTSM";
            this.GestionLibrosTSM.Size = new System.Drawing.Size(110, 20);
            this.GestionLibrosTSM.Text = "Gestión de Libros";
            this.GestionLibrosTSM.Click += new System.EventHandler(this.GestionLibrosTSM_Click);
            // 
            // ConsultaLibrosTSM
            // 
            this.ConsultaLibrosTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarLibroPorTítuloToolStripMenuItem});
            this.ConsultaLibrosTSM.Name = "ConsultaLibrosTSM";
            this.ConsultaLibrosTSM.Size = new System.Drawing.Size(117, 20);
            this.ConsultaLibrosTSM.Text = "Consulta de Libros";
            // 
            // buscarLibroPorTítuloToolStripMenuItem
            // 
            this.buscarLibroPorTítuloToolStripMenuItem.Name = "buscarLibroPorTítuloToolStripMenuItem";
            this.buscarLibroPorTítuloToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.buscarLibroPorTítuloToolStripMenuItem.Text = "Buscar libro";
            this.buscarLibroPorTítuloToolStripMenuItem.Click += new System.EventHandler(this.buscarLibroPorTítuloToolStripMenuItem_Click);
            this.buscarLibroPorTítuloToolStripMenuItem.DoubleClick += new System.EventHandler(this.buscarLibroPorTítuloToolStripMenuItem_DoubleClick);
            // 
            // GestionUsuariosTSM
            // 
            this.GestionUsuariosTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.editarUsuarioToolStripMenuItem});
            this.GestionUsuariosTSM.Name = "GestionUsuariosTSM";
            this.GestionUsuariosTSM.Size = new System.Drawing.Size(123, 20);
            this.GestionUsuariosTSM.Text = "Gestión de Usuarios";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar usuario";
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar usuario";
            // 
            // editarUsuarioToolStripMenuItem
            // 
            this.editarUsuarioToolStripMenuItem.Name = "editarUsuarioToolStripMenuItem";
            this.editarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.editarUsuarioToolStripMenuItem.Text = "Editar usuario";
            // 
            // unloginToolStripMenuItem
            // 
            this.unloginToolStripMenuItem.Name = "unloginToolStripMenuItem";
            this.unloginToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.unloginToolStripMenuItem.Text = "Unlogin";
            this.unloginToolStripMenuItem.Click += new System.EventHandler(this.unloginToolStripMenuItem_Click);
            // 
            // BuscarTituloGB
            // 
            this.BuscarTituloGB.Controls.Add(this.btnSalirBuscar);
            this.BuscarTituloGB.Controls.Add(this.btnX);
            this.BuscarTituloGB.Controls.Add(this.btnBuscarAutor);
            this.BuscarTituloGB.Controls.Add(this.label2);
            this.BuscarTituloGB.Controls.Add(this.txtBuscarAutor);
            this.BuscarTituloGB.Controls.Add(this.label1);
            this.BuscarTituloGB.Controls.Add(this.txtBuscar);
            this.BuscarTituloGB.Controls.Add(this.btnBuscar);
            this.BuscarTituloGB.Controls.Add(this.BuscarTituloDGV);
            this.BuscarTituloGB.Location = new System.Drawing.Point(430, 59);
            this.BuscarTituloGB.Name = "BuscarTituloGB";
            this.BuscarTituloGB.Size = new System.Drawing.Size(347, 335);
            this.BuscarTituloGB.TabIndex = 3;
            this.BuscarTituloGB.TabStop = false;
            this.BuscarTituloGB.Text = "Buscar libro";
            // 
            // btnSalirBuscar
            // 
            this.btnSalirBuscar.Location = new System.Drawing.Point(266, 303);
            this.btnSalirBuscar.Name = "btnSalirBuscar";
            this.btnSalirBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnSalirBuscar.TabIndex = 5;
            this.btnSalirBuscar.Text = "Salir";
            this.btnSalirBuscar.UseVisualStyleBackColor = true;
            this.btnSalirBuscar.Click += new System.EventHandler(this.btnSalirBuscar_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnX.Location = new System.Drawing.Point(519, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(17, 20);
            this.btnX.TabIndex = 4;
            this.btnX.Text = "x";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.Location = new System.Drawing.Point(252, 52);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAutor.TabIndex = 1;
            this.btnBuscarAutor.Text = "Buscar";
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            this.btnBuscarAutor.Click += new System.EventHandler(this.btnBuscarAutor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar por autor";
            // 
            // txtBuscarAutor
            // 
            this.txtBuscarAutor.Location = new System.Drawing.Point(112, 26);
            this.txtBuscarAutor.Name = "txtBuscarAutor";
            this.txtBuscarAutor.Size = new System.Drawing.Size(215, 20);
            this.txtBuscarAutor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar por titulo";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(112, 92);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(215, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(252, 118);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BuscarTituloDGV
            // 
            this.BuscarTituloDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuscarTituloDGV.Location = new System.Drawing.Point(16, 147);
            this.BuscarTituloDGV.Name = "BuscarTituloDGV";
            this.BuscarTituloDGV.Size = new System.Drawing.Size(311, 150);
            this.BuscarTituloDGV.TabIndex = 0;
            // 
            // GestionLibrosGB
            // 
            this.GestionLibrosGB.Controls.Add(this.btnSalirGestion);
            this.GestionLibrosGB.Controls.Add(this.btnModificar);
            this.GestionLibrosGB.Controls.Add(this.btnBorrar);
            this.GestionLibrosGB.Controls.Add(this.btnAgregar);
            this.GestionLibrosGB.Controls.Add(this.label6);
            this.GestionLibrosGB.Controls.Add(this.label5);
            this.GestionLibrosGB.Controls.Add(this.label4);
            this.GestionLibrosGB.Controls.Add(this.label3);
            this.GestionLibrosGB.Controls.Add(this.txtAutor);
            this.GestionLibrosGB.Controls.Add(this.txtAño);
            this.GestionLibrosGB.Controls.Add(this.txtTitulo);
            this.GestionLibrosGB.Controls.Add(this.txtISBN);
            this.GestionLibrosGB.Controls.Add(this.GestionLibrosDGV);
            this.GestionLibrosGB.Location = new System.Drawing.Point(12, 125);
            this.GestionLibrosGB.Name = "GestionLibrosGB";
            this.GestionLibrosGB.Size = new System.Drawing.Size(384, 285);
            this.GestionLibrosGB.TabIndex = 4;
            this.GestionLibrosGB.TabStop = false;
            this.GestionLibrosGB.Text = "Gestión de libros";
            // 
            // btnSalirGestion
            // 
            this.btnSalirGestion.Location = new System.Drawing.Point(300, 256);
            this.btnSalirGestion.Name = "btnSalirGestion";
            this.btnSalirGestion.Size = new System.Drawing.Size(75, 23);
            this.btnSalirGestion.TabIndex = 12;
            this.btnSalirGestion.Text = "Salir";
            this.btnSalirGestion.UseVisualStyleBackColor = true;
            this.btnSalirGestion.Click += new System.EventHandler(this.btnSalirGestion_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(204, 256);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(98, 256);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 256);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Año de publicación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Título";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(47, 62);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 4;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(275, 62);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 3;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(47, 34);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(275, 30);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 1;
            // 
            // GestionLibrosDGV
            // 
            this.GestionLibrosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GestionLibrosDGV.Location = new System.Drawing.Point(6, 100);
            this.GestionLibrosDGV.Name = "GestionLibrosDGV";
            this.GestionLibrosDGV.Size = new System.Drawing.Size(369, 145);
            this.GestionLibrosDGV.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GestionLibrosGB);
            this.Controls.Add(this.BuscarTituloGB);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema Bibliotecario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.BuscarTituloGB.ResumeLayout(false);
            this.BuscarTituloGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarTituloDGV)).EndInit();
            this.GestionLibrosGB.ResumeLayout(false);
            this.GestionLibrosGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GestionLibrosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GestionLibrosTSM;
        private System.Windows.Forms.ToolStripMenuItem ConsultaLibrosTSM;
        private System.Windows.Forms.ToolStripMenuItem buscarLibroPorTítuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionUsuariosTSM;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unloginToolStripMenuItem;
        private System.Windows.Forms.GroupBox BuscarTituloGB;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView BuscarTituloDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarAutor;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.GroupBox GestionLibrosGB;
        private System.Windows.Forms.DataGridView GestionLibrosDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btnSalirGestion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalirBuscar;
    }
}

