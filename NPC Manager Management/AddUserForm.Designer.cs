namespace NPC_Manager_Management
{
    partial class AddUserForm
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
            buttonClear = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(337, 356);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(79, 22);
            buttonClear.TabIndex = 8;
            buttonClear.Text = "Register";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(315, 298);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(208, 23);
            txtPassword.TabIndex = 15;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(315, 243);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(208, 23);
            txtUsername.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(315, 189);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(208, 23);
            txtEmail.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 25F);
            label4.Location = new Point(176, 288);
            label4.Name = "label4";
            label4.Size = new Size(127, 41);
            label4.TabIndex = 12;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 25F);
            label3.Location = new Point(174, 232);
            label3.Name = "label3";
            label3.Size = new Size(130, 41);
            label3.TabIndex = 11;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 25F);
            label2.Location = new Point(222, 178);
            label2.Name = "label2";
            label2.Size = new Size(81, 41);
            label2.TabIndex = 10;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 50.25F);
            label1.Location = new Point(281, 16);
            label1.Name = "label1";
            label1.Size = new Size(219, 81);
            label1.TabIndex = 9;
            label1.Text = "Register";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Teal;
            label6.Font = new Font("Segoe UI", 60F);
            label6.Location = new Point(-15, -3);
            label6.Name = "label6";
            label6.Size = new Size(837, 106);
            label6.TabIndex = 16;
            label6.Text = "                                    ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Teal;
            label5.Font = new Font("Segoe UI", 60F);
            label5.Location = new Point(-18, 172);
            label5.Name = "label5";
            label5.Size = new Size(0, 106);
            label5.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Teal;
            label7.Font = new Font("Segoe UI", 60F);
            label7.Location = new Point(-18, 172);
            label7.Name = "label7";
            label7.Size = new Size(0, 106);
            label7.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Teal;
            label8.Font = new Font("Segoe UI", 75F);
            label8.Location = new Point(106, 151);
            label8.Name = "label8";
            label8.Size = new Size(570, 133);
            label8.TabIndex = 19;
            label8.Text = "                   ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Teal;
            label9.Font = new Font("Segoe UI", 75F);
            label9.Location = new Point(106, 284);
            label9.Name = "label9";
            label9.Size = new Size(570, 133);
            label9.TabIndex = 20;
            label9.Text = "                   ";
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonClear);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label9);
            Name = "AddUserForm";
            Text = "AddUserfrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClear;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}