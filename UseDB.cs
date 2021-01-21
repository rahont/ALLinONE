﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ALLinONE
{
    public class UseDB
    {
        //MainForm mainForm = new MainForm();
        static RegistryKey registry = Registry.CurrentUser.OpenSubKey("All in One");
        public SQLiteConnection connectDB = new SQLiteConnection($@"Data Source={UseDB.registry.GetValue("PathDB", "Data_DB.db")}; Version=3"); //БД

        public int numbCol;
        public string table;
        public string col1;
        public string col2;
        public string col3;
        public string col4;
        public string str1;
        public string str2;
        public string str3;
        public string str4;

        public UseDB() { }

        public UseDB(string table, string col1)
        {
            this.table = table;
            this.col1 = col1;
        }

        public UseDB(string table, string col1, string str1, int numbCol = 1)
            : this(table, col1)
        {
            this.str1 = str1;
            this.numbCol = numbCol;
        }

        public UseDB(string table, string col1, string col2, string str1)
            : this(table, col1, str1)
        {
            this.col2 = col2;
        }

        public UseDB(string table, string col1, string col2, string str1, string str2, int numbCol = 2)
            : this(table, col1, str1, numbCol)
        {
            this.col2 = col2;
            this.str2 = str2;
        }

        public UseDB(string table, string col1, string col2, string col3, string str1, string str2, string str3, int numbCol = 3)
             : this(table, col1, col2, str1, str2, numbCol)
        {
            this.col3 = col3;
            this.str3 = str3;
        }

        public UseDB(string table, string col1, string col2, string col3, string col4, string str1, string str2, string str3, string str4, int numbCol = 4)
             : this(table, col1, col2, col3, str1, str2, str3, numbCol)
        {
            this.col4 = col4;
            this.str4 = str4;
        }

        ///// <summary>
        ///// select *COLUMN* from *TABLE*
        ///// </summary>
        //public SQLiteDataReader SelectDB()
        //{
        //    DB111.Open();
        //    //MainForm mainForm = new MainForm();
        //    SQLiteCommand comm = DB111.CreateCommand(); //переменная БД
        //    //SQLiteCommand comm = mainForm.DB.CreateCommand(); //переменная БД
        //    comm.CommandText = "select " + col1 + " from " + table + ""; //код БД в переменную
        //    SQLiteDataReader rdp = comm.ExecuteReader(); //результат кода в переменную

        //    //DB111.Close();
        //    return rdp;
        //}

        /// <summary>
        /// select *COLUMN* from *TABLE*
        /// </summary>
        public string[] SelectDB(string table, string column)
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
        public string SelectDBLike()
        {
            connectDB.Open();
            string res = null;

            try
            {
                //MainForm mainForm = new MainForm();
                //SQLiteCommand comm = mainForm.DB.CreateCommand(); //переменная БД
                SQLiteCommand comm = connectDB.CreateCommand(); //переменная БД
                comm.CommandText = $"select {col1} from {table} where {col2} like '{str1}'"; //код БД в переменную
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
        /// select *COLUMN_1* from *TABLE* where *COLUMN_2* like *STRING*
        /// returns *string*;
        /// </summary>
        public string SelectDBLike(string table, string col1, string col2, string str)
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
        public void InsertDB()
        {
            connectDB.Open();
            //MainForm mainForm = new MainForm();
            //SQLiteCommand comm = mainForm.DB.CreateCommand(); //переменная БД
            SQLiteCommand comm = connectDB.CreateCommand(); //переменная БД
            if (numbCol == 1)
                comm.CommandText = "insert into '" + table + "'('" + col1 + "') values('" + str1 + "')"; //код БД в переменную
            if (numbCol == 2)
                comm.CommandText = "insert into '" + table + "'('" + col1 + "', '" + col2 + "') values('" + str1 + "', '" + str2 + "')"; //код БД в переменную
            if (numbCol == 3)
                comm.CommandText = "insert into '" + table + "'('" + col1 + "', '" + col2 + "', '" + col3 + "') values('" + str1 + "', '" + str2 + "', '" + str3 + "')"; //код БД в переменную
            if (numbCol == 4)
                comm.CommandText = "insert into '" + table + "'('" + col1 + "', '" + col2 + "', '" + col3 + "', '" + col4 + "') values('" + str1 + "', '" + str2 + "', '" + str3 + "', '" + str4 + "')"; //код БД в переменную
            comm.ExecuteNonQuery();
            connectDB.Close();
        }

        /// <summary>
        /// insert into *TABLE*(*COLUMN*) values(*STRING*)
        /// </summary>
        public void InsertDB(string table, string col1, string str1)
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
        public void InsertDB(string table, string col1, string col2,string str1, string str2)
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
        public void InsertDB(string table, string col1, string col2, string col3, string str1, string str2, string str3)
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
        public void InsertDB(string table, string col1, string col2, string col3, string col4, string str1, string str2, string str3, string str4)
        {
            connectDB.Open();
            SQLiteCommand comm = connectDB.CreateCommand(); //переменная БД
            comm.CommandText = "insert into '" + table + "'('" + col1 + "', '" + col2 + "', '" + col3 + "', '" + col4 + "') values('" + str1 + "', '" + str2 + "', '" + str3 + "', '" + str4 + "')"; //код БД в переменную

            comm.ExecuteNonQuery();
            connectDB.Close();
        }

        /// <summary>
        /// update *TABLE* set *COLUMN_2*=*STRING_2* where *COLUMN_1* like *STRING_1*
        /// </summary>
        public void UpdateDB()
        {
            connectDB.Open();
            //MainForm mainForm = new MainForm();
            //SQLiteCommand comm = mainForm.DB.CreateCommand(); //переменная БД
            SQLiteCommand comm = connectDB.CreateCommand(); //переменная БД
            comm.CommandText = "update '" + table + "' set '" + col2 + "'='" + str2 + "' where " + col1 + " like '" + str1 + "'"; //код БД в переменную
            comm.ExecuteNonQuery();
            connectDB.Close();
        }

        /// <summary>
        /// update *TABLE* set *COLUMN_1*=*STRING_1* where *COLUMN_2* like *STRING_2*
        /// </summary>
        public void UpdateDB(string table, string col1, string col2, string str1, string str2)
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
        public void DeleteDB()
        {
            connectDB.Open();
            //MainForm mainForm = new MainForm();
            //SQLiteCommand comm = mainForm.DB.CreateCommand(); //переменная БД
            SQLiteCommand comm = connectDB.CreateCommand(); //переменная БД
            comm.CommandText = "delete from '" + table + "' where " + col1 + " like '" + str1 + "'"; //код БД в переменную
            comm.ExecuteNonQuery();
            connectDB.Close();
        }

        /// <summary>
        /// delete from *TABLE* where *COLUMN* like *STRING*
        /// </summary>
        public void DeleteDB(string table, string col1, string str1)
        {
            connectDB.Open();
            SQLiteCommand comm = connectDB.CreateCommand(); //переменная БД
            comm.CommandText = "delete from '" + table + "' where " + col1 + " like '" + str1 + "'"; //код БД в переменную
            comm.ExecuteNonQuery();
            connectDB.Close();
        }

        public void CreateNewDB(string nameNewDB)
        {
            connectDB.Open();
            SQLiteCommand comm = connectDB.CreateCommand();
            //Создание всех таблиц
            comm.CommandText = "create table ProfRab(" +
                "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                "[btn_name] VARCHAR(20) NOT NULL," +
                "[btn_title] VARCHAR(32) NOT NULL," +
                "[btn_value] VARCHAR(1024)" +
                ");" +
                "create table PingList(" +
                "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                "[Name] STRING(255) NOT NULL," +
                "[Title] STRING(100) NOT NULL" +
                ");" +
                "create table ServiceRDP(" +
                "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                "[Name] STRING(100) NOT NULL," +
                "[Title] STRING(50) NOT NULL" +
                ");" +
                "create table ServiceShare(" +
                "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                "[Name] STRING(255) NOT NULL," +
                "[Title] STRING(50) NOT NULL" +
                ");" +
                "create table Printers(" +
                "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                "[Name] STRING(100) NOT NULL," +
                "[NetName] STRING(50)," +
                "[Location] STRING(20)," +
                "[InvNumber] INTEGER(15)" +
                ");" +
                "create table ProgList(" +
                "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                "[Name] STRING(255) NOT NULL" +
                ");" +
                "create table ReinstallOS(" +
                "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                "[Name] STRING(255) NOT NULL" +
                ");" +
                "create table RequestList(" +
                "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                "[Value] STRING(300) NOT NULL," +
                "[User] STRING(50) NOT NULL," +
                "[DateCreate] STRING NOT NULL," +
                "[DateUse] INTEGER(15)" +
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
