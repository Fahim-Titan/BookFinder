using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookFinder
{
    public partial class CategoryAndTag : Form
    {
        #region Private Var
        DBtoProgram dp = new DBtoProgram();
        #endregion

        #region CTOR
        public CategoryAndTag()
        {
            InitializeComponent();
            ShowItemToListView();
        }

        #endregion

        #region Private Method
        private void ShowItemToListView()
        {
            //clear listboxs
            lbCategory.Items.Clear();
            lbTag.Items.Clear();

            //clear textbox
            tbCategory.Clear();
            tbTag.Clear();

            //fill category Listbox
            List<Category> cats = new List<Category>();
            cats = dp.getListofCategory();
            int count = 0;
            foreach (var item in cats)
            {
                //lbCategory.Items.Add(item.CategoryName.ToString());
                lbCategory.Items.Insert(count, item.CategoryName.ToString());
                count++;
            }

            //fill tag listbox
            List<Tag> tags = new List<Tag>();
            tags = dp.getListofTag();
            count = 0;
            foreach (var item in tags)
            {
                lbTag.Items.Insert(count, item.TagName.ToString());
                count++;
            }

        }


        private void addtoCategorylist()
        {
            Category cat = new Category();
            cat.CategoryName = tbCategory.Text;
            if (dp.AddCategoryToDB(cat))
            {
                lblMessage.Text = cat.CategoryName + " is successfully added";
                lblMessage.Visible = true;
                lblMessage.ForeColor = Color.MediumTurquoise;
                ShowItemToListView();
            }

        }

        private void DeleteFromCategory()
        {
            foreach (var item in lbCategory.SelectedItems)
            {
                var text = item.ToString();
                if (dp.DeleteCategory(item.ToString()))
                {
                    lblMessage.Text = text + " is successfully added";
                    lblMessage.Visible = true;
                    lblMessage.ForeColor = Color.Red;
                    //ShowItemToListView();
                }
            }
            ShowItemToListView();
        }


        private void AddToTagList()
        {
            Tag tag = new Tag();
            tag.TagName = tbTag.Text;
            if (dp.AddTagToDB(tag))
            {
                lblMessage.Text = tag.TagName + " is successfully added";
                lblMessage.Visible = true;
                lblMessage.ForeColor = Color.MediumTurquoise;
                ShowItemToListView();
            }
        }

        private void DeleteFromTag()
        {
            foreach (var item in lbTag.SelectedItems)
            {
                var text = item.ToString();
                if (dp.DeleteTag(item.ToString()))
                { 
                    lblMessage.Text = text + " is successfully Deleted";
                    lblMessage.Visible = true;
                    lblMessage.ForeColor = Color.Red;
                }
            }
            ShowItemToListView();
        }

        #endregion

        #region Event Handler
        private void button1_Click(object sender, EventArgs e)
        {
            addtoCategorylist();
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            DeleteFromCategory();
        }

        private void btnTagAdd_Click(object sender, EventArgs e)
        {
            AddToTagList();
        }

        private void btnTagDelete_Click(object sender, EventArgs e)
        {
            DeleteFromTag();
        }













        #endregion


    }
}
