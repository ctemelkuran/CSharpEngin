﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{ // Normalde kurumsal mimaride IProductDal 'dan çekiyor olururuz
    public class ProductDal //Data Access Layer veya Object
    {
        public DataTable GetAll()
        {
            //integrated security=true veri tabanına direkt local erişim sağlar, bilgisayara login olmak yeterli
            // uzaktaki veritabanı için false yapılır kullanıcı girilir 
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog = ETradeCSharpEngin; integrated security=true");
            if (connection.State==ConnectionState.Closed)
            {
                connection.Open();
            }
            //sql komutu yazılır
            SqlCommand sqlCommand = new SqlCommand("Select * from Products", connection);
            //komut execute edilmeli
            SqlDataReader reader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;
             
        }
    }
}
