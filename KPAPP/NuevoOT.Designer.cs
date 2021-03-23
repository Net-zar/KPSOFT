
namespace KPAPP
{
    partial class NuevoOT
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
            this.DgvOT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOT)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvOT
            // 
            this.DgvOT.AllowUserToAddRows = false;
            this.DgvOT.AllowUserToDeleteRows = false;
            this.DgvOT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvOT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOT.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvOT.Location = new System.Drawing.Point(12, 191);
            this.DgvOT.Name = "DgvOT";
            this.DgvOT.Size = new System.Drawing.Size(1351, 405);
            this.DgvOT.TabIndex = 0;
            this.DgvOT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NuevoOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 608);
            this.Controls.Add(this.DgvOT);
            this.Name = "NuevoOT";
            this.Text = "NuevoOT";
            this.Load += new System.EventHandler(this.NuevoOT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvOT;
    }
}