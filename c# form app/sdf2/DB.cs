using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sdf2
{
    class DB
    {
        
        private SqlConnection connection;
        private SqlCommand command;
        private string str_conn = "Data Source=.;Initial Catalog=market;Integrated Security=True";
        public DB() {
            connection = new SqlConnection(str_conn);
        }

        public bool insert(string tableName, string[] columns, object[] values) {
            bool isInserted = false;
            string cmd_insert = "insert into " + tableName +"("+ str_build(columns) + ") values("+ str_build(columns, '@') + ")" ;

            command = new SqlCommand(cmd_insert,connection);

            for (int i = 0; i < columns.Length; i++)
            {
                command.Parameters.AddWithValue("@" + columns[i], values[i]);
            }

            connection.Open();

            int result = command.ExecuteNonQuery();

            if (result != 0)
            {
                isInserted = true;
            }

            connection.Close();

            return isInserted;
        }

        public SqlDataReader select(string tableName, string[] selection, string[] where , object[] whereValues ) {
            string cmd_select = "select "+ str_build(selection) +" from "+tableName;

            if (where.Length != 0){
                StringBuilder builder = new StringBuilder();
                foreach (string w in where)
                {
                    builder.Append(w + "=@" + w);

                    if (w != where.Last())
                    {
                        builder.Append("and");
                    }
                }

                cmd_select += " where " + builder;
            }

            command = new SqlCommand(cmd_select, connection);

            if (where.Length != 0 && whereValues.Length != 0)
            {
                for (int i = 0; i < where.Length; i++)
                {
                    command.Parameters.AddWithValue("@" + where[i], whereValues[i]);
                }
            }

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            return reader;           
            
        }

        public bool delete(string tableName, string[] where, object[] whereValues) {
            bool isDeleted = false;

            string cmd_delete = "delete from " +tableName;

            if (where.Length != 0) {
                cmd_delete += " where ";

                StringBuilder builder = new StringBuilder();
                foreach (string w in where)
                {
                    builder.Append(w + "=@" + w);

                    if (w != where.Last())
                    {
                        builder.Append("and");
                    }
                }

                cmd_delete += builder;
            }

            command = new SqlCommand(cmd_delete,connection);

            if (where.Length != 0 && whereValues.Length != 0) {
                for (int i = 0; i < where.Length; i++)
                {
                    command.Parameters.AddWithValue("@" + where[i], whereValues[i]);
                }
            }
            
            connection.Open();

            int result = command.ExecuteNonQuery();

            if (result != 0)
            {
                isDeleted = true;
            }

            return isDeleted;
        }

        public bool update(string tableName, string[] updateColumn, object[] values, string[] where, object[] whereValues) {
            bool isUpdated = false;

            string cmd_update = "update " + tableName + " set ";

            StringBuilder builder = new StringBuilder();
            foreach (string col in updateColumn) {
                builder.Append(col + "=@" + col);

                if (col != updateColumn.Last()) {
                    builder.Append(',');
                }
            }

            cmd_update += builder;

            if (where.Length != 0)
            {
                cmd_update += " where ";

                StringBuilder builder2 = new StringBuilder();
                foreach (string w in where)
                {
                    builder2.Append(w + "=@" + w);

                    if (w != where.Last())
                    {
                        builder2.Append("and");
                    }
                }

                cmd_update += builder2;
            }

            command = new SqlCommand(cmd_update,connection);

            for (int i = 0; i < updateColumn.Length; i++) {
                command.Parameters.AddWithValue("@" + updateColumn[i], values[i]);
            }

            if (where.Length != 0 && whereValues.Length != 0)
            {
                for (int i = 0; i < where.Length; i++)
                {
                    command.Parameters.AddWithValue("@" + where[i], whereValues[i]);
                }
            }

            connection.Open();

            int result = command.ExecuteNonQuery();

            if (result != 0) {
                isUpdated = true;
            }

            connection.Close();

            return isUpdated;
            
        }

        public void closeConnection() {
            connection.Close();
        }

        private string str_build(string[] columns, char junc=' ' ) {
            StringBuilder builder = new StringBuilder();
            foreach (string col in columns) {
                builder.Append(junc+col);

                if (col != columns.Last()) {
                    builder.Append(',');
                }
            }

            return builder.ToString();
            
        }
    }
}
