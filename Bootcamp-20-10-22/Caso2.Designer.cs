namespace Bootcamp_20_10_22
{
    partial class Caso2
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
            this.btnIdent = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lvlEdad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIdent
            // 
            this.btnIdent.Location = new System.Drawing.Point(108, 128);
            this.btnIdent.Name = "btnIdent";
            this.btnIdent.Size = new System.Drawing.Size(118, 23);
            this.btnIdent.TabIndex = 0;
            this.btnIdent.Text = "Identificar edad";
            this.btnIdent.UseVisualStyleBackColor = true;
            this.btnIdent.Click += new System.EventHandler(this.btnIdent_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(150, 65);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 1;
            // 
            // lvlEdad
            // 
            this.lvlEdad.AutoSize = true;
            this.lvlEdad.Location = new System.Drawing.Point(61, 68);
            this.lvlEdad.Name = "lvlEdad";
            this.lvlEdad.Size = new System.Drawing.Size(73, 13);
            this.lvlEdad.TabIndex = 2;
            this.lvlEdad.Text = "Ingrese Edad:";
            // 
            // Caso2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 185);
            this.Controls.Add(this.lvlEdad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.btnIdent);
            this.Name = "Caso2";
            this.Text = "Caso2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIdent;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lvlEdad;
    }
}