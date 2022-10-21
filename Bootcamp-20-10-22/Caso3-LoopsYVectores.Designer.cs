namespace Bootcamp_20_10_22
{
    partial class Caso3_LoopsYVectores
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
            this.btnOpe = new System.Windows.Forms.Button();
            this.btnSue = new System.Windows.Forms.Button();
            this.lbOpe = new System.Windows.Forms.ListBox();
            this.lbSue = new System.Windows.Forms.ListBox();
            this.btnTot = new System.Windows.Forms.Button();
            this.btnMay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpe
            // 
            this.btnOpe.Location = new System.Drawing.Point(40, 58);
            this.btnOpe.Name = "btnOpe";
            this.btnOpe.Size = new System.Drawing.Size(125, 23);
            this.btnOpe.TabIndex = 0;
            this.btnOpe.Text = "Agregar Operarios";
            this.btnOpe.UseVisualStyleBackColor = true;
            this.btnOpe.Click += new System.EventHandler(this.btnOpe_Click);
            // 
            // btnSue
            // 
            this.btnSue.Location = new System.Drawing.Point(224, 59);
            this.btnSue.Name = "btnSue";
            this.btnSue.Size = new System.Drawing.Size(125, 23);
            this.btnSue.TabIndex = 1;
            this.btnSue.Text = "Agregar Sueldos";
            this.btnSue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSue.UseVisualStyleBackColor = true;
            this.btnSue.Click += new System.EventHandler(this.btnSue_Click);
            // 
            // lbOpe
            // 
            this.lbOpe.FormattingEnabled = true;
            this.lbOpe.Location = new System.Drawing.Point(45, 115);
            this.lbOpe.Name = "lbOpe";
            this.lbOpe.Size = new System.Drawing.Size(120, 95);
            this.lbOpe.TabIndex = 2;
            // 
            // lbSue
            // 
            this.lbSue.FormattingEnabled = true;
            this.lbSue.Location = new System.Drawing.Point(229, 115);
            this.lbSue.Name = "lbSue";
            this.lbSue.Size = new System.Drawing.Size(120, 95);
            this.lbSue.TabIndex = 3;
            // 
            // btnTot
            // 
            this.btnTot.Location = new System.Drawing.Point(40, 269);
            this.btnTot.Name = "btnTot";
            this.btnTot.Size = new System.Drawing.Size(135, 23);
            this.btnTot.TabIndex = 4;
            this.btnTot.Text = "Calcular Total Sueldos";
            this.btnTot.UseVisualStyleBackColor = true;
            this.btnTot.Click += new System.EventHandler(this.btnTot_Click);
            // 
            // btnMay
            // 
            this.btnMay.Location = new System.Drawing.Point(229, 269);
            this.btnMay.Name = "btnMay";
            this.btnMay.Size = new System.Drawing.Size(119, 23);
            this.btnMay.TabIndex = 5;
            this.btnMay.Text = "Operario Mejor Pago";
            this.btnMay.UseVisualStyleBackColor = true;
            this.btnMay.Click += new System.EventHandler(this.btnMay_Click);
            // 
            // Caso3_LoopsYVectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 322);
            this.Controls.Add(this.btnMay);
            this.Controls.Add(this.btnTot);
            this.Controls.Add(this.lbSue);
            this.Controls.Add(this.lbOpe);
            this.Controls.Add(this.btnSue);
            this.Controls.Add(this.btnOpe);
            this.Name = "Caso3_LoopsYVectores";
            this.Text = "Caso3_LoopsYVectores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpe;
        private System.Windows.Forms.Button btnSue;
        private System.Windows.Forms.ListBox lbOpe;
        private System.Windows.Forms.ListBox lbSue;
        private System.Windows.Forms.Button btnTot;
        private System.Windows.Forms.Button btnMay;
    }
}