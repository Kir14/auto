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
    public partial class FormOrders : Form
    {
        EntitiesAutomobiles automobiles = new EntitiesAutomobiles();

        public FormOrders()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DataSource = automobiles.Orders.ToList();

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Id Auto";
            dataGridView1.Columns[2].HeaderText = "ID User";
            dataGridView1.Columns[3].HeaderText = "Дата заказа";
            dataGridView1.Columns[4].HeaderText = "Начало аренды";
            dataGridView1.Columns[5].HeaderText = "Конец аренды";
            dataGridView1.Columns[6].HeaderText = "Стоимость";

            //DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                        
            //dataGridView1.Columns.Add(column);
            //dataGridView1.Columns[9].HeaderText = "Авто";
            //dataGridView1.Columns[9].Name = "Авто";

            int n = dataGridView1.Columns.Count;
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }


            //n = dataGridView1.Rows.Count;
            //for (int i = 0; i < n; i++)
            //{
            //    auto= automobiles.Automobiles.Where(x => x.idAuto ==
            //       Int32.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString())).FirstOrDefault();
            //    dataGridView1[9, i].Value = auto.Brands.nameBrand + " " + auto.Models.nameModel;
            //}

            Automobiles auto = new Automobiles();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int idauto = Int32.Parse(row.Cells[1].Value.ToString());
                auto = automobiles.Automobiles.Where(x => x.idAuto == idauto).FirstOrDefault();
                row.Cells[9].Value = (auto.Brands.nameBrand + "  11 " + auto.Models.nameModel).ToString();
            }
            dataGridView1[9, 1].Value = "dsdsds";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                Orders order = automobiles.Orders.Where(x => x.idOrder == id).FirstOrDefault();
                automobiles.Orders.Remove(order);
            }
            automobiles.SaveChanges();
            dataGridView1.DataSource = automobiles.Orders.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            automobiles.SaveChanges();
        }
    }
}
