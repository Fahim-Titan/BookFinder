using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;


namespace BookFinder
{
    class DBtoProgram
    {


        #region private var
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;
        #endregion

        #region Ctor
        public DBtoProgram()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("BookFinder");
        }
        #endregion

        #region Private Var

        #region Book
        //check if book exists
        //public async Task<bool> bookExist(Book book)
        //{
        //    var collection = _database.GetCollection<Book>("Books");
        //    var filter = Builders<Book>.Filter.Eq("FilePath", book.FilePath);
        //    var result = await collection.Find(filter).ToListAsync();
        //    //return result;
        //}

        //updates database if there is already a document otherwise creates a new one
        public void UpdateToDB(Book book)
        {
            var collection = _database.GetCollection<Book>("Books");
            var filter = Builders<Book>.Filter.Eq("FilePath", book.FilePath);
            var result = collection.ReplaceOneAsync(filter, options: new UpdateOptions { IsUpsert = true }, replacement: book);
        }


        //depricated function
        public void insertToDB(Book book)
        {

            var collection = _database.GetCollection<Book>("Books");
            //collection.
            collection.InsertOne(book);

        }

        
        #endregion

        #region Category
        public bool AddCategoryToDB(Category cat)
        {
            var collection = _database.GetCollection<Category>("Categories");
            var filter = Builders<Category>.Filter.Eq("CategoryName", cat.CategoryName);
            try
            {
                var result = collection.ReplaceOneAsync(filter, options: new UpdateOptions { IsUpsert = true }, replacement: cat);
                return true;
            }
            catch (Exception)
            {

                return false;
            }           
        }

        internal bool DeleteCategory(string v)
        {
            Category cat = new Category();
            cat.CategoryName = v;
            var collection = _database.GetCollection<Category>("Categories");
            var filter = Builders<Category>.Filter.Eq("CategoryName", cat.CategoryName);
            try
            {
                var result = collection.DeleteOne(filter);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public List<Category> getListofCategory()
        {
            List<Category> cats = new List<Category>();

            var collection = _database.GetCollection<Category>("Categories");
            var filter = new BsonDocument();
            //var list = collection.Find(_ => true).ToList();
            var list = from e in collection.AsQueryable<Category>() select e.CategoryName;
            foreach (var item in list)
            {
                Category cat = new Category();
                cat.CategoryName = item.ToString();
                cats.Add(cat);
            }
            return cats;
        }

        //public async Task<List<Category>> getListofCategory()
        //{
        //    List<Category> cats = new List<Category>();
        //    Category cat = new Category();
        //    var collection = _database.GetCollection<BsonDocument>("restaurants");
        //    var filter = new BsonDocument();
        //    var count = 0;
        //    using (var cursor = await collection.FindAsync(filter))
        //    {

        //        while (await cursor.MoveNextAsync())
        //        {
        //            var batch = cursor.Current;
        //            foreach (var document in batch)
        //            {
        //                // process document
        //                count++;
        //                cat.CategoryName = document.ToString();
        //                cats.Add(cat);
        //            }
        //        }
        //    }

        //    return cats;
        //}
        #endregion

        #region Tag
        internal bool AddTagToDB(Tag tag)
        {
            var collection = _database.GetCollection<Tag>("Tags");
            var filter = Builders<Tag>.Filter.Eq("TagName", tag.TagName);
            try
            {
                var result = collection.ReplaceOneAsync(filter, options: new UpdateOptions { IsUpsert = true }, replacement: tag);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal bool DeleteTag(string v)
        {
            Tag tag = new Tag();
            tag.TagName = v;
            var collection = _database.GetCollection<Tag>("Tags");
            var filter = Builders<Tag>.Filter.Eq("TagName", tag.TagName);
            try
            {
                var result = collection.DeleteOne(filter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal List<Tag> getListofTag()
        {
            List<Tag> tags = new List<Tag>();

            var collection = _database.GetCollection<Tag>("Tags");
            var filter = new BsonDocument();
            var list = from e in collection.AsQueryable<Tag>() select e.TagName;
            foreach (var item in list)
            {
                Tag tag = new Tag();
                tag.TagName = item.ToString();
                tags.Add(tag);
            }
            return tags;
        }
        #endregion

        #endregion
    }


}
