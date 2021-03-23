
namespace KPAPP
{
    partial class FrmAsociaTask
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
            this.btnasociar = new System.Windows.Forms.Button();
            this.txtidfabricacion = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.txtcompletada = new System.Windows.Forms.TextBox();
            this.txtidusuario = new System.Windows.Forms.TextBox();
            this.txtnrofabricacion = new System.Windows.Forms.TextBox();
            this.txtfabricacionid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnasociar
            // 
            this.btnasociar.Location = new System.Drawing.Point(263, 282);
            this.btnasociar.Name = "btnasociar";
            this.btnasociar.Size = new System.Drawing.Size(114, 23);
            this.btnasociar.TabIndex = 1;
            this.btnasociar.Text = "Asociar Tasks";
            this.btnasociar.UseVisualStyleBackColor = true;
            // 
            // txtidfabricacion
            // 
            this.txtidfabricacion.Location = new System.Drawing.Point(12, 22);
            this.txtidfabricacion.Name = "txtidfabricacion";
            this.txtidfabricacion.Size = new System.Drawing.Size(232, 20);
            this.txtidfabricacion.TabIndex = 2;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(12, 62);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(232, 20);
            this.txtfecha.TabIndex = 3;
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(12, 102);
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(232, 20);
            this.txtobs.TabIndex = 4;
            // 
            // txtcompletada
            // 
            this.txtcompletada.Location = new System.Drawing.Point(12, 137);
            this.txtcompletada.Name = "txtcompletada";
            this.txtcompletada.Size = new System.Drawing.Size(232, 20);
            this.txtcompletada.TabIndex = 5;
            // 
            // txtidusuario
            // 
            this.txtidusuario.Location = new System.Drawing.Point(12, 175);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(232, 20);
            this.txtidusuario.TabIndex = 6;
            // 
            // txtnrofabricacion
            // 
            this.txtnrofabricacion.Location = new System.Drawing.Point(12, 210);
            this.txtnrofabricacion.Name = "txtnrofabricacion";
            this.txtnrofabricacion.Size = new System.Drawing.Size(232, 20);
            this.txtnrofabricacion.TabIndex = 7;
            // 
            // txtfabricacionid
            // 
            this.txtfabricacionid.Location = new System.Drawing.Point(12, 246);
            this.txtfabricacionid.Name = "txtfabricacionid";
            this.txtfabricacionid.Size = new System.Drawing.Size(232, 20);
            this.txtfabricacionid.TabIndex = 8;
            this.txtfabricacionid.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // FrmAsociaTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 317);
            this.Controls.Add(this.txtfabricacionid);
            this.Controls.Add(this.txtnrofabricacion);
            this.Controls.Add(this.txtidusuario);
            this.Controls.Add(this.txtcompletada);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtidfabricacion);
            this.Controls.Add(this.btnasociar);
            this.Name = "FrmAsociaTask";
            this.Text = "FrmAsociaTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnasociar;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.TextBox txtcompletada;
        private System.Windows.Forms.TextBox txtidusuario;
        private System.Windows.Forms.TextBox txtnrofabricacion;
        private System.Windows.Forms.TextBox txtfabricacionid;
        public System.Windows.Forms.TextBox txtidfabricacion;
    }
}