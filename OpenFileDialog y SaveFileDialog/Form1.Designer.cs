namespace OpenFileDialog_y_SaveFileDialog
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
            textBoxContenido = new TextBox();
            buttonAbrir = new Button();
            buttonGuardar = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // textBoxContenido
            // 
            textBoxContenido.Dock = DockStyle.Fill;
            textBoxContenido.Location = new Point(0, 0);
            textBoxContenido.Multiline = true;
            textBoxContenido.Name = "textBoxContenido";
            textBoxContenido.ScrollBars = ScrollBars.Vertical;
            textBoxContenido.Size = new Size(331, 267);
            textBoxContenido.TabIndex = 0;
            textBoxContenido.TextChanged += textBox1_TextChanged;
            // 
            // buttonAbrir
            // 
            buttonAbrir.Location = new Point(54, 107);
            buttonAbrir.Name = "buttonAbrir";
            buttonAbrir.Size = new Size(75, 23);
            buttonAbrir.TabIndex = 1;
            buttonAbrir.Text = "Abril";
            buttonAbrir.UseVisualStyleBackColor = true;
            buttonAbrir.Click += buttonAbrir_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(159, 107);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 2;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 267);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonAbrir);
            Controls.Add(textBoxContenido);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxContenido;
        private Button buttonAbrir;
        private Button buttonGuardar;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
