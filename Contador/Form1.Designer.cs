namespace Contador
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            buttonIniciar = new Button();
            buttonDetener = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(76, 57);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 0;
            progressBar1.Click += progressBar1_Click;
            // 
            // buttonIniciar
            // 
            buttonIniciar.Location = new Point(53, 97);
            buttonIniciar.Name = "buttonIniciar";
            buttonIniciar.Size = new Size(75, 23);
            buttonIniciar.TabIndex = 1;
            buttonIniciar.Text = "Iniciar";
            buttonIniciar.UseVisualStyleBackColor = true;
            buttonIniciar.Click += buttonIniciar_Click;
            // 
            // buttonDetener
            // 
            buttonDetener.Location = new Point(153, 97);
            buttonDetener.Name = "buttonDetener";
            buttonDetener.Size = new Size(75, 23);
            buttonDetener.TabIndex = 2;
            buttonDetener.Text = "Detener";
            buttonDetener.UseVisualStyleBackColor = true;
            buttonDetener.Click += buttonDetener_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 196);
            Controls.Add(buttonDetener);
            Controls.Add(buttonIniciar);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Button buttonIniciar;
        private Button buttonDetener;
        private System.Windows.Forms.Timer timer1;
    }
}
