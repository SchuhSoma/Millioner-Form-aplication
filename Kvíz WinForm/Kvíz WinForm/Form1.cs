using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Kvíz_WinForm
{
    
    public partial class Form1 : Form
    {
        static List<KerdesekValaszok> KerdesekValaszokList;
        static List<Nyeremeny> NyeremenyList;
        static List<int> IsmetlesNElkulList;
        static Random rnd = new Random();
        static string Valasz;
        static string FelhasznaloValasz;
        static int j;
        static int i = 14;
        static string ALehetoseg;
        static string BLehetoseg;
        static string CLehetoseg;
        static string DLehetoseg;
        static int Sor=13;


        public Form1()
        {
            InitializeComponent();
            SzamGeneralas();
            Beolvasas();
            Feltoltes();
            NyeremenyFeltolt();
            Feltoltes2();           
        }
      
        private void Feltoltes2()
        {
            foreach (var ny in NyeremenyList)
            {
                dataGridView1.Rows.Add(ny.NyeremenySorszam, ny.NyeremenyOsszeg);                
            }

        }

        private void NyeremenyFeltolt()
        {
            NyeremenyList = new List<Nyeremeny>();
            var sr = new StreamReader(@"nyeremeny.txt", Encoding.UTF8);
            int db = 0;
            while (!sr.EndOfStream)
            {
                db++;
                NyeremenyList.Add(new Nyeremeny(sr.ReadLine()));
            }
            sr.Close();
            if (db > 0)
            {
                label2.Text = "Beolvasás sikeres";                
            }
            else
            {
                label2.Text = "Beolvasás sikertelen, béna vagy megint";
            }
        }

        private void Feltoltes()
        {
            int Hanyadik;
            foreach (var b in KerdesekValaszokList)
            {
                if (j<14)
                {
                    Hanyadik = IsmetlesNElkulList[j];
                    if (Hanyadik == b.Sorszam)
                    {
                        rtbSegitseg.Clear();
                        ALehetoseg = b.ALehetoseg.ToString();
                        BLehetoseg = b.BLehetoseg.ToString();
                        CLehetoseg = b.CLehetoseg.ToString();
                        DLehetoseg = b.DLehetoseg.ToString();
                        rtbKerdes.Text = b.Kerdes.ToString();
                        txtbA.Text = ALehetoseg;
                        txtbB.Text = BLehetoseg;
                        txtbC.Text = CLehetoseg;
                        txtbD.Text = DLehetoseg;
                        Valasz = b.Valasz;
                    }
                }                
            }
        }

        private void Beolvasas()
        {
            KerdesekValaszokList = new List<KerdesekValaszok>();
            var sr = new StreamReader(@"kerdesvalasz.txt", Encoding.UTF8);
            int db = 0;
            while (!sr.EndOfStream)
            {
                db++;
                KerdesekValaszokList.Add(new KerdesekValaszok(sr.ReadLine()));
            }
            sr.Close();
            if (db > 0)
            {
               // label1.Text="Beolvasás sikeres";
            }
            else
            {
                label1.Text = "Beolvasás sikertelen, béna vagy megint";
            }
        }

        private void SzamGeneralas()
        {
            IsmetlesNElkulList = new List<int>();
            int szam = 0;
            int k = 0;
            do
            {
                szam = rnd.Next(1, 26);
                if (!IsmetlesNElkulList.Contains(szam))
                {
                    IsmetlesNElkulList.Add(szam);
                }
                k++;
            }
            while (IsmetlesNElkulList.Count <= 14);
            label1.Text = IsmetlesNElkulList.Count.ToString();
        }

       
        public void buttonA_Click(object sender, EventArgs e)
        {
            FelhasznaloValasz = "A";
            if (FelhasznaloValasz== Valasz)
            {
                label1.Text="Ügyes vagy jó válasz";
                j++;
                Feltoltes();
                NyeremenySzin();
                if (j == 14)
                {
                    DialogResult dialogResult = MessageBox.Show("Újra kívánja kezdeni a játékot?", "Gartulálok 40'000'000 nyertél", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Clear();
                        j = 0;
                        i = 14;
                        SzamGeneralas();
                        Beolvasas();
                        Feltoltes();
                        NyeremenyFeltolt();
                        Feltoltes2();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                label1.Text = "Vége a játéknak, béna vagy";
                if(0<=j && j<6)
                { 
                    //MessageBox.Show("Sajnálom vesztettél garantált nyereményed 5'000");
                    DialogResult dialogResult = MessageBox.Show("Újra kívánja kezdeni a játékot?", "Sajnálom vesztettél garantált nyereményed 5'000", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Clear();
                        SzamGeneralas();
                        Beolvasas();
                        Feltoltes();
                        NyeremenyFeltolt();
                        Feltoltes2();                        
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
                if (6<= j && j < 10)
                {
                    //MessageBox.Show("Sajnálom vesztettél garantált nyereményed 100'000");
                    DialogResult dialogResult = MessageBox.Show("Újra kívánja kezdeni a játékot?", "Sajnálom vesztettél garantált nyereményed 100'000",MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Clear();
                        SzamGeneralas();
                        Beolvasas();
                        Feltoltes();                       
                        NyeremenyFeltolt();
                        Feltoltes2();                        
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
                if (10 <= j && j < 14)
                {
                    //MessageBox.Show("Sajnálom vesztettél garantált nyereményed 1'500'000");
                    DialogResult dialogResult = MessageBox.Show("Újra kívánja kezdeni a játékot?", "Sajnálom vesztettél garantált nyereményed 1'500'000",  MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Clear();
                        SzamGeneralas();
                        Beolvasas();
                        Feltoltes();                        
                        NyeremenyFeltolt();
                        Feltoltes2();                        
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
               
            }
        }

        public void buttonB_Click(object sender, EventArgs e)
        {
            FelhasznaloValasz = "B";
            if (FelhasznaloValasz == Valasz)
            {
                label1.Text="Ügyes vagy jó válasz";
                j++;
                Feltoltes();
                NyeremenySzin();
                if (j == 14)
                {
                    DialogResult dialogResult = MessageBox.Show("Újra kívánja kezdeni a játékot?", "Gartulálok 40'000'000 nyertél",  MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Clear();
                        j = 0;
                        i = 14;
                        SzamGeneralas();
                        Beolvasas();
                        Feltoltes();
                        NyeremenyFeltolt();
                        Feltoltes2();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                label1.Text = "Vége a játéknak, béna vagy";
                if (0 <= j && j < 6)
                {
                    //MessageBox.Show("Sajnálom vesztettél garantált nyereményed 5'000");
                    DialogResult dialogResult = MessageBox.Show("Újra kívánja kezdeni a játékot?", "Sajnálom vesztettél garantált nyereményed 5'000",  MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Clear();
                        SzamGeneralas();
                        Beolvasas();
                        Feltoltes();                       
                        NyeremenyFeltolt();
                        Feltoltes2();                        
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
                if (6 <= j && j < 10)
                {
                    //MessageBox.Show("Sajnálom vesztettél garantált nyereményed 100'000");
                    DialogResult dialogResult = MessageBox.Show("Újra kívánja kezdeni a játékot?", "Sajnálom vesztettél garantált nyereményed 100'000",  MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Clear();
                        SzamGeneralas();
                        Beolvasas();
                        Feltoltes();                        
                        NyeremenyFeltolt();
                        Feltoltes2();                        
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
                if (10 <= j && j < 14)
                {
                    //MessageBox.Show("Sajnálom vesztettél garantált nyereményed 1'500'000");
                    DialogResult dialogResult = MessageBox.Show("Újra kívánja kezdeni a játékot?", "Sajnálom vesztettél garantált nyereményed 1'500'000",  MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Clear();
                        SzamGeneralas();
                        Beolvasas();
                        Feltoltes();
                        NyeremenyFeltolt();
                        Feltoltes2();                        
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }

            }
        }

        public void buttonC_Click(object sender, EventArgs e)
        {
            FelhasznaloValasz = "C";
            if (FelhasznaloValasz == Valasz)
            {
                label1.Text="Ügyes vagy jó válasz";
                j++;
                Feltoltes();
                NyeremenySzin();
                if(j==14)
                {
                    DialogResult dialogResult = MessageBox.Show("Újra kívánja kezdeni a játékot?", "Gartulálok 40'000'000 nyertél",  MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Clear();
                        j = 0;
                        i = 14;
                        SzamGeneralas();
                        Beolvasas();
                        Feltoltes();
                        NyeremenyFeltolt();
                        Feltoltes2();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                label1.Text = "Vége a játéknak, béna vagy";
                if (0 <= j && j < 6)
                {
                    //MessageBox.Show("Sajnálom vesztettél garantált nyereményed 5'000");
                    DialogResult dialogResult = MessageBox.Show("Újra kívánja kezdeni a játékot?", "Sajnálom vesztettél garantált nyereményed 5'000", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Clear();
                        SzamGeneralas();
                        Beolvasas();
                        Feltoltes();                       
                        NyeremenyFeltolt();
                        Feltoltes2();                        
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
                if (6 <= j && j < 10)
                {
                    //MessageBox.Show("Sajnálom vesztettél garantált nyereményed 100'000");
                    DialogResult dialogResult = MessageBox.Show("Újra kívánja kezdeni a játékot?", "Sajnálom vesztettél garantált nyereményed 100'000",  MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Clear();
                        SzamGeneralas();
                        Beolvasas();
                        Feltoltes();                        
                        NyeremenyFeltolt();
                        Feltoltes2();                        
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
                if (10 <= j && j < 14)
                {
                    //MessageBox.Show("Sajnálom vesztettél garantált nyereményed 1'500'000");
                    DialogResult dialogResult = MessageBox.Show("Újra kívánja kezdeni a játékot?", "Sajnálom vesztettél garantált nyereményed 1'500'000", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Clear();
                        SzamGeneralas();
                        Beolvasas();
                        Feltoltes();                        
                        NyeremenyFeltolt();
                        Feltoltes2();                        
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }

            }
        }

        public void buttonD_Click(object sender, EventArgs e)
        {
            FelhasznaloValasz = "D";
            if (FelhasznaloValasz == Valasz)
            {
                label1.Text="Ügyes vagy jó válasz";
                j++;
                Feltoltes();
                NyeremenySzin();
                if (j == 14)
                {
                    DialogResult dialogResult = MessageBox.Show("Újra kívánja kezdeni a játékot?", "Gartulálok 40'000'000 nyertél",  MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Clear();
                        j = 0;
                        i = 14;
                        SzamGeneralas();
                        Beolvasas();
                        Feltoltes();
                        NyeremenyFeltolt();
                        Feltoltes2();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                label1.Text = "Vége a játéknak, béna vagy";
                if (0 <= j && j < 6)
                {
                    //MessageBox.Show("Sajnálom vesztettél garantált nyereményed 5'000");
                    DialogResult dialogResult = MessageBox.Show("Újra kívánja kezdeni a játékot?", "Sajnálom vesztettél garantált nyereményed 5'000",  MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Clear();
                        SzamGeneralas();
                        Beolvasas();
                        Feltoltes();                        
                        NyeremenyFeltolt();
                        Feltoltes2();                       
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
                if (6 <= j && j < 10)
                {
                    //MessageBox.Show("Sajnálom vesztettél garantált nyereményed 100'000");
                    DialogResult dialogResult = MessageBox.Show("Újra kívánja kezdeni a játékot?", "Sajnálom vesztettél garantált nyereményed 100'000",  MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Clear();
                        SzamGeneralas();
                        Beolvasas();
                        Feltoltes();                        
                        NyeremenyFeltolt();
                        Feltoltes2();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
                if (10 <= j && j < 14)
                {
                    //MessageBox.Show("Sajnálom vesztettél garantált nyereményed 1'500'000");
                    DialogResult dialogResult = MessageBox.Show("Újra kívánja kezdeni a játékot?", "Sajnálom vesztettél garantált nyereményed 1'500'000", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Clear();
                        SzamGeneralas();
                        Beolvasas();
                        Feltoltes();                       
                        NyeremenyFeltolt();
                        Feltoltes2();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void NyeremenySzin()
        {
           
            foreach (var ny in NyeremenyList)
            {
                if (ny.NyeremenySorszam == j+1)
                {
                    i--;
                    dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                }
            }
        }
        int db = 0;
        private void btnFelezes_Click(object sender, EventArgs e)
        {
            if(db==0)
            {
                if (Valasz == "A")
                {
                    txtbA.Text = ALehetoseg;
                    txtbB.Text = " ";
                    txtbC.Text = CLehetoseg;
                    txtbD.Text = " ";
                   
                }
                if (Valasz == "B")
                {
                    txtbA.Text = ALehetoseg;
                    txtbB.Text = BLehetoseg;
                    txtbC.Text = " ";
                    txtbD.Text = " ";
                    //db++;
                }
                if (Valasz == "C")
                {
                    txtbA.Text = " ";
                    txtbB.Text = BLehetoseg;
                    txtbC.Text = CLehetoseg;
                    txtbD.Text = " ";
                    //db++;
                }
                if (Valasz == "D")
                {
                    txtbA.Text = " ";
                    txtbB.Text = BLehetoseg;
                    txtbC.Text = " ";
                    txtbD.Text = DLehetoseg;
                    //db++;
                }
                db++;
            }
            else
            {
                txtbA.Text = ALehetoseg;
                txtbB.Text = BLehetoseg;
                txtbC.Text = CLehetoseg;
                txtbD.Text = DLehetoseg;
                rtbSegitseg.Text = "Sajnos ezt a segítséget nem használhatja többet";
            }
        }
        int db2 = 0;
        private void btnKozonseg_Click(object sender, EventArgs e)
        {

            if(db2==0)
            {
                if (Valasz == "A")
                {
                    int AValszin = rnd.Next(75, 82);
                    int BValszin = rnd.Next(0, 6);
                    int CValszin = rnd.Next(0, 6);
                    int DValszin = 100 - AValszin - BValszin - CValszin;
                    string Kozonseg = "A válasz lehetősége : " + AValszin + "%\t B válasz lehetősége : " + BValszin + "%\nC válasz lehetősége : " + CValszin + "%\tD válasz lehetősége : " + DValszin + "%";
                    rtbSegitseg.Text =Kozonseg;
                   
                }
                if (Valasz == "B")
                {
                    int BValszin = rnd.Next(75, 82);
                    int AValszin = rnd.Next(0, 6);
                    int CValszin = rnd.Next(0, 6);
                    int DValszin = 100 - AValszin - BValszin - CValszin;
                    string Kozonseg = "A válasz lehetősége : " + AValszin + "%\t B válasz lehetősége : " + BValszin + "%\nC válasz lehetősége : " + CValszin + "%\tD válasz lehetősége : " + DValszin + "%";
                    rtbSegitseg.Text = Kozonseg;
                    //db2++;
                }
                if (Valasz == "C")
                {
                    int CValszin = rnd.Next(75, 82);
                    int BValszin = rnd.Next(0, 6);
                    int AValszin = rnd.Next(0, 6);
                    int DValszin = 100 - AValszin - BValszin - CValszin;
                    string Kozonseg = "A válasz lehetősége : " + AValszin + "%\tB válasz lehetősége : " + BValszin + "%\nC válasz lehetősége : " + CValszin + "%\tD válasz lehetősége : " + DValszin + "%";
                    rtbSegitseg.Text = Kozonseg;
                    //db2++;
                }
                if (Valasz == "D")
                {
                    int DValszin = rnd.Next(75, 82);
                    int BValszin = rnd.Next(0, 6);
                    int CValszin = rnd.Next(0, 6);
                    int AValszin = 100 - DValszin - BValszin - CValszin;
                    string Kozonseg = "A válasz lehetősége : " + AValszin + "%\t B válasz lehetősége : " + BValszin + "%\nC válasz lehetősége : " + CValszin + "%\tD válasz lehetősége : " + DValszin + "%";
                    rtbSegitseg.Text = Kozonseg;
                    //db2++;
                }
                db2++;
            }
            else
            {
                rtbSegitseg.Text = "Sajnos ezt a segítséget nem veheti többet igénybe";
            }
        }
        int db3 = 0;
        private void btnTelefon_Click(object sender, EventArgs e)
        {
            if (db3 == 0)
            {
                if (Valasz == "A")
                {
                    int AValszin = rnd.Next(85, 100);
                    string Telefonos = AValszin+"%-ban biztos vagyok benne, hogy A a helyes válasz";
                    rtbSegitseg.Text = Telefonos;
                    
                }
                if (Valasz == "B")
                {
                    int BValszin = rnd.Next(85, 100);
                    string Telefonos = BValszin + "%-ban biztos vagyok benne, hogy B a helyes válasz";
                    rtbSegitseg.Text = Telefonos;
                    //db3++;
                }
                if (Valasz == "C")
                {
                    int CValszin = rnd.Next(85, 100);
                    string Telefonos = CValszin + "%-ban biztos vagyok benne, hogy C a helyes válasz";
                    rtbSegitseg.Text = Telefonos;
                    //db3++;
                }
                if (Valasz == "D")
                {
                    int DValszin = rnd.Next(85, 100);
                    string Telefonos = DValszin + "%-ban biztos vagyok benne, hogy D a helyes válasz";
                    rtbSegitseg.Text = Telefonos;
                    //db3++;
                }
                db3++;
            }
            else
            {
                rtbSegitseg.Text = "Sajnos ezt a segítséget nem veheti többet igénybe";
            }
        }
    }
}
