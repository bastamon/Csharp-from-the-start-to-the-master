using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Test11.ClsDB
{
    class ClsDBControl
    {
        private SqlConnection con;

        #region//生成连接对象
        public SqlConnection ConDB()
        {
            con = new SqlConnection("server=.;uid=sa;pwd=;database=db_15");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        #endregion

        public bool insertDB(String sql)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.CommandText = sql;//设置SQL语句
                    cmd.Connection = ConDB();//调用打开数据库连接方法
                    cmd.ExecuteNonQuery();//执行
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
