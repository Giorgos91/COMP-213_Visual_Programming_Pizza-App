
namespace Pizza_App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.SizeGroupBox = new System.Windows.Forms.GroupBox();
            this.sizeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FreeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IngredientsGroupBox = new System.Windows.Forms.GroupBox();
            this.ingFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.CostLabel = new System.Windows.Forms.Label();
            this.TotalCostTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CurrentTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.settingsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SizeGroupBox.SuspendLayout();
            this.IngredientsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome  to \" Pizza \" ";
            // 
            // SizeGroupBox
            // 
            this.SizeGroupBox.Controls.Add(this.sizeFlowLayoutPanel);
            this.SizeGroupBox.Controls.Add(this.FreeTextBox);
            this.SizeGroupBox.Controls.Add(this.label5);
            this.SizeGroupBox.Controls.Add(this.label2);
            this.SizeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeGroupBox.Location = new System.Drawing.Point(53, 95);
            this.SizeGroupBox.Name = "SizeGroupBox";
            this.SizeGroupBox.Size = new System.Drawing.Size(413, 172);
            this.SizeGroupBox.TabIndex = 2;
            this.SizeGroupBox.TabStop = false;
            this.SizeGroupBox.Text = "Size";
            // 
            // sizeFlowLayoutPanel
            // 
            this.sizeFlowLayoutPanel.AutoScroll = true;
            this.sizeFlowLayoutPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.sizeFlowLayoutPanel.Location = new System.Drawing.Point(16, 54);
            this.sizeFlowLayoutPanel.Name = "sizeFlowLayoutPanel";
            this.sizeFlowLayoutPanel.Size = new System.Drawing.Size(231, 107);
            this.sizeFlowLayoutPanel.TabIndex = 8;
            // 
            // FreeTextBox
            // 
            this.FreeTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FreeTextBox.ForeColor = System.Drawing.Color.Red;
            this.FreeTextBox.Location = new System.Drawing.Point(301, 87);
            this.FreeTextBox.Name = "FreeTextBox";
            this.FreeTextBox.ReadOnly = true;
            this.FreeTextBox.Size = new System.Drawing.Size(91, 27);
            this.FreeTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "No of FREE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please select the size:";
            // 
            // IngredientsGroupBox
            // 
            this.IngredientsGroupBox.Controls.Add(this.ingFlowLayoutPanel);
            this.IngredientsGroupBox.Controls.Add(this.label4);
            this.IngredientsGroupBox.Enabled = false;
            this.IngredientsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientsGroupBox.Location = new System.Drawing.Point(59, 289);
            this.IngredientsGroupBox.Name = "IngredientsGroupBox";
            this.IngredientsGroupBox.Size = new System.Drawing.Size(407, 173);
            this.IngredientsGroupBox.TabIndex = 3;
            this.IngredientsGroupBox.TabStop = false;
            this.IngredientsGroupBox.Text = "Ingredients";
            // 
            // ingFlowLayoutPanel
            // 
            this.ingFlowLayoutPanel.AutoScroll = true;
            this.ingFlowLayoutPanel.Location = new System.Drawing.Point(10, 67);
            this.ingFlowLayoutPanel.Name = "ingFlowLayoutPanel";
            this.ingFlowLayoutPanel.Size = new System.Drawing.Size(376, 106);
            this.ingFlowLayoutPanel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Please select the ingredients: \r\nEach extra has cost 0.75 ";
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(492, 331);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(111, 43);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.AutoSize = true;
            this.OrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderButton.Location = new System.Drawing.Point(630, 331);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(122, 43);
            this.OrderButton.TabIndex = 5;
            this.OrderButton.Text = "Place &Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Visible = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(487, 292);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(119, 25);
            this.CostLabel.TabIndex = 6;
            this.CostLabel.Text = "Total Cost:";
            // 
            // TotalCostTextBox
            // 
            this.TotalCostTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TotalCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostTextBox.ForeColor = System.Drawing.Color.Red;
            this.TotalCostTextBox.Location = new System.Drawing.Point(630, 289);
            this.TotalCostTextBox.Name = "TotalCostTextBox";
            this.TotalCostTextBox.ReadOnly = true;
            this.TotalCostTextBox.Size = new System.Drawing.Size(122, 30);
            this.TotalCostTextBox.TabIndex = 7;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(492, 392);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(111, 43);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TimeMaskedTextBox
            // 
            this.TimeMaskedTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TimeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeMaskedTextBox.ForeColor = System.Drawing.Color.Red;
            this.TimeMaskedTextBox.Location = new System.Drawing.Point(682, 226);
            this.TimeMaskedTextBox.Mask = "00:00";
            this.TimeMaskedTextBox.Name = "TimeMaskedTextBox";
            this.TimeMaskedTextBox.Size = new System.Drawing.Size(70, 30);
            this.TimeMaskedTextBox.TabIndex = 9;
            this.TimeMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(487, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Set Delivery time: ";
            // 
            // CurrentTimeMaskedTextBox
            // 
            this.CurrentTimeMaskedTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentTimeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTimeMaskedTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CurrentTimeMaskedTextBox.Location = new System.Drawing.Point(608, 149);
            this.CurrentTimeMaskedTextBox.Mask = "00:00";
            this.CurrentTimeMaskedTextBox.Name = "CurrentTimeMaskedTextBox";
            this.CurrentTimeMaskedTextBox.Size = new System.Drawing.Size(67, 30);
            this.CurrentTimeMaskedTextBox.TabIndex = 11;
            this.CurrentTimeMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CurrentTimeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // settingsToolStrip
            // 
            this.settingsToolStrip.Name = "settingsToolStrip";
            this.settingsToolStrip.Size = new System.Drawing.Size(88, 24);
            this.settingsToolStrip.Text = "SETTINGS";
            this.settingsToolStrip.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStrip,
            this.userToolStrip,
            this.aboutToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStrip
            // 
            this.userToolStrip.Name = "userToolStrip";
            this.userToolStrip.Size = new System.Drawing.Size(58, 24);
            this.userToolStrip.Text = "USER";
            this.userToolStrip.Click += new System.EventHandler(this.userToolStrip_Click);
            // 
            // aboutToolStrip
            // 
            this.aboutToolStrip.Name = "aboutToolStrip";
            this.aboutToolStrip.Size = new System.Drawing.Size(71, 24);
            this.aboutToolStrip.Text = "ABOUT";
            this.aboutToolStrip.Click += new System.EventHandler(this.aboutToolStrip_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pizza_App.Properties.Resources.pizza_logo;
            this.pictureBox1.Location = new System.Drawing.Point(656, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.CurrentTimeMaskedTextBox);
            this.Controls.Add(this.TimeMaskedTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TotalCostTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.IngredientsGroupBox);
            this.Controls.Add(this.SizeGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza App";
            this.SizeGroupBox.ResumeLayout(false);
            this.SizeGroupBox.PerformLayout();
            this.IngredientsGroupBox.ResumeLayout(false);
            this.IngredientsGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SizeGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox IngredientsGroupBox;
        private System.Windows.Forms.TextBox FreeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox TotalCostTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.MaskedTextBox TimeMaskedTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox CurrentTimeMaskedTextBox;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel sizeFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ingFlowLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem userToolStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStrip;
    }
}

