namespace Bootcamp_20_10_22
{
    partial class Caso2_LoopsYVectores
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
            this.btnAgr = new System.Windows.Forms.Button();
            this.lbPro = new System.Windows.Forms.ListBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.lbPre = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAgr
            // 
            this.btnAgr.Location = new System.Drawing.Point(237, 211);
            this.btnAgr.Name = "btnAgr";
            this.btnAgr.Size = new System.Drawing.Size(181, 23);
            this.btnAgr.TabIndex = 0;
            this.btnAgr.Text = "Agregar Productos y Precio";
            this.btnAgr.UseVisualStyleBackColor = true;
            this.btnAgr.Click += new System.EventHandler(this.btnAgr_Click);
            // 
            // lbPro
            // 
            this.lbPro.FormattingEnabled = true;
            this.lbPro.Location = new System.Drawing.Point(197, 92);
            this.lbPro.Name = "lbPro";
            this.lbPro.Size = new System.Drawing.Size(120, 95);
            this.lbPro.TabIndex = 1;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(237, 257);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(181, 23);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "Sumar Precios";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // lbPre
            // 
            this.lbPre.FormattingEnabled = true;
            this.lbPre.Location = new System.Drawing.Point(359, 92);
            this.lbPre.Name = "lbPre";
            this.lbPre.Size = new System.Drawing.Size(120, 95);
            this.lbPre.TabIndex = 3;
            // 
            // Caso2_LoopsYVectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPre);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.lbPro);
            this.Controls.Add(this.btnAgr);
            this.Name = "Caso2_LoopsYVectores";
            this.Text = "Caso2_LoopsYVectores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgr;
        private System.Windows.Forms.ListBox lbPro;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.ListBox lbPre;
    }
}