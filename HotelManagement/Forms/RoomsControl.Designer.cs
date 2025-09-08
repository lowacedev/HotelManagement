namespace HotelManagement
{
    partial class RoomsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel3 = new Panel();
            txtSearch = new TextBox();
            comboBox2 = new ComboBox();
            addroombtn = new Button();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            txtRoomNo = new DataGridViewTextBoxColumn();
            txtRoomType = new DataGridViewTextBoxColumn();
            txtPrice = new DataGridViewTextBoxColumn();
            txtStatus = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(addroombtn);
            panel3.Controls.Add(comboBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1371, 64);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(3, 13);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(228, 29);
            txtSearch.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1101, 16);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(98, 28);
            comboBox2.TabIndex = 7;
            // 
            // addroombtn
            // 
            addroombtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addroombtn.BackColor = Color.Teal;
            addroombtn.FlatStyle = FlatStyle.Flat;
            addroombtn.ForeColor = Color.White;
            addroombtn.Location = new Point(1206, 7);
            addroombtn.Margin = new Padding(3, 4, 3, 4);
            addroombtn.Name = "addroombtn";
            addroombtn.Size = new Size(152, 49);
            addroombtn.TabIndex = 6;
            addroombtn.Text = "Add New Room";
            addroombtn.UseVisualStyleBackColor = false;
            addroombtn.Click += addroombtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(995, 16);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(98, 28);
            comboBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txtRoomNo, txtRoomType, txtPrice, txtStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(0, 64);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1371, 1003);
            dataGridView1.TabIndex = 6;
            // 
            // txtRoomNo
            // 
            txtRoomNo.HeaderText = "Room No";
            txtRoomNo.MinimumWidth = 6;
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.ReadOnly = true;
            // 
            // txtRoomType
            // 
            txtRoomType.HeaderText = "Room Type";
            txtRoomType.MinimumWidth = 6;
            txtRoomType.Name = "txtRoomType";
            txtRoomType.ReadOnly = true;
            // 
            // txtPrice
            // 
            txtPrice.HeaderText = "Price";
            txtPrice.MinimumWidth = 6;
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            // 
            // txtStatus
            // 
            txtStatus.HeaderText = "Status";
            txtStatus.MinimumWidth = 6;
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            // 
            // RoomsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Margin = new Padding(0, 133, 0, 0);
            Name = "RoomsControl";
            Size = new Size(1371, 1067);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        internal Button button6;
        internal Button button5;
        internal Button roomsbtn;
        internal Button button3;
        internal Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel3;
        private ComboBox comboBox2;
        private Button addroombtn;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn txtRoomNo;
        private DataGridViewTextBoxColumn txtRoomType;
        private DataGridViewTextBoxColumn txtCapacity;
        private DataGridViewTextBoxColumn txtPrice;
        private DataGridViewTextBoxColumn txtStatus;
        private TextBox txtSearch;
    }
}
