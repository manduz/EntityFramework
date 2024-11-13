namespace entitydatakatrarim
{
    partial class Form1
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
            this.TumSiparisler = new System.Windows.Forms.Button();
            this.Ilk5Siparsi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TumSiparisler
            // 
            this.TumSiparisler.Location = new System.Drawing.Point(34, 26);
            this.TumSiparisler.Name = "TumSiparisler";
            this.TumSiparisler.Size = new System.Drawing.Size(75, 52);
            this.TumSiparisler.TabIndex = 0;
            this.TumSiparisler.Text = "Tüm Siparişler";
            this.TumSiparisler.UseVisualStyleBackColor = true;
            this.TumSiparisler.Click += new System.EventHandler(this.TumSiparisler_Click);
            // 
            // Ilk5Siparsi
            // 
            this.Ilk5Siparsi.Location = new System.Drawing.Point(138, 26);
            this.Ilk5Siparsi.Name = "Ilk5Siparsi";
            this.Ilk5Siparsi.Size = new System.Drawing.Size(75, 52);
            this.Ilk5Siparsi.TabIndex = 1;
            this.Ilk5Siparsi.Text = "İlk 5 sipariş";
            this.Ilk5Siparsi.UseVisualStyleBackColor = true;
            this.Ilk5Siparsi.Click += new System.EventHandler(this.Ilk5Siparsi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 199);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Ilk5Siparsi);
            this.Controls.Add(this.TumSiparisler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TumSiparisler;
        private System.Windows.Forms.Button Ilk5Siparsi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

