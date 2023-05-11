using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruNo)
                {
                    case 1:
                        if (textBox1.Text.ToLower() == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 2:
                        if (textBox1.Text.ToLower() == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 3:
                        if (textBox1.Text.ToLower() == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 4:
                        if (textBox1.Text.ToLower() == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 5:
                        if (textBox1.Text.ToLower() == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 6:
                        if (textBox1.Text.ToLower() == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 7:
                        if (textBox1.Text.ToLower() == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 8:
                        if (textBox1.Text.ToLower() == "halı")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 9:
                        if (textBox1.Text.ToLower() == "ısparta")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 10:
                        if (textBox1.Text.ToLower() == "içel")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 11:
                        if (textBox1.Text.ToLower() == "jandarma")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 12:
                        if (textBox1.Text.ToLower() == "kayısı")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 13:
                        if (textBox1.Text.ToLower() == "lale")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 14:
                        if (textBox1.Text.ToLower() == "mart")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 15:
                        if (textBox1.Text.ToLower() == "ney")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 16:
                        if (textBox1.Text.ToLower() == "ozan")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                        case 17:
                        if (textBox1.Text.ToLower() == "pırasa")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 18:
                        if (textBox1.Text.ToLower() == "ramazan")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 19:
                        if (textBox1.Text.ToLower() == "snake")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 20:
                        if (textBox1.Text.ToLower() == "tarkan")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 21:
                        if (textBox1.Text.ToLower() == "umut")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 22:
                        if (textBox1.Text.ToLower() == "van")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 23:
                        if (textBox1.Text.ToLower() == "yıldırım")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;

                    case 24:
                        if (textBox1.Text.ToLower() == "zeytin")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = string.Empty;
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = string.Empty;
                        }
                        break;
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruNo++;
            this.Text = soruNo.ToString();   //Form1 yazısını değiştiriyoruz, soru numarası kaçsa o yazıyor

            if (soruNo == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi";
                button1.BackColor = Color.Yellow;
            }

            if (soruNo == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü Marmara ilimiz";
                button2.BackColor = Color.Yellow;
            }

            if (soruNo == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü";
                button3.BackColor = Color.Yellow;
            }

            if (soruNo == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz";
                button4.BackColor = Color.Yellow;
            }

            if (soruNo == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı";
                button5.BackColor = Color.Yellow;
            }

            if (soruNo == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali";
                button6.BackColor = Color.Yellow;
            }

            if (soruNo == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı";
                button7.BackColor = Color.Yellow;
            }

            if (soruNo == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne";
                button8.BackColor = Color.Yellow;
            }

            if (soruNo == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz";
                button9.BackColor = Color.Yellow;
            }

            if (soruNo == 10)
            {
                richTextBox1.Text = "Mersinin diğer ismi";
                button10.BackColor = Color.Yellow;
            }

            if (soruNo == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk";
                button11.BackColor = Color.Yellow;
            }

            if (soruNo == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi";
                button12.BackColor = Color.Yellow;
            }

            if (soruNo == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali";
                button13.BackColor = Color.Yellow;
            }

            if (soruNo == 14)
            {
                richTextBox1.Text = "Yılın 3.ayı";
                button14.BackColor = Color.Yellow;
            }

            if (soruNo == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti";
                button15.BackColor = Color.Yellow;
            }

            if (soruNo == 16)
            {
                richTextBox1.Text = "Halk şairi";
                button16.BackColor = Color.Yellow;
            }

            if (soruNo == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği ve pirinç, havuç gibi malzemelerle yapılan sebze yemeği";
                button17.BackColor = Color.Yellow;
            }

            if (soruNo == 18)
            {
                richTextBox1.Text = "11 ayın sultanı";
                button18.BackColor = Color.Yellow;
            }

            if (soruNo == 19)
            {
                richTextBox1.Text = "İngilizcede yılan";
                button19.BackColor = Color.Yellow;
            }

            if (soruNo == 20)
            {
                richTextBox1.Text = "Türkiyenin mega starı";
                button20.BackColor = Color.Yellow;
            }

            if (soruNo == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı";
                button21.BackColor = Color.Yellow;
            }

            if (soruNo == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz";
                button22.BackColor = Color.Yellow;
            }

            if (soruNo == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı";
                button23.BackColor = Color.Yellow;
            }

            if (soruNo == 24)
            {
                richTextBox1.Text = "Ege bölgesinin en çok agacıbulunan, yağı da yapılan besin ";
                button24.BackColor = Color.Yellow;
            }
        }
    }
}
