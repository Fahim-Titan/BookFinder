using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace BookFinder
{
    public partial class BookAdd : Form
    {
        DBtoProgram dp = new DBtoProgram();
        protected static string sizeofBook, pathName;
        #region Ctor
        public BookAdd()
        {
            InitializeComponent();
            ShowItemToCheckBox();
        }



        public BookAdd(string file)
        {
            InitializeComponent();
            string path = file;
            pathName = path;
            //string filename = Path.GetFileName(path);
            //string fileExtension = Path.GetExtension(path);
            //FileInfo fi = new FileInfo(path);
            //float filesize = (float)fi.Length / (float)1024 / (float)1024;
            //string size = filesize.ToString();
            //string date = fi.CreationTime.ToShortDateString();
            //string modifiedDate = fi.LastWriteTime.ToShortDateString();

            ///shows item to the checkboxes
            ShowItemToCheckBox();
            
            Book book = new Book();
            book.FilePath = file;
            
            book.BookName = Path.GetFileName(path);
            //string fileExtension = Path.GetExtension(path);
            FileInfo fi = new FileInfo(path);
            float filesize = (float)fi.Length / (float)1024 / (float)1024;
            book.Size = filesize.ToString();
            sizeofBook = book.Size;
            book.CreationDate = fi.CreationTime.ToShortDateString();
            book.ModifiedDate = fi.LastWriteTime.ToShortDateString();
            showtoUI(book);

        }

       
        #endregion

        #region Private method
        public void showtoUI(Book book)
        {
            tbBookName.Text = book.BookName;
            tbAuthor.Text = book.AuthorName;
            tbSize.Text = book.Size+ " MB";
            tbCreationDate.Text = book.CreationDate;
            tbModifiedDate.Text = book.ModifiedDate;
        }

        private void AddCategoryToTextbox()
        {
            tbCategory.Clear();
            //CategoryCheckList.CheckedItems
            foreach (var item in CategoryCheckList.CheckedItems)
            {
                //MessageBox.Show(item.ToString());
                tbCategory.Text += item.ToString() + "; ";
            }
        }

        private void AddTagToTextbox()
        {
            tbTags.Clear();
            foreach (var item in TagsCheckList.CheckedItems)
            {
                tbTags.Text += item.ToString() + "; ";
            }
        }

        /// <summary>
        /// category and tag check list box are filled with data from DB
        /// </summary>
        private void ShowItemToCheckBox()
        {
            List<Category> cats = new List<Category>();
            cats = dp.getListofCategory();

            foreach (var item in cats)
            {
                CategoryCheckList.Items.Add(item.CategoryName);
            }

            List<Tag> tags = new List<Tag>();
            tags = dp.getListofTag();
            foreach (var item in tags)
            {
                TagsCheckList.Items.Add(item.TagName);
            }
        }

        /// <summary>
        /// --->gets books information ---> requests to insert in to DB
        /// </summary>
        private void AddBookTODB()
        {
            Book book = new Book();
            book.BookName = tbBookName.Text;
            book.AuthorName = tbAuthor.Text;
            book.Categories = tbCategory.Text;
            book.Tags = tbTags.Text;
            book.Size = sizeofBook;
            book.FilePath = pathName;
            book.CreationDate = tbCreationDate.Text;
            book.ModifiedDate = tbModifiedDate.Text;


            //insert if statement
            //if the book is already added,
            //will ask user permission to update or discard update
            //dp.insertToDB(book);
            dp.UpdateToDB(book);
        }
        #endregion

        #region events
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            //call to function
            AddBookTODB();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            AddCategoryToTextbox();
        }

        private void btnTagAdd_Click(object sender, EventArgs e)
        {
            AddTagToTextbox();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        #endregion

    }
}
