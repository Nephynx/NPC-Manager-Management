namespace NPC_Manager_Management
{
    partial class UserHome
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
            button2 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("MS UI Gothic", 20.25F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(401, 12);
            button2.Name = "button2";
            button2.Size = new Size(200, 87);
            button2.TabIndex = 0;
            button2.Text = "Home Page";
            button2.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("MS UI Gothic", 20.25F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(607, 12);
            button6.Name = "button6";
            button6.Size = new Size(200, 87);
            button6.TabIndex = 0;
            button6.Text = "NPC Manager";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("MS UI Gothic", 20.25F);
            button7.ForeColor = Color.White;
            button7.Location = new Point(813, 12);
            button7.Name = "button7";
            button7.Size = new Size(200, 87);
            button7.TabIndex = 0;
            button7.Text = "Dialogue Manager";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.Cursor = Cursors.Hand;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("MS UI Gothic", 20.25F);
            button8.ForeColor = Color.White;
            button8.Location = new Point(1019, 12);
            button8.Name = "button8";
            button8.Size = new Size(200, 87);
            button8.TabIndex = 0;
            button8.Text = "Dialogue Player";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Transparent;
            button9.Cursor = Cursors.Hand;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("MS UI Gothic", 20.25F);
            button9.ForeColor = Color.White;
            button9.Location = new Point(1225, 12);
            button9.Name = "button9";
            button9.Size = new Size(200, 87);
            button9.TabIndex = 0;
            button9.Text = "Log Out";
            button9.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS UI Gothic", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 9);
            label1.Name = "label1";
            label1.Size = new Size(351, 86);
            label1.TabIndex = 5;
            label1.Text = "Welcome To NPC\r\nDialogue Manager\r\n";
            // 
            // UserHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources._794204bd9d539df36ec7390dc82fe08b;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1484, 611);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UserHome";
            RightToLeftLayout = true;
            Text = "UserHome";
            Load += UserHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
    }
}