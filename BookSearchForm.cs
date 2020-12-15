using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BookManageProgram
{
    public partial class BookSearchForm : Form
    {
        string connStr = "Server=localhost;Database=testdb;UID=DD;PWD=1q2w3e4r!;CharSet=utf8";
        MySqlConnection conn;
        public BookSearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sub = comboBox1.Text;
            string searchKey = txtSearchKey.Text;
            if (sub == "제목") { sub = "Title"; }
            else if (sub == "저자") { sub = "Writer"; }
            else if (sub == "출판사") { sub = "Publisher"; }
            else if (sub == "소장위치") { sub = "BookLocation"; }
            else if (sub == "등록번호") { sub = "BookRegister"; }
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                MessageBox.Show("검색 되었습니다.");

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM book WHERE " + sub + "='" + searchKey + "'", conn);
                //MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM book WHERE Title = '정전기'",conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                /*
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["ISBN"].ToString());
                    listitem.SubItems.Add(dr["Title"].ToString());
                    listitem.SubItems.Add(dr["Writer"].ToString());
                    listitem.SubItems.Add(dr["Price"].ToString());
                    listitem.SubItems.Add(dr["BookReply"].ToString());
                    listitem.SubItems.Add(dr["BookLocation"].ToString());
                    listitem.SubItems.Add(dr["EnterWith"].ToString());
                    listitem.SubItems.Add(dr["BookCondition"].ToString());
                    listitem.SubItems.Add(dr["Publisher"].ToString());

                }*/
                conn.Close();
            }
            catch (Exception ex)
            {

                conn.Close();
                MessageBox.Show("연결실패" + ex.Message);
                Application.OpenForms["BookSearchForm"].Close();
            }
        }

        private void BookSearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
