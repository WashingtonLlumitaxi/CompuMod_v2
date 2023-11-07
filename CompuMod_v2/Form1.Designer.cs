
namespace CompuMod_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ptbPixel = new System.Windows.Forms.PictureBox();
            this.btnEncender = new System.Windows.Forms.Button();
            this.btnDegradado = new System.Windows.Forms.Button();
            this.btnLetra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPixel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(251, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPUTACIÓN CIENTÍFICA";
            // 
            // ptbPixel
            // 
            this.ptbPixel.BackColor = System.Drawing.Color.White;
            this.ptbPixel.Location = new System.Drawing.Point(51, 45);
            this.ptbPixel.Name = "ptbPixel";
            this.ptbPixel.Size = new System.Drawing.Size(600, 500);
            this.ptbPixel.TabIndex = 1;
            this.ptbPixel.TabStop = false;
            // 
            // btnEncender
            // 
            this.btnEncender.Location = new System.Drawing.Point(1, 561);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(75, 23);
            this.btnEncender.TabIndex = 2;
            this.btnEncender.Text = "Encender";
            this.btnEncender.UseVisualStyleBackColor = true;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // btnDegradado
            // 
            this.btnDegradado.Location = new System.Drawing.Point(163, 561);
            this.btnDegradado.Name = "btnDegradado";
            this.btnDegradado.Size = new System.Drawing.Size(75, 23);
            this.btnDegradado.TabIndex = 3;
            this.btnDegradado.Text = "Degradado";
            this.btnDegradado.UseVisualStyleBackColor = true;
            this.btnDegradado.Click += new System.EventHandler(this.btnDegradado_Click);
            // 
            // btnLetra
            // 
            this.btnLetra.Location = new System.Drawing.Point(82, 561);
            this.btnLetra.Name = "btnLetra";
            this.btnLetra.Size = new System.Drawing.Size(75, 23);
            this.btnLetra.TabIndex = 4;
            this.btnLetra.Text = "Letra";
            this.btnLetra.UseVisualStyleBackColor = true;
            this.btnLetra.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(718, 655);
            this.Controls.Add(this.btnLetra);
            this.Controls.Add(this.btnDegradado);
            this.Controls.Add(this.btnEncender);
            this.Controls.Add(this.ptbPixel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbPixel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbPixel;
        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Button btnDegradado;
        private System.Windows.Forms.Button btnLetra;
    }
}

