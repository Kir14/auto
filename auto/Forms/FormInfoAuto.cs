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
        int i = 0;
        int idUser = 0;
        int idAuto = 0;
        Automobiles auto;
        EntitiesAutomobiles automobiles;

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
            automobiles = new EntitiesAutomobiles();

            InfoUser info = new InfoUser();

            idUser = info.getidUser();
            Users user = automobiles.Users.Where(x => x.idUser == idUser).FirstOrDefault();
            
            idAuto = idauto;

            if (user.admin.Value)
            {
                iconButtonOrder.Visible = false;
                btnIzm.Visible = true;
                labelBrand.ReadOnly = false;
                labelModel.ReadOnly = false;
                labelYear.ReadOnly = false;
                labelPrice.ReadOnly = false;
            }
            else
            {
                iconButton1.Visible = false;
                iconButton2.Visible = false;
                btnIzm.Visible = false;
                labelBrand.ReadOnly = true;
                labelModel.ReadOnly = true;
                labelYear.ReadOnly = true;
                labelPrice.ReadOnly = true;
            }

            auto = automobiles.Automobiles.Where(x => x.idAuto == idAuto).FirstOrDefault();

            listView1.LargeImageList = imageList1;
            imageList1.ImageSize = new Size(100, 100);

            List<string> images = auto.Images.
                    Where(x => x.idAuto == auto.idAuto)
                    .Select(x => x.image).ToList();
            int j = 0;
            foreach (string el in images)
            {
                try
                {
                    imageList1.Images.Add(Image.FromFile(el));
                    i++;
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
                lvi.ImageIndex = j; // установка картинки для файла

                listView1.Items.Add(lvi);
                j++;
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
            int n = 0;
            n = (dateTimeFinish.Value - dateTimeStart.Value).Days + 1;
            order.cost = automobiles.Automobiles.Where(z => z.idAuto == idAuto).Select(x => x.price).FirstOrDefault() * n;

            bool add = false;
            DateTime start = DateTime.Now, finish = DateTime.Now;
            if (automobiles.Orders.Where(x => x.idAuto == idAuto).Count() == 0)
            {
                add = true;
            }

            foreach (Orders ord in automobiles.Orders.Where(x => x.idAuto == idAuto))
            {
                if ((order.dateStart.Value.Date >= ord.dateStart.Value.Date && order.dateStart.Value.Date <= ord.dateFinish.Value.Date) ||
                    (order.dateFinish.Value.Date >= ord.dateStart.Value.Date && order.dateFinish.Value.Date <= ord.dateFinish.Value.Date) ||
                    (ord.dateStart.Value.Date >= order.dateStart.Value.Date && ord.dateStart.Value.Date <= order.dateFinish.Value.Date) ||
                    (ord.dateFinish.Value.Date >= order.dateStart.Value.Date && ord.dateFinish.Value.Date <= order.dateFinish.Value.Date))
                {
                    start = ord.dateStart.Value.Date;
                    finish = ord.dateFinish.Value.Date;
                    add = false;
                    break;
                }
                else
                {
                    add = true;
                }
            }
            if (add)
            {
                labelMessage.ForeColor = Color.GreenYellow;
                labelMessage.Text = "Авто забронированно";
                automobiles.Orders.Add(order);
            }
            else
            {
                labelMessage.ForeColor = Color.Red;
                labelMessage.Text = "Автомобиль уже забронирован с " + start.Date.ToString() + " до " + finish.Date.ToString();
            }
            automobiles.SaveChanges();

        }

        private void btnIzm_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = false;
            listView1.LargeImageList = imageList1;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in OFD.FileNames)
                {
                    imageList1.Images.Add(Image.FromFile(file));
                    //MessageBox.Show(file);
                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag = "packages\\Foto\\"+ labelBrand.Text + "_" + labelModel.Text + "_" + (i + 1).ToString()+ ".jpg";
                    lvi.ImageIndex = i; // установка картинки для файла
                    
                    // добавляем элемент в ListView
                    listView1.Items.Add(lvi);

                    string path = "";
                    path += lvi.Tag.ToString();
                    Images image = new Images();
                    image.idAuto = auto.idAuto;
                    image.image = path;
                    automobiles.Images.Add(image);

                    
                    Image img = imageList1.Images[i];
                    img.Save(path);

                    i++;
                }
                automobiles.SaveChanges();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null)
            {
                string path = "";
                path = listView1.FocusedItem.Tag.ToString();
                
                imageList1.Images.RemoveAt(listView1.FocusedItem.Index);
                listView1.FocusedItem.Remove();
                Images image = automobiles.Images.Where(x => x.image == path).FirstOrDefault();
                automobiles.Images.Remove(image);

                i = 0;
                foreach (ListViewItem lvi in listView1.Items)
                {
                    image=automobiles.Images.Where(x => x.image==lvi.Tag.ToString()).FirstOrDefault();
                    lvi.Tag = "packages\\Foto\\"+ labelBrand.Text + "_" + labelModel.Text + "_" + (i + 1).ToString()+".jpg";
                    image.image = lvi.Tag.ToString();
                    lvi.ImageIndex = i; // установка картинки для файла
                    i++;
                    automobiles.SaveChanges();
                }
            }
        }
    }
}
