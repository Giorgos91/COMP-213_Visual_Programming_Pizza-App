
namespace Pizza_App
{
    partial class user_Form
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
            this.closeButton = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.resetButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(452, 219);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(90, 37);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.ColumnHeadersHeight = 29;
            this.userDataGridView.Location = new System.Drawing.Point(12, 30);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersWidth = 51;
            this.userDataGridView.RowTemplate.Height = 24;
            this.userDataGridView.Size = new System.Drawing.Size(416, 370);
            this.userDataGridView.TabIndex = 9;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(452, 366);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(90, 37);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(452, 289);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 37);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // user_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 421);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.saveButton);
            this.Name = "user_Form";
            this.Text = "User";
            this.Load += new System.EventHandler(this.user_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button saveButton;
    }
}