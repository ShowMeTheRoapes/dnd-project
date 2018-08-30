namespace dnd_project
{
    partial class NewCharacter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCharacter));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainButton = new System.Windows.Forms.Button();
            this.summaryBox = new System.Windows.Forms.GroupBox();
            this.charismaLabel = new System.Windows.Forms.Label();
            this.wisdomLabel = new System.Windows.Forms.Label();
            this.intelligenceLabel = new System.Windows.Forms.Label();
            this.constitutionLabel = new System.Windows.Forms.Label();
            this.dexterityLabel = new System.Windows.Forms.Label();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.attributesLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.namePage = new System.Windows.Forms.TabPage();
            this.racePage = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.summaryBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mainButton
            // 
            this.mainButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainButton.Location = new System.Drawing.Point(0, 512);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(1148, 33);
            this.mainButton.TabIndex = 1;
            this.mainButton.Text = "Back To Main";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // summaryBox
            // 
            this.summaryBox.Controls.Add(this.charismaLabel);
            this.summaryBox.Controls.Add(this.wisdomLabel);
            this.summaryBox.Controls.Add(this.intelligenceLabel);
            this.summaryBox.Controls.Add(this.constitutionLabel);
            this.summaryBox.Controls.Add(this.dexterityLabel);
            this.summaryBox.Controls.Add(this.strengthLabel);
            this.summaryBox.Controls.Add(this.attributesLabel);
            this.summaryBox.Controls.Add(this.classLabel);
            this.summaryBox.Controls.Add(this.raceLabel);
            this.summaryBox.Controls.Add(this.nameLabel);
            this.summaryBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.summaryBox.Location = new System.Drawing.Point(0, 24);
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.Size = new System.Drawing.Size(153, 488);
            this.summaryBox.TabIndex = 2;
            this.summaryBox.TabStop = false;
            this.summaryBox.Text = "Character Summary";
            this.summaryBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // charismaLabel
            // 
            this.charismaLabel.AutoSize = true;
            this.charismaLabel.Location = new System.Drawing.Point(26, 317);
            this.charismaLabel.Name = "charismaLabel";
            this.charismaLabel.Size = new System.Drawing.Size(53, 13);
            this.charismaLabel.TabIndex = 9;
            this.charismaLabel.Text = "Charisma:";
            // 
            // wisdomLabel
            // 
            this.wisdomLabel.AutoSize = true;
            this.wisdomLabel.Location = new System.Drawing.Point(26, 295);
            this.wisdomLabel.Name = "wisdomLabel";
            this.wisdomLabel.Size = new System.Drawing.Size(48, 13);
            this.wisdomLabel.TabIndex = 8;
            this.wisdomLabel.Text = "Wisdom:";
            // 
            // intelligenceLabel
            // 
            this.intelligenceLabel.AutoSize = true;
            this.intelligenceLabel.Location = new System.Drawing.Point(26, 271);
            this.intelligenceLabel.Name = "intelligenceLabel";
            this.intelligenceLabel.Size = new System.Drawing.Size(64, 13);
            this.intelligenceLabel.TabIndex = 7;
            this.intelligenceLabel.Text = "Intelligence:";
            // 
            // constitutionLabel
            // 
            this.constitutionLabel.AutoSize = true;
            this.constitutionLabel.Location = new System.Drawing.Point(26, 248);
            this.constitutionLabel.Name = "constitutionLabel";
            this.constitutionLabel.Size = new System.Drawing.Size(65, 13);
            this.constitutionLabel.TabIndex = 6;
            this.constitutionLabel.Text = "Constitution:";
            // 
            // dexterityLabel
            // 
            this.dexterityLabel.AutoSize = true;
            this.dexterityLabel.Location = new System.Drawing.Point(26, 225);
            this.dexterityLabel.Name = "dexterityLabel";
            this.dexterityLabel.Size = new System.Drawing.Size(51, 13);
            this.dexterityLabel.TabIndex = 5;
            this.dexterityLabel.Text = "Dexterity:";
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Location = new System.Drawing.Point(26, 202);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(50, 13);
            this.strengthLabel.TabIndex = 4;
            this.strengthLabel.Text = "Strength:";
            // 
            // attributesLabel
            // 
            this.attributesLabel.AutoSize = true;
            this.attributesLabel.Location = new System.Drawing.Point(7, 171);
            this.attributesLabel.Name = "attributesLabel";
            this.attributesLabel.Size = new System.Drawing.Size(54, 13);
            this.attributesLabel.TabIndex = 3;
            this.attributesLabel.Text = "Attributes:";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(7, 128);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(35, 13);
            this.classLabel.TabIndex = 2;
            this.classLabel.Text = "Class:";
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Location = new System.Drawing.Point(6, 81);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(39, 13);
            this.raceLabel.TabIndex = 1;
            this.raceLabel.Text = "Race: ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(110, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Character Name Here";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.namePage);
            this.tabControl.Controls.Add(this.racePage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(153, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(995, 488);
            this.tabControl.TabIndex = 3;
            // 
            // namePage
            // 
            this.namePage.Location = new System.Drawing.Point(4, 22);
            this.namePage.Name = "namePage";
            this.namePage.Padding = new System.Windows.Forms.Padding(3);
            this.namePage.Size = new System.Drawing.Size(987, 462);
            this.namePage.TabIndex = 0;
            this.namePage.Text = "Names";
            this.namePage.UseVisualStyleBackColor = true;
            // 
            // racePage
            // 
            this.racePage.Location = new System.Drawing.Point(4, 22);
            this.racePage.Name = "racePage";
            this.racePage.Padding = new System.Windows.Forms.Padding(3);
            this.racePage.Size = new System.Drawing.Size(987, 462);
            this.racePage.TabIndex = 1;
            this.racePage.Text = "Race";
            this.racePage.UseVisualStyleBackColor = true;
            // 
            // NewCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 545);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.summaryBox);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "NewCharacter";
            this.Text = "NewCharacter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.summaryBox.ResumeLayout(false);
            this.summaryBox.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.GroupBox summaryBox;
        private System.Windows.Forms.Label charismaLabel;
        private System.Windows.Forms.Label wisdomLabel;
        private System.Windows.Forms.Label intelligenceLabel;
        private System.Windows.Forms.Label constitutionLabel;
        private System.Windows.Forms.Label dexterityLabel;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Label attributesLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage namePage;
        private System.Windows.Forms.TabPage racePage;
    }
}