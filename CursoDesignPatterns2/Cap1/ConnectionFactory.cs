using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap1
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();

            conexao.ConnectionString = "User Id=sa;Password=root;Server=DESKTOP-URPHR1B;DataBase=ACADEMIA";
            conexao.Open();

            return conexao;
        }
    }
}
