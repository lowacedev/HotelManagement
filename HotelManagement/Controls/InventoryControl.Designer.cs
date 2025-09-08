namespace HotelManagement.Forms
{
    partial class InventoryControl
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryControl));
            panel1 = new Panel();
            btnAddInventory = new Button();
            dataGridView1 = new DataGridView();
            contextMenuInventory = new ContextMenuStrip(components);
            restockToolStripRestock = new ToolStripMenuItem();
            txtItemID = new DataGridViewTextBoxColumn();
            txtItemName = new DataGridViewTextBoxColumn();
            txtCategory = new DataGridViewTextBoxColumn();
            txtQuantity = new DataGridViewTextBoxColumn();
            txtReorder = new DataGridViewTextBoxColumn();
            txtSupplier = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuInventory.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddInventory);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 48);
            panel1.TabIndex = 0;
            // 
            // btnAddInventory
            // 
            btnAddInventory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddInventory.BackColor = Color.Teal;
            btnAddInventory.FlatStyle = FlatStyle.Flat;
            btnAddInventory.ForeColor = Color.White;
            btnAddInventory.Location = new Point(957, 3);
            btnAddInventory.Name = "btnAddInventory";
            btnAddInventory.Size = new Size(160, 37);
            btnAddInventory.TabIndex = 9;
            btnAddInventory.Text = "Add New Item";
            btnAddInventory.UseVisualStyleBackColor = false;
            btnAddInventory.Click += btnAddInventory_Click;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txtItemID, txtItemName, txtCategory, txtQuantity, txtReorder, txtSupplier });
            dataGridView1.ContextMenuStrip = contextMenuInventory;
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
            dataGridView1.Location = new Point(0, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1129, 612);
            dataGridView1.TabIndex = 7;
            // 
            // contextMenuInventory
            // 
            contextMenuInventory.Items.AddRange(new ToolStripItem[] { restockToolStripRestock });
            contextMenuInventory.Name = "contextMenuStrip1";
            contextMenuInventory.Size = new Size(116, 26);
            // 
            // restockToolStripRestock
            // 
            restockToolStripRestock.Image = (Image)resources.GetObject("restockToolStripRestock.Image");
            restockToolStripRestock.Name = "restockToolStripRestock";
            restockToolStripRestock.Size = new Size(115, 22);
            restockToolStripRestock.Text = "Restock";
            restockToolStripRestock.Click += restockToolStripRestock_Click;
            // 
            // txtItemID
            // 
            txtItemID.FillWeight = 30F;
            txtItemID.HeaderText = "Item ID";
            txtItemID.Name = "txtItemID";
            txtItemID.ReadOnly = true;
            // 
            // txtItemName
            // 
            txtItemName.HeaderText = "Item Name";
            txtItemName.MinimumWidth = 6;
            txtItemName.Name = "txtItemName";
            txtItemName.ReadOnly = true;
            // 
            // txtCategory
            // 
            txtCategory.HeaderText = "Category";
            txtCategory.MinimumWidth = 6;
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            // 
            // txtQuantity
            // 
            txtQuantity.HeaderText = "Quantity";
            txtQuantity.MinimumWidth = 6;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            // 
            // txtReorder
            // 
            txtReorder.HeaderText = "Reorder";
            txtReorder.MinimumWidth = 6;
            txtReorder.Name = "txtReorder";
            txtReorder.ReadOnly = true;
            // 
            // txtSupplier
            // 
            txtSupplier.HeaderText = "Supplier";
            txtSupplier.Name = "txtSupplier";
            txtSupplier.ReadOnly = true;
            // 
            // InventoryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "InventoryControl";
            Size = new Size(1129, 660);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuInventory.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAddInventory;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn txtItemID;
        private DataGridViewTextBoxColumn txtItemName;
        private DataGridViewTextBoxColumn txtCategory;
        private DataGridViewTextBoxColumn txtQuantity;
        private DataGridViewTextBoxColumn txtReorder;
        private DataGridViewTextBoxColumn txtSupplier;
        private ContextMenuStrip contextMenuInventory;
        private ToolStripMenuItem restockToolStripMenuItem;
        private ToolStripMenuItem restockToolStripRestock;
    }
}
