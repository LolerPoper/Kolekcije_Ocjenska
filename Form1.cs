using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Kolekcije
{
    public partial class Form1 : Form
    {
        List<Osoba> osobaList = new List<Osoba>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUnos_Click(object sender, EventArgs e)
        {
            if (TxtBoxIme.Text == "" || TxtBoxPrz.Text == "" || TxtBoxGodRod.Text == "" || CmbBoxRod.Text == "")
            {
                MessageBox.Show("Pogrešan unos. Molimo pokušajte ponovo.", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBoxIme.Clear();
                TxtBoxPrz.Clear();
                TxtBoxGodRod.Clear();
            }
            else
            {
                Osoba osoba = new Osoba(TxtBoxIme.Text, TxtBoxPrz.Text, Convert.ToInt16(TxtBoxGodRod.Text), CmbBoxRod.Text);
                osobaList.Add(osoba);
                TxtBoxIme.Clear();
                TxtBoxPrz.Clear();
                TxtBoxGodRod.Clear();
            }
        }

        private void BtnIspis_Click(object sender, EventArgs e)
        {
            TxtBox.Clear();

            TxtBox.AppendText("Ime\tPrezimem\tGodRod\tRod\tDodatak\r\n");

            foreach (Osoba o in osobaList)
            {
                TxtBox.AppendText(o.ToString());
            }
        }

        private void BtnObrada_Click(object sender, EventArgs e)
        {
            foreach (Osoba o in osobaList)
            {
                if (o.Rod == "M")
                {
                    o.Dodatak = "ima brkove";
                }
                else
                {
                    o.Dodatak = "nema brkove";
                }
            }
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            StreamWriter writer = null;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                writer = new StreamWriter(saveFileDialog.OpenFile());

                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(osobaList);
                }
                writer.Close();
            }
        }
    }
}
