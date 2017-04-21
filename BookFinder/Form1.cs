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
    public partial class frmHome : Form
    {
        #region Private Var
        CategoryAndTag ct;
        #endregion


        #region CTOR
        public frmHome()
        {
            InitializeComponent();
        }
        #endregion
        

        #region events
        private void frmHome_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            lbldragdrop.Text = "drop it now!!!.....Fast. i'm hungry!";
        }

        private void frmHome_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                //Console.WriteLine(file);
                //MessageBox.Show(file);
                FileDetails(file);
            }
            lbldragdrop.Text = "Drag and Drop the PDF file";
        }

        private void frmHome_DragLeave(object sender, EventArgs e)
        {
            lbldragdrop.Text = "why aren't you dropping it!!!";
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenCategoryAndTagForm();
        }


        #endregion


        #region private methods
        private void OpenCategoryAndTagForm()
        {
            ct = new CategoryAndTag();
            ct.Show();
        }

        private void FileDetails(string file)
        {
            //string path = file;
            //string filename = Path.GetFileName(path);
            //string fileExtension = Path.GetExtension(path);
            //FileInfo fi = new FileInfo(path);
            //float filesize = (float)fi.Length / (float)1024 / (float)1024;
            //string size = filesize.ToString();
            //string date = fi.CreationTime.ToShortDateString();
            //string modifiedDate = fi.LastWriteTime.ToShortDateString();
            //MessageBox.Show("FileName: " + filename + "\nPath: " + path + "\nExtension: " + fileExtension + "\nSize: " + size + "MB\nDate Created: " + date + "\nDate Modified: " + modifiedDate);
            ////throw new NotImplementedException();

            BookAdd bk = new BookAdd(file);
            bk.Show();
        }

        #endregion       
    }
}
