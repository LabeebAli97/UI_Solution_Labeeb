using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Windows.Storage;

namespace DataBaseLibrary
{
    public class DataBaseLibraryAccess
    {
        public async static void InitializeDatabase()
        {
            await ApplicationData.Current.LocalFolder.CreateFileAsync("userData.db", CreationCollisionOption.OpenIfExists);
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "userData.db");

            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT EXISTS" +
                    " userInfo (userEmail NVARCHAR(50) PRIMARY KEY, " +
                              "userName NVARCHAR(50) NOT NULL," +
                              "userAge INTEGER NOT NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();

                db.Close();
            }
        }

        public async static void InitializeDatabaseAgain(string tableName)
        {
            await ApplicationData.Current.LocalFolder.CreateFileAsync("userData.db", CreationCollisionOption.OpenIfExists);
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "userData.db");

            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT EXISTS " + tableName +
                    " (userEmail NVARCHAR(50) PRIMARY KEY, " +
                              "userName NVARCHAR(50) NOT NULL," +
                              "userAge INTEGER NOT NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();

                db.Close();
            }
        }

       

        public static void AddData(string email, string name, int age)
        {
            if(!email.Equals("") && !email.Equals("") && age>0)
            {
                string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "userData.db");

                using (SqliteConnection db =
                   new SqliteConnection($"Filename={dbpath}"))
                {
                    db.Open();

                    SqliteCommand insertCommand = new SqliteCommand();
                    insertCommand.Connection = db;

                    // Use parameterized query to prevent SQL injection attacks
                    insertCommand.CommandText = "INSERT INTO userInfo VALUES (@userEmail, @userName, @userAge);";
                    insertCommand.Parameters.AddWithValue("@userEmail", email);
                    insertCommand.Parameters.AddWithValue("@userName", name);
                    insertCommand.Parameters.AddWithValue("@userAge", age);



                    insertCommand.ExecuteReader();

                    db.Close();
                }
            }

            

        }

        public static void DeleteByName(string name)
        {
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "userData.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                string SQL_DELETE = "DELETE FROM " + "userInfo" + " WHERE userName =" +"'"+name+"'";

                SqliteCommand delete = new SqliteCommand(SQL_DELETE, db);

                delete.ExecuteReader();

                db.Close();
            }
        }

        public static void DeleteByEmail(string email)
        {
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "userData.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                string SQL_DELETE = "DELETE FROM " + "userInfo" + " WHERE userEmail =" + "'" + email + "'";

                SqliteCommand delete = new SqliteCommand(SQL_DELETE, db);

                delete.ExecuteReader();

                db.Close();
            }
        }

        public static void DeleteByAge(int age)
        {
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "userData.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                string SQL_DELETE = "DELETE FROM " + "userInfo" + " WHERE userAge =" + "'" + age + "'";

                SqliteCommand delete = new SqliteCommand(SQL_DELETE, db);

                delete.ExecuteReader();

                db.Close();
            }
        }

        public static void UpdateName(string name,string newName)
        {
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "userData.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                string SQL_UPDATE = "UPDATE " + "userInfo" +" SET userName ="+ "'" + newName + "'"+" WHERE userName =" + "'" + name + "'";

                SqliteCommand update = new SqliteCommand(SQL_UPDATE, db);

                update.ExecuteReader();

                db.Close();
            }
        }


        public static List<UserDetails> GetData()
        {
            List<UserDetails> usersList = new List<UserDetails>();

            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "userData.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT userEmail, userName, userAge from userInfo", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    usersList.Add(new UserDetails(query.GetString(0), query.GetString(1),query.GetInt32(2)));
                }

                db.Close();
            }

            return usersList;
        }

        public static List<UserDetails> GetNewData(string tableName)
        {
            List<UserDetails> usersList = new List<UserDetails>();

            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "userData.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT userEmail, userName, userAge from "+ tableName, db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    usersList.Add(new UserDetails(query.GetString(0), query.GetString(1), query.GetInt32(2)));
                }

                db.Close();
            }

            return usersList;
        }


        public static void DeleteAll()
        {
         
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "userData.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();         

                string SQL_DELETE = "DELETE FROM " + "userInfo";

                SqliteCommand delete = new SqliteCommand(SQL_DELETE,db);

                delete.ExecuteReader();

                db.Close();
            }
        }



        //new Codes

        public async static void DbRadio()
        {
            await ApplicationData.Current.LocalFolder.CreateFileAsync("Study.db", CreationCollisionOption.OpenIfExists);
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "Study.db");

            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT EXISTS" +
                    " switch (btnName NVARCHAR(50) PRIMARY KEY, " +
                              "btnValue INTEGER)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
        
                SqliteCommand selectCommand1 = new SqliteCommand
                    ("SELECT btnName, btnValue from " + "switch", db);

                SqliteDataReader query = selectCommand1.ExecuteReader();

                while (query.Read())
                {
                    if (query.GetString(0) == "First" )
                    {
                        db.Close();
                        return;
                    }        
                }

                SqliteCommand insertCommand1 = new SqliteCommand();
                insertCommand1.Connection = db;
                insertCommand1.CommandText = "INSERT INTO switch(btnName,btnValue) VALUES('First',1)," +
             "('Second',0),('sliderOne',0),('sliderTwo',5)," +
             "('sliderThree',0),('sliderFour',0),('sliderFive',0);";

                insertCommand1.ExecuteReader();

                db.Close();
            }
        }

        public static bool GetBtnData(string BtnName)
        {

            string nam="";
            int ch=0;
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "Study.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT btnName, btnValue from " + "switch", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    if (query.GetString(0) == BtnName)
                    {
                        nam = query.GetString(0);
                        ch = query.GetInt32(1);
                    }
                    
                }
                db.Close();
            }
            if (nam == BtnName && ch == 0)
            {
                return false;
            }
            else if (nam == BtnName && ch == 1)
            {
                return true;
            }
            return false;
        }

        public static int GetSliderValue(string SliderName)
        {
   
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "Study.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT btnName, btnValue from " + "switch", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    if (query.GetString(0) == SliderName)
                    {
                        return query.GetInt32(1);
                    }
                }
                db.Close();
            }
            return 0;
        }


        public static void UpdateCheck(int value, string BtnName)
        {
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "Study.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                string SQL_UPDATE = "UPDATE " + "switch" + " SET btnValue =" + "'" + value + "'" + " WHERE btnName =" + "'" + BtnName + "'";

                SqliteCommand update = new SqliteCommand(SQL_UPDATE, db);

                update.ExecuteReader();

                db.Close();
            }
        }


        //new Codes




    }
    public class UserDetails
    {
        
    
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public UserDetails(string email, string name, int age)
        {
            Name = name;
            Email = email;
            Age = age;
        }
    }
}
