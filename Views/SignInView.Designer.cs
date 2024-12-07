namespace Desafio2_PED_EduardoLopez
{
    partial class SignInView
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
            panel1 = new Panel();
            btnSignIn = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            passwordTxt = new TextBox();
            groupBox1 = new GroupBox();
            userTxt = new TextBox();
            btnExit = new Button();
            btnMinimize = new Button();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 21, 21);
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(407, 188);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 367);
            panel1.TabIndex = 0;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(0, 187, 132);
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(80, 279);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(365, 51);
            btnSignIn.TabIndex = 3;
            btnSignIn.Text = "Continuar";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(205, 36);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 6;
            label1.Text = "Iniciar sesión";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(passwordTxt);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            groupBox2.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox2.Location = new Point(80, 175);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(365, 75);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Contraseña";
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = Color.FromArgb(21, 21, 21);
            passwordTxt.BorderStyle = BorderStyle.None;
            passwordTxt.Font = new Font("Segoe UI", 14.25F);
            passwordTxt.ForeColor = Color.White;
            passwordTxt.Location = new Point(14, 32);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(333, 26);
            passwordTxt.TabIndex = 1;
            passwordTxt.KeyDown += passwordTxt_KeyDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(userTxt);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox1.Location = new Point(80, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 75);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuario";
            // 
            // userTxt
            // 
            userTxt.BackColor = Color.FromArgb(21, 21, 21);
            userTxt.BorderStyle = BorderStyle.None;
            userTxt.Font = new Font("Segoe UI", 14.25F);
            userTxt.ForeColor = Color.White;
            userTxt.Location = new Point(14, 32);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(333, 26);
            userTxt.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 128, 128);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(15, 15, 15);
            btnExit.Location = new Point(1296, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(42, 42);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.FromArgb(128, 128, 255);
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = Color.FromArgb(15, 15, 15);
            btnMinimize.Location = new Point(1248, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(42, 42);
            btnMinimize.TabIndex = 2;
            btnMinimize.Text = "_";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // SignInView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1350, 729);
            Controls.Add(btnMinimize);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignInView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesión | Ubikt";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnMinimize;
        private TextBox userTxt;
        private GroupBox groupBox2;
        private TextBox passwordTxt;
        private GroupBox groupBox1;
        private Button btnSignIn;
        private Label label1;
    }
}