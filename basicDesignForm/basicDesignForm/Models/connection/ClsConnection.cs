using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using basicDesignForm.Models;

namespace basicDesignForm.Models
{
    public class ClsConnection
    {
        private int errorCode;
        private string errorMsg;
        private SqlConnection con;

        public int _errorCode { get { return errorCode; } } //Read Only
        public string _errorMsg { get { return errorMsg; } } //Read Only

        public SqlConnection _con { get {return con; } set { con = value; } }

        public SqlCommand _cmd { get; set; }
        public SqlDataAdapter _ad { get; set; }
        //constructor 
        public ClsConnection()
        {
            ConnDb();
        }

        private void ConnDb()
        {
            //server : PC NAME , serverName , IP public , localhost ( . )
            //initial catalog  : Database table , view , query
            // Integrated Security = True don't have username and pw
            // user = sa ; password  = ........ ; user have pw
            string str = StaticMember.conStr; //get data from cls and before get it be have add more in StartUp under
            try
            {
                con = new SqlConnection(str);
                if (con.State == System.Data.ConnectionState.Closed) con.Open(); 
                if(con.State == System.Data.ConnectionState.Open)
                {
                    errorCode = 0;
                    errorMsg = "Success to connect with database SQL SERVER";
                }
                else
                {
                    errorCode = 1;
                    errorMsg = "Unknown Problem ";
                }
                
            }
            catch (Exception e)
            {
                errorCode = e.HResult;
                errorMsg = e.Message;
            }
        }
    }
}
