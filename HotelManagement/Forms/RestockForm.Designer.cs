namespace HotelManagement.Forms
{
    partial class RestockForm
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
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 272);
            panel3.Name = "panel3";
            panel3.Size = new Size(319, 45);
            panel3.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(169, 10);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 1;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(83, 10);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 0;
            button1.Text = "Restock";
            button1.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(83, 218);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(136, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(83, 148);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(161, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 89);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 200);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 10;
            label4.Text = "Add Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 130);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 9;
            label3.Text = "Current Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 71);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 7;
            label2.Text = "Item";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 40);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 14;
            label1.Text = "Restock Item";
            // 
            // RestockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 317);
            Controls.Add(panel1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RestockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RestockForm";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Button button2;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
    }
}