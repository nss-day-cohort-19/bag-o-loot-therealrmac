using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using System.Collections;

namespace BagOLoot
{
    public class AssignToyToChild
    {
         private string _connectionString = $"Data Source={Environment.GetEnvironmentVariable("BAGOLOOT_DB")}";
         private SqliteConnection _connection;

         public bool GetChildFromDB (string child) 
        {
            return true;
        //     int _lastId = 0; // Will store the id of the last inserted record
        //     using (_connection)
        //     {
        //         _connection.Open ();
        //         SqliteCommand dbcmd = _connection.CreateCommand ();

        //         // Insert the new child
        //         dbcmd.CommandText = $"Select a child to assign a toy";
        //         Console.WriteLine(dbcmd.CommandText);
        //         dbcmd.ExecuteNonQuery ();

        //         // Get the id of the new row
        //         dbcmd.CommandText = $"select last_insert_rowid()";
        //         using (SqliteDataReader dr = dbcmd.ExecuteReader()) 
        //         {
        //             if (dr.Read()) {
        //                 _lastId = dr.GetInt32(0);
        //             } else {
        //                 throw new Exception("Unable to insert value");
        //             }
        //         }

        //         // clean up
        //         dbcmd.Dispose ();
        //         _connection.Close ();
        //     }

        //     return _lastId != 0;
        // }
        }
        public int AddToyToBag(string toy, int child)
        {
            return 4;
        }
        public List<int> GetChildsToys(int child)
        {
            return new List<int>(){4,6,7,8};
        }

    }
}