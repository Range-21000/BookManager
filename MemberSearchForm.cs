using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace BookManageProgram
{
    public partial class MemberSearchForm : Form
    {
        string connStr = "Server=localhost;Database=testdb;UID=DD;PWD=1q2w3e4r!;CharSet=utf8";
        MySqlConnection conn;

        public MemberSearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sub = comboBox1.Text;

            if(sub == "회원번호") { sub = "MemberNum"; }
            else if(sub == "회원명") { sub = "MemberName"; }
            else if(sub == "회원등급") { sub = "MemberGrade"; }

            string searchkey = txtMemberSearch.Text;

            conn = new MySqlConnection(connStr);

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM member WHERE " + sub + "='" + searchkey + "'", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show("연결실패" + ex.Message);
                Application.OpenForms["MemberSearchForm"].Close();
            }


        }

        private void MemberSearchForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectAll();
        }
    }
}
