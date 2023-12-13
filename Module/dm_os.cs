using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Reflection;
using REMAS.Forms.Account;
using System.Data.SqlClient;

namespace REMAS.Module
{
    internal class dm_os
    {
        private DataTable AutoNumberedTable(DataTable SourceTable)

        {

            DataTable ResultTable = new DataTable();

            DataColumn AutoNumberColumn = new DataColumn();

            AutoNumberColumn.ColumnName = "No.";

            AutoNumberColumn.DataType = typeof(int);

            AutoNumberColumn.AutoIncrement = true;

            AutoNumberColumn.AutoIncrementSeed = 1;

            AutoNumberColumn.AutoIncrementStep = 1;

            ResultTable.Columns.Add(AutoNumberColumn);

            ResultTable.Merge(SourceTable);

            return ResultTable;

        }
    }

    public class RunQuery : DataTable
    {
        private OleDbConnection MyCon;
        private DataTable MyData;
        private OleDbDataAdapter myOleAdapter;
        public DataTable OpenAdoQuery(string sQuery)
        {
            string sServerAddress = Properties.Settings.Default.ServerName;
            string sPassword = Properties.Settings.Default.PwdDB;
            //string sServerAddress = "192.168.111.26";
            string strConn = "Provider=SQLOLEDB.1;Password="+ sPassword +";" +
                             "Persist Security Info=True;User ID=sa;Initial Catalog=REMAS;" +
                             "Data Source=" + sServerAddress + " ";

            MyCon = new OleDbConnection(strConn);
            MyData = new DataTable();
            try
            {
                MyCon.Open();

                myOleAdapter = new OleDbDataAdapter();
                myOleAdapter.SelectCommand = new OleDbCommand(sQuery, MyCon);
                myOleAdapter.Fill(MyData);
                MyCon.Close();
            }
            catch (Exception e)
            {
                MyCon.Close();
                MessageBox.Show("SQL Connection Fail --> " + e.Message, "SQLConCLS - OpenAdoQuery");
            }
            return MyData;
        }
    }

    public class ExecSqlServer
    {
        private OleDbConnection MyCon;
        private OleDbCommand cmd;
        //private List<SqlParameter> Params = new List<SqlParameter>();

        public bool ExecSql(string StrQuery)
        {
            string sServerAddress = Properties.Settings.Default.ServerName;
            string sPassword = Properties.Settings.Default.PwdDB;
            //string sServerAddress = "192.168.111.26";
            string strConn = "Provider=SQLOLEDB.1;Password="+ sPassword +";MultipleActiveResult=True;" +
                             "Persist Security Info=True;User ID=sa;Initial Catalog=REMAS;" +
                             "Data Source=" + sServerAddress + " ";

            MyCon = new OleDbConnection(strConn);

            try
            {
                MyCon.Open();
                cmd = new OleDbCommand(StrQuery, MyCon);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MyCon.Close();
                return true;
            }
            catch (Exception e)
            {
                MyCon.Close();
                MessageBox.Show("SQL EXEC Fail --> " + e.Message, "SQLConCLS - ExecSqlServer");
                return false;
            }
        }        

        public bool ExecSql(string StrQuery, string StrQuery2)
        {
            string sServerAddress = Properties.Settings.Default.ServerName;
            string sPassword = Properties.Settings.Default.PwdDB;
            //string sServerAddress = "192.168.111.26";
            string strConn = "Provider=SQLOLEDB.1;Password=" + sPassword + ";MultipleActiveResult=True;" +
                             "Persist Security Info=True;User ID=sa;Initial Catalog=REMAS;" +
                             "Data Source=" + sServerAddress + " ";

            MyCon = new OleDbConnection(strConn);
            OleDbTransaction trans = null;

            try
            {
                MyCon.Open();
                trans = MyCon.BeginTransaction();
                cmd = new OleDbCommand(StrQuery, MyCon, trans);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand(StrQuery2, MyCon, trans);
                cmd.ExecuteNonQuery();
                //trans.Rollback();
                trans.Commit();
                cmd.Dispose();
                MyCon.Close();
                return true;
            }
            catch (Exception e)
            {
                if (trans != null) trans.Rollback();
                MyCon.Close();
                MessageBox.Show("SQL EXEC Fail --> " + e.Message, "SQLConCLS - ExecSqlServer");
                return false;
            }
        }

