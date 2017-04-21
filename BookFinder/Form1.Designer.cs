namespace BookFinder
{
    partial class frmHome
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
            this.lbldragdrop = new System.Windows.Forms.Label();
            this.btnCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldragdrop
            // 
            this.lbldragdrop.AutoSize = true;
            this.lbldragdrop.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldragdrop.ForeColor = System.Drawing.Color.DimGray;
            this.lbldragdrop.Location = new System.Drawing.Point(138, 204);
            this.lbldragdrop.Name = "lbldragdrop";
            this.lbldragdrop.Size = new System.Drawing.Size(478, 50);
            this.lbldragdrop.TabIndex = 1;
            this.lbldragdrop.Text = "Drag and Drop the PDF file";
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(12, 12);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(221, 33);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "Add Categories && Tags";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // frmHome
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.lbldragdrop);
            this.Name = "frmHome";
            this.Text = "Book Finder";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmHome_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmHome_DragEnter);
            this.DragLeave += new System.EventHandler(this.frmHome_DragLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbldragdrop;
        private System.Windows.Forms.Button btnCategory;
    }
}

