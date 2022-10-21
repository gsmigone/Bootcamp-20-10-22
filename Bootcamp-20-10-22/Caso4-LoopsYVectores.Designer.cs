namespace Bootcamp_20_10_22
{
    partial class Caso4_LoopsYVectores
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
            this.btnPer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMay = new System.Windows.Forms.Button();
            this.lbPer = new System.Windows.Forms.ListBox();
            this.lbEda = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPer
            // 
            this.btnPer.Location = new System.Drawing.Point(205, 66);
            this.btnPer.Name = "btnPer";
            this.btnPer.Size = new System.Drawing.Size(126, 23);
            this.btnPer.TabIndex = 0;
            this.btnPer.Text = "Agregar Personas";
            this.btnPer.UseVisualStyleBackColor = true;
            this.btnPer.Click += new System.EventHandler(this.btnPer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(419, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Agregar Edades";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnMay
            // 
            this.btnMay.Location = new System.Drawing.Point(321, 262);
            this.btnMay.Name = "btnMay";
            this.btnMay.Size = new System.Drawing.Size(110, 23);
            this.btnMay.TabIndex = 2;
            this.btnMay.Text = "Imprimir Mayores";
            this.btnMay.UseVisualStyleBackColor = true;
            this.btnMay.Click += new System.EventHandler(this.btnMay_Click);
            // 
            // lbPer
            // 
            this.lbPer.FormattingEnabled = true;
            this.lbPer.Location = new System.Drawing.Point(211, 124);
            this.lbPer.Name = "lbPer";
            this.lbPer.Size = new System.Drawing.Size(120, 95);
            this.lbPer.TabIndex = 3;
            // 
            // lbEda
            // 
            this.lbEda.FormattingEnabled = true;
            this.lbEda.Location = new System.Drawing.Point(419, 124);
            this.lbEda.Name = "lbEda";
            this.lbEda.Size = new System.Drawing.Size(120, 95);
            this.lbEda.TabIndex = 4;
            // 
            // Caso4_LoopsYVectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbEda);
            this.Controls.Add(this.lbPer);
            this.Controls.Add(this.btnMay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPer);
            this.Name = "Caso4_LoopsYVectores";
            this.Text = "Caso4_LoopsYVectores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMay;
        private System.Windows.Forms.ListBox lbPer;
        private System.Windows.Forms.ListBox lbEda;
    }
}