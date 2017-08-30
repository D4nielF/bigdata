namespace HelloWorld_Build1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_hello = new System.Windows.Forms.Button();
            this.tb_hello = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_hello
            // 
            this.btn_hello.Location = new System.Drawing.Point(87, 85);
            this.btn_hello.Name = "btn_hello";
            this.btn_hello.Size = new System.Drawing.Size(100, 23);
            this.btn_hello.TabIndex = 0;
            this.btn_hello.Text = "show";
            this.btn_hello.UseVisualStyleBackColor = true;
            this.btn_hello.Click += new System.EventHandler(this.btn_hello_Click);
            // 
            // tb_hello
            // 
            this.tb_hello.Location = new System.Drawing.Point(87, 59);
            this.tb_hello.Name = "tb_hello";
            this.tb_hello.Size = new System.Drawing.Size(100, 20);
            this.tb_hello.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 185);
            this.Controls.Add(this.tb_hello);
            this.Controls.Add(this.btn_hello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hello;
        private System.Windows.Forms.TextBox tb_hello;
    }
}

