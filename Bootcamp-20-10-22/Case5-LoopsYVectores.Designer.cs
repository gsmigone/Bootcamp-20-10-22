namespace Bootcamp_20_10_22
{
    partial class Case5_LoopsYVectores
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
            this.btnPro = new System.Windows.Forms.Button();
            this.lbPro = new System.Windows.Forms.ListBox();
            this.lbTemp1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTemp2 = new System.Windows.Forms.ListBox();
            this.lbTemp3 = new System.Windows.Forms.ListBox();
            this.lbTemp4 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMay = new System.Windows.Forms.Button();
            this.btnMed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPro
            // 
            this.btnPro.Location = new System.Drawing.Point(296, 55);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(193, 23);
            this.btnPro.TabIndex = 0;
            this.btnPro.Text = "Agregar Provincias y Temperaturas";
            this.btnPro.UseVisualStyleBackColor = true;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // lbPro
            // 
            this.lbPro.FormattingEnabled = true;
            this.lbPro.Location = new System.Drawing.Point(12, 118);
            this.lbPro.Name = "lbPro";
            this.lbPro.Size = new System.Drawing.Size(120, 95);
            this.lbPro.TabIndex = 1;
            // 
            // lbTemp1
            // 
            this.lbTemp1.FormattingEnabled = true;
            this.lbTemp1.Location = new System.Drawing.Point(172, 118);
            this.lbTemp1.Name = "lbTemp1";
            this.lbTemp1.Size = new System.Drawing.Size(120, 95);
            this.lbTemp1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PROVINCIAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TEMP PROVINCIA 1:";
            // 
            // lbTemp2
            // 
            this.lbTemp2.FormattingEnabled = true;
            this.lbTemp2.Location = new System.Drawing.Point(342, 118);
            this.lbTemp2.Name = "lbTemp2";
            this.lbTemp2.Size = new System.Drawing.Size(120, 95);
            this.lbTemp2.TabIndex = 5;
            // 
            // lbTemp3
            // 
            this.lbTemp3.FormattingEnabled = true;
            this.lbTemp3.Location = new System.Drawing.Point(505, 118);
            this.lbTemp3.Name = "lbTemp3";
            this.lbTemp3.Size = new System.Drawing.Size(120, 95);
            this.lbTemp3.TabIndex = 6;
            // 
            // lbTemp4
            // 
            this.lbTemp4.FormattingEnabled = true;
            this.lbTemp4.Location = new System.Drawing.Point(668, 118);
            this.lbTemp4.Name = "lbTemp4";
            this.lbTemp4.Size = new System.Drawing.Size(120, 95);
            this.lbTemp4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "TEMP PROVINCIA 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "TEMP PROVINCIA 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "TEMP PROVINCIA 4:";
            // 
            // btnMay
            // 
            this.btnMay.Location = new System.Drawing.Point(433, 257);
            this.btnMay.Name = "btnMay";
            this.btnMay.Size = new System.Drawing.Size(159, 23);
            this.btnMay.TabIndex = 11;
            this.btnMay.Text = "Mostrar Mayor Temperatura";
            this.btnMay.UseVisualStyleBackColor = true;
            this.btnMay.Click += new System.EventHandler(this.btnMay_Click);
            // 
            // btnMed
            // 
            this.btnMed.Location = new System.Drawing.Point(200, 257);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(156, 23);
            this.btnMed.TabIndex = 12;
            this.btnMed.Text = "Calcular Temperaturas Media";
            this.btnMed.UseVisualStyleBackColor = true;
            this.btnMed.Click += new System.EventHandler(this.btnMed_Click);
            // 
            // Case5_LoopsYVectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMed);
            this.Controls.Add(this.btnMay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTemp4);
            this.Controls.Add(this.lbTemp3);
            this.Controls.Add(this.lbTemp2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTemp1);
            this.Controls.Add(this.lbPro);
            this.Controls.Add(this.btnPro);
            this.Name = "Case5_LoopsYVectores";
            this.Text = "Case5_LoopsYVectores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.ListBox lbPro;
        private System.Windows.Forms.ListBox lbTemp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbTemp2;
        private System.Windows.Forms.ListBox lbTemp3;
        private System.Windows.Forms.ListBox lbTemp4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMay;
        private System.Windows.Forms.Button btnMed;
    }
}