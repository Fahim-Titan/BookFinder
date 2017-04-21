namespace BookFinder
{
    partial class BookAdd
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSize = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.lblModifiedDate = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.tbModifiedDate = new System.Windows.Forms.TextBox();
            this.tbCreationDate = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTags = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbTags = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbCategories = new System.Windows.Forms.GroupBox();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.CategoryCheckList = new System.Windows.Forms.CheckedListBox();
            this.GBTags = new System.Windows.Forms.GroupBox();
            this.btnTagAdd = new System.Windows.Forms.Button();
            this.TagsCheckList = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbCategories.SuspendLayout();
            this.GBTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.42253F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.57747F));
            this.tableLayoutPanel1.Controls.Add(this.lblSize, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbSize, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblModifiedDate, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCreationDate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbModifiedDate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbCreationDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCategory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTags, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAuthor, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbBookName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbCategory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbTags, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbAuthor, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblBookName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.59065F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.65306F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.08163F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.59065F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.59065F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(694, 207);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(111, 185);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 22);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "Size";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(144, 188);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(183, 20);
            this.tbSize.TabIndex = 7;
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModifiedDate.AutoSize = true;
            this.lblModifiedDate.Location = new System.Drawing.Point(65, 165);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(73, 20);
            this.lblModifiedDate.TabIndex = 4;
            this.lblModifiedDate.Text = "Modified Date";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(66, 144);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(72, 21);
            this.lblCreationDate.TabIndex = 2;
            this.lblCreationDate.Text = "Creation Date";
            // 
            // tbModifiedDate
            // 
            this.tbModifiedDate.Location = new System.Drawing.Point(144, 168);
            this.tbModifiedDate.Name = "tbModifiedDate";
            this.tbModifiedDate.Size = new System.Drawing.Size(183, 20);
            this.tbModifiedDate.TabIndex = 5;
            // 
            // tbCreationDate
            // 
            this.tbCreationDate.Location = new System.Drawing.Point(144, 147);
            this.tbCreationDate.Name = "tbCreationDate";
            this.tbCreationDate.Size = new System.Drawing.Size(183, 20);
            this.tbCreationDate.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(89, 21);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 54);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // lblTags
            // 
            this.lblTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(107, 75);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(31, 48);
            this.lblTags.TabIndex = 0;
            this.lblTags.Text = "Tags";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(100, 123);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 21);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author";
            // 
            // tbBookName
            // 
            this.tbBookName.AllowDrop = true;
            this.tbBookName.Location = new System.Drawing.Point(144, 3);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(337, 20);
            this.tbBookName.TabIndex = 1;
            // 
            // tbCategory
            // 
            this.tbCategory.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCategory.Location = new System.Drawing.Point(144, 24);
            this.tbCategory.Multiline = true;
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(459, 48);
            this.tbCategory.TabIndex = 1;
            // 
            // tbTags
            // 
            this.tbTags.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTags.Location = new System.Drawing.Point(144, 78);
            this.tbTags.Multiline = true;
            this.tbTags.Name = "tbTags";
            this.tbTags.Size = new System.Drawing.Size(459, 42);
            this.tbTags.TabIndex = 1;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(144, 126);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(337, 20);
            this.tbAuthor.TabIndex = 1;
            // 
            // lblBookName
            // 
            this.lblBookName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(72, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(66, 21);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Book Name ";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBook.Location = new System.Drawing.Point(624, 513);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(101, 36);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "Add to list";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(501, 513);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbCategories
            // 
            this.gbCategories.Controls.Add(this.btnCategoryAdd);
            this.gbCategories.Controls.Add(this.CategoryCheckList);
            this.gbCategories.Location = new System.Drawing.Point(28, 247);
            this.gbCategories.Name = "gbCategories";
            this.gbCategories.Size = new System.Drawing.Size(327, 252);
            this.gbCategories.TabIndex = 3;
            this.gbCategories.TabStop = false;
            this.gbCategories.Text = "Category";
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(282, 19);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(39, 41);
            this.btnCategoryAdd.TabIndex = 1;
            this.btnCategoryAdd.Text = "+";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // CategoryCheckList
            // 
            this.CategoryCheckList.FormattingEnabled = true;
            this.CategoryCheckList.Location = new System.Drawing.Point(18, 19);
            this.CategoryCheckList.Name = "CategoryCheckList";
            this.CategoryCheckList.Size = new System.Drawing.Size(258, 214);
            this.CategoryCheckList.TabIndex = 0;
            // 
            // GBTags
            // 
            this.GBTags.Controls.Add(this.btnTagAdd);
            this.GBTags.Controls.Add(this.TagsCheckList);
            this.GBTags.Location = new System.Drawing.Point(398, 247);
            this.GBTags.Name = "GBTags";
            this.GBTags.Size = new System.Drawing.Size(327, 252);
            this.GBTags.TabIndex = 3;
            this.GBTags.TabStop = false;
            this.GBTags.Text = "Tag";
            // 
            // btnTagAdd
            // 
            this.btnTagAdd.Location = new System.Drawing.Point(270, 19);
            this.btnTagAdd.Name = "btnTagAdd";
            this.btnTagAdd.Size = new System.Drawing.Size(37, 41);
            this.btnTagAdd.TabIndex = 1;
            this.btnTagAdd.Text = "+";
            this.btnTagAdd.UseVisualStyleBackColor = true;
            this.btnTagAdd.Click += new System.EventHandler(this.btnTagAdd_Click);
            // 
            // TagsCheckList
            // 
            this.TagsCheckList.FormattingEnabled = true;
            this.TagsCheckList.Location = new System.Drawing.Point(6, 19);
            this.TagsCheckList.Name = "TagsCheckList";
            this.TagsCheckList.Size = new System.Drawing.Size(258, 214);
            this.TagsCheckList.TabIndex = 0;
            // 
            // BookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.GBTags);
            this.Controls.Add(this.gbCategories);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BookAdd";
            this.Text = "BookAdd";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbCategories.ResumeLayout(false);
            this.GBTags.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.TextBox tbCreationDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbTags;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblModifiedDate;
        private System.Windows.Forms.TextBox tbModifiedDate;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbCategories;
        private System.Windows.Forms.GroupBox GBTags;
        private System.Windows.Forms.CheckedListBox CategoryCheckList;
        private System.Windows.Forms.CheckedListBox TagsCheckList;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.Button btnTagAdd;
    }
}