
namespace KPAPP
{
    partial class FrmNuevaTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaTarea));
            this.dgvtarea = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbfabric = new System.Windows.Forms.ComboBox();
            this.lblfabric = new System.Windows.Forms.Label();
            this.txtorden = new System.Windows.Forms.TextBox();
            this.lblorden = new System.Windows.Forms.Label();
            this.lbldescrip = new System.Windows.Forms.Label();
            this.txtdescrip = new System.Windows.Forms.TextBox();
            this.gbnuevatarea = new System.Windows.Forms.GroupBox();
            this.lblobs = new System.Windows.Forms.Label();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.cmbbuscar = new System.Windows.Forms.ComboBox();
            this.lblaviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtarea)).BeginInit();
            this.gbnuevatarea.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvtarea
            // 
            this.dgvtarea.AllowUserToAddRows = false;
            this.dgvtarea.AllowUserToDeleteRows = false;
            this.dgvtarea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvtarea.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvtarea.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvtarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtarea.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvtarea.Location = new System.Drawing.Point(12, 178);
            this.dgvtarea.Name = "dgvtarea";
            this.dgvtarea.ReadOnly = true;
            this.dgvtarea.Size = new System.Drawing.Size(776, 260);
            this.dgvtarea.TabIndex = 0;
            this.dgvtarea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtarea_CellContentClick);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 91);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nueva Tarea";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbfabric
            // 
            this.cmbfabric.FormattingEnabled = true;
            this.cmbfabric.Location = new System.Drawing.Point(113, 19);
            this.cmbfabric.Name = "cmbfabric";
            this.cmbfabric.Size = new System.Drawing.Size(303, 21);
            this.cmbfabric.TabIndex = 2;
            // 
            // lblfabric
            // 
            this.lblfabric.AutoSize = true;
            this.lblfabric.Location = new System.Drawing.Point(6, 22);
            this.lblfabric.Name = "lblfabric";
            this.lblfabric.Size = new System.Drawing.Size(101, 13);
            this.lblfabric.TabIndex = 3;
            this.lblfabric.Text = "Tipo de fabricación:";
            // 
            // txtorden
            // 
            this.txtorden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtorden.Location = new System.Drawing.Point(113, 46);
            this.txtorden.Name = "txtorden";
            this.txtorden.Size = new System.Drawing.Size(79, 20);
            this.txtorden.TabIndex = 4;
            // 
            // lblorden
            // 
            this.lblorden.AutoSize = true;
            this.lblorden.Location = new System.Drawing.Point(22, 49);
            this.lblorden.Name = "lblorden";
            this.lblorden.Size = new System.Drawing.Size(85, 13);
            this.lblorden.TabIndex = 5;
            this.lblorden.Text = "Orden de Tarea:";
            // 
            // lbldescrip
            // 
            this.lbldescrip.AutoSize = true;
            this.lbldescrip.Location = new System.Drawing.Point(41, 78);
            this.lbldescrip.Name = "lbldescrip";
            this.lbldescrip.Size = new System.Drawing.Size(66, 13);
            this.lbldescrip.TabIndex = 7;
            this.lbldescrip.Text = "Descripción:";
            // 
            // txtdescrip
            // 
            this.txtdescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescrip.Location = new System.Drawing.Point(113, 75);
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Size = new System.Drawing.Size(303, 20);
            this.txtdescrip.TabIndex = 6;
            // 
            // gbnuevatarea
            // 
            this.gbnuevatarea.Controls.Add(this.lblobs);
            this.gbnuevatarea.Controls.Add(this.txtobs);
            this.gbnuevatarea.Controls.Add(this.btncancelar);
            this.gbnuevatarea.Controls.Add(this.btnaceptar);
            this.gbnuevatarea.Controls.Add(this.cmbfabric);
            this.gbnuevatarea.Controls.Add(this.lbldescrip);
            this.gbnuevatarea.Controls.Add(this.lblfabric);
            this.gbnuevatarea.Controls.Add(this.txtdescrip);
            this.gbnuevatarea.Controls.Add(this.txtorden);
            this.gbnuevatarea.Controls.Add(this.lblorden);
            this.gbnuevatarea.Location = new System.Drawing.Point(361, 3);
            this.gbnuevatarea.Name = "gbnuevatarea";
            this.gbnuevatarea.Size = new System.Drawing.Size(427, 169);
            this.gbnuevatarea.TabIndex = 8;
            this.gbnuevatarea.TabStop = false;
            this.gbnuevatarea.Text = "Ingrese los datos para la nueva Tarea";
            this.gbnuevatarea.Visible = false;
            // 
            // lblobs
            // 
            this.lblobs.AutoSize = true;
            this.lblobs.Location = new System.Drawing.Point(26, 104);
            this.lblobs.Name = "lblobs";
            this.lblobs.Size = new System.Drawing.Size(81, 13);
            this.lblobs.TabIndex = 11;
            this.lblobs.Text = "Observaciones:";
            // 
            // txtobs
            // 
            this.txtobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtobs.Location = new System.Drawing.Point(113, 101);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(132, 62);
            this.txtobs.TabIndex = 10;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(341, 101);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 62);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnaceptar.Location = new System.Drawing.Point(251, 101);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 62);
            this.btnaceptar.TabIndex = 8;
            this.btnaceptar.Text = "Crear Tarea";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // cmbbuscar
            // 
            this.cmbbuscar.FormattingEnabled = true;
            this.cmbbuscar.Location = new System.Drawing.Point(12, 151);
            this.cmbbuscar.Name = "cmbbuscar";
            this.cmbbuscar.Size = new System.Drawing.Size(302, 21);
            this.cmbbuscar.TabIndex = 12;
            this.cmbbuscar.SelectedIndexChanged += new System.EventHandler(this.cmbbusca_SelectedIndexChanged);
            // 
            // lblaviso
            // 
            this.lblaviso.AutoSize = true;
            this.lblaviso.Location = new System.Drawing.Point(12, 135);
            this.lblaviso.Name = "lblaviso";
            this.lblaviso.Size = new System.Drawing.Size(257, 13);
            this.lblaviso.TabIndex = 13;
            this.lblaviso.Text = "Si lo desea puede filtrar tareas por tipo de fabricación";
            // 
            // FrmNuevaTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblaviso);
            this.Controls.Add(this.cmbbuscar);
            this.Controls.Add(this.gbnuevatarea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvtarea);
            this.Name = "FrmNuevaTarea";
            this.Text = "FrmNuevaTarea";
            this.Load += new System.EventHandler(this.FrmNuevaTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtarea)).EndInit();
            this.gbnuevatarea.ResumeLayout(false);
            this.gbnuevatarea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtarea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbfabric;
        private System.Windows.Forms.Label lblfabric;
        private System.Windows.Forms.TextBox txtorden;
        private System.Windows.Forms.Label lblorden;
        private System.Windows.Forms.Label lbldescrip;
        private System.Windows.Forms.TextBox txtdescrip;
        private System.Windows.Forms.GroupBox gbnuevatarea;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblobs;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.ComboBox cmbbuscar;
        private System.Windows.Forms.Label lblaviso;
    }
}