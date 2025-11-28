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
            label1 = new Label();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NPC = new DataGridViewTextBoxColumn();
            PLAYER = new DataGridViewTextBoxColumn();
            DIALOGUE = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Bahnschrift Condensed", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(539, 81);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Home Page";
            // 
            // button2
            // 
            button2.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(0, 164);
            button2.Name = "button2";
            button2.Size = new Size(133, 87);
            button2.TabIndex = 0;
            button2.Text = "CREATE";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 192, 192);
            label4.Font = new Font("Segoe UI", 75F);
            label4.Location = new Point(0, -1);
            label4.Name = "label4";
            label4.Size = new Size(1650, 133);
            label4.TabIndex = 3;
            label4.Text = "                                                           ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 300F);
            label5.Location = new Point(-199, 132);
            label5.Name = "label5";
            label5.Size = new Size(332, 532);
            label5.TabIndex = 4;
            label5.Text = " ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Silver;
            label8.Font = new Font("Segoe UI", 300F);
            label8.Location = new Point(139, 156);
            label8.Name = "label8";
            label8.Size = new Size(1212, 532);
            label8.TabIndex = 6;
            label8.Text = "         ";
            label8.Click += label8_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(0, 257);
            button6.Name = "button6";
            button6.Size = new Size(133, 87);
            button6.TabIndex = 0;
            button6.Text = "READ";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(0, 350);
            button7.Name = "button7";
            button7.Size = new Size(133, 87);
            button7.TabIndex = 0;
            button7.Text = "EDIT";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(0, 443);
            button8.Name = "button8";
            button8.Size = new Size(133, 87);
            button8.TabIndex = 0;
            button8.Text = "NPC Manager";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(0, 536);
            button9.Name = "button9";
            button9.Size = new Size(133, 87);
            button9.TabIndex = 0;
            button9.Text = "NPC Manager";
            button9.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, NPC, PLAYER, DIALOGUE });
            dataGridView1.Location = new Point(148, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(565, 459);
            dataGridView1.TabIndex = 7;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // NPC
            // 
            NPC.HeaderText = "Non-Player Character";
            NPC.Name = "NPC";
            // 
            // PLAYER
            // 
            PLAYER.HeaderText = "Player";
            PLAYER.Name = "PLAYER";
            // 
            // DIALOGUE
            // 
            DIALOGUE.HeaderText = "Dialogue";
            DIALOGUE.Name = "DIALOGUE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.Font = new Font("Segoe UI", 150F);
            label2.Location = new Point(723, 164);
            label2.Name = "label2";
            label2.Size = new Size(332, 265);
            label2.TabIndex = 8;
            label2.Text = "    ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGray;
            label3.Font = new Font("Segoe UI", 150F);
            label3.Location = new Point(723, 355);
            label3.Name = "label3";
            label3.Size = new Size(332, 265);
            label3.TabIndex = 9;
            label3.Text = "    ";
            // 
            // UserHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1069, 633);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UserHome";
            RightToLeftLayout = true;
            Text = "UserHome";
            Load += UserHome_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label label8;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NPC;
        private DataGridViewTextBoxColumn PLAYER;
        private DataGridViewTextBoxColumn DIALOGUE;
        private Label label2;
        private Label label3;
    }
}