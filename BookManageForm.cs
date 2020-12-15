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

    public partial class BookManageForm : Form
    {

        string connStr = "Server=localhost;Database=testdb;UID=DD;PWD=1q2w3e4r!;CharSet=utf8";
        MySqlConnection conn;
        MySqlCommand cmd;

        public BookManageForm()
        {
            InitializeComponent();


        }

        private void 대출반납ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("대출 하시겠습니까? 아니요시 반납 화면으로 넘어갑니다.", "대출 / 반납 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new BorrowBookForm().ShowDialog();
                Application.Exit();
            }
            else
            {
                new ReturnBookForm().ShowDialog();
                Application.Exit();
            }

        }

        private void 회원관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MemberManageForm().ShowDialog();
        }

        private void BookManageForm_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false; 
            button1.Enabled = false;

            //conn = new MySqlConnection(connStr);
            //try
            //{
            //    conn.Open();
            //    MessageBox.Show("연결 성공", "DB연결");

            //    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM book", conn);
            //    DataTable dt = new DataTable();
            //    adapter.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //    /*
            //    for(int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        DataRow dr = dt.Rows[i];
            //        ListViewItem listitem = new ListViewItem(dr["ISBN"].ToString());
            //        listitem.SubItems.Add(dr["Title"].ToString());
            //        listitem.SubItems.Add(dr["Writer"].ToString());
            //        listitem.SubItems.Add(dr["Price"].ToString());
            //        listitem.SubItems.Add(dr["BookReply"].ToString());
            //        listitem.SubItems.Add(dr["BookLocation"].ToString());
            //        listitem.SubItems.Add(dr["EnterWith"].ToString());
            //        listitem.SubItems.Add(dr["BookCondition"].ToString());
            //        listitem.SubItems.Add(dr["Publisher"].ToString());

            //    }*/
            //    conn.Close();
            //}
            //catch (Exception ex)
            //{

            //    conn.Close();
            //    MessageBox.Show("연결실패" + ex.Message, "오류");
            //    Application.OpenForms["BookManageForm"].Close();
            //}

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAllSelect_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectAll();
        }

        private void 도서검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BookSearchForm().ShowDialog();
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("현재 페이지입니다.","도서관리");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }

        private void btnAllDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택하신 정보가 전부 삭제 됩니다. 계속하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conn = new MySqlConnection(connStr);
                    conn.Open();
                    string cmdStr = "DELETE FROM book";
                    cmd = new MySqlCommand(cmdStr, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();


                }
                catch (Exception ex)
                {

                    conn.Close();
                    MessageBox.Show("연결실패" + ex.Message);
                    Application.OpenForms["MemberManageForm"].Close();
                }
                finally
                {
                    Application.OpenForms["BookManageForm"].Refresh();
                    dataGridView1.Refresh();
                    dataGridView1.Update();
                }
            }
            else
            {
                MessageBox.Show("아니요 클릭");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text;
            string title = txtTitle.Text;
            string writer = txtWriter.Text;
            string price = txtPrice.Text;
            string bookreply = txtMeans.Text;
            string booklocation = comboBox1.Text;
            string enterwith = comboBox2.Text;
            string bookcon = comboBox3.Text;
            string bookregister = txtNum.Text;
            string publisher = txtPub.Text;

            if (MessageBox.Show("입력하신 정보가 저장 됩니다. 계속하시겠습니까?", "저장 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conn = new MySqlConnection(connStr);
                    conn.Open();
                    string cmdStr = "INSERT INTO book(ISBN,Title,BookRegister,Writer,Price,BookReply,BookLocation,EnterWith,BookCondition,Publisher) values('" + isbn + "','" + title + "'," + bookregister + ",'" + writer + "'," + price + ",'" + bookreply + "','" + booklocation + "','" + enterwith + "','" + bookcon + "','" + publisher + "');";
                    cmd = new MySqlCommand(cmdStr, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();


                }
                catch (Exception ex)
                {

                    conn.Close();
                    MessageBox.Show("연결실패" + ex.Message);
                    Application.OpenForms["MemberManageForm"].Close();
                }
                finally
                {
                    Application.OpenForms["BookManageForm"].Refresh();
                    dataGridView1.Refresh();
                    dataGridView1.Update();
                }
            }
            else
            {
                MessageBox.Show("아니요가 선택 되었습니다.");
            }

            txtISBN.ReadOnly = true;
            txtISBN.Text = "";
            txtNum.ReadOnly = true;
            txtNum.Text = "";
            txtPrice.ReadOnly = true;
            txtPrice.Text = "";
            txtTitle.ReadOnly = true;
            txtTitle.Text = "";
            txtWriter.ReadOnly = true;
            txtWriter.Text = "";
            txtMeans.ReadOnly = true;
            txtMeans.Text = "";
            txtPub.ReadOnly = true;
            txtPub.Text = "";
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            txtSearchISBN.ReadOnly = false;

            btnSearch.Enabled = true;
            btnSave.Enabled = false;
            button1.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("추가 하시겠습니까?", "신규", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtISBN.ReadOnly = false;
                txtNum.ReadOnly = false;
                txtPrice.ReadOnly = false;
                txtTitle.ReadOnly = false;
                txtWriter.ReadOnly = false;
                txtMeans.ReadOnly = false;
                txtPub.ReadOnly = false;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                txtSearchISBN.ReadOnly = true;

                btnSearch.Enabled = false;
                btnSave.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("취소 되었습니다.");
            }


        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string searchkey = txtNum.Text;

            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM book WHERE BookRegister = " + searchkey, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
                Application.OpenForms["BookManageForm"].Refresh();
            }
            catch
            {
                conn.Close();
                MessageBox.Show("연결 실패", "오류");
                Application.OpenForms["BookManageForm"].Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtISBN.ReadOnly = true;
            txtISBN.Text = "";
            txtNum.ReadOnly = true;
            txtNum.Text = "";
            txtPrice.ReadOnly = true;
            txtPrice.Text = "";
            txtTitle.ReadOnly = true;
            txtTitle.Text = "";
            txtWriter.ReadOnly = true;
            txtWriter.Text = "";
            txtMeans.ReadOnly = true;
            txtMeans.Text = "";
            txtPub.ReadOnly = true;
            txtPub.Text = "";
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            txtSearchISBN.ReadOnly = false;

            btnSearch.Enabled = true;
            btnSave.Enabled = false;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM book", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
                Application.OpenForms["BookManageForm"].Refresh();
            }
            catch
            {
                conn.Close();
                MessageBox.Show("연결 실패", "오류");
                Application.OpenForms["BookManageForm"].Close();

            }
        }
    }
}
