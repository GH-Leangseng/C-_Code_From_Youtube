using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Crud.Model
{
    public class db
    {
        SqlConnection con = new SqlConnection("Data Source=LEANG-SENG\\SQLEXPRESS;Initial Catalog=API;Integrated Security=True");
    }
}
