namespace ComboBox
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
            comboBoxColores = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // comboBoxColores
            // 
            comboBoxColores.FormattingEnabled = true;
            comboBoxColores.Items.AddRange(new object[] { "Rojo", "Verde", "Azul" });
            comboBoxColores.Location = new Point(109, 41);
            comboBoxColores.Name = "comboBoxColores";
            comboBoxColores.Size = new Size(121, 23);
            comboBoxColores.TabIndex = 0;
            comboBoxColores.Text = "Colores";
            comboBoxColores.SelectedIndexChanged += comboBoxColores_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 304);
            Controls.Add(comboBoxColores);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxColores;
    }
}
