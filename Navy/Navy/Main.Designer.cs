namespace Navy
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.transactionView = new System.Windows.Forms.PropertyGrid();
            this.register = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.ToolStrip();
            this.add = new System.Windows.Forms.ToolStripButton();
            this.delete = new System.Windows.Forms.ToolStripButton();
            this.accept = new System.Windows.Forms.Button();
            this.datagridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter = new System.Windows.Forms.Splitter();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.register)).BeginInit();
            this.menu.SuspendLayout();
            this.datagridMenu.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // transactionView
            // 
            this.transactionView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionView.Location = new System.Drawing.Point(3, 3);
            this.transactionView.Name = "transactionView";
            this.transactionView.Size = new System.Drawing.Size(333, 437);
            this.transactionView.TabIndex = 0;
            // 
            // register
            // 
            this.register.AllowUserToAddRows = false;
            this.register.AllowUserToDeleteRows = false;
            this.register.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.register.ContextMenuStrip = this.datagridMenu;
            this.register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.register.Location = new System.Drawing.Point(0, 0);
            this.register.Name = "register";
            this.register.ReadOnly = true;
            this.register.Size = new System.Drawing.Size(706, 508);
            this.register.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.delete});
            this.menu.Location = new System.Drawing.Point(0, 508);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1056, 25);
            this.menu.TabIndex = 2;
            this.menu.Text = "toolStrip1";
            // 
            // add
            // 
            this.add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(33, 22);
            this.add.Text = "Add";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(44, 22);
            this.delete.Text = "Delete";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // accept
            // 
            this.accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.accept.Location = new System.Drawing.Point(252, 469);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(75, 23);
            this.accept.TabIndex = 3;
            this.accept.Text = "Accept";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // datagridMenu
            // 
            this.datagridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.datagridMenu.Name = "datagridMenu";
            this.datagridMenu.Size = new System.Drawing.Size(108, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter.Location = new System.Drawing.Point(706, 0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(11, 508);
            this.splitter.TabIndex = 5;
            this.splitter.TabStop = false;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.addCopy);
            this.rightPanel.Controls.Add(this.transactionView);
            this.rightPanel.Controls.Add(this.accept);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(717, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(339, 508);
            this.rightPanel.TabIndex = 6;
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // addCopy
            // 
            this.addCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addCopy.Location = new System.Drawing.Point(162, 469);
            this.addCopy.Name = "addCopy";
            this.addCopy.Size = new System.Drawing.Size(84, 23);
            this.addCopy.TabIndex = 4;
            this.addCopy.Text = "Add Copy";
            this.addCopy.UseVisualStyleBackColor = true;
            this.addCopy.Click += new System.EventHandler(this.addCopy_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 533);
            this.Controls.Add(this.register);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.menu);
            this.Name = "Main";
            this.Text = "Navy - Net Asset Valuation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.register)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.datagridMenu.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid transactionView;
        private System.Windows.Forms.DataGridView register;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripButton add;
        private System.Windows.Forms.ToolStripButton delete;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.ContextMenuStrip datagridMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.Button addCopy;
    }
}

