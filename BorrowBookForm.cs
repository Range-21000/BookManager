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
    public partial class BorrowBookForm : Form
    {

        string connStr = "Server=localhost;Database=testdb;UID=DD;PWD=1q2w3e4r!;CharSet=utf8";
        MySqlConnection conn;
        MySqlCommand cmd;

        public BorrowBookForm()
        {
            InitializeComponent();
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BookManageForm().ShowDialog();

        }

        private void 도서검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BookSearchForm().ShowDialog();
        }

        private void BorrowBookForm_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM member", conn);
                MySqlDataAdapter adapter1 = new MySqlDataAdapter("SELECT * FROM book", conn);
                DataTable dt1 = new DataTable();
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                adapter1.Fill(dt1);
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = dt1;
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
                Application.OpenForms["MemberManageForm"].Close();
            }
        }

       

 


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string a = dataGridView2.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            //MessageBox.Show(a);
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DateTime returnDay = System.DateTime.Now.AddDays(7);
            textBox11.Text = System.DateTime.Now.ToString("yyyy / MM / dd");
            textBox9.Text = returnDay.ToString("yyyy / MM / dd");
            textBox7.Text = dataGridView2.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            textBox8.Text = dataGridView2.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            textBox10.Text = dataGridView2.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            textBox12.Text = dataGridView2.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            textBox13.Text = dataGridView2.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
            textBox14.Text = dataGridView2.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
            textBox17.Text = dataGridView2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void 대출반납ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("반납 페이지로 이동하시겠습니까?", "반납 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new ReturnBookForm().ShowDialog();
            }
            else
            {

            }

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtNum.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
            txtGrade.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtTel.Text = dataGridView1.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
            txtAdd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtCondition.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtMemo.Text = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }

        private void 회원관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MemberManageForm().ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string register = textBox7.Text;
            string isbn = textBox17.Text;
            if (txtCondition.Text != "대출 불가능" && textBox13.Text != "대출 불가능")
            {
                if ((register != null && register != "") && (isbn != null && isbn != "") && (txtNum.Text != null && txtNum.Text != "") && (txtName.Text != null && txtName.Text != ""))
                {
                    if (MessageBox.Show("대출 하시겠습니까?", "대출", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            conn = new MySqlConnection(connStr);
                            conn.Open();
                            string cmdStr = "UPDATE book SET BookCondition = '대출 불가능' WHERE BookRegister = '" + register + "' AND ISBN = '" + isbn + "'";
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
                        MessageBox.Show("대출 취소되었습니다.");
                    }
                }

                else
                {
                    MessageBox.Show("책을 빌리는 분과 빌리실 책을 선택해 주세요");
                }
            }
            else { MessageBox.Show("대출 불가능한 상태입니다."); }
        }
    }
}
