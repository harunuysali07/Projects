using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatingSystemsHomeworkkVol3part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int[] dizi = new int[1000];
        public static int[] dizi1 = new int[500];
        public static int[] dizi2 = new int[500];
        private void Form1_Load(object sender, EventArgs e)
        {
            t0.Start();
            t0.Join();
            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();
            t3.Start();
        }
        Thread t0 = new Thread(delegate ()
        {
            diziyidoldur();
        }
        );
        Thread t1 = new Thread(delegate()
        {
            sırala(dizi1);
        }
        );
        Thread t2 = new Thread(delegate ()
        {
            sırala(dizi2);
        }
        );
        Thread t3 = new Thread(delegate ()
        {
            dizileribirlestir();
        }
        );
        private static Semaphore sem = new Semaphore(2, 2);
        private static void dizileribirlestir()
        {
            string yz = "";
            StreamWriter dosya = File.AppendText(Application.StartupPath + "\\END.txt");
            for (int i = 0; i < 999; i++)
            {
                if (i < 500)
                {
                    dizi[i] = dizi1[i];
                }
                else
                {
                    dizi[i] = dizi2[i - 499];
                }
                yz += dizi[i].ToString() + "\n";
            }
            dosya.WriteLine(yz);
            dosya.Close();
            MessageBox.Show("Yazma İşlemi Tamamlandı !!!");
        }
        public static void diziyidoldur()
        {
            sem.WaitOne();
            Random R = new Random();
            int a;
            for(int i = 0; i < 999; i++)
            {
                a = R.Next(0,10000);
                if (!dizi.Contains(a))
                {
                    dizi[i] = a;
                }
                else
                    i--;
            }
            for (int i = 0; i < 999; i++)
            {
                if (i <= 499)
                {
                    dizi1[i] = dizi[i];
                }
                else
                    dizi2[i - 499] = dizi[i];
            }
            sem.Release();
        }
        public static void sırala(int[] dizi)
        {
            try
            {
                sem.WaitOne();
                QuickSort(dizi, 0, 499);
            }
            finally
            {
                sem.Release();
            }
        }
        public static void QuickSort(int[] dizi, int baslangic, int bitis)
        {
            int i;
            if (baslangic < bitis)
            {
                i = partition(dizi, baslangic, bitis);
                QuickSort(dizi, baslangic, i - 1);
                QuickSort(dizi, i + 1, bitis);
            }

        }
        public static int partition(int[] A, int baslangic, int bitis)
        {
            int gecici;
            int x = A[bitis];
            int i = baslangic - 1;

            for (int j = baslangic; j <= bitis - 1; j++)
            {
                if (A[j] <= x)
                {
                    i++;
                    gecici = A[i];
                    A[i] = A[j];
                    A[j] = gecici;
                }
            }
            gecici = A[i + 1];
            A[i + 1] = A[bitis];
            A[bitis] = gecici;
            return i + 1;
        }
    }
}
