namespace Bootcamp_20_10_22
{
    partial class Caso6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.dtpNac = new System.Windows.Forms.DateTimePicker();
            this.bntGua = new System.Windows.Forms.Button();
            this.btnImpA = new System.Windows.Forms.Button();
            this.btnTod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(147, 66);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 3;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(146, 101);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(100, 20);
            this.txtApe.TabIndex = 4;
            // 
            // dtpNac
            // 
            this.dtpNac.Location = new System.Drawing.Point(146, 133);
            this.dtpNac.Name = "dtpNac";
            this.dtpNac.Size = new System.Drawing.Size(200, 20);
            this.dtpNac.TabIndex = 6;
            // 
            // bntGua
            // 
            this.bntGua.Location = new System.Drawing.Point(124, 176);
            this.bntGua.Name = "bntGua";
            this.bntGua.Size = new System.Drawing.Size(138, 23);
            this.bntGua.TabIndex = 7;
            this.bntGua.Text = "Guardar";
            this.bntGua.UseVisualStyleBackColor = true;
            this.bntGua.Click += new System.EventHandler(this.bntGua_Click);
            // 
            // btnImpA
            // 
            this.btnImpA.Location = new System.Drawing.Point(125, 205);
            this.btnImpA.Name = "btnImpA";
            this.btnImpA.Size = new System.Drawing.Size(137, 23);
            this.btnImpA.TabIndex = 8;
            this.btnImpA.Text = "Imprimir nombre completo";
            this.btnImpA.UseVisualStyleBackColor = true;
            this.btnImpA.Click += new System.EventHandler(this.btnImpA_Click);
            // 
            // btnTod
            // 
            this.btnTod.Location = new System.Drawing.Point(125, 234);
            this.btnTod.Name = "btnTod";
            this.btnTod.Size = new System.Drawing.Size(139, 23);
            this.btnTod.TabIndex = 9;
            this.btnTod.Text = "Imprimir todo";
            this.btnTod.UseVisualStyleBackColor = true;
            this.btnTod.Click += new System.EventHandler(this.btnTod_Click);
            // 
            // Caso6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 303);
            this.Controls.Add(this.btnTod);
            this.Controls.Add(this.btnImpA);
            this.Controls.Add(this.bntGua);
            this.Controls.Add(this.dtpNac);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Caso6";
            this.Text = "Caso6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.DateTimePicker dtpNac;
        private System.Windows.Forms.Button bntGua;
        private System.Windows.Forms.Button btnImpA;
        private System.Windows.Forms.Button btnTod;
    }
}