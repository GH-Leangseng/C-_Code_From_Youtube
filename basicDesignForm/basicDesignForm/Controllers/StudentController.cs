using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using basicDesignForm.Models;
using System.Data.SqlClient;

namespace basicDesignForm.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult FormStudent()
        {
            return View();
        }

        [HttpPost]
                    //using for get method post from Ajax by method "POST"
                   //get data by Object from view Jquery
                   //public IActionResult PostStudent(ClsStudent obj)
                   //{
                   //    obj.Address = "we have change data in OBJ Controller ";
                   //    return Ok(obj);

        //}

        //get data by array from view Jquery
        //public IActionResult PostStudent(List<ClsStudent> obj)
        //{
        //    return Ok(obj);

        //}

        public IActionResult PostStudent(ClsStudent obj)
        {
            //insert data to  database 
            ClsConnection con = new ClsConnection();
            SqlTransaction tran = con._con.BeginTransaction();
            ClsError error = new ClsError();
            try
            {
                
                if (con._errorCode == 0)
                {
                    con._cmd = new System.Data.SqlClient.SqlCommand();
                    con._cmd.Connection = con._con;
                    con._cmd.CommandText = "INSERT INTO dbo.tblStudent VALUES (N'" + obj.Name + "',N'" + obj.Gender + "');";
                    con._cmd.Transaction = tran; //map with transaction to catch problem or not 
                    if (con._cmd.ExecuteNonQuery() == 1)
                    {
                        //success
                    }
                    else
                    {
                        //fauk
                    }
                    //int a = 10;
                    //int b = 0;
                    // a= a / b;

                    error.ErrorMsg = "Success Insert Data ";
                    error.ErrorCode = 0;

                    tran.Commit(); //top to bottom no problem 
                }
                else
                {
                    error.ErrorCode = con._errorCode;
                    error.ErrorMsg = con._errorMsg;
                }

                con._con.Close();
            }catch(Exception ex)
            {
                //ex.Message();
                tran.Rollback(); //remove data back when you have problem 
                error.ErrorCode = ex.HResult;
                error.ErrorMsg = ex.Message;
            }
            finally
            {
                tran.Dispose(); // break transaction if you don't braek so other user are using will be waiting us to Finish 
            }
            return Ok(error);

        }
    }
}
