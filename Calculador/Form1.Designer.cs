namespace Calculador
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
            textBoxPantalla = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonLimpiar = new Button();
            buttonIgual = new Button();
            buttonSuma = new Button();
            buttonResta = new Button();
            buttonMulti = new Button();
            buttonDiv = new Button();
            SuspendLayout();
            // 
            // textBoxPantalla
            // 
            textBoxPantalla.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPantalla.Location = new Point(62, 36);
            textBoxPantalla.Name = "textBoxPantalla";
            textBoxPantalla.ReadOnly = true;
            textBoxPantalla.Size = new Size(237, 33);
            textBoxPantalla.TabIndex = 0;
            textBoxPantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(62, 133);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BotonNumero_Click;
            // 
            // button2
            // 
            button2.Location = new Point(143, 133);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BotonNumero_Click;
            // 
            // button3
            // 
            button3.Location = new Point(224, 133);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += BotonNumero_Click;
            // 
            // button4
            // 
            button4.Location = new Point(62, 104);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += BotonNumero_Click;
            // 
            // button5
            // 
            button5.Location = new Point(143, 104);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += BotonNumero_Click;
            // 
            // button6
            // 
            button6.Location = new Point(224, 104);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += BotonNumero_Click;
            // 
            // button7
            // 
            button7.Location = new Point(62, 75);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += BotonNumero_Click;
            // 
            // button8
            // 
            button8.Location = new Point(143, 75);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += BotonNumero_Click;
            // 
            // button9
            // 
            button9.Location = new Point(223, 75);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += BotonNumero_Click;
            // 
            // button0
            // 
            button0.Location = new Point(62, 162);
            button0.Name = "button0";
            button0.Size = new Size(75, 23);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += BotonNumero_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(143, 162);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(75, 23);
            buttonLimpiar.TabIndex = 11;
            buttonLimpiar.Text = "Borrar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.Location = new Point(224, 162);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(75, 23);
            buttonIgual.TabIndex = 12;
            buttonIgual.Text = " =";
            buttonIgual.UseVisualStyleBackColor = true;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // buttonSuma
            // 
            buttonSuma.Location = new Point(305, 75);
            buttonSuma.Name = "buttonSuma";
            buttonSuma.Size = new Size(75, 23);
            buttonSuma.TabIndex = 13;
            buttonSuma.Text = "+";
            buttonSuma.UseVisualStyleBackColor = true;
            buttonSuma.Click += BotonOperacion_Click;
            // 
            // buttonResta
            // 
            buttonResta.Location = new Point(305, 104);
            buttonResta.Name = "buttonResta";
            buttonResta.Size = new Size(75, 23);
            buttonResta.TabIndex = 14;
            buttonResta.Text = "-";
            buttonResta.UseVisualStyleBackColor = true;
            buttonResta.Click += BotonOperacion_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.Location = new Point(305, 133);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(75, 23);
            buttonMulti.TabIndex = 15;
            buttonMulti.Text = "*";
            buttonMulti.UseVisualStyleBackColor = true;
            buttonMulti.Click += BotonOperacion_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(305, 162);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(75, 23);
            buttonDiv.TabIndex = 16;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += BotonOperacion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 245);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMulti);
            Controls.Add(buttonResta);
            Controls.Add(buttonSuma);
            Controls.Add(buttonIgual);
            Controls.Add(buttonLimpiar);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxPantalla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPantalla;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonLimpiar;
        private Button buttonIgual;
        private Button buttonSuma;
        private Button buttonResta;
        private Button buttonMulti;
        private Button buttonDiv;
    }
}
