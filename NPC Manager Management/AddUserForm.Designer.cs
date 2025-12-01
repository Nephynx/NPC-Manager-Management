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
            SuspendLayout();
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(217, 224);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(271, 46);
            buttonClear.TabIndex = 8;
            buttonClear.Text = "CREATE";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(292, 181);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(208, 23);
            txtPassword.TabIndex = 15;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(292, 150);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(208, 23);
            txtUsername.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(292, 116);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(208, 23);
            txtEmail.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(199, 184);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 12;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(199, 151);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 11;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(199, 124);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 10;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(343, 71);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 9;
            label1.Text = "Register";
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonClear);
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
    }
}