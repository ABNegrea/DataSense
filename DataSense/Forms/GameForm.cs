using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace DataSense.Forms
{
    public partial class GameForm : Form
    {

        string db = "DataSense.db";
        string path = @"URI=file:" + Application.StartupPath + "\\DataSense.db";

        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataAdapter da;

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

            GameTable.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            GameTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            conn = new SQLiteConnection(path);
            conn.Open();
            string q = "SELECT * FROM Games";
            cmd = new SQLiteCommand(q, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //GameTable.DataSource = dt;


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string data = "";
                GameTable.Rows.Add(dt.Rows[i].ItemArray[1].ToString());
                for (int j = 1; j < dt.Columns.Count; j++)
                {
                    GameTable.Rows[i].Cells[j-1].Value = dt.Rows[i].ItemArray[j].ToString();
                    //DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
                    //buttonCell.Value = dt.Rows[i].ItemArray[j].ToString();
                    //GameTable.Rows[i].Cells[j - 1].Value = buttonCell.Value;
                    //GameTable.Rows[i].Cells[j].Value = "Mama";//dt.Rows[i][j].ToString();
                    // data += dt.Rows[i].ItemArray[j].ToString();
                }
                //GameTable.Rows.Add(data);
            }

        }

    }
}
