namespace Fecha
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
            dateTimePicker1 = new DateTimePicker();
            buttonMostrarFecha = new Button();
            labelFecha = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(30, 36);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // buttonMostrarFecha
            // 
            buttonMostrarFecha.Location = new Point(41, 94);
            buttonMostrarFecha.Name = "buttonMostrarFecha";
            buttonMostrarFecha.Size = new Size(75, 23);
            buttonMostrarFecha.TabIndex = 1;
            buttonMostrarFecha.Text = "Mostrar";
            buttonMostrarFecha.UseVisualStyleBackColor = true;
            buttonMostrarFecha.Click += buttonMostrarFecha_Click;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(136, 98);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(110, 15);
            labelFecha.TabIndex = 2;
            labelFecha.Text = "Fecha Seleccionada";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 302);
            Controls.Add(labelFecha);
            Controls.Add(buttonMostrarFecha);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button buttonMostrarFecha;
        private Label labelFecha;
    }
}
