namespace NPC_Manager_Management
{
    partial class UserLogin
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
            label2 = new Label();
            label3 = new Label();
            buttonSubmit = new Button();
            label1 = new Label();
            LoginUsername = new TextBox();
            LoginPassword = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift Condensed", 25F);
            label2.Location = new Point(202, 189);
            label2.Name = "label2";
            label2.Size = new Size(130, 41);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift Condensed", 25F);
            label3.Location = new Point(201, 238);
            label3.Name = "label3";
            label3.Size = new Size(127, 41);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(372, 328);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(75, 23);
            buttonSubmit.TabIndex = 3;
            buttonSubmit.Text = "Login";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift Condensed", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 10);
            label1.Name = "label1";
            label1.Size = new Size(590, 81);
            label1.TabIndex = 0;
            label1.Text = "Welcome to NPC Manager";
            // 
            // LoginUsername
            // 
            LoginUsername.Location = new Point(338, 200);
            LoginUsername.Name = "LoginUsername";
            LoginUsername.Size = new Size(177, 23);
            LoginUsername.TabIndex = 6;
            // 
            // LoginPassword
            // 
            LoginPassword.Font = new Font("Lucida Sans", 10F);
            LoginPassword.Location = new Point(338, 248);
            LoginPassword.Name = "LoginPassword";
            LoginPassword.PasswordChar = '*';
            LoginPassword.Size = new Size(177, 23);
            LoginPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Teal;
            label4.Font = new Font("Segoe UI", 75F);
            label4.Location = new Point(107, 139);
            label4.Name = "label4";
            label4.Size = new Size(570, 133);
            label4.TabIndex = 7;
            label4.Text = "                   ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Teal;
            label5.Font = new Font("Segoe UI", 75F);
            label5.Location = new Point(107, 272);
            label5.Name = "label5";
            label5.Size = new Size(570, 133);
            label5.TabIndex = 7;
            label5.Text = "                   ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Teal;
            label6.Font = new Font("Segoe UI", 60F);
            label6.Location = new Point(-14, 1);
            label6.Name = "label6";
            label6.Size = new Size(837, 106);
            label6.TabIndex = 8;
            label6.Text = "                                    ";
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginPassword);
            Controls.Add(LoginUsername);
            Controls.Add(buttonSubmit);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Name = "UserLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Button buttonSubmit;
        private Label label1;
        private TextBox LoginUsername;
        private TextBox LoginPassword;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
