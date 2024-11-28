namespace Sportivex
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            panel1 = new Panel();
            register = new Label();
            label5 = new Label();
            Log_in = new Button();
            Sign_in = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            S_password = new MaskedTextBox();
            S_username = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(register);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Log_in);
            panel1.Controls.Add(Sign_in);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(S_password);
            panel1.Controls.Add(S_username);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(228, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 470);
            panel1.TabIndex = 3;
            // 
            // register
            // 
            register.AutoSize = true;
            register.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register.ForeColor = Color.DarkViolet;
            register.Location = new Point(242, 423);
            register.Name = "register";
            register.Size = new Size(70, 18);
            register.TabIndex = 7;
            register.Text = "Sign Up";
            register.Click += register_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F);
            label5.Location = new Point(59, 424);
            label5.Name = "label5";
            label5.Size = new Size(184, 18);
            label5.TabIndex = 6;
            label5.Text = "Don't have an account?";
            // 
            // Log_in
            // 
            Log_in.Font = new Font("Verdana", 9F, FontStyle.Bold);
            Log_in.ForeColor = Color.DarkViolet;
            Log_in.Location = new Point(237, 477);
            Log_in.Name = "Log_in";
            Log_in.Size = new Size(73, 36);
            Log_in.TabIndex = 4;
            Log_in.Text = "Login";
            Log_in.UseVisualStyleBackColor = true;
            // 
            // Sign_in
            // 
            Sign_in.BackColor = SystemColors.ActiveBorder;
            Sign_in.Font = new Font("Verdana", 9F, FontStyle.Bold);
            Sign_in.Location = new Point(79, 356);
            Sign_in.Name = "Sign_in";
            Sign_in.Size = new Size(210, 43);
            Sign_in.TabIndex = 4;
            Sign_in.Text = "Sign In";
            Sign_in.UseVisualStyleBackColor = false;
            Sign_in.Click += Sign_in_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 173);
            label3.Name = "label3";
            label3.Size = new Size(92, 18);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label2.Location = new Point(41, 261);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 485);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 3;
            label1.Text = "Already had an account?";
            // 
            // S_password
            // 
            S_password.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            S_password.Location = new Point(41, 282);
            S_password.Name = "S_password";
            S_password.PasswordChar = '*';
            S_password.Size = new Size(297, 41);
            S_password.TabIndex = 2;
            // 
            // S_username
            // 
            S_username.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            S_username.Location = new Point(41, 194);
            S_username.Name = "S_username";
            S_username.Size = new Size(297, 41);
            S_username.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(79, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 103);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 531);
            Controls.Add(panel1);
            Name = "SignIn";
            Text = "SignIn";
            FormClosed += SignIn_FormClosed;
            Load += SignIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Button Log_in;
        private Button Sign_in;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox S_password;
        private TextBox S_username;
        private PictureBox pictureBox1;
        private Label register;
    }
}