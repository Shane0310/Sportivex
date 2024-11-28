namespace Sportivex
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            panel1 = new Panel();
            Log_in = new Button();
            Sign_up = new Button();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            X_password = new MaskedTextBox();
            X_cpassword = new MaskedTextBox();
            X_username = new TextBox();
            X_email = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(Log_in);
            panel1.Controls.Add(Sign_up);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(X_password);
            panel1.Controls.Add(X_cpassword);
            panel1.Controls.Add(X_username);
            panel1.Controls.Add(X_email);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(293, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 536);
            panel1.TabIndex = 2;
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
            Log_in.Click += Log_in_Click;
            // 
            // Sign_up
            // 
            Sign_up.BackColor = SystemColors.ActiveBorder;
            Sign_up.Font = new Font("Verdana", 9F, FontStyle.Bold);
            Sign_up.Location = new Point(91, 411);
            Sign_up.Name = "Sign_up";
            Sign_up.Size = new Size(210, 43);
            Sign_up.TabIndex = 4;
            Sign_up.Text = "Sign Up";
            Sign_up.UseVisualStyleBackColor = false;
            Sign_up.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label5.Location = new Point(41, 190);
            label5.Name = "label5";
            label5.Size = new Size(52, 18);
            label5.TabIndex = 3;
            label5.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 118);
            label3.Name = "label3";
            label3.Size = new Size(92, 18);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label4.Location = new Point(41, 326);
            label4.Name = "label4";
            label4.Size = new Size(157, 18);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password";
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
            // X_password
            // 
            X_password.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            X_password.Location = new Point(41, 282);
            X_password.Name = "X_password";
            X_password.PasswordChar = '*';
            X_password.Size = new Size(297, 41);
            X_password.TabIndex = 2;
            X_password.MaskInputRejected += X_password_MaskInputRejected;
            // 
            // X_cpassword
            // 
            X_cpassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            X_cpassword.Location = new Point(41, 347);
            X_cpassword.Name = "X_cpassword";
            X_cpassword.PasswordChar = '*';
            X_cpassword.Size = new Size(297, 41);
            X_cpassword.TabIndex = 2;
            // 
            // X_username
            // 
            X_username.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            X_username.Location = new Point(41, 141);
            X_username.Name = "X_username";
            X_username.Size = new Size(297, 41);
            X_username.TabIndex = 1;
            // 
            // X_email
            // 
            X_email.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            X_email.Location = new Point(41, 213);
            X_email.Name = "X_email";
            X_email.Size = new Size(297, 41);
            X_email.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(104, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 80);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 597);
            Controls.Add(panel1);
            Name = "SignUp";
            Text = "SignUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Log_in;
        private Button Sign_up;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private MaskedTextBox X_password;
        private MaskedTextBox X_cpassword;
        private TextBox X_username;
        private TextBox X_email;
        private PictureBox pictureBox1;
    }
}