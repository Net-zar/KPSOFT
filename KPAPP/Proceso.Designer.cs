
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
            this.CmbControl1 = new System.Windows.Forms.ComboBox();
            this.lblcontrol1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProceso)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvProceso
            // 
            this.DgvProceso.AllowUserToAddRows = false;
            this.DgvProceso.AllowUserToDeleteRows = false;
            this.DgvProceso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProceso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvProceso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProceso.Location = new System.Drawing.Point(13, 205);
            this.DgvProceso.Name = "DgvProceso";
            this.DgvProceso.Size = new System.Drawing.Size(1198, 379);
            this.DgvProceso.TabIndex = 0;
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.lblusuario.Click += new System.EventHandler(this.label3_Click);
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
            this.txttask.TextChanged += new System.EventHandler(this.txttask_TextChanged);
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
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            // CmbControl1
            // 
            this.CmbControl1.FormattingEnabled = true;
            this.CmbControl1.Location = new System.Drawing.Point(14, 129);
            this.CmbControl1.Name = "CmbControl1";
            this.CmbControl1.Size = new System.Drawing.Size(229, 21);
            this.CmbControl1.TabIndex = 19;
            // 
            // lblcontrol1
            // 
            this.lblcontrol1.AutoSize = true;
            this.lblcontrol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontrol1.Location = new System.Drawing.Point(14, 110);
            this.lblcontrol1.Name = "lblcontrol1";
            this.lblcontrol1.Size = new System.Drawing.Size(91, 13);
            this.lblcontrol1.TabIndex = 20;
            this.lblcontrol1.Text = "Control Nivel 1";
            // 
            // Proceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 596);
            this.Controls.Add(this.lblcontrol1);
            this.Controls.Add(this.CmbControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvProceso);
            this.Name = "Proceso";
            this.Text = "Proceso";
            this.Load += new System.EventHandler(this.Proceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProceso)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox CmbControl1;
        private System.Windows.Forms.Label lblcontrol1;
    }
}