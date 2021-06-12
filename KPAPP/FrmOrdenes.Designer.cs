
namespace KPAPP
{
    partial class FrmOrdenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenes));
            this.TabGral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkfilt = new System.Windows.Forms.CheckBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TXTIDFAB = new System.Windows.Forms.TextBox();
            this.DgvListado2 = new System.Windows.Forms.DataGridView();
            this.txtidgenerado = new System.Windows.Forms.TextBox();
            this.btnasociar = new System.Windows.Forms.Button();
            this.BtnCreaOrden = new System.Windows.Forms.Button();
            this.lblobservacion = new System.Windows.Forms.Label();
            this.USUARIO = new System.Windows.Forms.Label();
            this.lblfabricacion = new System.Windows.Forms.Label();
            this.lblnroorden = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.CmbUsuario = new System.Windows.Forms.ComboBox();
            this.CmbFabric = new System.Windows.Forms.ComboBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.txtnroorden = new System.Windows.Forms.TextBox();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkcomp = new System.Windows.Forms.CheckBox();
            this.TabGral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // TabGral
            // 
            this.TabGral.Controls.Add(this.tabPage1);
            this.TabGral.Controls.Add(this.tabPage2);
            this.TabGral.Location = new System.Drawing.Point(18, 20);
            this.TabGral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabGral.Name = "TabGral";
            this.TabGral.SelectedIndex = 0;
            this.TabGral.Size = new System.Drawing.Size(1617, 660);
            this.TabGral.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkcomp);
            this.tabPage1.Controls.Add(this.chkfilt);
            this.tabPage1.Controls.Add(this.btnActualizar);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1609, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkfilt
            // 
            this.chkfilt.AutoSize = true;
            this.chkfilt.Location = new System.Drawing.Point(568, 34);
            this.chkfilt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkfilt.Name = "chkfilt";
            this.chkfilt.Size = new System.Drawing.Size(199, 24);
            this.chkfilt.TabIndex = 22;
            this.chkfilt.Text = "Filtrar Cargas Erroneas";
            this.chkfilt.UseVisualStyleBackColor = true;
            this.chkfilt.CheckedChanged += new System.EventHandler(this.chkfilt_CheckedChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(10, 569);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(129, 38);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "Actualizar ";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(404, 28);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(112, 35);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(10, 28);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(356, 26);
            this.TxtBuscar.TabIndex = 1;
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvListado.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListado.Location = new System.Drawing.Point(10, 88);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 62;
            this.DgvListado.Size = new System.Drawing.Size(1576, 472);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 8;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 98;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TXTIDFAB);
            this.tabPage2.Controls.Add(this.DgvListado2);
            this.tabPage2.Controls.Add(this.txtidgenerado);
            this.tabPage2.Controls.Add(this.btnasociar);
            this.tabPage2.Controls.Add(this.BtnCreaOrden);
            this.tabPage2.Controls.Add(this.lblobservacion);
            this.tabPage2.Controls.Add(this.USUARIO);
            this.tabPage2.Controls.Add(this.lblfabricacion);
            this.tabPage2.Controls.Add(this.lblnroorden);
            this.tabPage2.Controls.Add(this.lblfecha);
            this.tabPage2.Controls.Add(this.txtobs);
            this.tabPage2.Controls.Add(this.CmbUsuario);
            this.tabPage2.Controls.Add(this.CmbFabric);
            this.tabPage2.Controls.Add(this.dtpfecha);
            this.tabPage2.Controls.Add(this.txtnroorden);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1609, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Administracion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TXTIDFAB
            // 
            this.TXTIDFAB.Location = new System.Drawing.Point(692, 168);
            this.TXTIDFAB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTIDFAB.Name = "TXTIDFAB";
            this.TXTIDFAB.Size = new System.Drawing.Size(148, 26);
            this.TXTIDFAB.TabIndex = 32;
            this.TXTIDFAB.Visible = false;
            // 
            // DgvListado2
            // 
            this.DgvListado2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListado2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado2.Location = new System.Drawing.Point(66, 262);
            this.DgvListado2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvListado2.Name = "DgvListado2";
            this.DgvListado2.RowHeadersWidth = 62;
            this.DgvListado2.Size = new System.Drawing.Size(1276, 357);
            this.DgvListado2.TabIndex = 30;
            this.DgvListado2.Visible = false;
            // 
            // txtidgenerado
            // 
            this.txtidgenerado.Location = new System.Drawing.Point(478, 120);
            this.txtidgenerado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtidgenerado.Name = "txtidgenerado";
            this.txtidgenerado.Size = new System.Drawing.Size(148, 26);
            this.txtidgenerado.TabIndex = 29;
            this.txtidgenerado.Visible = false;
            // 
            // btnasociar
            // 
            this.btnasociar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnasociar.Image = ((System.Drawing.Image)(resources.GetObject("btnasociar.Image")));
            this.btnasociar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnasociar.Location = new System.Drawing.Point(1118, 202);
            this.btnasociar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnasociar.Name = "btnasociar";
            this.btnasociar.Size = new System.Drawing.Size(225, 51);
            this.btnasociar.TabIndex = 28;
            this.btnasociar.Text = "ASOCIAR TASKS";
            this.btnasociar.UseVisualStyleBackColor = false;
            this.btnasociar.Click += new System.EventHandler(this.btnasociar_Click);
            // 
            // BtnCreaOrden
            // 
            this.BtnCreaOrden.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCreaOrden.Image = ((System.Drawing.Image)(resources.GetObject("BtnCreaOrden.Image")));
            this.BtnCreaOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCreaOrden.Location = new System.Drawing.Point(864, 202);
            this.BtnCreaOrden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCreaOrden.Name = "BtnCreaOrden";
            this.BtnCreaOrden.Size = new System.Drawing.Size(225, 51);
            this.BtnCreaOrden.TabIndex = 26;
            this.BtnCreaOrden.Text = "CREAR ORDEN";
            this.BtnCreaOrden.UseVisualStyleBackColor = false;
            this.BtnCreaOrden.Click += new System.EventHandler(this.BtnCreaOrden_Click);
            // 
            // lblobservacion
            // 
            this.lblobservacion.AutoSize = true;
            this.lblobservacion.Location = new System.Drawing.Point(708, 83);
            this.lblobservacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblobservacion.Name = "lblobservacion";
            this.lblobservacion.Size = new System.Drawing.Size(149, 20);
            this.lblobservacion.TabIndex = 25;
            this.lblobservacion.Text = "OBSERVACIONES";
            // 
            // USUARIO
            // 
            this.USUARIO.AutoSize = true;
            this.USUARIO.Location = new System.Drawing.Point(84, 83);
            this.USUARIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.Size = new System.Drawing.Size(84, 20);
            this.USUARIO.TabIndex = 24;
            this.USUARIO.Text = "USUARIO";
            // 
            // lblfabricacion
            // 
            this.lblfabricacion.AutoSize = true;
            this.lblfabricacion.Location = new System.Drawing.Point(669, 28);
            this.lblfabricacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfabricacion.Name = "lblfabricacion";
            this.lblfabricacion.Size = new System.Drawing.Size(186, 20);
            this.lblfabricacion.TabIndex = 23;
            this.lblfabricacion.Text = "TIPO DE FABRICACION";
            // 
            // lblnroorden
            // 
            this.lblnroorden.AutoSize = true;
            this.lblnroorden.Location = new System.Drawing.Point(333, 29);
            this.lblnroorden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnroorden.Name = "lblnroorden";
            this.lblnroorden.Size = new System.Drawing.Size(133, 20);
            this.lblnroorden.TabIndex = 22;
            this.lblnroorden.Text = "NRO DE ORDEN";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(105, 28);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(64, 20);
            this.lblfecha.TabIndex = 21;
            this.lblfecha.Text = "FECHA";
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(864, 78);
            this.txtobs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(476, 118);
            this.txtobs.TabIndex = 20;
            // 
            // CmbUsuario
            // 
            this.CmbUsuario.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.CmbUsuario.FormattingEnabled = true;
            this.CmbUsuario.Location = new System.Drawing.Point(177, 78);
            this.CmbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbUsuario.Name = "CmbUsuario";
            this.CmbUsuario.Size = new System.Drawing.Size(450, 28);
            this.CmbUsuario.TabIndex = 19;
            // 
            // CmbFabric
            // 
            this.CmbFabric.BackColor = System.Drawing.Color.LightBlue;
            this.CmbFabric.FormattingEnabled = true;
            this.CmbFabric.Location = new System.Drawing.Point(864, 17);
            this.CmbFabric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbFabric.Name = "CmbFabric";
            this.CmbFabric.Size = new System.Drawing.Size(476, 28);
            this.CmbFabric.TabIndex = 18;
            this.CmbFabric.SelectedIndexChanged += new System.EventHandler(this.CmbFabric_SelectedIndexChanged);
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(177, 18);
            this.dtpfecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(145, 26);
            this.dtpfecha.TabIndex = 17;
            // 
            // txtnroorden
            // 
            this.txtnroorden.Location = new System.Drawing.Point(478, 18);
            this.txtnroorden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnroorden.Name = "txtnroorden";
            this.txtnroorden.Size = new System.Drawing.Size(148, 26);
            this.txtnroorden.TabIndex = 16;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // chkcomp
            // 
            this.chkcomp.AutoSize = true;
            this.chkcomp.Location = new System.Drawing.Point(840, 34);
            this.chkcomp.Name = "chkcomp";
            this.chkcomp.Size = new System.Drawing.Size(259, 24);
            this.chkcomp.TabIndex = 23;
            this.chkcomp.Text = "Mostrar Solo Ordenes Cerradas";
            this.chkcomp.UseVisualStyleBackColor = true;
            this.chkcomp.CheckedChanged += new System.EventHandler(this.chkcomp_CheckedChanged);
            // 
            // FrmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1648, 698);
            this.Controls.Add(this.TabGral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOrdenes";
            this.Text = "Administracion de Ordenes de Trabajo";
            this.Load += new System.EventHandler(this.FrmOrdenes_Load);
            this.TabGral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabGral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button btnasociar;
        private System.Windows.Forms.Button BtnCreaOrden;
        private System.Windows.Forms.Label lblobservacion;
        private System.Windows.Forms.Label USUARIO;
        private System.Windows.Forms.Label lblfabricacion;
        private System.Windows.Forms.Label lblnroorden;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.ComboBox CmbUsuario;
        private System.Windows.Forms.ComboBox CmbFabric;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.TextBox txtnroorden;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TextBox txtidgenerado;
        private System.Windows.Forms.DataGridView DgvListado2;
        private System.Windows.Forms.TextBox TXTIDFAB;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.CheckBox chkfilt;
        private System.Windows.Forms.CheckBox chkcomp;
    }
}