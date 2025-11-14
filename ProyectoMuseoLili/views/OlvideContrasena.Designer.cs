namespace ProyectoMuseoLili.views
{
    partial class OlvideContrasena
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            button3 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(250, 325);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(239, 23);
            textBox2.TabIndex = 11;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(250, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 328);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 9;
            label3.Text = "Nueva contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 201);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 8;
            label2.Text = "Correo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 52);
            label1.Name = "label1";
            label1.Size = new Size(228, 44);
            label1.TabIndex = 7;
            label1.Text = "MUSEO LILI";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(250, 372);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(239, 23);
            textBox3.TabIndex = 13;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 375);
            label4.Name = "label4";
            label4.Size = new Size(154, 15);
            label4.TabIndex = 12;
            label4.Text = "Nueva contraseña de nuevo";
            // 
            // button1
            // 
            button1.Location = new Point(534, 197);
            button1.Name = "button1";
            button1.Size = new Size(136, 23);
            button1.TabIndex = 14;
            button1.Text = "Verificar correo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(534, 244);
            button2.Name = "button2";
            button2.Size = new Size(136, 23);
            button2.TabIndex = 15;
            button2.Text = "Verificar codigo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(250, 244);
            textBox4.MaxLength = 4;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(239, 23);
            textBox4.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 248);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 17;
            label5.Text = "Codigo";
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(534, 345);
            button3.Name = "button3";
            button3.Size = new Size(136, 23);
            button3.TabIndex = 18;
            button3.Text = "Cambiar contraseña";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(28, 52);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(117, 37);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "VOLVER";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // OlvideContrasena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OlvideContrasena";
            Text = "OlvideContrasena";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private Button button2;
        private TextBox textBox4;
        private Label label5;
        private Button button3;
        private LinkLabel linkLabel1;
    }
}