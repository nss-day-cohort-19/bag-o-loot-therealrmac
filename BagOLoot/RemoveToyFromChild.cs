using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using System.Collections;

namespace BagOLoot
{
    
    public class RemoveChildToy
    {
        private List<string> _children = new List<string>();
        private string _connectionString = $"Data Source={Environment.GetEnvironmentVariable("BAGOLOOT_DB")}";
        private SqliteConnection _connection;

        public RemoveChildToy()
        {
            _connection = new SqliteConnection(_connectionString);
        }

        public List<string> GetChildren ()
        {
            using(_connection)
            {
                _connection.Open();
                SqliteCommand dbcmd= _connection.CreateCommand();

                dbcmd.CommandText= $"select id, name for child";
                using (SqliteDataReader dr= dbcmd.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        _children.Add(dr[1].ToString());
                    }
                }
                dbcmd.Dispose();
                _connection.Close();
            }
            return _children;
        }
        public int SelectChildToRemoveToy(int childId)
        {
            return 5;
        }
        public List<int> GetListOfToys(int childId)
        {
            return new List<int>(){1,2,3,4,5,6};
        }
        public List<int> RemoveToyFromBag(int toyId, int chidId)
        {
            return new List <int>() {1,2,3,4,6};
        }
    }
}