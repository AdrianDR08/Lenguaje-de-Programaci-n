namespace Mensaje_emergente
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
            buttonMensaje = new Button();
            SuspendLayout();
            // 
            // buttonMensaje
            // 
            buttonMensaje.Location = new Point(55, 67);
            buttonMensaje.Name = "buttonMensaje";
            buttonMensaje.Size = new Size(75, 23);
            buttonMensaje.TabIndex = 0;
            buttonMensaje.Text = "Mensaje";
            buttonMensaje.UseVisualStyleBackColor = true;
            buttonMensaje.Click += buttonMensaje_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(199, 177);
            Controls.Add(buttonMensaje);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonMensaje;
    }
}
