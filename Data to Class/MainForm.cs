using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_to_Class
{
    public partial class MainForm : Form
    {
        OleDbConnection cnn;
        List<Table> allTables;

        public MainForm()
        {
            InitializeComponent();
            allTables = new List<Table>();
        }

        private void btnConnectAndGetTableNames_Click(object sender, EventArgs e)
        {
            string error = "";
            error = ConnectToDatabase();
            if (error != "")
            {
                MessageBox.Show(error);
                return;
            }

            error = GetAllTablesAndColumnsFromDatabase();
            if (error != "")
            {
                MessageBox.Show(error);
                return;
            }

            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }

            error = ListDatabaseInListbox();
            if (error != "")
            {
                MessageBox.Show(error);
                return;
            }

            panelConnection.Visible = false;
            panelSave.Visible = true;
        }

        private string ListDatabaseInListbox()
        {
            string error = "";

            try
            {
                for (int i = 0; i < allTables.Count; i++)
                {
                    lstTableNames.Items.Add(allTables[i].tableName);

                }
                lblTabloSayisi.Text = "TABLO SAYISI: " + allTables.Count.ToString();
            }
            catch (Exception e)
            {
                error = e.Message;
            }

            return error;
        }

        private string GetAllTablesAndColumnsFromDatabase()
        {
            string error = "";

            switch (cmbDatabaseName.Text)
            {
                case "MSSQL":
                    try
                    {
                        string getAllTableNamesAndColumnsSQL = string.Format("SELECT t.TABLE_NAME,c.COLUMN_NAME,c.DATA_TYPE,c.CHARACTER_MAXIMUM_LENGTH " +
                            "FROM {0}.INFORMATION_SCHEMA.COLUMNS c, " +
                            "{0}.INFORMATION_SCHEMA.TABLES t WHERE " +
                            "t.TABLE_NAME=c.TABLE_NAME AND t.TABLE_TYPE='BASE TABLE' ORDER BY t.TABLE_NAME,c.ORDINAL_POSITION", txtDatabaseName.Text);

                        OleDbCommand sqlCmd = new OleDbCommand(getAllTableNamesAndColumnsSQL, cnn);
                        OleDbDataReader rdr = sqlCmd.ExecuteReader();

                        string tableName = "";
                        bool firstRow = true;
                        allTables = new List<Table>();
                        Table myTable = new Table();
                        Column myColumn = new Column();

                        while (rdr.Read())
                        {
                            if (firstRow)
                            {
                                tableName = rdr["TABLE_NAME"].ToString();
                                firstRow = false;
                            }

                            if (tableName != rdr["TABLE_NAME"].ToString())
                            {
                                myTable.tableName = tableName;
                                allTables.Add(myTable);
                                myTable = new Table();
                                tableName = rdr["TABLE_NAME"].ToString();
                            }


                            myColumn.columnName = rdr["COLUMN_NAME"].ToString();
                            myColumn.columnDbType = rdr["DATA_TYPE"].ToString();
                            myColumn.columnProgramType = GetProgramVaraibleType(myColumn.columnDbType);
                            if (rdr["CHARACTER_MAXIMUM_LENGTH"] != null)
                            {
                                myColumn.columnLength = rdr["CHARACTER_MAXIMUM_LENGTH"].ToString();
                            }
                            myTable.columnArray.Add(myColumn);
                            myColumn = new Column();
                        }
                        myTable.tableName = tableName;
                        allTables.Add(myTable);
                        myTable = new Table();
                        rdr.Close();
                    }
                    catch (Exception ex)
                    {
                        error = ex.Message;
                    }
                    break;

                case "Bir Diğer Data Tipi":
                    break;

                default:
                    error = "Tabloları Alamadım!";
                    break;
            }
            return error;
        }

        private string ConnectToDatabase()
        {
            string error = "";
            switch (cmbDatabaseName.Text)
            {
                case "MSSQL":
                    string connetionString = string.Format("Provider=SQLOLEDB;Server={0};Database={1};User Id={2};Password={3};",
                        txtServerName.Text, txtDatabaseName.Text, txtUserName.Text, txtPassword.Text);

                    cnn = new OleDbConnection(connetionString);
                    try
                    {
                        cnn.Open();
                    }
                    catch (Exception ex)
                    {
                        error = ex.Message;
                    }
                    break;

                default:
                    error = "Database Seçimi Yap!";
                    break;
            }
            return error;
        }

        private string GetProgramVaraibleType(string dbVaraibleType)
        {
            switch (dbVaraibleType)
            {
                case "bigint":
                    return "long";

                case "binary":
                    return "byte[]";

                case "bit":
                    return "bool";

                case "char":
                    return "string";

                case "date":
                    return "DateTime";

                case "datetime":
                    return "DateTime";

                case "datetime2":
                    return "DateTime";

                case "datetimeoffset":
                    return "DateTimeOffset";

                case "decimal":
                    return "decimal";

                case "float":
                    return "float";

                case "image":
                    return "byte[]";

                case "int":
                    return "int";

                case "money":
                    return "decimal";

                case "nchar":
                    return "string";

                case "ntext":
                    return "string";

                case "numeric":
                    return "decimal";

                case "nvarchar":
                    return "string";

                case "real":
                    return "double";

                case "smalldatetime":
                    return "DateTime";

                case "smallint":
                    return "short";

                case "smallmoney":
                    return "decimal";

                case "text":
                    return "string";

                case "time":
                    return "TimeSpan";

                case "timestamp":
                    return "DateTime";

                case "tinyint":
                    return "byte";

                case "uniqueidentifier":
                    return "Guid";

                case "varbinary":
                    return "byte[]";

                case "varchar":
                    return "string";
                default:
                    return "UNKNOWN_" + dbVaraibleType;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbConvertLanguage.SelectedIndex = cmbConvertLanguage.FindStringExact("C#");
            cmbDatabaseName.SelectedIndex = cmbDatabaseName.FindStringExact("MSSQL");
        }

        private void btnConvertAndSave_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(lblSavePath.Text))
            {
                MessageBox.Show("Seçilen kayıt yolu geçerli değil.");
                return;
            }

            string error = "";

            if (cmbConvertLanguage.Text == "C#")
            {
                error = ConvertAllTables();

                if (error != "")
                {
                    MessageBox.Show(error);
                    return;
                }

                error = SaveAllTables();

                if (error != "")
                {
                    MessageBox.Show(error);
                    return;
                }
                Process.Start(lblSavePath.Text);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Henüz C# dışında diğer diller için destek gelmemiştir.");
            }
        }

        private string SaveAllTables()
        {
            string error = "";
            try
            {
                for (int i = 0; i < allTables.Count; i++)
                {
                    FileStream fs = new FileStream(lblSavePath.Text + "\\" + allTables[i].tableName + ".cs", FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.BaseStream.Seek(0, SeekOrigin.End);
                    sw.WriteLine(allTables[i].classText);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return error;
        }

        private string ConvertAllTables()
        {
            string error = "";
            try
            {
                for (int i = 0; i < allTables.Count; i++)
                {
                    allTables[i].classText += Consts.classIntro;
                    allTables[i].classText += allTables[i].tableName;
                    allTables[i].classText += Consts.classSecondIntro;
                    for (int j = 0; j < allTables[i].columnArray.Count; j++)
                    {
                        allTables[i].classText +=
                            Consts.accessModifiersPublic +
                            Consts.space +
                            allTables[i].columnArray[j].columnProgramType +
                            Consts.space +
                            allTables[i].columnArray[j].columnName +
                            Consts.space +
                            Consts.getterSetter + "\n";
                    }
                    allTables[i].classText += Consts.classOutro;
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return error;
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    lblSavePath.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
