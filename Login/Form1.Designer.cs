namespace Login
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            pwd = new TextBox();
            user = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pwd);
            panel1.Controls.Add(user);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(230, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 343);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 130, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 8.5F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(280, 257);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 6;
            button2.Text = "Ingresar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.FlatAppearance.BorderColor = SystemColors.ScrollBar;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 8.5F);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(183, 257);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 5;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 8.5F);
            label2.Location = new Point(43, 203);
            label2.Name = "label2";
            label2.Size = new Size(159, 17);
            label2.TabIndex = 4;
            label2.Text = "Olvidaste tu contraseña?";
            // 
            // pwd
            // 
            pwd.BackColor = SystemColors.ScrollBar;
            pwd.Cursor = Cursors.IBeam;
            pwd.Location = new Point(39, 169);
            pwd.Name = "pwd";
            pwd.Size = new Size(316, 23);
            pwd.TabIndex = 3;
            // 
            // user
            // 
            user.BackColor = SystemColors.ScrollBar;
            user.Cursor = Cursors.IBeam;
            user.Location = new Point(39, 110);
            user.Name = "user";
            user.ShortcutsEnabled = false;
            user.Size = new Size(316, 23);
            user.TabIndex = 2;
            user.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 63);
            label1.Name = "label1";
            label1.Size = new Size(109, 19);
            label1.TabIndex = 1;
            label1.Text = "Iniciar Sesión";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private TextBox pwd;
        private TextBox user;
        private Button button2;
        private Button button1;
        private Label label2;
    }
}
