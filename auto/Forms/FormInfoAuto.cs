using auto.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto.Forms
{
    public partial class FormInfoAuto : Form
    {
        int idUser = 0;
        int idAuto = 0;
        Automobiles auto;

        public FormInfoAuto()
        {
            InitializeComponent();

            labelBrand.ReadOnly = true;
            labelModel.ReadOnly = true;
            labelYear.ReadOnly = true;
            labelPrice.ReadOnly = true;
        }

        public FormInfoAuto(int idauto, int iduser)
        {
            InitializeComponent();

            idUser = iduser;
            idAuto = idauto;

            labelBrand.ReadOnly = true;
            labelModel.ReadOnly = true;
            labelYear.ReadOnly = true;
            labelPrice.ReadOnly = true;

            EntitiesAutomobiles automobiles = new EntitiesAutomobiles();
            auto = automobiles.Automobiles.Where(x => x.idAuto == idAuto).FirstOrDefault();

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
            pictureBox1.Load(listView1.Items[0].Tag.ToString());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                ListViewItem lvi = listView1.FocusedItem; //получаем индекс выбранного файла в листе
                pictureBox1.Load(lvi.Tag.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMaximaze_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButtonOrder_Click(object sender, EventArgs e)
        {
            EntitiesAutomobiles automobiles = new EntitiesAutomobiles();
            Orders order = new Orders();
            Users users = automobiles.Users.Where(x => x.idUser == idUser).FirstOrDefault();
            Automobiles auto = automobiles.Automobiles.Where(x => x.idAuto == idAuto).FirstOrDefault();

            order.idAuto = idAuto;
            order.idUser = idUser;
            order.dateOrder = DateTime.Now;
            order.dateStart = dateTimeStart.Value;
            order.dateFinish = dateTimeFinish.Value;
            int n=0;
            n = (dateTimeFinish.Value-dateTimeStart.Value).Days+1;
            order.cost = automobiles.Automobiles.Where(z=>z.idAuto==idAuto).Select(x=>x.price).FirstOrDefault()*n;

            automobiles.Orders.Add(order);
            automobiles.SaveChanges();
        }
    }
}
