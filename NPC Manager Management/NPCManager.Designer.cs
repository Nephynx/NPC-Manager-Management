namespace NPC_Manager_Management
{
    partial class NPCManager
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("MS UI Gothic", 17.25F, FontStyle.Bold);
            button2.Location = new Point(316, 12);
            button2.Margin = new Padding(12);
            button2.Name = "button2";
            button2.Size = new Size(271, 39);
            button2.TabIndex = 0;
            button2.Text = "Dialogue Manager";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("MS UI Gothic", 17.25F, FontStyle.Bold);
            button3.Location = new Point(611, 12);
            button3.Margin = new Padding(12);
            button3.Name = "button3";
            button3.Size = new Size(271, 39);
            button3.TabIndex = 0;
            button3.Text = "Dialogue Player";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("MS UI Gothic", 17.25F, FontStyle.Bold);
            button4.Location = new Point(906, 12);
            button4.Margin = new Padding(12);
            button4.Name = "button4";
            button4.Size = new Size(271, 39);
            button4.TabIndex = 0;
            button4.Text = "Home Page";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("MS UI Gothic", 17.25F, FontStyle.Bold);
            button5.Location = new Point(1201, 12);
            button5.Margin = new Padding(12);
            button5.Name = "button5";
            button5.Size = new Size(271, 39);
            button5.TabIndex = 0;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("MS UI Gothic", 17.25F, FontStyle.Bold);
            button6.Location = new Point(21, 158);
            button6.Margin = new Padding(12);
            button6.Name = "button6";
            button6.Size = new Size(271, 39);
            button6.TabIndex = 0;
            button6.Text = "CREATE";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("MS UI Gothic", 17.25F, FontStyle.Bold);
            button7.Location = new Point(21, 221);
            button7.Margin = new Padding(12);
            button7.Name = "button7";
            button7.Size = new Size(271, 39);
            button7.TabIndex = 0;
            button7.Text = "EDIT";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("MS UI Gothic", 17.25F, FontStyle.Bold);
            button8.Location = new Point(21, 284);
            button8.Margin = new Padding(12);
            button8.Name = "button8";
            button8.Size = new Size(271, 39);
            button8.TabIndex = 0;
            button8.Text = "DELETE";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(316, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(930, 492);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.SpringGreen;
            label1.Location = new Point(1252, 107);
            label1.Name = "label1";
            label1.Size = new Size(220, 492);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = Color.SpringGreen;
            label2.Location = new Point(0, -3);
            label2.Name = "label2";
            label2.Size = new Size(1485, 91);
            label2.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 107);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(298, 492);
            dataGridView2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.IndianRed;
            label3.Font = new Font("MS UI Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 12);
            label3.Name = "label3";
            label3.Size = new Size(258, 40);
            label3.TabIndex = 5;
            label3.Text = "NPC Manager";
            // 
            // NPCManager
            // 
            AutoScaleDimensions = new SizeF(27F, 58F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1484, 611);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Font = new Font("Bahnschrift", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(12, 12, 12, 12);
            Name = "NPCManager";
            Text = "NPCManager";
            Load += NPCManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView2;
        private Label label3;
    }
}