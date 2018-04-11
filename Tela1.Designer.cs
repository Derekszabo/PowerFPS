namespace WindowsFormsApplication1
{
    partial class Tela1
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
            this.Help1 = new System.Windows.Forms.Button();
            this.btnVermelho = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Help1
            // 
            this.Help1.BackColor = System.Drawing.Color.Transparent;
            this.Help1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Help1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.Help1.ForeColor = System.Drawing.Color.Lime;
            this.Help1.Location = new System.Drawing.Point(-4, -1);
            this.Help1.Name = "Help1";
            this.Help1.Size = new System.Drawing.Size(36, 38);
            this.Help1.TabIndex = 10;
            this.Help1.Text = "?";
            this.Help1.UseVisualStyleBackColor = false;
            this.Help1.Click += new System.EventHandler(this.Help1_Click);
            // 
            // btnVermelho
            // 
            this.btnVermelho.BackColor = System.Drawing.Color.Transparent;
            this.btnVermelho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVermelho.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVermelho.ForeColor = System.Drawing.Color.Red;
            this.btnVermelho.Location = new System.Drawing.Point(180, 85);
            this.btnVermelho.Name = "btnVermelho";
            this.btnVermelho.Size = new System.Drawing.Size(165, 30);
            this.btnVermelho.TabIndex = 11;
            this.btnVermelho.Text = "Pilula Azul";
            this.btnVermelho.UseVisualStyleBackColor = false;
            this.btnVermelho.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.Transparent;
            this.btnAzul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAzul.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzul.ForeColor = System.Drawing.Color.Blue;
            this.btnAzul.Location = new System.Drawing.Point(12, 85);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(162, 30);
            this.btnAzul.TabIndex = 12;
            this.btnAzul.Text = "Pilula Vermelha";
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.btnVermelho_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(68, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter in the Matrix";
            // 
            // Tela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.military_camouflage_patterns_t21;
            this.ClientSize = new System.Drawing.Size(357, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnVermelho);
            this.Controls.Add(this.Help1);
            this.Name = "Tela1";
            this.Text = "Enter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tela1_FormClosed);
            this.Load += new System.EventHandler(this.Tela1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Help1;
        private System.Windows.Forms.Button btnVermelho;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Label label1;
    }
}