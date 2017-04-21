namespace BookFinder
{
    partial class CategoryAndTag
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
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.tbTag = new System.Windows.Forms.TextBox();
            this.btnTagAdd = new System.Windows.Forms.Button();
            this.btnTagDelete = new System.Windows.Forms.Button();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.lbTag = new System.Windows.Forms.ListBox();
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(26, 304);
            this.tbCategory.Multiline = true;
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(201, 41);
            this.tbCategory.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblMessage.Location = new System.Drawing.Point(297, 29);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(87, 24);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Message";
            this.lblMessage.Visible = false;
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(301, 302);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(55, 43);
            this.btnCategoryDelete.TabIndex = 2;
            this.btnCategoryDelete.Text = "Delete";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // tbTag
            // 
            this.tbTag.Location = new System.Drawing.Point(505, 304);
            this.tbTag.Multiline = true;
            this.tbTag.Name = "tbTag";
            this.tbTag.Size = new System.Drawing.Size(201, 41);
            this.tbTag.TabIndex = 0;
            // 
            // btnTagAdd
            // 
            this.btnTagAdd.Location = new System.Drawing.Point(712, 302);
            this.btnTagAdd.Name = "btnTagAdd";
            this.btnTagAdd.Size = new System.Drawing.Size(55, 43);
            this.btnTagAdd.TabIndex = 2;
            this.btnTagAdd.Text = "Add";
            this.btnTagAdd.UseVisualStyleBackColor = true;
            this.btnTagAdd.Click += new System.EventHandler(this.btnTagAdd_Click);
            // 
            // btnTagDelete
            // 
            this.btnTagDelete.Location = new System.Drawing.Point(780, 302);
            this.btnTagDelete.Name = "btnTagDelete";
            this.btnTagDelete.Size = new System.Drawing.Size(55, 43);
            this.btnTagDelete.TabIndex = 2;
            this.btnTagDelete.Text = "Delete";
            this.btnTagDelete.UseVisualStyleBackColor = true;
            this.btnTagDelete.Click += new System.EventHandler(this.btnTagDelete_Click);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(26, 92);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(49, 13);
            this.lblCategories.TabIndex = 4;
            this.lblCategories.Text = "Category";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(506, 92);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(26, 13);
            this.lblTag.TabIndex = 4;
            this.lblTag.Text = "Tag";
            // 
            // lbTag
            // 
            this.lbTag.FormattingEnabled = true;
            this.lbTag.Location = new System.Drawing.Point(505, 112);
            this.lbTag.Name = "lbTag";
            this.lbTag.Size = new System.Drawing.Size(327, 186);
            this.lbTag.TabIndex = 5;
            // 
            // lbCategory
            // 
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.Location = new System.Drawing.Point(26, 112);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(327, 186);
            this.lbCategory.TabIndex = 5;
            // 
            // CategoryAndTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 380);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbTag);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.btnTagDelete);
            this.Controls.Add(this.btnCategoryDelete);
            this.Controls.Add(this.btnTagAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tbTag);
            this.Controls.Add(this.tbCategory);
            this.Name = "CategoryAndTag";
            this.Text = "CategoryAndTag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.TextBox tbTag;
        private System.Windows.Forms.Button btnTagAdd;
        private System.Windows.Forms.Button btnTagDelete;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.ListBox lbTag;
        private System.Windows.Forms.ListBox lbCategory;
    }
}