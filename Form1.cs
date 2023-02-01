using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlfaBetoRusso
{
    public partial class Form1 : Form
    {
        public static int contImagem = 0, idTranslate = 0;
        public static string pronuncia = "";
        public static string PT = "";
        public static string[] ptVetor = new string[200];
        public static string[] pronunciaVetor = new string[200];
        public Form1()
        {
            InitializeComponent();
            loadVertors();
            changeImage(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void  changeImage(int op)
        {
            if (op == 1)
            {
                if (contImagem == 33)
                {
                    contImagem = 0;
                    pctbAfaRussian.ImageLocation = (@"img\33.png");
                    idTranslate = 33;
                    loadLabel(idTranslate);
                }
                contImagem = contImagem + 1;
                idTranslate = contImagem;
                loadLabel(idTranslate);
            }
            else
            {
                contImagem = contImagem - 1;
                if (contImagem == 0)
                {
                    contImagem = 33;
                    pctbAfaRussian.ImageLocation = (@"img\33.png");
                    idTranslate = 33;
                    loadLabel(idTranslate);
                }
                idTranslate = contImagem;
                loadLabel(idTranslate);
            }
            
            if (contImagem == 1)
            {
                pctbAfaRussian.ImageLocation = (@"img\1.png");
            }
            if (contImagem == 2)
            {
                pctbAfaRussian.ImageLocation = (@"img\2.png");
            }
            if (contImagem == 3)
            {
                pctbAfaRussian.ImageLocation = (@"img\3.png");
            }
            if (contImagem == 4)
            {
                pctbAfaRussian.ImageLocation = (@"img\4.png");
            }
            if (contImagem == 5)
            {
                pctbAfaRussian.ImageLocation = (@"img\5.png");
            }
            if (contImagem == 6)
            {
                pctbAfaRussian.ImageLocation = (@"img\6.png");
            }
            if (contImagem == 7)
            {
                pctbAfaRussian.ImageLocation = (@"img\7.png");
            }
            if (contImagem == 8)
            {
                pctbAfaRussian.ImageLocation = (@"img\8.png");
            }
            if (contImagem == 9)
            {
                pctbAfaRussian.ImageLocation = (@"img\9.png");
            }
            if (contImagem == 10)
            {
                pctbAfaRussian.ImageLocation = (@"img\10.png");
            }
            if (contImagem == 11)
            {
                pctbAfaRussian.ImageLocation = (@"img\11.png");
            }
            if (contImagem == 12)
            {
                pctbAfaRussian.ImageLocation = (@"img\12.png");
            }
            if (contImagem == 13)
            {
                pctbAfaRussian.ImageLocation = (@"img\13.png");
            }
            if (contImagem == 14)
            {
                pctbAfaRussian.ImageLocation = (@"img\14.png");
            }
            if (contImagem == 15)
            {
                pctbAfaRussian.ImageLocation = (@"img\15.png");
            }
            if (contImagem == 16)
            {
                pctbAfaRussian.ImageLocation = (@"img\16.png");
            }
            if (contImagem == 17)
            {
                pctbAfaRussian.ImageLocation = (@"img\17.png");
            }
            if (contImagem == 18)
            {
                pctbAfaRussian.ImageLocation = (@"img\18.png");
            }
            if (contImagem == 19)
            {
                pctbAfaRussian.ImageLocation = (@"img\19.png");
            }
            if (contImagem == 20)
            {
                pctbAfaRussian.ImageLocation = (@"img\20.png");
            }
            if (contImagem == 21)
            {
                pctbAfaRussian.ImageLocation = (@"img\21.png");
            }
            if (contImagem == 22)
            {
                pctbAfaRussian.ImageLocation = (@"img\22.png");
            }
            if (contImagem == 23)
            {
                pctbAfaRussian.ImageLocation = (@"img\23.png");
            }
            if (contImagem == 24)
            {
                pctbAfaRussian.ImageLocation = (@"img\24.png");
            }
            if (contImagem == 25)
            {
                pctbAfaRussian.ImageLocation = (@"img\25.png");
            }
            if (contImagem == 26)
            {
                pctbAfaRussian.ImageLocation = (@"img\26.png");
            }
            if (contImagem == 27)
            {
                pctbAfaRussian.ImageLocation = (@"img\27.png");
            }
            if (contImagem == 28)
            {
                pctbAfaRussian.ImageLocation = (@"img\28.png");
            }
            if (contImagem == 29)
            {
                pctbAfaRussian.ImageLocation = (@"img\29.png");
            }
            if (contImagem == 30)
            {
                pctbAfaRussian.ImageLocation = (@"img\30.png");
            }
            if (contImagem == 31)
            {
                pctbAfaRussian.ImageLocation = (@"img\31.png");
            }
            if (contImagem == 32)
            {
                pctbAfaRussian.ImageLocation = (@"img\32.png");
            }
            if (contImagem == 33)
            {
                pctbAfaRussian.ImageLocation = (@"img\33.png");
            }
            
            lbContador.Text = "" + contImagem;
            clearLabel();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeImage(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contImagem == 1)
            {

            }
            changeImage(2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbPronuncia.Text = pronunciaVetor[idTranslate-1];
            lbPT.Text = ptVetor[idTranslate-1];
        }

        public void clearLabel ()
        {
            lbPronuncia.Text = "-";
            lbPT.Text = "-";
        }

        public void loadLabel(int id)
        {

        }

        public void loadVertors()
        {
            ptVetor[0] = "A";
            pronunciaVetor[0] = "A";
            ptVetor[1] = "B";
            pronunciaVetor[1] = "b";
            ptVetor[2] = "V";
            pronunciaVetor[2] = "V";
            ptVetor[3] = "G";
            pronunciaVetor[3] = "G";
            ptVetor[4] = "D";
            pronunciaVetor[4] = "D";
            ptVetor[5] = "";
            pronunciaVetor[5] = "A";
        }
    }
}
