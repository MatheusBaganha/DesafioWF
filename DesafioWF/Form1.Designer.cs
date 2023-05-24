namespace DesafioWF
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
            button1Extrair = new Button();
            textBox1Dados = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // button1Extrair
            // 
            button1Extrair.BackColor = SystemColors.ControlLightLight;
            button1Extrair.Location = new Point(316, 33);
            button1Extrair.Name = "button1Extrair";
            button1Extrair.Size = new Size(166, 29);
            button1Extrair.TabIndex = 0;
            button1Extrair.Text = "Extrair Dados";
            button1Extrair.UseVisualStyleBackColor = false;
            button1Extrair.Click += button1_Click;
            // 
            // textBox1Dados
            // 
            textBox1Dados.BackColor = SystemColors.ControlLightLight;
            textBox1Dados.ForeColor = SystemColors.ActiveCaptionText;
            textBox1Dados.Location = new Point(155, 98);
            textBox1Dados.Multiline = true;
            textBox1Dados.Name = "textBox1Dados";
            textBox1Dados.ReadOnly = true;
            textBox1Dados.ScrollBars = ScrollBars.Vertical;
            textBox1Dados.Size = new Size(500, 300);
            textBox1Dados.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1Dados);
            Controls.Add(button1Extrair);
            Name = "Form1";
            Text = "Extração de Dados de Arquivo Txt";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1Extrair;
        private TextBox textBox1Dados;
        private SaveFileDialog saveFileDialog1;
    }
}