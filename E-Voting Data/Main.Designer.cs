namespace E_Voting_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collegesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.collegesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.classFilter = new System.Windows.Forms.ComboBox();
            this.schoolFilter = new System.Windows.Forms.ComboBox();
            this.collegeFilter = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.mainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.collegesToolStripMenuItem,
            this.addToolStripMenuItem,
            this.importToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(744, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "Menu";
            this.mainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainMenu_ItemClicked);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.userToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.userToolStripMenuItem.Text = "Main";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            this.userToolStripMenuItem.MouseLeave += new System.EventHandler(this.userToolStripMenuItem_MouseLeave);
            this.userToolStripMenuItem.MouseHover += new System.EventHandler(this.userToolStripMenuItem_MouseHover);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("profileToolStripMenuItem.Image")));
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // collegesToolStripMenuItem
            // 
            this.collegesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.classesToolStripMenuItem,
            this.schoolsToolStripMenuItem,
            this.collegesToolStripMenuItem1,
            this.usersToolStripMenuItem});
            this.collegesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.collegesToolStripMenuItem.Name = "collegesToolStripMenuItem";
            this.collegesToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.collegesToolStripMenuItem.Text = "View";
            this.collegesToolStripMenuItem.Click += new System.EventHandler(this.collegesToolStripMenuItem_Click);
            this.collegesToolStripMenuItem.MouseLeave += new System.EventHandler(this.collegesToolStripMenuItem_MouseLeave);
            this.collegesToolStripMenuItem.MouseHover += new System.EventHandler(this.collegesToolStripMenuItem_MouseHover);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("classesToolStripMenuItem.Image")));
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.classesToolStripMenuItem.Text = "Classes";
            this.classesToolStripMenuItem.Click += new System.EventHandler(this.classesToolStripMenuItem_Click);
            // 
            // schoolsToolStripMenuItem
            // 
            this.schoolsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("schoolsToolStripMenuItem.Image")));
            this.schoolsToolStripMenuItem.Name = "schoolsToolStripMenuItem";
            this.schoolsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.schoolsToolStripMenuItem.Text = "Schools";
            this.schoolsToolStripMenuItem.Click += new System.EventHandler(this.schoolsToolStripMenuItem_Click);
            // 
            // collegesToolStripMenuItem1
            // 
            this.collegesToolStripMenuItem1.Name = "collegesToolStripMenuItem1";
            this.collegesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.collegesToolStripMenuItem1.Text = "Colleges";
            this.collegesToolStripMenuItem1.Click += new System.EventHandler(this.collegesToolStripMenuItem1_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem1,
            this.classesToolStripMenuItem1,
            this.schoolsToolStripMenuItem1,
            this.collegesToolStripMenuItem2,
            this.usersToolStripMenuItem1});
            this.addToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            this.addToolStripMenuItem.MouseLeave += new System.EventHandler(this.addToolStripMenuItem_MouseLeave);
            this.addToolStripMenuItem.MouseHover += new System.EventHandler(this.addToolStripMenuItem_MouseHover);
            // 
            // studentsToolStripMenuItem1
            // 
            this.studentsToolStripMenuItem1.Name = "studentsToolStripMenuItem1";
            this.studentsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.studentsToolStripMenuItem1.Text = "Students";
            this.studentsToolStripMenuItem1.Click += new System.EventHandler(this.studentsToolStripMenuItem1_Click);
            // 
            // classesToolStripMenuItem1
            // 
            this.classesToolStripMenuItem1.Name = "classesToolStripMenuItem1";
            this.classesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.classesToolStripMenuItem1.Text = "Classes";
            this.classesToolStripMenuItem1.Click += new System.EventHandler(this.classesToolStripMenuItem1_Click);
            // 
            // schoolsToolStripMenuItem1
            // 
            this.schoolsToolStripMenuItem1.Name = "schoolsToolStripMenuItem1";
            this.schoolsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.schoolsToolStripMenuItem1.Text = "Schools";
            this.schoolsToolStripMenuItem1.Click += new System.EventHandler(this.schoolsToolStripMenuItem1_Click);
            // 
            // collegesToolStripMenuItem2
            // 
            this.collegesToolStripMenuItem2.Name = "collegesToolStripMenuItem2";
            this.collegesToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.collegesToolStripMenuItem2.Text = "Colleges";
            this.collegesToolStripMenuItem2.Click += new System.EventHandler(this.collegesToolStripMenuItem2_Click);
            // 
            // usersToolStripMenuItem1
            // 
            this.usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            this.usersToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.usersToolStripMenuItem1.Text = "Users";
            this.usersToolStripMenuItem1.Click += new System.EventHandler(this.usersToolStripMenuItem1_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem2});
            this.importToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.MouseLeave += new System.EventHandler(this.importToolStripMenuItem_MouseLeave);
            this.importToolStripMenuItem.MouseHover += new System.EventHandler(this.importToolStripMenuItem_MouseHover);
            // 
            // studentsToolStripMenuItem2
            // 
            this.studentsToolStripMenuItem2.Name = "studentsToolStripMenuItem2";
            this.studentsToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.studentsToolStripMenuItem2.Text = "Students";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.MouseLeave += new System.EventHandler(this.settingsToolStripMenuItem_MouseLeave);
            this.settingsToolStripMenuItem.MouseHover += new System.EventHandler(this.settingsToolStripMenuItem_MouseHover);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.quickHelpToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.MouseLeave += new System.EventHandler(this.helpToolStripMenuItem_MouseLeave);
            this.helpToolStripMenuItem.MouseHover += new System.EventHandler(this.helpToolStripMenuItem_MouseHover);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // quickHelpToolStripMenuItem
            // 
            this.quickHelpToolStripMenuItem.Name = "quickHelpToolStripMenuItem";
            this.quickHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quickHelpToolStripMenuItem.Text = "Quick Help";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.classFilter);
            this.panel1.Controls.Add(this.schoolFilter);
            this.panel1.Controls.Add(this.collegeFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 430);
            this.panel1.TabIndex = 2;
            // 
            // classFilter
            // 
            this.classFilter.FormattingEnabled = true;
            this.classFilter.Location = new System.Drawing.Point(34, 144);
            this.classFilter.Name = "classFilter";
            this.classFilter.Size = new System.Drawing.Size(121, 21);
            this.classFilter.TabIndex = 2;
            this.classFilter.Text = "Classes";
            // 
            // schoolFilter
            // 
            this.schoolFilter.FormattingEnabled = true;
            this.schoolFilter.Location = new System.Drawing.Point(34, 85);
            this.schoolFilter.Name = "schoolFilter";
            this.schoolFilter.Size = new System.Drawing.Size(121, 21);
            this.schoolFilter.TabIndex = 1;
            this.schoolFilter.Text = "Schools";
            this.schoolFilter.SelectedIndexChanged += new System.EventHandler(this.schoolFilter_SelectedIndexChanged);
            // 
            // collegeFilter
            // 
            this.collegeFilter.FormattingEnabled = true;
            this.collegeFilter.Location = new System.Drawing.Point(34, 32);
            this.collegeFilter.Name = "collegeFilter";
            this.collegeFilter.Size = new System.Drawing.Size(121, 21);
            this.collegeFilter.TabIndex = 0;
            this.collegeFilter.Text = "Colleges";
            this.collegeFilter.SelectedIndexChanged += new System.EventHandler(this.collegeFilter_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.dataTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(206, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 430);
            this.panel2.TabIndex = 3;
            // 
            // dataTable
            // 
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTable.BackgroundColor = System.Drawing.Color.White;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTable.Location = new System.Drawing.Point(0, 0);
            this.dataTable.Name = "dataTable";
            this.dataTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTable.Size = new System.Drawing.Size(538, 430);
            this.dataTable.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collegesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collegesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem schoolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem collegesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickHelpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.ComboBox collegeFilter;
        private System.Windows.Forms.ComboBox classFilter;
        private System.Windows.Forms.ComboBox schoolFilter;
    }
}