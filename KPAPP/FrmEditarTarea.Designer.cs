
namespace KPAPP
{
    partial class FrmEditarTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarTarea));
            this.txtidtarea = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtorden = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.txtfabric = new System.Windows.Forms.TextBox();
            this.txtfabricacion = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtidtarea
            // 
            this.txtidtarea.Enabled = false;
            this.txtidtarea.Location = new System.Drawing.Point(108, 16);
            this.txtidtarea.Name = "txtidtarea";
            this.txtidtarea.Size = new System.Drawing.Size(100, 20);
            this.txtidtarea.TabIndex = 0;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(52, 19);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(50, 13);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "Id Tarea:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Orden de Tarea:";
            // 
            // txtorden
            // 
            this.txtorden.Location = new System.Drawing.Point(108, 101);
            this.txtorden.Name = "txtorden";
            this.txtorden.Size = new System.Drawing.Size(100, 20);
            this.txtorden.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de Tarea:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(108, 151);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(265, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Observaciones:";
            // 
            // txtobservacion
            // 
            this.txtobservacion.Location = new System.Drawing.Point(108, 201);
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.Size = new System.Drawing.Size(265, 20);
            this.txtobservacion.TabIndex = 6;
            // 
            // txtfabric
            // 
            this.txtfabric.Enabled = false;
            this.txtfabric.Location = new System.Drawing.Point(108, 60);
            this.txtfabric.Name = "txtfabric";
            this.txtfabric.Size = new System.Drawing.Size(265, 20);
            this.txtfabric.TabIndex = 8;
            // 
            // txtfabricacion
            // 
            this.txtfabricacion.AutoSize = true;
            this.txtfabricacion.Location = new System.Drawing.Point(33, 63);
            this.txtfabricacion.Name = "txtfabricacion";
            this.txtfabricacion.Size = new System.Drawing.Size(65, 13);
            this.txtfabricacion.TabIndex = 9;
            this.txtfabricacion.Text = "Fabricación:";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(298, 252);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 62);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneditar.Location = new System.Drawing.Point(108, 252);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 62);
            this.btneditar.TabIndex = 10;
            this.btneditar.Text = "Editar Tarea";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Image = ((System.Drawing.Image)(resources.GetObject("btnborrar.Image")));
            this.btnborrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnborrar.Location = new System.Drawing.Point(202, 252);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 62);
            this.btnborrar.TabIndex = 12;
            this.btnborrar.Text = "Borrar Tarea";
            this.btnborrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // FrmEditarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(431, 350);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.txtfabricacion);
            this.Controls.Add(this.txtfabric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtobservacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtorden);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtidtarea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarTarea";
            this.Text = "Editar Tarea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtidtarea;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtorden;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtobservacion;
        public System.Windows.Forms.TextBox txtfabric;
        private System.Windows.Forms.Label txtfabricacion;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnborrar;
    }
}