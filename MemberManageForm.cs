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
    public partial class MemberManageForm : Form
    {
        string connStr = "Server=localhost;Database=testdb;UID=DD;PWD=1q2w3e4r!;CharSet=utf8";
        MySqlConnection conn;
        MySqlCommand cmd;
        public MemberManageForm()
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

        private void button5_Click(object sender, EventArgs e)
        {
            string grade = comboBox1.Text;
            comboBox1.Text = "";
            string num = txtNum.Text;
            string name = txtName.Text;
            string add = txtAdd.Text;
            string tel = txtTel.Text;
            string email = txtEmail.Text;
            string condi = comboBox2.Text;
            string borrow = txtBorrow.Text;
            string reserv = txtReserv.Text;
            string memo = txtMemo.Text;
            bool checkright = checkBox1.Checked;
            int stopBorrow;

            if (checkright == true)
            {
                stopBorrow = 1;
            }
            else stopBorrow = 0;
            conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();
                string cmdStr = "INSERT INTO member(MemberGrade,MemberNum,MemberName,MemberAdd,MemberEmail,MemberTel,MemberCondition,MemberBorrow,MemberReserv,BorrowStop,Memo) values('" + grade + "','" + num + "','" + name + "','" + add + "','" + email + "','" + tel + "','" + condi + "','" + borrow + "','" + reserv + "'," + stopBorrow + ",'" + memo + "');";
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
                dataGridView1.Refresh();
                dataGridView1.Update();

            }
        }

        private void MemberManageForm_Load(object sender, EventArgs e)
        {

            conn = new MySqlConnection(connStr);
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM member", conn);
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
                Application.OpenForms["MemberManageForm"].Close();
            }

            txtBorrow.Text = "0";
            txtReserv.Text = "0";
        }



        private void button7_Click(object sender, EventArgs e)
        {
            new MemberSearchForm().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string delNum = txtNum.Text;
            if (MessageBox.Show("해당 번호의 회원이 삭제 됩니다.계속하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conn = new MySqlConnection(connStr);
                    conn.Open();
                    string cmdStr = "DELETE FROM member WHERE MemberNum = '" + delNum + "'";
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
                    dataGridView1.Refresh();
                    dataGridView1.Update();
                }
            }
            else
            {
                MessageBox.Show("취소했습니다.", "취소");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectAll();
        }

        private void txtBorrow_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택하신 정보가 삭제 됩니다. 계속하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conn = new MySqlConnection(connStr);
                    conn.Open();
                    string cmdStr = "DELETE FROM member";
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
                    dataGridView1.Refresh();
                    dataGridView1.Update();
                }
            }
            else
            {
                MessageBox.Show("취소했습니다.", "취소");
            }



        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            txtTel.ReadOnly = false;
            txtAdd.ReadOnly = false;
            txtEmail.ReadOnly = false;
        }

        private void 대출반납ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("대출 하시겠습니까? 아니요시 반납 화면으로 넘어갑니다.", "대출 / 반납 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new BorrowBookForm().ShowDialog();
            }
            else
            {
                new ReturnBookForm().ShowDialog();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNum.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
        }
    }
}

