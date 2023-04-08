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

namespace HW_week_7
{
    public partial class FormPlay : Form
    {
        Random rnd = new Random();
        List<string> huruf = new List<string>() { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Enter", "Z", "X", "C", "V", "B", "N", "M", "Delete" };
        List<Button> kotakIsi = new List<Button>();
        List<Button> kotakKeyboard = new List<Button>();
        List<string> hasilRand = new List<string>();
        public static int Size = 0;
        int keyBoardReal = 10;
        int huruf2 = 0;
        int pindahIsi = 0;
        string[] hint = File.ReadAllText("Wordle Word List.txt").Split(',');
        string jawaban = "";
        int batas = 4;
        int batas2 = 0;
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 4;
        string cek = "";
        int checking = 0;

        public FormPlay()
        {
            InitializeComponent();
        }

        private void FormPlay_Load(object sender, EventArgs e)
        {
            printKotak();
            printKeyboard();
            jawaban = hint[rnd.Next(0,hint.Length)];
            MessageBox.Show(jawaban);
        }

        public void printKotak()
        {
            for (int x = 1; x<= Size; x++)
            {
                for (int y = 1; y<= 5; y++)
                {
                    Button kotak = new Button();
                    kotak.Size = new Size(55, 55);
                    kotak.Location = new Point(60*y, 60*x);
                    kotakIsi.Add(kotak);
                    this.Controls.Add(kotak);
                }
            }
        }
        public void printKeyboard()
        {
            for(int x = 1; x<= 3; x++)
            {
                for(int y = 1; y<= keyBoardReal; y++)
                {
                    Button keyboard = new Button();
                    keyboard.Text = huruf[huruf2];
                    keyboard.Tag = huruf[huruf2];
                    keyboard.Size = new Size(50, 50);
                    keyboard.Location = new Point(370+(60*y), 70*x);
                    kotakKeyboard.Add(keyboard);
                    this.Controls.Add(keyboard);
                    huruf2++;
                }
                keyBoardReal = 9;
            }
            foreach(Button kotak in kotakKeyboard)
            {
                kotak.Click += masukinHuruf;
            }
        }
        private void masukinHuruf(object sender, EventArgs e)
        {
            Button banding = sender as Button;
            if (pindahIsi <= batas)
            {
                foreach (Button masuk in kotakKeyboard)
                {
                    if (masuk.Tag == banding.Tag && banding.Tag.ToString() != "Enter" &&  banding.Tag.ToString() != "Delete")
                    {
                        kotakIsi[pindahIsi].Text = masuk.Text;
                        pindahIsi++;
                    }
                }
            }
            if (banding.Text == "Enter")
            {
                checking = 0;
                if (pindahIsi-1 == batas)
                {
                    cek = "";
                    for(int i = c; i<= d; i++)
                    {
                        cek += kotakIsi[i].Text;
                    }
                    for (int x = 0; x <= hint.Length - 1; x++)
                    {
                        if (cek.ToUpper() == hint[x].ToUpper())
                        {
                            checking = 10;
                        }
                    }
                    if (checking == 10)
                    {
                        kuningIjo();
                        batas += 5;
                        batas2 += 5;
                    }
                    else
                    {
                        MessageBox.Show(cek + " not on the word list");
                    }
                }
            }
            if (banding.Text == "Delete")
            {
                if (pindahIsi != batas2)
                {
                    kotakIsi[pindahIsi - 1].Text = "";
                    pindahIsi--;
                }
            }
        }
        public void kuningIjo ()
        {
            hasilRand.Clear();
            b = 0;
            for(int i = 0 ; i < jawaban.Length; i++)
            {
                hasilRand.Add(jawaban[i].ToString().ToUpper());
            }
            for (int h = a; h <= batas; h++)
            {
                
                if (kotakIsi[h].Text == jawaban[b].ToString().ToUpper())
                {
                    kotakIsi[h].BackColor = Color.Green;
                    hasilRand[b] = "";
                }
                b++;
            }
            
            for (int k = a; k <= batas; k++)
            {
                foreach (string cekkuning in hasilRand)
                {
                    if (kotakIsi[k].Text == cekkuning)
                    {
                        kotakIsi[k].BackColor = Color.Yellow;
                    }
                }
            }
            a += 5;
        }
    }
}
