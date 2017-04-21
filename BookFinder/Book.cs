using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFinder
{
   public class Book
    {
        //public string Id { get; set; }
        public string BookName { get; set; }
        public string FilePath { get; set; }
        public string AuthorName { get; set; }
        public string CreationDate { get; set; }
        public string ModifiedDate { get; set; }
        public string Size { get; set; }
        public string Tags { get; set; }
        public string Categories { get; set; }
        //public  IList<Tag> Tags { get;set }
        //public IList<Category> Categories { get; set; }
    }


   public class Tag
    {
        public string TagName { get; set; }

    }

    public class Category
    {
        public string CategoryName { get; set; }    
    }
}
