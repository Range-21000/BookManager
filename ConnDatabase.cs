using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
//using System.Linq;
using MySql.Data.MySqlClient;

namespace BookManageProgram
{
//   class ConnDatabase
//    {
//        static string connStr = "Server=localhost;Database=testdb;UID=DD;PWD=1q2w3e4r!;CharSet=utf8";
//        MySqlConnection conn = new MySqlConnection(connStr);
//            try
//            {
//                conn.Open();
//                MessageBox.Show("연결 성공");
                
//                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM book", conn);
//        DataTable dt = new DataTable();
//        adapter.Fill(dt);
//                dataGridView1.DataSource = dt;
//                /*
//                for(int i = 0; i < dt.Rows.Count; i++)
//                {
//                    DataRow dr = dt.Rows[i];
//                    ListViewItem listitem = new ListViewItem(dr["ISBN"].ToString());
//                    listitem.SubItems.Add(dr["Title"].ToString());
//                    listitem.SubItems.Add(dr["Writer"].ToString());
//                    listitem.SubItems.Add(dr["Price"].ToString());
//                    listitem.SubItems.Add(dr["BookReply"].ToString());
//                    listitem.SubItems.Add(dr["BookLocation"].ToString());
//                    listitem.SubItems.Add(dr["EnterWith"].ToString());
//                    listitem.SubItems.Add(dr["BookCondition"].ToString());
//                    listitem.SubItems.Add(dr["Publisher"].ToString());

//                }*/
//                conn.Close();
//            }
//            catch(Exception ex)
//            {   
                
//                conn.Close();
//                MessageBox.Show("연결실패" + ex.Message);
//                Application.OpenForms["BookManageForm"].Close();
//}
//    }
}
