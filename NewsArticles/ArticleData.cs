using System;
using System.Collections.Generic;
using System.Configuration; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NewsArticles
{
    public class ArticleData
    {
        private string ConnectionString = string.Empty;

        public ArticleData()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public int InsertArticle(Article article)
        {

            //Create the SQL Query for inserting an article
            string sqlQuery = String.Format("Insert into Article (Title, Body ,PublishDate, CategoryID) Values('{0}', '{1}', '{2}', {3} );"
            + "Select @@Identity", article.Title, article.Body, article.PublishDate.ToString("yyyy-MM-dd"), article.CategoryId);

            //Create and open a connection to SQL Server
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            //Create a Command object
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Execute the command to SQL Server and return the newly created ID
            int newArticleID = Convert.ToInt32((decimal)command.ExecuteScalar());

            //Close and dispose
            command.Dispose();
            connection.Close();
            connection.Dispose();

            // Set return value
            return newArticleID;
        }

        public int SaveArticle(Article article)
        {

            //Create the SQL Query for inserting an article
            string createQuery = String.Format("Insert into Article (Title, Body ,PublishDate, CategoryID) Values('{0}', '{1}', '{2}', {3} );"
                + "Select @@Identity", article.Title, article.Body, article.PublishDate.ToString("yyyy-MM-dd"), article.CategoryId);

            //Create the SQL Query for updating an article
            string updateQuery = String.Format("Update Article SET Title='{0}', Body = '{1}', PublishDate ='{2}', CategoryID = {3} Where ArticleID = {4};",
                article.Title, article.Body, article.PublishDate.ToString("yyyy-MM-dd"), article.CategoryId, article.ArticleId);

            //Create and open a connection to SQL Server
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            //Create a Command object
            SqlCommand command = null;

            if (article.ArticleId != 0)
                command = new SqlCommand(updateQuery, connection);
            else
                command = new SqlCommand(createQuery, connection);

            int savedArticleID = 0;
            try
            {
                //Execute the command to SQL Server and return the newly created ID
                var commandResult = command.ExecuteScalar();
                if (commandResult != null)
                {
                    savedArticleID = Convert.ToInt32(commandResult);
                }
                else
                {
                    //the update SQL query will not return the primary key but if doesn't throw exception
                    //then we will take it from the already provided data
                    savedArticleID = article.ArticleId;
                }
            }
            catch (Exception ex)
            {
                //there was a problem executing the script
                Console.WriteLine(ex.Message);
            }

            //Close and dispose
            command.Dispose();
            connection.Close();
            connection.Dispose();

            return savedArticleID;
        }



        public Article GetArticleById(int articleId)
        {
            Article result = new Article();

            //Create the SQL Query for returning an article category based on its primary key
            string sqlQuery = String.Format("select * from Article where ArticleID={0}", articleId);

            //Create and open a connection to SQL Server
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader dataReader = command.ExecuteReader();

            //load into the result object the returned row from the database
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    result.ArticleId = Convert.ToInt32(dataReader["ArticleID"]);
                    result.Body = dataReader["Body"].ToString();
                    result.CategoryId = Convert.ToInt32(dataReader["CategoryID"]);
                    result.PublishDate = Convert.ToDateTime(dataReader["PublishDate"]);
                    result.Title = dataReader["Title"].ToString();
                }
            }

            return result;
        }

        public List<Article> GetArticles()
        {

            List<Article> result = new List<Article>();

            //Create the SQL Query for returning all the articles
            string sqlQuery = String.Format("select * from Article");

            //Create and open a connection to SQL Server
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Create DataReader for storing the returning table into server memory
            SqlDataReader dataReader = command.ExecuteReader();

            Article article = null;

            //load into the result object the returned row from the database
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    article = new Article();

                    article.ArticleId = Convert.ToInt32(dataReader["ArticleID"]);
                    article.Body = dataReader["Body"].ToString();
                    article.CategoryId = Convert.ToInt32(dataReader["CategoryID"]);
                    article.PublishDate = Convert.ToDateTime(dataReader["PublishDate"]);
                    article.Title = dataReader["Title"].ToString();

                    result.Add(article);
                }
            }

            return result;

        }


        public bool DeleteArticle(int ArticleID)
        {
            bool result = false;

            //Create the SQL Query for deleting an article
            string sqlQuery = String.Format("delete from Article where ArticleID = {0}", ArticleID);

            //Create and open a connection to SQL Server
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            //Create a Command object
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            // Execute the command
            int rowsDeletedCount = command.ExecuteNonQuery();
            if (rowsDeletedCount != 0)
                result = true;
            // Close and dispose
            command.Dispose();
            connection.Close();
            connection.Dispose();


            return result;
        }

    }

}
