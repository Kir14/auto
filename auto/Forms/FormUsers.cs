using auto.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto.Forms
{
    public partial class FormUsers : Form
    {

        EntitiesAutomobiles automobiles = new EntitiesAutomobiles();

        public FormUsers()
        {
            

            InitializeComponent();

            

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DataSource = automobiles.Users.ToList();

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "№ Прав";
            dataGridView1.Columns[5].HeaderText = "Телефон";
            dataGridView1.Columns[6].HeaderText = "Логин";
            dataGridView1.Columns[7].HeaderText = "Пароль";
            dataGridView1.Columns[8].HeaderText = "Почта";
            dataGridView1.Columns[9].HeaderText = "Администратор";

            //DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            //col.TrueValue = 1;
            //col.FalseValue = 0;

            //dataGridView1.Columns.Add(col);
            //dataGridView1.Columns[11].HeaderText = "Администратор";

            int n = dataGridView1.Columns.Count;
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            //n = dataGridView1.Rows.Count;
            //for (int i = 0; i < n; n++)
            //{
            //    dataGridView1.Rows[i].Cells[11].Value = "1";
            //}

            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[11];
            //    chk.Value = 1;
            //}

            dataGridView1.Columns[0].ReadOnly = true;

            dataGridView1.Columns[7].Visible = false;

            dataGridView1.Columns[10].Visible = false;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            automobiles.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach( DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                Users user = automobiles.Users.Where(x => x.idUser == id).FirstOrDefault();
                automobiles.Users.Remove(user);
            }
            automobiles.SaveChanges();
            dataGridView1.DataSource= automobiles.Users.ToList();

        }

        private void dataGridView1_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            object head = this.dataGridView1.Rows[e.RowIndex].HeaderCell.Value;
            if (head == null ||
                !head.Equals((e.RowIndex + 1).ToString()))
                this.dataGridView1.Rows[e.RowIndex].HeaderCell.Value =
                    (e.RowIndex + 1).ToString();
        }
    }
}
