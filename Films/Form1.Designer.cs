namespace Films
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dwg1 = new DataGridView();
            AddButton = new Button();
            SrchButton = new Button();
            txtName = new TextBox();
            txtAutor = new TextBox();
            txtYear = new TextBox();
            SearchTxt = new TextBox();
            DelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dwg1).BeginInit();
            SuspendLayout();
            // 
            // dwg1
            // 
            dwg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dwg1.Location = new Point(12, 12);
            dwg1.Name = "dwg1";
            dwg1.Size = new Size(552, 404);
            dwg1.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(591, 184);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // SrchButton
            // 
            SrchButton.Location = new Point(635, 343);
            SrchButton.Name = "SrchButton";
            SrchButton.Size = new Size(75, 23);
            SrchButton.TabIndex = 3;
            SrchButton.Text = "Search";
            SrchButton.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(591, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(179, 23);
            txtName.TabIndex = 4;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(591, 76);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(179, 23);
            txtAutor.TabIndex = 5;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(591, 119);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(179, 23);
            txtYear.TabIndex = 6;
            // 
            // SearchTxt
            // 
            SearchTxt.Location = new Point(623, 293);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(100, 23);
            SearchTxt.TabIndex = 7;
            // 
            // DelButton
            // 
            DelButton.Location = new Point(695, 184);
            DelButton.Name = "DelButton";
            DelButton.Size = new Size(75, 23);
            DelButton.TabIndex = 8;
            DelButton.Text = "Delete";
            DelButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DelButton);
            Controls.Add(SearchTxt);
            Controls.Add(txtYear);
            Controls.Add(txtAutor);
            Controls.Add(txtName);
            Controls.Add(SrchButton);
            Controls.Add(AddButton);
            Controls.Add(dwg1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dwg1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dwg1;
        private Button AddButton;
        private Button SrchButton;
        private TextBox txtName;
        private TextBox txtAutor;
        private TextBox txtYear;
        private TextBox SearchTxt;
        private Button DelButton;
    }
}
