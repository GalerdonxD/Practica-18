namespace Practica_18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ladoA = new TextBox();
            ladoB = new TextBox();
            ladoC = new TextBox();
            triangulo = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(386, 78);
            label1.TabIndex = 0;
            label1.Text = "Este programa te dira si un triangulo es\r\nEquilatero, Isosceles o Escaleno en base\r\na la longitud de sus 3 lados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 146);
            label2.Name = "label2";
            label2.Size = new Size(165, 26);
            label2.TabIndex = 1;
            label2.Text = "Longitud Lado A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 185);
            label3.Name = "label3";
            label3.Size = new Size(164, 26);
            label3.TabIndex = 2;
            label3.Text = "Longitud Lado B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 223);
            label4.Name = "label4";
            label4.Size = new Size(165, 26);
            label4.TabIndex = 3;
            label4.Text = "Longitud Lado C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(115, 356);
            label5.Name = "label5";
            label5.Size = new Size(179, 26);
            label5.TabIndex = 4;
            label5.Text = "Tipo de triangulo:";
            // 
            // ladoA
            // 
            ladoA.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ladoA.Location = new Point(187, 143);
            ladoA.Name = "ladoA";
            ladoA.Size = new Size(108, 33);
            ladoA.TabIndex = 5;
            // 
            // ladoB
            // 
            ladoB.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ladoB.Location = new Point(187, 186);
            ladoB.Name = "ladoB";
            ladoB.Size = new Size(108, 33);
            ladoB.TabIndex = 6;
            // 
            // ladoC
            // 
            ladoC.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ladoC.Location = new Point(187, 224);
            ladoC.Name = "ladoC";
            ladoC.Size = new Size(108, 33);
            ladoC.TabIndex = 7;
            // 
            // triangulo
            // 
            triangulo.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            triangulo.Location = new Point(300, 353);
            triangulo.Name = "triangulo";
            triangulo.Size = new Size(158, 33);
            triangulo.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(115, 290);
            button1.Name = "button1";
            button1.Size = new Size(114, 35);
            button1.TabIndex = 9;
            button1.Text = "Desición";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(254, 290);
            button2.Name = "button2";
            button2.Size = new Size(114, 35);
            button2.TabIndex = 10;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(388, 290);
            button3.Name = "button3";
            button3.Size = new Size(114, 35);
            button3.TabIndex = 11;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(324, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 393);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(triangulo);
            Controls.Add(ladoC);
            Controls.Add(ladoB);
            Controls.Add(ladoA);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ladoA;
        private TextBox ladoB;
        private TextBox ladoC;
        private TextBox triangulo;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}