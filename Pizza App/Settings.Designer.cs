
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
            this.closeButtonSize = new System.Windows.Forms.Button();
            this.SizeDataGridView = new System.Windows.Forms.DataGridView();
            this.resetButtonSize = new System.Windows.Forms.Button();
            this.saveButtonSize = new System.Windows.Forms.Button();
            this.toppingsTabPage = new System.Windows.Forms.TabPage();
            this.closeButonIng = new System.Windows.Forms.Button();
            this.toppingsDataGridView = new System.Windows.Forms.DataGridView();
            this.resetButtonIng = new System.Windows.Forms.Button();
            this.saveButtonIng = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.sizeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeDataGridView)).BeginInit();
            this.toppingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toppingsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.sizeTabPage);
            this.mainTabControl.Controls.Add(this.toppingsTabPage);
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
            this.sizeTabPage.Controls.Add(this.closeButtonSize);
            this.sizeTabPage.Controls.Add(this.SizeDataGridView);
            this.sizeTabPage.Controls.Add(this.resetButtonSize);
            this.sizeTabPage.Controls.Add(this.saveButtonSize);
            this.sizeTabPage.Location = new System.Drawing.Point(4, 29);
            this.sizeTabPage.Name = "sizeTabPage";
            this.sizeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sizeTabPage.Size = new System.Drawing.Size(549, 413);
            this.sizeTabPage.TabIndex = 1;
            this.sizeTabPage.Text = "Size";
            // 
            // closeButtonSize
            // 
            this.closeButtonSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButtonSize.Location = new System.Drawing.Point(441, 201);
            this.closeButtonSize.Name = "closeButtonSize";
            this.closeButtonSize.Size = new System.Drawing.Size(90, 37);
            this.closeButtonSize.TabIndex = 6;
            this.closeButtonSize.Text = "&Close";
            this.closeButtonSize.UseVisualStyleBackColor = true;
            this.closeButtonSize.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SizeDataGridView
            // 
            this.SizeDataGridView.ColumnHeadersHeight = 29;
            this.SizeDataGridView.Location = new System.Drawing.Point(19, 24);
            this.SizeDataGridView.Name = "SizeDataGridView";
            this.SizeDataGridView.RowHeadersWidth = 51;
            this.SizeDataGridView.RowTemplate.Height = 24;
            this.SizeDataGridView.Size = new System.Drawing.Size(416, 370);
            this.SizeDataGridView.TabIndex = 5;
            // 
            // resetButtonSize
            // 
            this.resetButtonSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButtonSize.Location = new System.Drawing.Point(441, 348);
            this.resetButtonSize.Name = "resetButtonSize";
            this.resetButtonSize.Size = new System.Drawing.Size(90, 37);
            this.resetButtonSize.TabIndex = 4;
            this.resetButtonSize.Text = "&Reset";
            this.resetButtonSize.UseVisualStyleBackColor = true;
            this.resetButtonSize.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // saveButtonSize
            // 
            this.saveButtonSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButtonSize.Location = new System.Drawing.Point(441, 271);
            this.saveButtonSize.Name = "saveButtonSize";
            this.saveButtonSize.Size = new System.Drawing.Size(90, 37);
            this.saveButtonSize.TabIndex = 3;
            this.saveButtonSize.Text = "&Save";
            this.saveButtonSize.UseVisualStyleBackColor = true;
            this.saveButtonSize.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // toppingsTabPage
            // 
            this.toppingsTabPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toppingsTabPage.Controls.Add(this.closeButonIng);
            this.toppingsTabPage.Controls.Add(this.toppingsDataGridView);
            this.toppingsTabPage.Controls.Add(this.resetButtonIng);
            this.toppingsTabPage.Controls.Add(this.saveButtonIng);
            this.toppingsTabPage.Location = new System.Drawing.Point(4, 29);
            this.toppingsTabPage.Name = "toppingsTabPage";
            this.toppingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.toppingsTabPage.Size = new System.Drawing.Size(549, 413);
            this.toppingsTabPage.TabIndex = 2;
            this.toppingsTabPage.Text = "Toppings";
            // 
            // closeButonIng
            // 
            this.closeButonIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButonIng.Location = new System.Drawing.Point(442, 193);
            this.closeButonIng.Name = "closeButonIng";
            this.closeButonIng.Size = new System.Drawing.Size(90, 37);
            this.closeButonIng.TabIndex = 7;
            this.closeButonIng.Text = "&Close";
            this.closeButonIng.UseVisualStyleBackColor = true;
            this.closeButonIng.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // toppingsDataGridView
            // 
            this.toppingsDataGridView.ColumnHeadersHeight = 29;
            this.toppingsDataGridView.Location = new System.Drawing.Point(19, 24);
            this.toppingsDataGridView.Name = "toppingsDataGridView";
            this.toppingsDataGridView.RowHeadersWidth = 51;
            this.toppingsDataGridView.RowTemplate.Height = 24;
            this.toppingsDataGridView.Size = new System.Drawing.Size(417, 370);
            this.toppingsDataGridView.TabIndex = 2;
            // 
            // resetButtonIng
            // 
            this.resetButtonIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButtonIng.Location = new System.Drawing.Point(442, 346);
            this.resetButtonIng.Name = "resetButtonIng";
            this.resetButtonIng.Size = new System.Drawing.Size(90, 31);
            this.resetButtonIng.TabIndex = 1;
            this.resetButtonIng.Text = "&Reset";
            this.resetButtonIng.UseVisualStyleBackColor = true;
            this.resetButtonIng.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // saveButtonIng
            // 
            this.saveButtonIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButtonIng.Location = new System.Drawing.Point(442, 269);
            this.saveButtonIng.Name = "saveButtonIng";
            this.saveButtonIng.Size = new System.Drawing.Size(90, 37);
            this.saveButtonIng.TabIndex = 0;
            this.saveButtonIng.Text = "&Save";
            this.saveButtonIng.UseVisualStyleBackColor = true;
            this.saveButtonIng.Click += new System.EventHandler(this.SaveButton_Click);
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
            this.toppingsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toppingsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage sizeTabPage;
        private System.Windows.Forms.TabPage toppingsTabPage;
        private System.Windows.Forms.DataGridView toppingsDataGridView;
        private System.Windows.Forms.Button resetButtonIng;
        private System.Windows.Forms.Button saveButtonIng;
        private System.Windows.Forms.DataGridView SizeDataGridView;
        private System.Windows.Forms.Button resetButtonSize;
        private System.Windows.Forms.Button saveButtonSize;
        private System.Windows.Forms.Button closeButtonSize;
        private System.Windows.Forms.Button closeButonIng;
    }
}