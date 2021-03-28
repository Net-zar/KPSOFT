
namespace KPAPP
{
    partial class Proceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proceso));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DgvProceso = new System.Windows.Forms.DataGridView();
            this.txtidseleccionado = new System.Windows.Forms.TextBox();
            this.txtnrofabricacion = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dtpfechaorden = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.txtusrorden = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnotas = new System.Windows.Forms.TextBox();
            this.txttask = new System.Windows.Forms.TextBox();
            this.lbltask = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttaskcomp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.chkcerrada = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProceso)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProceso
            // 
            this.DgvProceso.AllowUserToAddRows = false;
            this.DgvProceso.AllowUserToDeleteRows = false;
            this.DgvProceso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProceso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvProceso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvProceso.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvProceso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProceso.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvProceso.Location = new System.Drawing.Point(13, 205);
            this.DgvProceso.Name = "DgvProceso";
            this.DgvProceso.ReadOnly = true;
            this.DgvProceso.Size = new System.Drawing.Size(1198, 416);
            this.DgvProceso.TabIndex = 0;
            this.DgvProceso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProceso_CellContentClick);
            this.DgvProceso.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvProceso_CellFormatting);
           
            this.DgvProceso.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProceso_CellMouseLeave);
            this.DgvProceso.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvProceso_CellMouseMove);
            this.DgvProceso.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvProceso_EditingControlShowing);
            // 
            // txtidseleccionado
            // 
            this.txtidseleccionado.Location = new System.Drawing.Point(7, 43);
            this.txtidseleccionado.Name = "txtidseleccionado";
            this.txtidseleccionado.Size = new System.Drawing.Size(56, 20);
            this.txtidseleccionado.TabIndex = 1;
            // 
            // txtnrofabricacion
            // 
            this.txtnrofabricacion.Location = new System.Drawing.Point(257, 43);
            this.txtnrofabricacion.Name = "txtnrofabricacion";
            this.txtnrofabricacion.Size = new System.Drawing.Size(143, 20);
            this.txtnrofabricacion.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(5, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id";
            // 
            // dtpfechaorden
            // 
            this.dtpfechaorden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaorden.Location = new System.Drawing.Point(94, 43);
            this.dtpfechaorden.Name = "dtpfechaorden";
            this.dtpfechaorden.Size = new System.Drawing.Size(143, 20);
            this.dtpfechaorden.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha de Orden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número de Orden";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.ForeColor = System.Drawing.Color.Red;
            this.lbltipo.Location = new System.Drawing.Point(90, 7);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(57, 20);
            this.lbltipo.TabIndex = 9;
            this.lbltipo.Text = "label3";
            // 
            // txtusrorden
            // 
            this.txtusrorden.Location = new System.Drawing.Point(415, 43);
            this.txtusrorden.Name = "txtusrorden";
            this.txtusrorden.Size = new System.Drawing.Size(178, 20);
            this.txtusrorden.TabIndex = 10;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(412, 27);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(43, 13);
            this.lblusuario.TabIndex = 11;
            this.lblusuario.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(848, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Notas";
            // 
            // txtnotas
            // 
            this.txtnotas.Location = new System.Drawing.Point(851, 43);
            this.txtnotas.Multiline = true;
            this.txtnotas.Name = "txtnotas";
            this.txtnotas.Size = new System.Drawing.Size(319, 20);
            this.txtnotas.TabIndex = 13;
            // 
            // txttask
            // 
            this.txttask.Location = new System.Drawing.Point(607, 43);
            this.txttask.Name = "txttask";
            this.txttask.Size = new System.Drawing.Size(100, 20);
            this.txttask.TabIndex = 14;
            // 
            // lbltask
            // 
            this.lbltask.AutoSize = true;
            this.lbltask.Location = new System.Drawing.Point(604, 27);
            this.lbltask.Name = "lbltask";
            this.lbltask.Size = new System.Drawing.Size(92, 13);
            this.lbltask.TabIndex = 15;
            this.lbltask.Text = "Cantidad de tasks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(722, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tasks Completadas";
            // 
            // txttaskcomp
            // 
            this.txttaskcomp.Location = new System.Drawing.Point(725, 43);
            this.txttaskcomp.Name = "txttaskcomp";
            this.txttaskcomp.Size = new System.Drawing.Size(100, 20);
            this.txttaskcomp.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttaskcomp);
            this.groupBox1.Controls.Add(this.lbltask);
            this.groupBox1.Controls.Add(this.txttask);
            this.groupBox1.Controls.Add(this.txtnotas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblusuario);
            this.groupBox1.Controls.Add(this.txtusrorden);
            this.groupBox1.Controls.Add(this.lbltipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpfechaorden);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtnrofabricacion);
            this.groupBox1.Controls.Add(this.txtidseleccionado);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1192, 85);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Orden";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(14, 174);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 25);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar Tarea";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // chart
            // 
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(731, 98);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Color = System.Drawing.Color.White;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Tareas";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.ShadowOffset = 3;
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(445, 78);
            this.chart.TabIndex = 25;
            this.chart.Text = "chart1";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.Location = new System.Drawing.Point(14, 98);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(112, 58);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.Text = "CERRAR ORDEN";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // chkcerrada
            // 
            this.chkcerrada.AutoSize = true;
            this.chkcerrada.Location = new System.Drawing.Point(14, 138);
            this.chkcerrada.Name = "chkcerrada";
            this.chkcerrada.Size = new System.Drawing.Size(95, 17);
            this.chkcerrada.TabIndex = 28;
            this.chkcerrada.Text = "Orden Cerrada";
            this.chkcerrada.UseVisualStyleBackColor = true;
            // 
            // Proceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1223, 633);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvProceso);
            this.Controls.Add(this.chkcerrada);
            this.Name = "Proceso";
            this.Text = "Proceso";
            this.Load += new System.EventHandler(this.Proceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProceso)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProceso;
        public System.Windows.Forms.TextBox txtidseleccionado;
        private System.Windows.Forms.Label lblId;
        public System.Windows.Forms.DateTimePicker dtpfechaorden;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtnrofabricacion;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblusuario;
        public System.Windows.Forms.TextBox txtusrorden;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtnotas;
        private System.Windows.Forms.Label lbltask;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txttask;
        public System.Windows.Forms.TextBox txttaskcomp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.CheckBox chkcerrada;
    }
}