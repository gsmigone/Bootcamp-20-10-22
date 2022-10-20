namespace Bootcamp_20_10_22
{
    partial class Caso1_LoopsYVectores
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
            this.btnAlu = new System.Windows.Forms.Button();
            this.btnNot = new System.Windows.Forms.Button();
            this.lbNot = new System.Windows.Forms.ListBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbAlu = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAlu
            // 
            this.btnAlu.Location = new System.Drawing.Point(85, 58);
            this.btnAlu.Name = "btnAlu";
            this.btnAlu.Size = new System.Drawing.Size(103, 23);
            this.btnAlu.TabIndex = 0;
            this.btnAlu.Text = "Agregar Alumnos";
            this.btnAlu.UseVisualStyleBackColor = true;
            this.btnAlu.Click += new System.EventHandler(this.btnAlu_Click);
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(221, 58);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(89, 23);
            this.btnNot.TabIndex = 1;
            this.btnNot.Text = "Agregar Notas";
            this.btnNot.UseVisualStyleBackColor = true;
            // 
            // lbNot
            // 
            this.lbNot.FormattingEnabled = true;
            this.lbNot.Location = new System.Drawing.Point(221, 96);
            this.lbNot.Name = "lbNot";
            this.lbNot.Size = new System.Drawing.Size(120, 95);
            this.lbNot.TabIndex = 2;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(166, 216);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 3;
            this.btnCal.Text = "Calcular";
            this.btnCal.UseVisualStyleBackColor = true;
            // 
            // lbAlu
            // 
            this.lbAlu.FormattingEnabled = true;
            this.lbAlu.Location = new System.Drawing.Point(68, 96);
            this.lbAlu.Name = "lbAlu";
            this.lbAlu.Size = new System.Drawing.Size(120, 95);
            this.lbAlu.TabIndex = 4;
            // 
            // Caso1_LoopsYVectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 275);
            this.Controls.Add(this.lbAlu);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.lbNot);
            this.Controls.Add(this.btnNot);
            this.Controls.Add(this.btnAlu);
            this.Name = "Caso1_LoopsYVectores";
            this.Text = "Caso1_LoopsYVectores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlu;
        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.ListBox lbNot;
        private System.Windows.Forms.Button btnCal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox lbAlu;
    }
}