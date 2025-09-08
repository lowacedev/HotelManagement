namespace HotelManagement.Forms
{
    partial class AddInventoryForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            comboBox2 = new ComboBox();
            label6 = new Label();
            numericUpDown2 = new NumericUpDown();
            panel3 = new Panel();
            btnAddItem = new Button();
            btnCancel = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 42);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(171, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 0;
            label1.Text = "Add New Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 38);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 11;
            label2.Text = "Item Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 95);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 12;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 158);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 13;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 276);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 14;
            label5.Text = "Supplier";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(145, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 23);
            comboBox1.TabIndex = 16;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(145, 176);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(196, 23);
            numericUpDown1.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(145, 294);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(195, 23);
            comboBox2.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(145, 215);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 19;
            label6.Text = "Reorder";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(145, 233);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(195, 23);
            numericUpDown2.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnAddItem);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 367);
            panel3.Name = "panel3";
            panel3.Size = new Size(499, 41);
            panel3.TabIndex = 21;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.Teal;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(146, 3);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(80, 35);
            btnAddItem.TabIndex = 0;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveBorder;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(265, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(numericUpDown2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(499, 408);
            panel2.TabIndex = 1;
            // 
            // AddInventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddInventoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddInventoryForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private NumericUpDown numericUpDown2;
        private Label label6;
        private ComboBox comboBox2;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Button btnCancel;
        private Button btnAddItem;
    }
}