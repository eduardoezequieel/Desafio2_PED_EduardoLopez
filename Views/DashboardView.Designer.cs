namespace Desafio2_PED_EduardoLopez.Views
{
    partial class DashboardView
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
            btnDeleteAristas = new Button();
            groupBox3 = new GroupBox();
            cbType = new ComboBox();
            groupBox2 = new GroupBox();
            cityCb = new ComboBox();
            groupBox1 = new GroupBox();
            countryCb = new ComboBox();
            btnContinue = new Button();
            btnMinimize = new Button();
            btnExit = new Button();
            countryPanel = new Panel();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 21, 21);
            panel1.Controls.Add(btnDeleteAristas);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnContinue);
            panel1.Location = new Point(14, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(1220, 93);
            panel1.TabIndex = 1;
            // 
            // btnDeleteAristas
            // 
            btnDeleteAristas.BackColor = Color.FromArgb(255, 128, 128);
            btnDeleteAristas.FlatAppearance.BorderSize = 0;
            btnDeleteAristas.FlatStyle = FlatStyle.Flat;
            btnDeleteAristas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDeleteAristas.ForeColor = Color.White;
            btnDeleteAristas.Location = new Point(860, 21);
            btnDeleteAristas.Name = "btnDeleteAristas";
            btnDeleteAristas.Size = new Size(190, 57);
            btnDeleteAristas.TabIndex = 8;
            btnDeleteAristas.Text = "Eliminar conexiones";
            btnDeleteAristas.UseVisualStyleBackColor = false;
            btnDeleteAristas.Click += btnDeleteAristas_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbType);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            groupBox3.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox3.Location = new Point(480, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(229, 75);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tipo de recorrido";
            // 
            // cbType
            // 
            cbType.BackColor = Color.FromArgb(21, 21, 21);
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.FlatStyle = FlatStyle.Flat;
            cbType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbType.ForeColor = Color.White;
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(16, 28);
            cbType.Name = "cbType";
            cbType.Size = new Size(195, 33);
            cbType.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cityCb);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            groupBox2.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox2.Location = new Point(240, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(229, 75);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ciudad";
            // 
            // cityCb
            // 
            cityCb.BackColor = Color.FromArgb(21, 21, 21);
            cityCb.DropDownStyle = ComboBoxStyle.DropDownList;
            cityCb.FlatStyle = FlatStyle.Flat;
            cityCb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cityCb.ForeColor = Color.White;
            cityCb.FormattingEnabled = true;
            cityCb.Location = new Point(16, 28);
            cityCb.Name = "cityCb";
            cityCb.Size = new Size(195, 33);
            cityCb.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(countryCb);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox1.Location = new Point(14, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 75);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "País";
            // 
            // countryCb
            // 
            countryCb.BackColor = Color.FromArgb(21, 21, 21);
            countryCb.DropDownStyle = ComboBoxStyle.DropDownList;
            countryCb.FlatStyle = FlatStyle.Flat;
            countryCb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countryCb.ForeColor = Color.White;
            countryCb.Location = new Point(16, 28);
            countryCb.Name = "countryCb";
            countryCb.Size = new Size(181, 33);
            countryCb.TabIndex = 0;
            countryCb.SelectedValueChanged += countryCb_SelectedValueChanged;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.FromArgb(0, 187, 132);
            btnContinue.FlatAppearance.BorderSize = 0;
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnContinue.ForeColor = Color.White;
            btnContinue.Location = new Point(1056, 21);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(143, 57);
            btnContinue.TabIndex = 3;
            btnContinue.Text = "Continuar";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
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
            btnMinimize.TabIndex = 4;
            btnMinimize.Text = "_";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
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
            btnExit.TabIndex = 3;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // countryPanel
            // 
            countryPanel.BackColor = Color.FromArgb(21, 21, 21);
            countryPanel.Location = new Point(14, 118);
            countryPanel.Name = "countryPanel";
            countryPanel.Size = new Size(1324, 599);
            countryPanel.TabIndex = 9;
            countryPanel.Paint += countryPanel_Paint_1;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1350, 729);
            Controls.Add(countryPanel);
            Controls.Add(btnMinimize);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardView";
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnContinue;
        private Button btnMinimize;
        private Button btnExit;
        private GroupBox groupBox1;
        private ComboBox countryCb;
        private GroupBox groupBox3;
        private ComboBox cbType;
        private GroupBox groupBox2;
        private ComboBox cityCb;
        private Button btnDeleteAristas;
        private Panel countryPanel;
    }
}