using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ALLinONE
{
    public static class UseDB
    {
        static RegistryKey registry = Registry.CurrentUser.OpenSubKey("SOFTWARE\\All in One");
        public static SQLiteConnection connectDB = new SQLiteConnection($@"Data Source={registry.GetValue("PathDB", "Data_DB.db")}; Version=3"); //БД

        /// <summary>
        /// select *COLUMN* from *TABLE*
        /// </summary>
        public static string[] SelectDB(string table, string column)
        {
            connectDB.Open();
            
            SQLiteCommand comm = connectDB.CreateCommand(); //переменная БД
            comm.CommandText = $"select {column} from {table}"; //код БД в переменную
            int tmp = 0;

            //Определяем количество строк (из команды SQL выше) для объявления массива (result[] ниже)
            SQLiteDataReader arr = comm.ExecuteReader(); //результат кода в переменную
            while (arr.Read()) tmp++;
            arr.Close();

            //Объявляем массив и пишем в него результаты ридера
            string[] result = new string[tmp];
            SQLiteDataReader data = comm.ExecuteReader(); //результат кода в переменную
            tmp = 0;
            while (data.Read())
                result[tmp++] = data[column].ToString();
            data.Close();

            connectDB.Close();
            return result;
        }

        /// <summary>
        /// select *COLUMN_1* from *TABLE* where *COLUMN_2* like *STRING*
        /// returns *string*;
        /// </summary>
        public static string SelectDBLike(string table, string col1, string col2, string str)
        {
            connectDB.Open();
            string res = null;

            try
            {
                SQLiteCommand comm = connectDB.CreateCommand(); //переменная БД
                comm.CommandText = $"select {col1} from {table} where {col2} like '{str}'"; //код БД в переменную
                res = comm.ExecuteScalar().ToString(); //результат кода в переменную
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connectDB.Close();
            return res;
        }

        /// <summary>
        /// insert into *TABLE*(*COLUMN*) values(*STRING*)
        /// </summary>
        public static void InsertDB(string table, string col1, string str1)
        {
            connectDB.Open();
            //MainForm mainForm = new MainForm();
            //SQLiteCommand comm = mainForm.DB.CreateCommand(); //переменная БД
            SQLiteCommand comm = connectDB.CreateCommand(); //переменная БД
            comm.CommandText = "insert into '" + table + "'('" + col1 + "') values('" + str1 + "')"; //код БД в переменную

            comm.ExecuteNonQuery();
            connectDB.Close();
        }

        /// <summary>
        /// insert into *TABLE*(*COLUMN*) values(*STRING*)
        /// </summary>
        public static void InsertDB(string table, string col1, string col2,string str1, string str2)
        {
            connectDB.Open();
            SQLiteCommand comm = connectDB.CreateCommand(); //переменная БД
            comm.CommandText = "insert into '" + table + "'('" + col1 + "', '" + col2 + "') values('" + str1 + "', '" + str2 + "')"; //код БД в переменную
            //comm.CommandText = $@"insert into {table}({col1}, {col2}) values({str1}, {str2})"; //Некоторые символы принимает за SQL запросы

            comm.ExecuteNonQuery();
            connectDB.Close();
        }

        /// <summary>
        /// insert into *TABLE*(*COLUMN*) values(*STRING*)
        /// </summary>
        public static void InsertDB(string table, string col1, string col2, string col3, string str1, string str2, string str3)
        {
            connectDB.Open();
            SQLiteCommand comm = connectDB.CreateCommand(); //переменная БД
            comm.CommandText = "insert into '" + table + "'('" + col1 + "', '" + col2 + "', '" + col3 + "') values('" + str1 + "', '" + str2 + "', '" + str3 + "')"; //код БД в переменную

            comm.ExecuteNonQuery();
            connectDB.Close();
        }

        /// <summary>
        /// insert into *TABLE*(*COLUMN*) values(*STRING*)
        /// </summary>
        public static void InsertDB(string table, string col1, string col2, string col3, string col4, string str1, string str2, string str3, string str4)
        {
            connectDB.Open();
            SQLiteCommand comm = connectDB.CreateCommand(); //переменная БД
            comm.CommandText = "insert into '" + table + "'('" + col1 + "', '" + col2 + "', '" + col3 + "', '" + col4 + "') values('" + str1 + "', '" + str2 + "', '" + str3 + "', '" + str4 + "')"; //код БД в переменную

            comm.ExecuteNonQuery();
            connectDB.Close();
        }

        /// <summary>
        /// update *TABLE* set *COLUMN_1*=*STRING_1* where *COLUMN_2* like *STRING_2*
        /// </summary>
        public static void UpdateDB(string table, string col1, string col2, string str1, string str2)
        {
            connectDB.Open();
            //MainForm mainForm = new MainForm();
            //SQLiteCommand comm = mainForm.DB.CreateCommand(); //переменная БД
            SQLiteCommand comm = connectDB.CreateCommand(); //переменная БД
            comm.CommandText = "update '" + table + "' set '" + col1 + "'='" + str1 + "' where " + col2 + " like '" + str2 + "'"; //код БД в переменную
            comm.ExecuteNonQuery();
            connectDB.Close();
        }

        /// <summary>
        /// delete from *TABLE* where *COLUMN* like *STRING*
        /// </summary>
        public static void DeleteDB(string table, string col1, string str1)
        {
            connectDB.Open();
            SQLiteCommand comm = connectDB.CreateCommand(); //переменная БД
            comm.CommandText = "delete from '" + table + "' where " + col1 + " like '" + str1 + "'"; //код БД в переменную
            comm.ExecuteNonQuery();
            connectDB.Close();
        }

        public static void CreateNewDB(string nameNewDB)
        {
            connectDB.Open();
            SQLiteCommand comm = connectDB.CreateCommand();
            //Создание всех таблиц
            comm.CommandText = "create table ProfRab(" + //ProfRab
                "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                "[btn_name] VARCHAR(20) NOT NULL," +
                "[btn_title] VARCHAR(32) NOT NULL," +
                "[btn_value] VARCHAR(1024)" +
                ");" +
                "create table PingList(" + //PingList
                "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                "[Name] STRING(255) NOT NULL," +
                "[Title] STRING(100) NOT NULL" +
                ");" +
                "create table ServiceRDP(" + //ServiceRDP
                "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                "[Name] STRING(100) NOT NULL," +
                "[Title] STRING(50) NOT NULL" +
                ");" +
                "create table ServiceShare(" + //ServiceShare
                "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                "[Name] STRING(255) NOT NULL," +
                "[Title] STRING(50) NOT NULL" +
                ");" +
                "create table Printers(" + //Printers
                "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                "[Name] STRING(100) NOT NULL," +
                "[NetName] STRING(50)," +
                "[Location] STRING(20)," +
                "[InvNumber] INTEGER(15)" +
                ");" +
                "create table ProgList(" + //ProgList
                "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                "[Name] STRING(255) NOT NULL" +
                ");" +
                "create table ReinstallOS(" + //ReinstallOS
                "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                "[Name] STRING(255) NOT NULL" +
                ");" +
                "create table RequestList(" + //RequestList
                "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                "[Value] STRING(300) NOT NULL," +
                "[User] STRING(50) NOT NULL," +
                "[DateCreate] STRING NOT NULL," +
                "[DateUse] INTEGER(15)" +
                ");" +
                "create table ToDo(" + //ToDo
                "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                "[Value] TEXT(256) NOT NULL," +
                "[Date] STRING NOT NULL" +
                ");";
            comm.ExecuteNonQuery();
            connectDB.Close();

            //Заполняем Профы дефолтным значением (необходимо для кнопок)
            MainForm mForm = new MainForm();
            for (int i = 1; i < mForm.tabPageProfRab.Controls.Count - 1; i++)
            {
                InsertDB("ProfRab", "btn_name", "btn_title", "btn_value", "btnPR" + i, i.ToString(), "\\_(ツ)_/ -ать");
            }
            mForm.Close();

            connectDB.Close();
        }
    }
}
