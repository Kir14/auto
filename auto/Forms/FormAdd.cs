using auto.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto.Forms
{
    public partial class FormAdd : Form
    {
        int i = 0;

        public FormAdd()
        {
            InitializeComponent();
            imageList1.ImageSize = new Size(250, 250);
        }

        public void SaveFoto()
        {

            foreach (ListViewItem lvi in listView1.Items)
            {
                string path = "packages\\Foto\\";
                path += lvi.Text + ".jpg";
                Image img = imageList1.Images[lvi.Index];
                img.Save(path);
            }

        }

        private void addFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = false;
            listView1.LargeImageList = imageList1;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                //List<string> files = Directory.GetFiles(OFD.FileNames);

                foreach (string file in OFD.FileNames)
                {
                    imageList1.Images.Add(Image.FromFile(file));
                    //MessageBox.Show(file);
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = textBrand.Text + "_" + textModel.Text + "_" + (i + 1).ToString();
                    lvi.ImageIndex = i; // установка картинки для файла
                    i++;
                    // добавляем элемент в ListView
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void deleteFoto_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null)
            {
                i = 0;
                imageList1.Images.RemoveAt(listView1.FocusedItem.Index);
                listView1.FocusedItem.Remove();
                foreach (ListViewItem lvi in listView1.Items)
                {
                    lvi.Text = textBrand.Text + "_" + textModel.Text + "_" + (i + 1).ToString();
                    lvi.ImageIndex = i; // установка картинки для файла
                    i++;
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            EntitiesAutomobiles automobiles = new EntitiesAutomobiles();
            string brandN = textBrand.Text;
            string modelN = textModel.Text;
            string classN = textClass.Text;
            string kppN = textKPP.Text;


            Automobiles auto = new Automobiles();
            auto.price = decimal.Parse(textPrice.Text);
            auto.yearModel = Int32.Parse(textYear.Text);

            if (brandN != "")
            {
                Brands brand = automobiles.Brands.Where(x => x.nameBrand == brandN).FirstOrDefault();
                if (brand == null)
                {
                    Brands newBrand = new Brands
                    {
                        nameBrand = brandN
                    };
                    automobiles.Brands.Add(newBrand);
                    automobiles.SaveChanges();
                    brand = automobiles.Brands.Where(x => x.nameBrand == brandN).FirstOrDefault();
                    auto.idBrand = brand.idBrand;
                }
                else
                {
                    auto.idBrand = brand.idBrand;
                }
            }

            if (modelN != "" && classN != "")
            {
                Models model = automobiles.Models.Where(x => x.nameModel == modelN && x.classModel == classN).FirstOrDefault();
                if (model == null)
                {
                    Models newModel = new Models
                    {
                        nameModel = modelN,
                        classModel = classN
                    };
                    automobiles.Models.Add(newModel);
                    automobiles.SaveChanges();
                    model = automobiles.Models.Where(x => x.nameModel == modelN && x.classModel == classN).FirstOrDefault();
                    auto.idModel = model.idModel;
                }
                else
                {
                    auto.idModel = model.idModel;
                }
            }

            if (kppN != "")
            {
                KPP kpp = automobiles.KPP.Where(x => x.nameKPP == kppN).FirstOrDefault();
                if (kpp == null)
                {
                    KPP newKpp = new KPP
                    {
                        nameKPP = kppN
                    };
                    automobiles.KPP.Add(newKpp);
                    automobiles.SaveChanges();
                    kpp = automobiles.KPP.Where(x => x.nameKPP == kppN).FirstOrDefault();
                    auto.idKPP = kpp.idKPP;
                }
                else
                {
                    auto.idKPP = kpp.idKPP;
                }
            }

            automobiles.Automobiles.Add(auto);
            automobiles.SaveChanges();
            SaveFoto();
            auto = automobiles.Automobiles
                .Where(x=>x.Brands.nameBrand==brandN 
                && x.Models.nameModel==modelN
                && x.Models.classModel==classN).FirstOrDefault();
            foreach (ListViewItem lvi in listView1.Items)
            {
                string path = "packages\\Foto\\";
                path += lvi.Text + ".jpg";
                Images image = new Images();
                image.idAuto = auto.idAuto;
                image.image = path;
                automobiles.Images.Add(image);
            }
            automobiles.SaveChanges();
        }
    }
}
