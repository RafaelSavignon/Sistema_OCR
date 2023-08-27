namespace OCRFeiraDeCiencias
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
            button1 = new Button();
            button2 = new Button();
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(165, 416);
            button1.Name = "button1";
            button1.Size = new Size(126, 23);
            button1.TabIndex = 0;
            button1.Text = "Buscar Arquivo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(109, 416);
            button2.Name = "button2";
            button2.Size = new Size(116, 23);
            button2.TabIndex = 3;
            button2.Text = "Fazer Teste";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, -1);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(button2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Size = new Size(801, 450);
            splitContainer1.SplitterDistance = 372;
            splitContainer1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(14, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(398, 397);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 13);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 397);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Object Character Recognition";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}