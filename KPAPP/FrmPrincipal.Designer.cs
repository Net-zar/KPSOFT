
namespace KPAPP
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuOrdenes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccesos = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasDeProcesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNuevoTipoDeFabricaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNuevasTareasAsociadasAProcesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNuevosProcesosAsociadosAFabricaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOrdenes,
            this.reportesToolStripMenuItem,
            this.altasDeProcesosToolStripMenuItem,
            this.mnuAccesos});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1215, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnuOrdenes
            // 
            this.mnuOrdenes.Name = "mnuOrdenes";
            this.mnuOrdenes.Size = new System.Drawing.Size(119, 20);
            this.mnuOrdenes.Text = "Ordenes de trabajo";
            this.mnuOrdenes.Click += new System.EventHandler(this.ordenesDeTrabajoToolStripMenuItem_Click);
            // 
            // mnuAccesos
            // 
            this.mnuAccesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.mnuAccesos.Name = "mnuAccesos";
            this.mnuAccesos.Size = new System.Drawing.Size(62, 20);
            this.mnuAccesos.Text = "Accesos";
            this.mnuAccesos.Click += new System.EventHandler(this.mnuAccesos_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 534);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1215, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(42, 17);
            this.statusBar.Text = "Estado";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // altasDeProcesosToolStripMenuItem
            // 
            this.altasDeProcesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaNuevoTipoDeFabricaciónToolStripMenuItem,
            this.altaNuevosProcesosAsociadosAFabricaciónToolStripMenuItem,
            this.altaNuevasTareasAsociadasAProcesoToolStripMenuItem});
            this.altasDeProcesosToolStripMenuItem.Name = "altasDeProcesosToolStripMenuItem";
            this.altasDeProcesosToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.altasDeProcesosToolStripMenuItem.Text = "Altas de procesos";
            // 
            // altaNuevoTipoDeFabricaciónToolStripMenuItem
            // 
            this.altaNuevoTipoDeFabricaciónToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.altaNuevoTipoDeFabricaciónToolStripMenuItem.Name = "altaNuevoTipoDeFabricaciónToolStripMenuItem";
            this.altaNuevoTipoDeFabricaciónToolStripMenuItem.Size = new System.Drawing.Size(314, 22);
            this.altaNuevoTipoDeFabricaciónToolStripMenuItem.Text = "Alta nuevo Tipo de Fabricación";
            this.altaNuevoTipoDeFabricaciónToolStripMenuItem.Click += new System.EventHandler(this.altaNuevoTipoDeFabricaciónToolStripMenuItem_Click);
            // 
            // altaNuevasTareasAsociadasAProcesoToolStripMenuItem
            // 
            this.altaNuevasTareasAsociadasAProcesoToolStripMenuItem.Name = "altaNuevasTareasAsociadasAProcesoToolStripMenuItem";
            this.altaNuevasTareasAsociadasAProcesoToolStripMenuItem.Size = new System.Drawing.Size(314, 22);
            this.altaNuevasTareasAsociadasAProcesoToolStripMenuItem.Text = "Alta nuevas Tareas asociadas a Proceso";
            this.altaNuevasTareasAsociadasAProcesoToolStripMenuItem.Click += new System.EventHandler(this.altaNuevasTareasAsociadasAProcesoToolStripMenuItem_Click);
            // 
            // altaNuevosProcesosAsociadosAFabricaciónToolStripMenuItem
            // 
            this.altaNuevosProcesosAsociadosAFabricaciónToolStripMenuItem.Name = "altaNuevosProcesosAsociadosAFabricaciónToolStripMenuItem";
            this.altaNuevosProcesosAsociadosAFabricaciónToolStripMenuItem.Size = new System.Drawing.Size(314, 22);
            this.altaNuevosProcesosAsociadosAFabricaciónToolStripMenuItem.Text = "Alta nuevos Procesos asociados a Fabricación";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1215, 556);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmPrincipal";
            this.Text = "Sistema para el control de procesos de fabricación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mnuOrdenes;
        private System.Windows.Forms.ToolStripMenuItem mnuAccesos;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasDeProcesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNuevoTipoDeFabricaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNuevosProcesosAsociadosAFabricaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNuevasTareasAsociadasAProcesoToolStripMenuItem;
    }
}



