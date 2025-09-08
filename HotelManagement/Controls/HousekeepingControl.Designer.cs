namespace HotelManagement.Forms
{
    partial class HousekeepingControl
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            txtRoomNo = new DataGridViewTextBoxColumn();
            txtRoomType = new DataGridViewTextBoxColumn();
            txtStatus = new DataGridViewTextBoxColumn();
            txtAssignedStaff = new DataGridViewTextBoxColumn();
            txtLastCleaned = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1399, 51);
            panel1.TabIndex = 0;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txtRoomNo, txtRoomType, txtStatus, txtAssignedStaff, txtLastCleaned });
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
            dataGridView1.Location = new Point(0, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1399, 605);
            dataGridView1.TabIndex = 8;
            // 
            // txtRoomNo
            // 
            txtRoomNo.FillWeight = 30F;
            txtRoomNo.HeaderText = "Room No.";
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
            // txtStatus
            // 
            txtStatus.HeaderText = "Status";
            txtStatus.MinimumWidth = 6;
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            // 
            // txtAssignedStaff
            // 
            txtAssignedStaff.HeaderText = "Assigned Staff";
            txtAssignedStaff.MinimumWidth = 6;
            txtAssignedStaff.Name = "txtAssignedStaff";
            txtAssignedStaff.ReadOnly = true;
            // 
            // txtLastCleaned
            // 
            txtLastCleaned.HeaderText = "Last Cleaned";
            txtLastCleaned.MinimumWidth = 6;
            txtLastCleaned.Name = "txtLastCleaned";
            txtLastCleaned.ReadOnly = true;
            // 
            // HousekeepingControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "HousekeepingControl";
            Size = new Size(1399, 656);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn txtRoomNo;
        private DataGridViewTextBoxColumn txtRoomType;
        private DataGridViewTextBoxColumn txtStatus;
        private DataGridViewTextBoxColumn txtAssignedStaff;
        private DataGridViewTextBoxColumn txtLastCleaned;
    }
}
