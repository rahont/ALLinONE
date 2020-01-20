using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ALLinONE
{
    class UseDB
    {
        MainForm mainForm = new MainForm();

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

        /// <summary>
        /// select *COLUMN* from *TABLE*
        /// </summary>
        public SQLiteDataReader SelectDB()
        {
            SQLiteCommand comm = mainForm.DB.CreateCommand(); //переменная БД
            comm.CommandText = "select " + col1 + " from " + table + ""; //код БД в переменную
            SQLiteDataReader rdp = comm.ExecuteReader(); //результат кода в переменную

            return rdp;
        }

        /// <summary>
        /// select *COLUMN_1* from *TABLE* where *COLUMN_2* like *STRING*
        /// </summary>
        public SQLiteDataReader SelectDBLike()
        {
            SQLiteCommand comm = mainForm.DB.CreateCommand(); //переменная БД
            comm.CommandText = "select " + col1 + " from " + table + " where " + col2 + " like " + str1 + ""; //код БД в переменную
            SQLiteDataReader rdp = comm.ExecuteReader(); //результат кода в переменную

            return rdp;
        }

        /// <summary>
        /// insert into *TABLE*(*COLUMN*) values(*STRING*)
        /// </summary>
        public void InsertDB()
        {
            SQLiteCommand comm = mainForm.DB.CreateCommand(); //переменная БД
            if (numbCol == 1)
                comm.CommandText = "insert into '" + table + "'('" + col1 + "') values('" + str1 + "')"; //код БД в переменную
            if (numbCol == 2)
                comm.CommandText = "insert into '" + table + "'('" + col1 + "', '" + col2 + "') values('" + str1 + "', '" + str2 + "')"; //код БД в переменную
            if (numbCol == 3)
                comm.CommandText = "insert into '" + table + "'('" + col1 + "', '" + col2 + "', '" + col3 + "') values('" + str1 + "', '" + str2 + "', '" + str3 + "')"; //код БД в переменную
            if (numbCol == 4)
                comm.CommandText = "insert into '" + table + "'('" + col1 + "', '" + col2 + "', '" + col3 + "', '" + col4 + "') values('" + str1 + "', '" + str2 + "', '" + str3 + "', '" + str4 + "')"; //код БД в переменную
            comm.ExecuteNonQuery();
        }

        /// <summary>
        /// update *TABLE* set *COLUMN_2*=*STRING_2* where *COLUMN_1* like *STRING_1*
        /// </summary>
        public void UpdateDB()
        {
            SQLiteCommand comm = mainForm.DB.CreateCommand(); //переменная БД
            comm.CommandText = "update '" + table + "' set '" + col2 + "'='" + str2 + "' where " + col1 + " like '" + str1 + "'"; //код БД в переменную
            comm.ExecuteNonQuery();
        }

        /// <summary>
        /// delete from *TABLE* where *COLUMN* like *STRING*
        /// </summary>
        public void DeleteDB()
        {
            SQLiteCommand comm = mainForm.DB.CreateCommand(); //переменная БД
            comm.CommandText = "delete from '" + table + "' where " + col1 + " like '" + str1 + "'"; //код БД в переменную
            comm.ExecuteNonQuery();
        }
    }
}
