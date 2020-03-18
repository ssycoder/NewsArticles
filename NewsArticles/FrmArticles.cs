using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsArticles
{
    public partial class FrmNewArticle : Form
    {
        public FrmNewArticle()
        {
            InitializeComponent();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void FrmNewArticle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vTDIDataSet.Course' table. You can move, or remove it, as needed.
            populateList();
        }

        private void btnTestDB_Click(object sender, EventArgs e)
        {
            var objArticle = new Article();
            objArticle.CategoryId = 1;
            objArticle.Title = txtArticleTitle.Text;
            objArticle.Body = txtBody.Text;
            objArticle.PublishDate = dateTimePicker1.Value;

            ArticleData objArticleData = new ArticleData();
            objArticleData.InsertArticle(objArticle);

            populateList();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            AllArticles allArticles = new AllArticles();
            allArticles.Show();
        }

        public void populateList()
        {
            ArticleData articleData = new ArticleData();
            List<Article> articles = articleData.GetArticles();
            DataTable table = new DataTable();
            DataColumn titleColumn = new DataColumn("title");
            DataColumn dateColumn = new DataColumn("publishDate");
            table.Columns.Add(titleColumn);
            table.Columns.Add(dateColumn);

            foreach (Article item in articles)
            {

                DataRow row = table.NewRow();
                row[titleColumn] = item.Title;
                row[dateColumn] = item.PublishDate;
                table.Rows.Add(row);

            }

            gridViewArticles.DataSource = table;
        }

        private void txtTitle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}