        public bool ExecSql(string StrQuery, string StrQuery2, string StrQuery3)
        {
            string sServerAddress = Properties.Settings.Default.ServerName;
            string sPassword = Properties.Settings.Default.PwdDB;
            //string sServerAddress = "192.168.111.26";
            string strConn = "Provider=SQLOLEDB.1;Password=" + sPassword + ";MultipleActiveResult=True;" +
                             "Persist Security Info=True;User ID=sa;Initial Catalog=REMAS;" +
                             "Data Source=" + sServerAddress + " ";

            MyCon = new OleDbConnection(strConn);
            OleDbTransaction trans = null;

            try
            {
                MyCon.Open();
                trans = MyCon.BeginTransaction();
                cmd = new OleDbCommand(StrQuery, MyCon, trans);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand(StrQuery2, MyCon, trans);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand(StrQuery3, MyCon, trans);
                cmd.ExecuteNonQuery();
                //trans.Rollback();
                trans.Commit();
                cmd.Dispose();
                MyCon.Close();
                return true;
            }
            catch (Exception e)
            {
                if (trans != null) trans.Rollback();
                MyCon.Close();
                MessageBox.Show("SQL EXEC Fail --> " + e.Message, "SQLConCLS - ExecSqlServer");
                return false;
            }
        }
        /*
        public bool ExecSql(string StrQuery, string StrQuery2, string StrQuery3, string StrQuery4)
        {
            string sServerAddress = Properties.Settings.Default.ServerName;
            string sPassword = Properties.Settings.Default.PwdDB;
            //string sServerAddress = "192.168.111.26";
            string strConn = "Provider=SQLOLEDB.1;Password=" + sPassword + ";MultipleActiveResult=True;" +
                             "Persist Security Info=True;User ID=sa;Initial Catalog=REMAS;" +
                             "Data Source=" + sServerAddress + " ";

            MyCon = new OleDbConnection(strConn);
            OleDbTransaction trans = null;

            try
            {
                MyCon.Open();
                trans = MyCon.BeginTransaction();
                cmd = new OleDbCommand(StrQuery, MyCon, trans);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand(StrQuery2, MyCon, trans);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand(StrQuery3, MyCon, trans);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand(StrQuery4, MyCon, trans);
                cmd.ExecuteNonQuery();
                //trans.Rollback();
                trans.Commit();
                cmd.Dispose();
                MyCon.Close();
                return true;
            }
            catch (Exception e)
            {
                if (trans != null) trans.Rollback();
                MyCon.Close();
                MessageBox.Show("SQL EXEC Fail --> " + e.Message, "SQLConCLS - ExecSqlServer");
                return false;
            }
        }


        public bool ExecSql(string StrQuery, string StrQuery2, string StrQuery3, string StrQuery4, string StrQuery5)
        {
            string sServerAddress = Properties.Settings.Default.ServerName;
            string sPassword = Properties.Settings.Default.PwdDB;
            //string sServerAddress = "192.168.111.26";
            string strConn = "Provider=SQLOLEDB.1;Password=" + sPassword + ";MultipleActiveResult=True;" +
                             "Persist Security Info=True;User ID=sa;Initial Catalog=REMAS;" +
                             "Data Source=" + sServerAddress + " ";

            MyCon = new OleDbConnection(strConn);
            OleDbTransaction trans = null;

            try
            {
                MyCon.Open();
                trans = MyCon.BeginTransaction();
                cmd = new OleDbCommand(StrQuery, MyCon, trans);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand(StrQuery2, MyCon, trans);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand(StrQuery3, MyCon, trans);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand(StrQuery4, MyCon, trans);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand(StrQuery5, MyCon, trans);
                cmd.ExecuteNonQuery();
                //trans.Rollback();
                trans.Commit();
                cmd.Dispose();
                MyCon.Close();
                return true;
            }
            catch (Exception e)
            {
                if (trans != null) trans.Rollback();
                MyCon.Close();
                MessageBox.Show("SQL EXEC Fail --> " + e.Message, "SQLConCLS - ExecSqlServer");
                return false;
            }
        }
        */
    }

    public class Security
    {
        /* Generate Salt */
        private static byte[] GenerateSalt(int length)
        {
            var salt = new byte[length];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        /* Hashing Password */
        public string Hashing(string password)
        {
            //byte[] salt = GenerateSalt(32);
            byte[] salt = Encoding.ASCII.GetBytes("r7TMZ98zLzsAfN8K");
            var sha = SHA1.Create();
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            var passwordWithSaltBytes = new byte[passwordBytes.Length + salt.Length];

            Buffer.BlockCopy(passwordBytes, 0, passwordWithSaltBytes, 0, passwordBytes.Length);
            Buffer.BlockCopy(salt, 0, passwordWithSaltBytes, passwordBytes.Length, salt.Length);

            var hashBytes = sha.ComputeHash(passwordWithSaltBytes);
            var hash = Convert.ToBase64String(hashBytes);

            return hash;
        }

        /* Verify Password with Original Password and Salt */
        public bool VerifyPassword(string password, string hash)
        {
            var hashedPassword = Hashing(password);
            return hash == hashedPassword;
        }

        public string GeneratePassword()
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-=[]{};:,.<>?";
            var random = new Random();
            var password = new StringBuilder();

            for (int i = 0; i < 8; i++)
            {
                int index = random.Next(validChars.Length);
                password.Append(validChars[index]);
            }
            return password.ToString();
        }        
    }

    public class CallForm
    {
        // No MDIParent only to fm Login
        public void fmNames(Type formName)
        {
            Form frm = new Form();
            frm = (Form)Activator.CreateInstance(formName);
            frm.ShowDialog();
        }

        public void fmByName(string formName)
        {
            Type[] typelist = GetTypesInNamespace(Assembly.GetExecutingAssembly(), "REMAS.Forms.Account");
            for (int i = 0; i < typelist.Length; i++)
            {//Loop on them 
                //if (typelist[i].BaseType == typeof(System.Windows.Forms.Form) && typelist[i].Name == formName)
                if (typelist[i].BaseType == typeof(Form) && typelist[i].Name == formName)
                {//if windows form and the name is match

                    //Create Instance and show it
                    Form tmp = (Form)Activator.CreateInstance(typelist[i]);
                    //MessageBox.Show(typelist[i].Name);
                    tmp.ShowDialog();
                }
            }
        }

        private Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return assembly.GetTypes().Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal)).ToArray();
        }

        private static string namespacePrefix = "REMAS.Forms.Account.";

        public Form CreateFormByName(string formName)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Type formType = myAssembly.GetType(namespacePrefix + formName);
            if (formType == null)
                throw new ArgumentException("Form type not found");
            return (Form)Activator.CreateInstance(formType);
        }
    }
}
