
namespace KPAPP
{
    partial class FrmControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControl));
            this.txtorden = new System.Windows.Forms.TextBox();
            this.txttarea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtorden
            // 
            this.txtorden.Location = new System.Drawing.Point(88, 30);
            this.txtorden.Name = "txtorden";
            this.txtorden.Size = new System.Drawing.Size(100, 20);
            this.txtorden.TabIndex = 0;
            // 
            // txttarea
            // 
            this.txttarea.Location = new System.Drawing.Point(238, 30);
            this.txttarea.Name = "txttarea";
            this.txttarea.Size = new System.Drawing.Size(100, 20);
            this.txttarea.TabIndex = 1;
            // 
            // FrmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttarea);
            this.Controls.Add(this.txtorden);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmControl";
            this.Text = "Controles de Tarea";
            this.Load += new System.EventHandler(this.FrmControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtorden;
        public System.Windows.Forms.TextBox txttarea;
    }
}