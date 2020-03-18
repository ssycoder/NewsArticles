namespace NewsArticles
{
    partial class FrmNewArticle
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
            this.btnTestDB = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.gridViewArticles = new System.Windows.Forms.DataGridView();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtArticleTitle = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTestDB
            // 
            this.btnTestDB.Location = new System.Drawing.Point(187, 226);
            this.btnTestDB.Name = "btnTestDB";
            this.btnTestDB.Size = new System.Drawing.Size(75, 23);
            this.btnTestDB.TabIndex = 0;
            this.btnTestDB.Text = "Add Article";
            this.btnTestDB.UseVisualStyleBackColor = true;
            this.btnTestDB.Click += new System.EventHandler(this.btnTestDB_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(535, 43);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "All Articles";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // gridViewArticles
            // 
            this.gridViewArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewArticles.Location = new System.Drawing.Point(34, 255);
            this.gridViewArticles.Name = "gridViewArticles";
            this.gridViewArticles.Size = new System.Drawing.Size(673, 160);
            this.gridViewArticles.TabIndex = 2;
            this.gridViewArticles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.txtTitle_CellContentClick);
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(187, 100);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(341, 94);
            this.txtBody.TabIndex = 4;
            // 
            // txtArticleTitle
            // 
            this.txtArticleTitle.Location = new System.Drawing.Point(187, 63);
            this.txtArticleTitle.Name = "txtArticleTitle";
            this.txtArticleTitle.Size = new System.Drawing.Size(100, 20);
            this.txtArticleTitle.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(187, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(636, 97);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(77, 200);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // FrmNewArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtArticleTitle);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.gridViewArticles);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnTestDB);
            this.Name = "FrmNewArticle";
            this.Text = "0";
            this.Load += new System.EventHandler(this.FrmNewArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewArticles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestDB;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.DataGridView gridViewArticles;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtArticleTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

