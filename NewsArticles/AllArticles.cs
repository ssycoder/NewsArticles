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
    public partial class AllArticles : Form
    {
        public AllArticles()
        {
            InitializeComponent();
        }

        private void AllArticles_Load(object sender, EventArgs e)
        {
            ArticleData articleData = new ArticleData();
            List<Article> articles = articleData.GetArticles();
            DataTable table = new DataTable();
            DataColumn titleColumn = new DataColumn("title");
            DataColumn dateColumn = new DataColumn("publishDate");
            table.Columns.Add(titleColumn);
            table.Columns.Add(dateColumn);

            DataRow row = table.NewRow();
            row[titleColumn] = "title 1";
            row[dateColumn] = "date";
            table.Rows.Add(row);

            dataGridView1.DataSource = table;
           

        }
    }
}
