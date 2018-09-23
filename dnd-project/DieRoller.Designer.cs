namespace dnd_project
{
    partial class DieRoller
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
            this.rollOutput = new System.Windows.Forms.RichTextBox();
            this.rollerOutputLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rollerChoice = new System.Windows.Forms.ComboBox();
            this.parentPanel = new System.Windows.Forms.Panel();
            this.generalRollerPanel = new System.Windows.Forms.Panel();
            this.generalRollerGrid = new System.Windows.Forms.TableLayoutPanel();
            this.rollerStringLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.inputModifier = new System.Windows.Forms.NumericUpDown();
            this.inputDieSize = new System.Windows.Forms.NumericUpDown();
            this.rollerInputLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputDieNumber = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rollStringInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rollerInputLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.generalRollButton = new System.Windows.Forms.Button();
            this.attributeRollerPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.attributeRollButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.parentPanel.SuspendLayout();
            this.generalRollerPanel.SuspendLayout();
            this.generalRollerGrid.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDieSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDieNumber)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.attributeRollerPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // rollOutput
            // 
            this.rollOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.rollOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollOutput.Location = new System.Drawing.Point(3, 21);
            this.rollOutput.Name = "rollOutput";
            this.rollOutput.ReadOnly = true;
            this.rollOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rollOutput.Size = new System.Drawing.Size(468, 179);
            this.rollOutput.TabIndex = 2;
            this.rollOutput.Text = "";
            // 
            // rollerOutputLabel
            // 
            this.rollerOutputLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rollerOutputLabel.AutoSize = true;
            this.rollerOutputLabel.Location = new System.Drawing.Point(3, 2);
            this.rollerOutputLabel.Name = "rollerOutputLabel";
            this.rollerOutputLabel.Size = new System.Drawing.Size(60, 13);
            this.rollerOutputLabel.TabIndex = 7;
            this.rollerOutputLabel.Text = "Roll Output";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rollerOutputLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rollOutput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rollerChoice, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.parentPanel, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.914729F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.08527F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(474, 351);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // rollerChoice
            // 
            this.rollerChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rollerChoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rollerChoice.FormattingEnabled = true;
            this.rollerChoice.Items.AddRange(new object[] {
            "General",
            "Attribute"});
            this.rollerChoice.Location = new System.Drawing.Point(3, 206);
            this.rollerChoice.Name = "rollerChoice";
            this.rollerChoice.Size = new System.Drawing.Size(121, 21);
            this.rollerChoice.TabIndex = 11;
            this.rollerChoice.SelectedIndexChanged += new System.EventHandler(this.rollerChoice_SelectedIndexChanged);
            // 
            // parentPanel
            // 
            this.parentPanel.Controls.Add(this.generalRollerPanel);
            this.parentPanel.Controls.Add(this.attributeRollerPanel);
            this.parentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentPanel.Location = new System.Drawing.Point(3, 234);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.Size = new System.Drawing.Size(468, 114);
            this.parentPanel.TabIndex = 12;
            // 
            // generalRollerPanel
            // 
            this.generalRollerPanel.Controls.Add(this.generalRollerGrid);
            this.generalRollerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalRollerPanel.Location = new System.Drawing.Point(0, 0);
            this.generalRollerPanel.Name = "generalRollerPanel";
            this.generalRollerPanel.Size = new System.Drawing.Size(468, 114);
            this.generalRollerPanel.TabIndex = 11;
            // 
            // generalRollerGrid
            // 
            this.generalRollerGrid.ColumnCount = 3;
            this.generalRollerGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.95726F));
            this.generalRollerGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.generalRollerGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.04274F));
            this.generalRollerGrid.Controls.Add(this.rollerStringLabel, 0, 0);
            this.generalRollerGrid.Controls.Add(this.tableLayoutPanel3, 2, 1);
            this.generalRollerGrid.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.generalRollerGrid.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.generalRollerGrid.Controls.Add(this.label3, 1, 1);
            this.generalRollerGrid.Controls.Add(this.generalRollButton, 2, 2);
            this.generalRollerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalRollerGrid.Location = new System.Drawing.Point(0, 0);
            this.generalRollerGrid.Name = "generalRollerGrid";
            this.generalRollerGrid.RowCount = 2;
            this.generalRollerGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.generalRollerGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.generalRollerGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.generalRollerGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.generalRollerGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.generalRollerGrid.Size = new System.Drawing.Size(468, 114);
            this.generalRollerGrid.TabIndex = 8;
            // 
            // rollerStringLabel
            // 
            this.rollerStringLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rollerStringLabel.AutoSize = true;
            this.rollerStringLabel.Location = new System.Drawing.Point(3, 3);
            this.rollerStringLabel.Name = "rollerStringLabel";
            this.rollerStringLabel.Size = new System.Drawing.Size(55, 13);
            this.rollerStringLabel.TabIndex = 5;
            this.rollerStringLabel.Text = "Roll String";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel3.Controls.Add(this.inputModifier, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.inputDieSize, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.rollerInputLabel1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.inputDieNumber, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(214, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(251, 27);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // inputModifier
            // 
            this.inputModifier.Location = new System.Drawing.Point(185, 3);
            this.inputModifier.Name = "inputModifier";
            this.inputModifier.Size = new System.Drawing.Size(62, 20);
            this.inputModifier.TabIndex = 7;
            // 
            // inputDieSize
            // 
            this.inputDieSize.Location = new System.Drawing.Point(92, 3);
            this.inputDieSize.Name = "inputDieSize";
            this.inputDieSize.Size = new System.Drawing.Size(59, 20);
            this.inputDieSize.TabIndex = 6;
            // 
            // rollerInputLabel1
            // 
            this.rollerInputLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rollerInputLabel1.AutoSize = true;
            this.rollerInputLabel1.Location = new System.Drawing.Point(71, 0);
            this.rollerInputLabel1.Name = "rollerInputLabel1";
            this.rollerInputLabel1.Size = new System.Drawing.Size(15, 27);
            this.rollerInputLabel1.TabIndex = 0;
            this.rollerInputLabel1.Text = "d";
            this.rollerInputLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "+/-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputDieNumber
            // 
            this.inputDieNumber.Location = new System.Drawing.Point(3, 3);
            this.inputDieNumber.Name = "inputDieNumber";
            this.inputDieNumber.Size = new System.Drawing.Size(62, 20);
            this.inputDieNumber.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.rollStringInput, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(165, 27);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // rollStringInput
            // 
            this.rollStringInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollStringInput.Location = new System.Drawing.Point(3, 3);
            this.rollStringInput.Name = "rollStringInput";
            this.rollStringInput.Size = new System.Drawing.Size(159, 20);
            this.rollStringInput.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.rollerInputLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(211, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(257, 20);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // rollerInputLabel
            // 
            this.rollerInputLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rollerInputLabel.AutoSize = true;
            this.rollerInputLabel.Location = new System.Drawing.Point(3, 3);
            this.rollerInputLabel.Name = "rollerInputLabel";
            this.rollerInputLabel.Size = new System.Drawing.Size(61, 13);
            this.rollerInputLabel.TabIndex = 6;
            this.rollerInputLabel.Text = "Roller Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(174, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "or";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generalRollButton
            // 
            this.generalRollButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.generalRollerGrid.SetColumnSpan(this.generalRollButton, 3);
            this.generalRollButton.Location = new System.Drawing.Point(175, 74);
            this.generalRollButton.Name = "generalRollButton";
            this.generalRollButton.Size = new System.Drawing.Size(117, 32);
            this.generalRollButton.TabIndex = 3;
            this.generalRollButton.Text = "Roll";
            this.generalRollButton.UseVisualStyleBackColor = true;
            this.generalRollButton.Click += new System.EventHandler(this.generalRollButton_Click);
            // 
            // attributeRollerPanel
            // 
            this.attributeRollerPanel.Controls.Add(this.tableLayoutPanel5);
            this.attributeRollerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attributeRollerPanel.Location = new System.Drawing.Point(0, 0);
            this.attributeRollerPanel.Name = "attributeRollerPanel";
            this.attributeRollerPanel.Size = new System.Drawing.Size(468, 114);
            this.attributeRollerPanel.TabIndex = 12;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.attributeRollButton, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(468, 114);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // attributeRollButton
            // 
            this.attributeRollButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attributeRollButton.Location = new System.Drawing.Point(173, 42);
            this.attributeRollButton.Name = "attributeRollButton";
            this.attributeRollButton.Size = new System.Drawing.Size(122, 30);
            this.attributeRollButton.TabIndex = 0;
            this.attributeRollButton.Text = "Roll Attributes";
            this.attributeRollButton.UseVisualStyleBackColor = true;
            this.attributeRollButton.Click += new System.EventHandler(this.attributeRollButton_Click);
            // 
            // DieRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 351);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 390);
            this.MinimumSize = new System.Drawing.Size(490, 390);
            this.Name = "DieRoller";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Die Roller";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.parentPanel.ResumeLayout(false);
            this.generalRollerPanel.ResumeLayout(false);
            this.generalRollerGrid.ResumeLayout(false);
            this.generalRollerGrid.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDieSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDieNumber)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.attributeRollerPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rollOutput;
        private System.Windows.Forms.Label rollerOutputLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox rollerChoice;
        private System.Windows.Forms.Panel parentPanel;
        private System.Windows.Forms.Panel attributeRollerPanel;
        private System.Windows.Forms.Panel generalRollerPanel;
        private System.Windows.Forms.TableLayoutPanel generalRollerGrid;
        private System.Windows.Forms.Label rollerStringLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label rollerInputLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox rollStringInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label rollerInputLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generalRollButton;
        private System.Windows.Forms.Button attributeRollButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.NumericUpDown inputModifier;
        private System.Windows.Forms.NumericUpDown inputDieSize;
        private System.Windows.Forms.NumericUpDown inputDieNumber;
    }
}