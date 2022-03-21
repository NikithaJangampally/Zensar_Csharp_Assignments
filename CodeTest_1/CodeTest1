using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EmployeeManagement
{
    class Program
    {
         public static SqlConnection con; 
         public static SqlCommand cmd; 
         public static SqlDataReader dr;
         
         static SqlConnection getConnection()
         { 
            con = new SqlConnection("data source=DESKTOP-2RIGPF3;initial catalog=EmployeeManagement;" + 
                 "integrated security=true");
            con.Open();
            return Con;
         }
    static void Main(string[] args)
    {
        con = getConnection();
        string ename, etype;
        double esal;
        Console.WriteLine("Enter the empmloyee details: ");
        name = Console.ReadLine();
        esal = Convert.ToDouble(Console.ReadLine());
        etype = Console.ReadLine();

        cmd = new SqlCommand("InsertEmployee", con);
        cmd.CommandType = CommandType.StoredProcedure;

        SqlParameter param;
        param = cmd.Parameters.Add("@empname", SqlDbType.NVarChar, 50);
        param.Value = ename;
        param = cmd.Parameters.Add("@empsal", SqlDbType.Money);
        param.Value = esal;
        param = cmd.Parameters.Add("@emptype", SqlDbType.NVarChar, 1);
        param.Value = etype;

        int NoOfRows = cmd.ExecuteNonQuery();
        con.Close();

        if (NoOfRows > 0)
            Console.WriteLine(NoOfRows.ToString() + " record(s) inserted");

        Console.ReadLine();
    }
}


