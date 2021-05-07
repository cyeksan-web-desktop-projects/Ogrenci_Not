using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ENTITYLAYER;
using BUSINESSLOGICLAYER;
using Utility;

namespace Öğrenci_Not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Form Designer Components
        private void Form1_Load(object sender, EventArgs e)
        {
            OgrenciListesi();
            SetKulupListesiToComboBox();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenRowNumber = dataGridView1.SelectedCells[0].RowIndex;


            if (this.Text == ResourcePresentation.OgrenciListesi)
            {
                txtId.Text = dataGridView1.Rows[secilenRowNumber].Cells[0].Value.ToString();
                txtAd.Text = dataGridView1.Rows[secilenRowNumber].Cells[1].Value.ToString();
                txtSoyad.Text = dataGridView1.Rows[secilenRowNumber].Cells[2].Value.ToString();
                txtFotograf.Text = dataGridView1.Rows[secilenRowNumber].Cells[3].Value.ToString();
                cmbKulup.SelectedIndex = Convert.ToInt16(dataGridView1.Rows[secilenRowNumber].Cells[4].Value);

            }

            if (this.Text == ResourcePresentation.NotListesi)
            {

                txtId.Text = dataGridView1.Rows[secilenRowNumber].Cells[0].Value.ToString();
                txtOgrId.Text = dataGridView1.Rows[secilenRowNumber].Cells[0].Value.ToString();
                txtAd.Text = dataGridView1.Rows[secilenRowNumber].Cells[7].Value.ToString();
                txtSoyad.Text = dataGridView1.Rows[secilenRowNumber].Cells[8].Value.ToString();
                txtSinav1.Text = dataGridView1.Rows[secilenRowNumber].Cells[1].Value.ToString();
                txtSinav2.Text = dataGridView1.Rows[secilenRowNumber].Cells[2].Value.ToString();
                txtSinav3.Text = dataGridView1.Rows[secilenRowNumber].Cells[3].Value.ToString();
                txtProje.Text = dataGridView1.Rows[secilenRowNumber].Cells[4].Value.ToString();
                txtOrt.Text = dataGridView1.Rows[secilenRowNumber].Cells[5].Value.ToString();
                txtDurum.Text = PrintDurum(dataGridView1.Rows[secilenRowNumber].Cells[6].Value.ToString());

            }


            if (this.Text == ResourcePresentation.KulupListesi)
            {

                txtKulupId.Text = dataGridView1.Rows[secilenRowNumber].Cells[0].Value.ToString();
                txtKulupAd.Text = dataGridView1.Rows[secilenRowNumber].Cells[1].Value.ToString();

            }

        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.Text == ResourcePresentation.NotListesi)
            {
                dataGridView1.ForeColor = Color.White;

                foreach (DataGridViewRow Myrow in dataGridView1.Rows)
                {

                    if (Myrow.Cells[6].Value.ToString() == ResourcePresentation.TrueString)
                    {
                        Myrow.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else
                    {
                        Myrow.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }

            else
            {
                dataGridView1.ForeColor = Color.DimGray;

            }
        }
        #endregion
        #region Ogrenci
        private void OgrenciListesi()
        {
            txtAd.Enabled = true;
            txtSoyad.Enabled = true;
            txtFotograf.Enabled = true;
            cmbKulup.Enabled = true;
            txtSinav1.Enabled = false;
            txtSinav2.Enabled = false;
            txtSinav3.Enabled = false;
            txtProje.Enabled = false;
            dataGridView1.DataSource = null;
            List<ENTITYOGRENCI> ogrList = BLLOGRENCI.LISTELE();
            dataGridView1.DataSource = ogrList;
            // KULUPID kolonunu gizliyoruz:
            DataGridViewColumn column = dataGridView1.Columns[4];
            column.Visible = false;
            //Form başlığı Öğrenci Listesi olarak değişecek
            this.Text = ResourcePresentation.OgrenciListesi;
        }
        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
            Temizle();
            OgrenciListesi();
        }

        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            ENTITYOGRENCI entOgrenci = new ENTITYOGRENCI
            {

                AD = txtAd.Text,
                SOYAD = txtSoyad.Text,
                FOTOGRAF = txtFotograf.Text,
                KULUPID = Convert.ToInt16(cmbKulup.SelectedValue)
            };

            var islemSonucu = BLLOGRENCI.EKLE(entOgrenci);

            ShowMessage(ReturnTrueFalse(islemSonucu), ResourcePresentation.OgrenciKaydetTrue, ResourcePresentation.OgrenciKaydetFalse);

            OgrenciListesi();

        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            var id = 0;
            if (txtId.Text != "")
            {
                id = Convert.ToInt16(txtId.Text);
            }

            var islemSonuc = BLLOGRENCI.SIL(id);

            ShowMessage(islemSonuc, ResourcePresentation.OgrenciSilTrue, ResourcePresentation.OgrenciSilFalse);

            OgrenciListesi();
        }

        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            var id = 0;
            if (txtId.Text != "")
            {
                id = Convert.ToInt16(txtId.Text);
            }
            ENTITYOGRENCI entOgrenci = new ENTITYOGRENCI
            {
                ID = id,
                AD = txtAd.Text,
                SOYAD = txtSoyad.Text,
                FOTOGRAF = txtFotograf.Text,
                KULUPID = Convert.ToInt16(cmbKulup.SelectedValue)
            };

            var islemSonucu = BLLOGRENCI.GUNCELLE(entOgrenci);
            ShowMessage(islemSonucu, ResourcePresentation.OgrenciGuncelleTrue, ResourcePresentation.OgrenciGuncelleFalse);

            OgrenciListesi();

        }
        #endregion
        #region Notlar
        private void NotlarListesi()
        {
            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            txtFotograf.Enabled = false;
            cmbKulup.Enabled = false;
            txtSinav1.Enabled = true;
            txtSinav2.Enabled = true;
            txtSinav3.Enabled = true;
            txtProje.Enabled = true;
            dataGridView1.DataSource = null;

            List<ENTITYNOTLAR> notList = BLLNOTLAR.LISTELE();
            dataGridView1.DataSource = notList;
            dataGridView1.Columns[ResourceTblNotlar.OGRENCIID].DisplayIndex = 0;
            dataGridView1.Columns[ResourceTblOgrenci.AD].DisplayIndex = 1;
            dataGridView1.Columns[ResourceTblOgrenci.SOYAD].DisplayIndex = 2;

            this.Text = ResourcePresentation.NotListesi;

        }

        private void btnNotListele_Click(object sender, EventArgs e)
        {
            Temizle();
            NotlarListesi();

        }

        private void btnNotGuncelle_Click(object sender, EventArgs e)
        {
            if (txtSinav1.Text != "" && txtSinav2.Text != "" && txtSinav3.Text != "" && txtProje.Text != "" && txtOgrId.Text != "")
            {
                double ort = MyExtensions.OrtHesapla(Convert.ToInt16(txtSinav1.Text), Convert.ToInt16(txtSinav2.Text),
                Convert.ToInt16(txtSinav3.Text), Convert.ToInt16(txtProje.Text));
                bool durum = MyExtensions.DurumHesapla(ort);

                ENTITYNOTLAR entNot = new ENTITYNOTLAR
                {
                    OGRENCIID = Convert.ToInt16(txtOgrId.Text),
                    SINAV1 = Convert.ToInt16(txtSinav1.Text),
                    SINAV2 = Convert.ToInt16(txtSinav2.Text),
                    SINAV3 = Convert.ToInt16(txtSinav3.Text),
                    PROJE = Convert.ToInt16(txtProje.Text),
                    ORTALAMA = Convert.ToDouble(txtOrt.Text),
                    DURUM = durum

                };
                var islemSonucu = BLLNOTLAR.GUNCELLE(entNot);
                if (islemSonucu)
                {
                    txtOrt.Text = ort.ToString();
                    txtDurum.Text = PrintDurum(durum.ToString());

                    MessageBox.Show(ResourcePresentation.NotGuncelleTrue);

                }
                else
                {
                    MessageBox.Show(ResourcePresentation.NotGuncelleFalse2);
                }

            }
            else
            {
                MessageBox.Show(ResourcePresentation.NotGuncelleFalse);
            }
            NotlarListesi();
        }
        #endregion
        #region Kulup
        private void KulupListesi()
        {
            dataGridView1.DataSource = null;

            List<ENTITYKULUP> kulupList = BLLKULUP.LISTELE();
            dataGridView1.DataSource = kulupList;

            this.Text = ResourcePresentation.KulupListesi;
        }

        private void btnKulupListele_Click(object sender, EventArgs e)
        {
            Temizle();
            KulupListesi();
        }

        private void btnKulupKaydet_Click(object sender, EventArgs e)
        {
            ENTITYKULUP entKulup = new ENTITYKULUP
            {
                KULUPAD = txtKulupAd.Text
            };
            var islemSonucu = BLLKULUP.EKLE(entKulup);

            ShowMessage(ReturnTrueFalse(islemSonucu), ResourcePresentation.KulupKaydetTrue, ResourcePresentation.KulupKaydetFalse);

            KulupListesi();
        }

        private void btnKulupSil_Click(object sender, EventArgs e)
        {
            var id = 0;
            if (txtKulupId.Text != "")
            {
                id = Convert.ToInt16(txtKulupId.Text);
            }
            var islemSonuc = BLLKULUP.SIL(id);
            ShowMessage(islemSonuc, ResourcePresentation.KulupSilTrue, ResourcePresentation.KulupSilFalse);

            KulupListesi();
        }

        private void btnKulupGuncelle_Click(object sender, EventArgs e)
        {
            var id = 0;
            if (txtKulupId.Text != "")
            {
                id = Convert.ToInt16(txtKulupId.Text);
            }
            ENTITYKULUP entKulup = new ENTITYKULUP
            {
                KULUPID = id,
                KULUPAD = txtKulupAd.Text,
            };

            var islemSonucu = BLLKULUP.GUNCELLE(entKulup);

            ShowMessage(islemSonucu, ResourcePresentation.KulupGuncelleTrue, ResourcePresentation.KulupGuncelleFalse);

            KulupListesi();
        }
        #endregion
        #region Useful methods and functions
        private void ShowMessage(bool islemSonucu, string basariliString, string hataliString)
        {
            if (islemSonucu)
            {
                MessageBox.Show(basariliString);
            }
            else
            {
                MessageBox.Show(hataliString);

            }
        }

        private bool ReturnTrueFalse(int islemSonucu)
        {
            if (islemSonucu == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SetKulupListesiToComboBox()
        {
            List<ENTITYKULUP> kulupList = BLLKULUP.LISTELE();
            kulupList.Insert(0, new ENTITYKULUP() { KULUPID = -1, KULUPAD = ResourcePresentation.cmbKulupDefaultValue });
            cmbKulup.DisplayMember = ResourceTblKulup.KULUP_AD;
            cmbKulup.ValueMember = ResourceTblKulup.KULUP_ID;

            cmbKulup.DataSource = kulupList;
            cmbKulup.SelectedIndex = 0;

        }

        private string PrintDurum(string passOrFail)
        {
            if (passOrFail == ResourcePresentation.TrueString)
            {
                return ResourcePresentation.Pass;
            }
            else
            {
                return ResourcePresentation.NotPass;
            }
        }

        private void Temizle()
        {
            txtId.Text = null;
            txtAd.Text = null;
            txtSoyad.Text = null;
            txtOgrId.Text = null;
            txtSinav1.Text = null;
            txtSinav2.Text = null;
            txtSinav3.Text = null;
            txtProje.Text = null;
            txtOrt.Text = null;
            txtDurum.Text = null;
            txtFotograf.Text = null;
            cmbKulup.SelectedIndex = 0;
            txtKulupAd.Text = null;
            txtKulupId.Text = null;

        }

        #endregion

    }
}
