
namespace KPAPP
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFabricacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaFabricacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procedimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProcedimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProcedimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Btncreaproceso = new System.Windows.Forms.Button();
            this.BtnNuevaOT = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlToolStripMenuItem,
            this.procedimientosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verFabricacionesToolStripMenuItem,
            this.nuevaFabricacionToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // verFabricacionesToolStripMenuItem
            // 
            this.verFabricacionesToolStripMenuItem.Name = "verFabricacionesToolStripMenuItem";
            this.verFabricacionesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.verFabricacionesToolStripMenuItem.Text = "Ver Fabricaciones";
            this.verFabricacionesToolStripMenuItem.Click += new System.EventHandler(this.verFabricacionesToolStripMenuItem_Click);
            // 
            // nuevaFabricacionToolStripMenuItem
            // 
            this.nuevaFabricacionToolStripMenuItem.Name = "nuevaFabricacionToolStripMenuItem";
            this.nuevaFabricacionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.nuevaFabricacionToolStripMenuItem.Text = "Nueva &Fabricacion";
            this.nuevaFabricacionToolStripMenuItem.Click += new System.EventHandler(this.nuevaFabricacionToolStripMenuItem_Click);
            // 
            // procedimientosToolStripMenuItem
            // 
            this.procedimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProcedimientosToolStripMenuItem,
            this.nuevoProcedimientoToolStripMenuItem});
            this.procedimientosToolStripMenuItem.Name = "procedimientosToolStripMenuItem";
            this.procedimientosToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.procedimientosToolStripMenuItem.Text = "Procedimientos";
            // 
            // verProcedimientosToolStripMenuItem
            // 
            this.verProcedimientosToolStripMenuItem.Name = "verProcedimientosToolStripMenuItem";
            this.verProcedimientosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.verProcedimientosToolStripMenuItem.Text = "Ver procedimientos";
            // 
            // nuevoProcedimientoToolStripMenuItem
            // 
            this.nuevoProcedimientoToolStripMenuItem.Name = "nuevoProcedimientoToolStripMenuItem";
            this.nuevoProcedimientoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.nuevoProcedimientoToolStripMenuItem.Text = "Nuevo procedimiento";
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1055, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 541);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1055, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // Btncreaproceso
            // 
            this.Btncreaproceso.Image = ((System.Drawing.Image)(resources.GetObject("Btncreaproceso.Image")));
            this.Btncreaproceso.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btncreaproceso.Location = new System.Drawing.Point(12, 24);
            this.Btncreaproceso.Name = "Btncreaproceso";
            this.Btncreaproceso.Size = new System.Drawing.Size(134, 25);
            this.Btncreaproceso.TabIndex = 4;
            this.Btncreaproceso.Text = "Generar Tasks";
            this.Btncreaproceso.UseVisualStyleBackColor = true;
            this.Btncreaproceso.Click += new System.EventHandler(this.BtnNuevaFabricacion_Click);
            // 
            // BtnNuevaOT
            // 
            this.BtnNuevaOT.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevaOT.Image")));
            this.BtnNuevaOT.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnNuevaOT.Location = new System.Drawing.Point(168, 24);
            this.BtnNuevaOT.Name = "BtnNuevaOT";
            this.BtnNuevaOT.Size = new System.Drawing.Size(134, 25);
            this.BtnNuevaOT.TabIndex = 6;
            this.BtnNuevaOT.Text = "Nueva OT";
            this.BtnNuevaOT.UseVisualStyleBackColor = true;
            this.BtnNuevaOT.Click += new System.EventHandler(this.BtnNuevaOT_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 563);
            this.Controls.Add(this.BtnNuevaOT);
            this.Controls.Add(this.Btncreaproceso);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de control de Procesos ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFabricacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaFabricacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procedimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProcedimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProcedimientoToolStripMenuItem;
        private System.Windows.Forms.Button Btncreaproceso;
        private System.Windows.Forms.Button BtnNuevaOT;
    }
}



