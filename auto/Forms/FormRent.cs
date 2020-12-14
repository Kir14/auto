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
    public partial class FormRent : Form
    {
        EntitiesAutomobiles automobiles = new EntitiesAutomobiles();

        public FormRent()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadBd();
        }

        private void LoadBd()
        {
            InfoUser info = new InfoUser();
            int idUser = info.getidUser();
            if (info.getidUser()==0)
            {

            }
            else
            {
                int i = 0;
                foreach(Orders rent in automobiles.Orders.Where(x => x.idUser == idUser))
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = rent.Automobiles.Brands.nameBrand + " " + rent.Automobiles.Models.nameModel;
                    dataGridView1.Rows[i].Cells[1].Value = rent.dateStart;
                    dataGridView1.Rows[i].Cells[2].Value = rent.dateFinish;
                    dataGridView1.Rows[i].Cells[3].Value = rent.cost;
                    dataGridView1.Rows[i].Cells[4].Value = rent.idOrder;
                    i++;
                }
            }
            
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            object head = this.dataGridView1.Rows[e.RowIndex].HeaderCell.Value;
            if (head == null ||
                !head.Equals((e.RowIndex + 1).ToString()))
                this.dataGridView1.Rows[e.RowIndex].HeaderCell.Value =
                    (e.RowIndex + 1).ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int id = Int32.Parse(row.Cells[4].Value.ToString());
                Orders order = automobiles.Orders.Where(x => x.idOrder == id).FirstOrDefault();
                automobiles.Orders.Remove(order);
                dataGridView1.Rows.Remove(row);
            }
            automobiles.SaveChanges();
        }
    }
}
