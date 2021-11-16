
namespace Pizza_App
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.sizeTabPage = new System.Windows.Forms.TabPage();
            this.SizeDataGridView = new System.Windows.Forms.DataGridView();
            this.ResetButtonSize = new System.Windows.Forms.Button();
            this.SaveButtonSize = new System.Windows.Forms.Button();
            this.IngreedientsTabPage = new System.Windows.Forms.TabPage();
            this.IngreedientsDataGridView = new System.Windows.Forms.DataGridView();
            this.ResetButtonIng = new System.Windows.Forms.Button();
            this.SaveButtonIng = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.sizeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeDataGridView)).BeginInit();
            this.IngreedientsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IngreedientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.sizeTabPage);
            this.mainTabControl.Controls.Add(this.IngreedientsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(557, 446);
            this.mainTabControl.TabIndex = 0;
            // 
            // sizeTabPage
            // 
            this.sizeTabPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sizeTabPage.Controls.Add(this.SizeDataGridView);
            this.sizeTabPage.Controls.Add(this.ResetButtonSize);
            this.sizeTabPage.Controls.Add(this.SaveButtonSize);
            this.sizeTabPage.Location = new System.Drawing.Point(4, 29);
            this.sizeTabPage.Name = "sizeTabPage";
            this.sizeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sizeTabPage.Size = new System.Drawing.Size(549, 413);
            this.sizeTabPage.TabIndex = 1;
            this.sizeTabPage.Text = "Size";
            // 
            // SizeDataGridView
            // 
            this.SizeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SizeDataGridView.Location = new System.Drawing.Point(19, 24);
            this.SizeDataGridView.Name = "SizeDataGridView";
            this.SizeDataGridView.RowHeadersWidth = 51;
            this.SizeDataGridView.RowTemplate.Height = 24;
            this.SizeDataGridView.Size = new System.Drawing.Size(397, 370);
            this.SizeDataGridView.TabIndex = 5;
            // 
            // ResetButtonSize
            // 
            this.ResetButtonSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButtonSize.Location = new System.Drawing.Point(441, 348);
            this.ResetButtonSize.Name = "ResetButtonSize";
            this.ResetButtonSize.Size = new System.Drawing.Size(90, 31);
            this.ResetButtonSize.TabIndex = 4;
            this.ResetButtonSize.Text = "&Reset";
            this.ResetButtonSize.UseVisualStyleBackColor = true;
            // 
            // SaveButtonSize
            // 
            this.SaveButtonSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButtonSize.Location = new System.Drawing.Point(441, 271);
            this.SaveButtonSize.Name = "SaveButtonSize";
            this.SaveButtonSize.Size = new System.Drawing.Size(90, 37);
            this.SaveButtonSize.TabIndex = 3;
            this.SaveButtonSize.Text = "&Save";
            this.SaveButtonSize.UseVisualStyleBackColor = true;
            // 
            // IngreedientsTabPage
            // 
            this.IngreedientsTabPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IngreedientsTabPage.Controls.Add(this.IngreedientsDataGridView);
            this.IngreedientsTabPage.Controls.Add(this.ResetButtonIng);
            this.IngreedientsTabPage.Controls.Add(this.SaveButtonIng);
            this.IngreedientsTabPage.Location = new System.Drawing.Point(4, 29);
            this.IngreedientsTabPage.Name = "IngreedientsTabPage";
            this.IngreedientsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.IngreedientsTabPage.Size = new System.Drawing.Size(549, 413);
            this.IngreedientsTabPage.TabIndex = 2;
            this.IngreedientsTabPage.Text = "Ingreedients";
            // 
            // IngreedientsDataGridView
            // 
            this.IngreedientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngreedientsDataGridView.Location = new System.Drawing.Point(19, 24);
            this.IngreedientsDataGridView.Name = "IngreedientsDataGridView";
            this.IngreedientsDataGridView.RowHeadersWidth = 51;
            this.IngreedientsDataGridView.RowTemplate.Height = 24;
            this.IngreedientsDataGridView.Size = new System.Drawing.Size(397, 370);
            this.IngreedientsDataGridView.TabIndex = 2;
            // 
            // ResetButtonIng
            // 
            this.ResetButtonIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButtonIng.Location = new System.Drawing.Point(442, 346);
            this.ResetButtonIng.Name = "ResetButtonIng";
            this.ResetButtonIng.Size = new System.Drawing.Size(90, 31);
            this.ResetButtonIng.TabIndex = 1;
            this.ResetButtonIng.Text = "&Reset";
            this.ResetButtonIng.UseVisualStyleBackColor = true;
            // 
            // SaveButtonIng
            // 
            this.SaveButtonIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButtonIng.Location = new System.Drawing.Point(442, 269);
            this.SaveButtonIng.Name = "SaveButtonIng";
            this.SaveButtonIng.Size = new System.Drawing.Size(90, 37);
            this.SaveButtonIng.TabIndex = 0;
            this.SaveButtonIng.Text = "&Save";
            this.SaveButtonIng.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 446);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.mainTabControl.ResumeLayout(false);
            this.sizeTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SizeDataGridView)).EndInit();
            this.IngreedientsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IngreedientsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage sizeTabPage;
        private System.Windows.Forms.TabPage IngreedientsTabPage;
        private System.Windows.Forms.DataGridView IngreedientsDataGridView;
        private System.Windows.Forms.Button ResetButtonIng;
        private System.Windows.Forms.Button SaveButtonIng;
        private System.Windows.Forms.DataGridView SizeDataGridView;
        private System.Windows.Forms.Button ResetButtonSize;
        private System.Windows.Forms.Button SaveButtonSize;
    }
}