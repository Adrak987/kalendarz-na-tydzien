using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace projektadraka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ustalanieDaty(dzien1, data1, 0);
            ustalanieDaty(dzien2, data2, 1);
            ustalanieDaty(dzien3, data3, 2);
            ustalanieDaty(dzien4, data4, 3);
            ustalanieDaty(dzien5, data5, 4);
            ustalanieDaty(dzien6, data6, 5);
            ustalanieDaty(dzien7, data7, 6);

            if (!(File.Exists("zdarzenia.txt")))
            {
                File.Create("zdarzenia.txt");
            }
            else
            {
                odczytZPliku();
                File.WriteAllText("zdarzenia.txt", "");
            }

        }
        private void ustalanieDaty(Label dzien, Label data, int ile)
        {
            dzien.Text = DateTime.Now.AddDays(+ile).ToString("dddd").ToUpper();
            data.Text = DateTime.Now.AddDays(+ile).ToString("d");
        }

        private void dodajZdarzenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.Text = "Dodawanie zdarzenia";
            if(dialog.ShowDialog() == DialogResult.OK && !(string.IsNullOrWhiteSpace(dialog.tekst)))
            {
                ListViewItem item = new ListViewItem(new string[] {dialog.tekst});
                if(contextMenuStrip1.SourceControl == listView1)
                {
                    listView1.Items.Add(item);
                }
                else if (contextMenuStrip1.SourceControl == listView2)
                {
                    listView2.Items.Add(item);
                }
                else if (contextMenuStrip1.SourceControl == listView3)
                {
                    listView3.Items.Add(item);
                }
                else if (contextMenuStrip1.SourceControl == listView4)
                {
                    listView4.Items.Add(item);
                }
                else if (contextMenuStrip1.SourceControl == listView5)
                {
                    listView5.Items.Add(item);
                }
                else if (contextMenuStrip1.SourceControl == listView6)
                {
                    listView6.Items.Add(item);
                }
                else if (contextMenuStrip1.SourceControl == listView7)
                {
                    listView7.Items.Add(item);
                }
            }
            else if(dialog.DialogResult == DialogResult.OK && string.IsNullOrWhiteSpace(dialog.tekst))
            {
                MessageBox.Show("Nie podano tekstu");
            }
        }

        private void usuńZdarzenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contextMenuStrip1.SourceControl == listView1)
            {
                foreach(ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }
            }
            else if (contextMenuStrip1.SourceControl == listView2)
            {
                foreach (ListViewItem item in listView2.SelectedItems)
                {
                    listView2.Items.Remove(item);
                }
            }
            else if (contextMenuStrip1.SourceControl == listView3)
            {
                foreach (ListViewItem item in listView3.SelectedItems)
                {
                    listView3.Items.Remove(item);
                }
            }
            else if (contextMenuStrip1.SourceControl == listView4)
            {
                foreach (ListViewItem item in listView4.SelectedItems)
                {
                    listView4.Items.Remove(item);
                }
            }
            else if (contextMenuStrip1.SourceControl == listView5)
            {
                foreach (ListViewItem item in listView5.SelectedItems)
                {
                    listView5.Items.Remove(item);
                }
            }
            else if (contextMenuStrip1.SourceControl == listView6)
            {
                foreach (ListViewItem item in listView6.SelectedItems)
                {
                    listView6.Items.Remove(item);
                }
            }
            else if (contextMenuStrip1.SourceControl == listView7)
            {
                foreach (ListViewItem item in listView7.SelectedItems)
                {
                    listView7.Items.Remove(item);
                }
            }
        }

        private void modyfikujZdarzenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contextMenuStrip1.SourceControl == listView1 && listView1.SelectedItems.Count > 0)
            {
                Form2 dialog = new Form2();
                dialog.Text = "Zmiana zdarzenia";
                if(dialog.ShowDialog() == DialogResult.OK && !(string.IsNullOrWhiteSpace(dialog.tekst)))
                {
                    listView1.SelectedItems[0].Text = dialog.tekst;
                }
                else if (dialog.DialogResult == DialogResult.OK && string.IsNullOrWhiteSpace(dialog.tekst))
                {
                    MessageBox.Show("Nie podano tekstu");
                }
            }
            else if (contextMenuStrip1.SourceControl == listView2 && listView2.SelectedItems.Count > 0)
            {
                Form2 dialog = new Form2();
                dialog.Text = "Zmiana zdarzenia";
                if (dialog.ShowDialog() == DialogResult.OK && !(string.IsNullOrWhiteSpace(dialog.tekst)))
                {
                    listView2.SelectedItems[0].Text = dialog.tekst;
                }
                else if (dialog.DialogResult == DialogResult.OK && string.IsNullOrWhiteSpace(dialog.tekst))
                {
                    MessageBox.Show("Nie podano tekstu");
                }
            }
            else if (contextMenuStrip1.SourceControl == listView3 && listView3.SelectedItems.Count > 0)
            {
                Form2 dialog = new Form2();
                dialog.Text = "Zmiana zdarzenia";
                if (dialog.ShowDialog() == DialogResult.OK && !(string.IsNullOrWhiteSpace(dialog.tekst)))
                {
                    listView3.SelectedItems[0].Text = dialog.tekst;
                }
                else if (dialog.DialogResult == DialogResult.OK && string.IsNullOrWhiteSpace(dialog.tekst))
                {
                    MessageBox.Show("Nie podano tekstu");
                }
            }
            else if (contextMenuStrip1.SourceControl == listView4 && listView4.SelectedItems.Count > 0)
            {
                Form2 dialog = new Form2();
                dialog.Text = "Zmiana zdarzenia";
                if (dialog.ShowDialog() == DialogResult.OK && !(string.IsNullOrWhiteSpace(dialog.tekst)))
                {
                    listView4.SelectedItems[0].Text = dialog.tekst;
                }
                else if (dialog.DialogResult == DialogResult.OK && string.IsNullOrWhiteSpace(dialog.tekst))
                {
                    MessageBox.Show("Nie podano tekstu");
                }
            }
            else if (contextMenuStrip1.SourceControl == listView5 && listView5.SelectedItems.Count > 0)
            {
                Form2 dialog = new Form2();
                dialog.Text = "Zmiana zdarzenia";
                if (dialog.ShowDialog() == DialogResult.OK && !(string.IsNullOrWhiteSpace(dialog.tekst)))
                {
                    listView5.SelectedItems[0].Text = dialog.tekst;
                }
                else if (dialog.DialogResult == DialogResult.OK && string.IsNullOrWhiteSpace(dialog.tekst))
                {
                    MessageBox.Show("Nie podano tekstu");
                }
            }
            else if (contextMenuStrip1.SourceControl == listView6 && listView6.SelectedItems.Count > 0)
            {
                Form2 dialog = new Form2();
                dialog.Text = "Zmiana zdarzenia";
                if (dialog.ShowDialog() == DialogResult.OK && !(string.IsNullOrWhiteSpace(dialog.tekst)))
                {
                    listView6.SelectedItems[0].Text = dialog.tekst;
                }
                else if (dialog.DialogResult == DialogResult.OK && string.IsNullOrWhiteSpace(dialog.tekst))
                {
                    MessageBox.Show("Nie podano tekstu");
                }
            }
            else if (contextMenuStrip1.SourceControl == listView7 && listView7.SelectedItems.Count > 0)
            {
                Form2 dialog = new Form2();
                dialog.Text = "Zmiana zdarzenia";
                if (dialog.ShowDialog() == DialogResult.OK && !(string.IsNullOrWhiteSpace(dialog.tekst)))
                {
                    listView7.SelectedItems[0].Text = dialog.tekst;
                }
                else if (dialog.DialogResult == DialogResult.OK && string.IsNullOrWhiteSpace(dialog.tekst))
                {
                    MessageBox.Show("Nie podano tekstu");
                }
            }
        }
        private void zapisDoPliku()
        {
            ListView[] listviews = new ListView[7];
            listviews[0] = listView1;
            listviews[1] = listView2;
            listviews[2] = listView3;
            listviews[3] = listView4;
            listviews[4] = listView5;
            listviews[5] = listView6;
            listviews[6] = listView7;

            int i = 0;
            foreach (ListView listview in listviews)
            {
                foreach (ListViewItem item in listview.Items)
                {
                    File.AppendAllText("zdarzenia.txt", DateTime.Now.AddDays(+i).Day.ToString() + ";" + item.Text + "\n");
                }
                i++;
            }
        }
        private void odczytZPliku()
        {
            ListView[] listviews = new ListView[7];
            listviews[0] = listView1;
            listviews[1] = listView2;
            listviews[2] = listView3;
            listviews[3] = listView4;
            listviews[4] = listView5;
            listviews[5] = listView6;
            listviews[6] = listView7;

            string[] linie = File.ReadAllLines("zdarzenia.txt");
            int i = 0;
            foreach(ListView listview in listviews)
            {
                foreach (string linia in linie)
                {
                    string[] temp = linia.Split(';');
                    if(DateTime.Now.AddDays(+i).Day.ToString() == temp[0])
                    {
                        listview.Items.Add(temp[1]);
                    }
                }
                i++;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            zapisDoPliku();
        }
    }
}