using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLYSHOPQUANAO
{
    class ketnoi
    {
        SqlConnection connect;
        SqlDataAdapter da;
        DataSet ds;
        public ketnoi()
        {
            string chuoiketnoi = @"server=LAPTOP-SLE8I799\KIMNGOC;database=QLSHOPQUANAO;UID=sa;PWD=123";
            connect = new SqlConnection(chuoiketnoi);
        }
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, connect);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        //Phuong thuc de thuc hien cac lenh Them, Xoa, Sua
        //public void executenonquery(string strSQL)
        //{
        //    SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
        //    connect.Open(); //Mo ket noi
        //    sqlcmd.ExecuteNonQuery();//Lenh hien lenh Them/Xoa/Sua
        //    connect.Close();//Dong ket noi
        //}
        public SqlConnection GetConnection()
        {
            return connect;
        }
        public void ExecuteNonQuery(SqlCommand cmd)
        {
            cmd.Connection = connect;
            connect.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
