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
    public partial class FormInfoAuto : Form
    {
        Automobiles auto;

        public FormInfoAuto()
        {
            InitializeComponent();
        }

        public FormInfoAuto(int id)
        {
            InitializeComponent();

            EntitiesAutomobiles automobiles = new EntitiesAutomobiles();
            auto = automobiles.Automobiles.Where(x => x.idAuto == id).FirstOrDefault();

            listView1.LargeImageList = imageList1;
            imageList1.ImageSize = new Size(100, 100);

            List<string> images = auto.Images.
                    Where(x => x.idAuto == auto.idAuto)
                    .Select(x => x.image).ToList();
            int i = 0;
            foreach (string el in images)
            {
                try
                {
                    imageList1.Images.Add(Image.FromFile(el));
                }
                catch
                {
                    MessageBox.Show(
                        "Файл не открывается",
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);

                }

                // установка названия файла
                ListViewItem lvi = new ListViewItem();
                //lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);

                lvi.Tag = el;
                lvi.ImageIndex = i; // установка картинки для файла
                
                listView1.Items.Add(lvi);
                i++;
            }
            labelBrand.Text = auto.Brands.nameBrand;
            labelModel.Text = auto.Models.nameModel;
            labelPrice.Text = auto.price.ToString();
            labelYear.Text = auto.yearModel.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                ListViewItem lvi = listView1.FocusedItem; //получаем индекс выбранного файла в листе
                pictureBox1.Load(lvi.Tag.ToString());
            }
        }
    }
}
