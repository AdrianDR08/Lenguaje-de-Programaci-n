namespace Convertit_temperatura
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
            textBoxCelsius = new TextBox();
            buttonConvertir = new Button();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // textBoxCelsius
            // 
            textBoxCelsius.Location = new Point(83, 60);
            textBoxCelsius.Name = "textBoxCelsius";
            textBoxCelsius.Size = new Size(100, 23);
            textBoxCelsius.TabIndex = 0;
            // 
            // buttonConvertir
            // 
            buttonConvertir.Location = new Point(37, 101);
            buttonConvertir.Name = "buttonConvertir";
            buttonConvertir.Size = new Size(75, 23);
            buttonConvertir.TabIndex = 1;
            buttonConvertir.Text = "Convertir";
            buttonConvertir.UseVisualStyleBackColor = true;
            buttonConvertir.Click += buttonConvertir_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(145, 109);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(59, 15);
            labelResultado.TabIndex = 2;
            labelResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 250);
            Controls.Add(labelResultado);
            Controls.Add(buttonConvertir);
            Controls.Add(textBoxCelsius);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCelsius;
        private Button buttonConvertir;
        private Label labelResultado;
    }
}
