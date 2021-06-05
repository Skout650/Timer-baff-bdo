using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;


namespace Таймер_забафов
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            panel1.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel2.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel3.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel4.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel5.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel6.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel7.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel8.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel9.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel10.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel11.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel13.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel14.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel15.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel16.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel17.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel18.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel19.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel20.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel21.BackColor = Color.FromArgb(70, 255, 255, 255);
            panel22.BackColor = Color.FromArgb(70, 255, 255, 255);

        }
        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        byte onOff1 = 1;    //Свиток удачи
        byte onOff2 = 1;    //Бальзам
        byte onOff3 = 1;    //Зелька
        byte onOff4 = 1;    //Палатка(180 минут)
        byte onOff5 = 1;    //Свиток 530%
        byte onOff6 = 1;    //Свиток 300%
        byte onOff7 = 1;    //Благославление 100м
        byte onOff8 = 1;    //Свиток наемника
        byte onOff9 = 1;    //Свиток очков навыков
        byte onOff10 = 1;   //Обед
        byte onOff11 = 1;   //Зелье Шока 
        byte onOff12 = 1;   //Зелье Ветра
        byte onOff13 = 1;   //Зелье Смерти
        byte onOff14 = 1;   //Зелье Смекалки
        byte onOff15 = 1;   //Алхимический камень
        byte onOff16 = 1;   //Энергия
        byte onOff17 = 1;   //Зелье труда
        byte onOff18 = 1;   //Свиток мастерства
        byte onOff19 = 1;   //Обед(60 минут)
        byte onOff20 = 1;   //Обед(120 минут)
        byte mB0 = 1;
        byte mB1 = 1;       //Свиток удачи
        byte mB2 = 1;       //Бальзам
        byte mB3 = 1;       //Зелька
        byte mB4 = 1;       //Палатка(180 минут)
        byte mB5 = 1;       //Свиток 530%
        byte mB6 = 1;       //Свиток 300%
        byte mB7 = 1;       //Благославление 100м
        byte mB8 = 1;       //Свиток наемника
        byte mB9 = 1;       //Свиток очков навыков
        byte mB10 = 1;      //Обед
        byte mB11 = 1;      //Зелье Шока 
        byte mB12 = 1;      //Зелье Ветра
        byte mB13 = 1;      //Зелье Смерти
        byte mB14 = 1;      //Зелье Смекалки
        byte mB15 = 1;      //Алхимический камень
        byte mB16 = 1;      //Энергия
        byte mB17 = 1;      //Зелье труда
        byte mB18 = 1;      //Свиток мастерства  
        byte mB19 = 1;      //Палатка(60 минут)
        byte mB20 = 1;      //Палатка(120 минут)





        //
        // voice acting
        //

        System.Media.SoundPlayer player1 = new SoundPlayer(Properties.Resources._1);                //Свиток удачи
        System.Media.SoundPlayer player2 = new SoundPlayer(Properties.Resources._2);                //Бальзам
        System.Media.SoundPlayer player3 = new SoundPlayer(Properties.Resources._3);                //Зелька
        System.Media.SoundPlayer player4 = new SoundPlayer(Properties.Resources._4);                //Палатка(180 минут)
        System.Media.SoundPlayer player5 = new SoundPlayer(Properties.Resources._5);                //Свиток 530%
        System.Media.SoundPlayer player6 = new SoundPlayer(Properties.Resources._6);                //Свиток 300%
        System.Media.SoundPlayer player7 = new SoundPlayer(Properties.Resources._7);                //Благославление 100м
        System.Media.SoundPlayer player8 = new SoundPlayer(Properties.Resources._8);                //Свиток наемника
        System.Media.SoundPlayer player9 = new SoundPlayer(Properties.Resources._9);                //Свиток очков навыков    
        System.Media.SoundPlayer player10 = new SoundPlayer(Properties.Resources._10);              //Обед  
        System.Media.SoundPlayer player11 = new SoundPlayer(Properties.Resources.potion_shock);     //Зелье Шока    
        System.Media.SoundPlayer player12 = new SoundPlayer(Properties.Resources.potion_wind);              //Зелье Ветра
        System.Media.SoundPlayer player13 = new SoundPlayer(Properties.Resources.potion_daeth);              //Зелье Смерти
        System.Media.SoundPlayer player14 = new SoundPlayer(Properties.Resources.potion_savvy);              //Зелье Смекалки
        System.Media.SoundPlayer player15 = new SoundPlayer(Properties.Resources._Alh_stone);              //Алхимический камень
        System.Media.SoundPlayer player16 = new SoundPlayer(Properties.Resources.Energy);              //Энергия
        System.Media.SoundPlayer player17 = new SoundPlayer(Properties.Resources.potion_work);              //Зелье труда
        System.Media.SoundPlayer player18 = new SoundPlayer(Properties.Resources.scroll_master);              //Свиток мастерства  
        System.Media.SoundPlayer player19 = new SoundPlayer(Properties.Resources._4);              //Палатка(60 минут)
        System.Media.SoundPlayer player20 = new SoundPlayer(Properties.Resources._4);              //Палатка(120 минут)
        System.Media.SoundPlayer playerTest = new SoundPlayer(Properties.Resources.voice_acting);   //Тест звука

        //
        //initial value 
        //

        byte s1 = 0;
        byte m1 = 0;    //Свиток удачи
        byte h1 = 1;

        byte s2 = 0;
        byte m2 = 20;   //Бальзам
        byte h2 = 0;

        byte s3 = 0;
        byte m3 = 15;   //Зелька
        byte h3 = 0;

        byte s4 = 0;
        byte m4 = 0;    //Палатка(180)
        byte h4 = 3;

        byte s5 = 0;
        byte m5 = 0;    //Сивток 530%
        byte h5 = 1;

        byte s6 = 0;
        byte m6 = 0;    //Свиток 300%
        byte h6 = 1;

        byte s7 = 0;
        byte m7 = 40;   //Благославление 100м
        byte h7 = 1;

        byte s8 = 0;    
        byte m8 = 0;    //Свиток наемника
        byte h8 = 1;

        byte s9 = 0;
        byte m9 = 0;    //Свиток очков навыков
        byte h9 = 1;

        byte s10 = 0;
        byte m10 = 0;   //Обед
        byte h10 = 2;

        byte s11 = 0;
        byte m11 = 8;
        byte h11 = 0;   //Зелье шока

        byte s12 = 0;
        byte m12 = 8;   //Зелье Ветра
        byte h12 = 0;

        byte s13 = 0;
        byte m13 = 8;   //Зелье Смерти
        byte h13 = 0;

        byte s14 = 0;
        byte m14 = 8;   //Зелье Смекалки
        byte h14 = 0;

        byte s15 = 0;
        byte m15 = 10;  //Алхимический камень 
        byte h15 = 0;

        byte s16 = 0;
        byte m16 = 10;  //Энергия 
        byte h16 = 0;

        byte s17 = 0;
        byte m17 = 8;   //Зелье труда
        byte h17 = 0;

        byte s18 = 0;
        byte m18 = 0;   //Свиток мастерства
        byte h18 = 1;

        byte s19 = 0;
        byte m19 = 0;   //Палатка(60мин)
        byte h19 = 1;

        byte s20 = 0;
        byte m20 = 0;   //Палатка(120мин)
        byte h20 = 2;
        //
        // initial value end
        //
        // button on/off
        // 

        // Свиток удачи
        private void OnOffButton1_Click(object sender, EventArgs e)
        {
            if (onOff1 == 0)
            {
                OnOffButton1.Text = "OFF";
                OnOffButton1.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff1++;
                timer1.Enabled = false;
            }

            else
            {
                OnOffButton1.Text = "ON";
                OnOffButton1.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff1--;
                timer1.Enabled = true;

            }
        }
        //Бальзам
        private void OnOffButton2_Click(object sender, EventArgs e)
        {
            if (onOff2 == 0)
            {
                OnOffButton2.Text = "OFF";
                OnOffButton2.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff2++;
                timer2.Enabled = false;
            }

            else
            {
                OnOffButton2.Text = "ON";
                OnOffButton2.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff2--;
                timer2.Enabled = true;
            }
        }
        //Зелька
        private void OnOffButton3_Click(object sender, EventArgs e)
        {
            if (onOff3 == 0)
            {
                OnOffButton3.Text = "OFF";
                OnOffButton3.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff3++;
                timer3.Enabled = false;
            }

            else
            {
                OnOffButton3.Text = "ON";
                OnOffButton3.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff3--;
                timer3.Enabled = true;
            }
        }
        //Палатка 180
        private void OnOffButton4_Click(object sender, EventArgs e)
        {
            if (onOff4 == 0)
            {
                OnOffButton4.Text = "OFF";
                OnOffButton4.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff4++;
                timer4.Enabled = false;
            }

            else
            {
                OnOffButton4.Text = "ON";
                OnOffButton4.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff4--;
                timer4.Enabled = true;
            }
        }
        //Свиток 530%
        private void OnOffButton5_Click(object sender, EventArgs e)
        {
            if (onOff5 == 0)
            {
                OnOffButton5.Text = "OFF";
                OnOffButton5.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff5++;
                timer5.Enabled = false;
            }

            else
            {
                OnOffButton5.Text = "ON";
                OnOffButton5.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff5--;
                timer5.Enabled = true;
            }
        }
        //Свиток 300%
        private void OnOffButton6_Click(object sender, EventArgs e)
        {
            if (onOff6 == 0)
            {
                OnOffButton6.Text = "OFF";
                OnOffButton6.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff6++;
                timer6.Enabled = false;
            }

            else
            {
                OnOffButton6.Text = "ON";
                OnOffButton6.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff6--;
                timer6.Enabled = true;
            }
        }
        //Благославление 100м
        private void OnOffButton7_Click(object sender, EventArgs e)
        {
            if (onOff7 == 0)
            {
                OnOffButton7.Text = "OFF";
                OnOffButton7.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff7++;
                timer7.Enabled = false;
            }

            else
            {
                OnOffButton7.Text = "ON";
                OnOffButton7.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff7--;
                timer7.Enabled = true;
            }
        }
        //Свиток наемника
        private void OnOffButton8_Click(object sender, EventArgs e)
        {
            if (onOff8 == 0)
            {
                OnOffButton8.Text = "OFF";
                OnOffButton8.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff8++;
                timer8.Enabled = false;
            }

            else
            {
                OnOffButton8.Text = "ON";
                OnOffButton8.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff8--;
                timer8.Enabled = true;
            }
        }
        //Свиток очков навыков
        private void OnOffButton9_Click(object sender, EventArgs e)
        {
            if (onOff9 == 0)
            {
                OnOffButton9.Text = "OFF";
                OnOffButton9.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff9++;
                timer9.Enabled = false;
            }

            else
            {
                OnOffButton9.Text = "ON";
                OnOffButton9.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff9--;
                timer9.Enabled = true;
            }
        }
        //Обед
        private void OnOffButton10_Click(object sender, EventArgs e)
        {
            if (onOff10 == 0)
            {
                OnOffButton10.Text = "OFF";
                OnOffButton10.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff10++;
                timer10.Enabled = false;
            }

            else
            {
                OnOffButton10.Text = "ON";
                OnOffButton10.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff10--;
                timer10.Enabled = true;
            }
        } 
        //Зелье скорости
        private void OnOffButton11_Click(object sender, EventArgs e)
        {
            if (onOff11 == 0)
            {
                OnOffButton11.Text = "OFF";
                OnOffButton11.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff11++;
                timer11.Enabled = false;
            }

            else
            {
                OnOffButton11.Text = "ON";
                OnOffButton11.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff11--;
                timer11.Enabled = true;

            }
        }
        //Зелье ветра
        private void OnOffButton12_Click(object sender, EventArgs e)
        {
            if (onOff12 == 0)
            {
                OnOffButton12.Text = "OFF";
                OnOffButton12.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff12++;
                timer12.Enabled = false;
            }

            else
            {
                OnOffButton12.Text = "ON";
                OnOffButton12.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff12--;
                timer12.Enabled = true;

            }
        }
        //Зелье смерти
        private void OnOffButton13_Click(object sender, EventArgs e)
        {
            if (onOff13 == 0)
            {
                OnOffButton13.Text = "OFF";
                OnOffButton13.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff13++;
                timer13.Enabled = false;
            }

            else
            {
                OnOffButton13.Text = "ON";
                OnOffButton13.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff13--;
                timer13.Enabled = true;

            }
        }
        //Зелье смекалика
        private void OnOffButton14_Click(object sender, EventArgs e)
        {
            if (onOff14 == 0)
            {
                OnOffButton14.Text = "OFF";
                OnOffButton14.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff14++;
                timer14.Enabled = false;
            }

            else
            {
                OnOffButton14.Text = "ON";
                OnOffButton14.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff14--;
                timer14.Enabled = true;

            }
        }
        //Алхимический камень
        private void OnOffButton15_Click(object sender, EventArgs e)
        {
            if (onOff15 == 0)
            {
                OnOffButton15.Text = "OFF";
                OnOffButton15.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff15++;
                timer15.Enabled = false;
            }

            else
            {
                OnOffButton15.Text = "ON";
                OnOffButton15.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff15--;
                timer15.Enabled = true;

            }
        }
        //Энергия
        private void OnOffButton16_Click(object sender, EventArgs e)
        {
            if (onOff16 == 0)
            {
                OnOffButton16.Text = "OFF";
                OnOffButton16.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff16++;
                timer16.Enabled = false;
            }

            else
            {
                OnOffButton16.Text = "ON";
                OnOffButton16.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff16--;
                timer16.Enabled = true;

            }
        }
        //Зелье труда
        private void OnOffButton17_Click(object sender, EventArgs e)
        {
            if (onOff17 == 0)
            {
                OnOffButton17.Text = "OFF";
                OnOffButton17.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff17++;
                timer17.Enabled = false;
            }

            else
            {
                OnOffButton17.Text = "ON";
                OnOffButton17.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff17--;
                timer17.Enabled = true;

            }
        }
        //Свиток мастерства
        private void OnOffButton18_Click(object sender, EventArgs e)
        {
            if (onOff18 == 0)
            {
                OnOffButton18.Text = "OFF";
                OnOffButton18.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff18++;
                timer18.Enabled = false;
            }

            else
            {
                OnOffButton18.Text = "ON";
                OnOffButton18.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff18--;
                timer18.Enabled = true;

            }
        }
        //Палатка 60
        private void OnOffButton19_Click(object sender, EventArgs e)
        {
            if (onOff19 == 0)
            {
                OnOffButton19.Text = "OFF";
                OnOffButton19.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff19++;
                timer19.Enabled = false;
            }

            else
            {
                OnOffButton19.Text = "ON";
                OnOffButton19.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff19--;
                timer19.Enabled = true;

            }
        }
        //Палатка 120
        private void OnOffButton20_Click(object sender, EventArgs e)
        {
            if (onOff20 == 0)
            {
                OnOffButton20.Text = "OFF";
                OnOffButton20.BackColor = Color.FromArgb(255, 255, 100, 100);
                onOff20++;
                timer20.Enabled = false;
            }

            else
            {
                OnOffButton20.Text = "ON";
                OnOffButton20.BackColor = Color.FromArgb(255, 100, 255, 100);
                onOff20--;
                timer20.Enabled = true;

            }
        }

        //
        //on/off button end
        //
        //
        //
        //timer clock
        //


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s1 == 0)
            {
                if (m1 == 0)
                {
                    if (h1 == 0)
                    {
                        h1 = 1;
                        player1.Play();
                        System.Threading.Thread.Sleep(1000);

                    }
                    else
                    {
                        h1--;
                        m1 = 59;
                        s1 = 59;
                    }
                }
                else
                {
                    m1--;
                    s1 = 59;
                }
            }
            else
            {
                s1--;
            }
            timerH1.Text = Convert.ToString(h1);
            timerM1.Text = Convert.ToString(m1);
            timerS1.Text = Convert.ToString(s1);
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (s2 == 0)
            {
                if (m2 == 0)
                {
                    m2 = 20;
                    player2.Play();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    m2--;
                    s2 = 59;
                }
            }
            else
            {
                s2--;
            }
            timerH2.Text = Convert.ToString(h2);
            timerM2.Text = Convert.ToString(m2);
            timerS2.Text = Convert.ToString(s2);
        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            if (s3 == 0)
            {
                if (m3 == 0)
                {
                    m3 = 15;
                    s3 = 00;
                    player3.Play();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    m3--;
                    s3 = 59;
                }
            }
            else
            {
                s3--;
            }
            timerH3.Text = Convert.ToString(h3);
            timerM3.Text = Convert.ToString(m3);
            timerS3.Text = Convert.ToString(s3);
        }


        private void timer4_Tick(object sender, EventArgs e)
        {
            if (s4 == 0)
            {
                if (m4 == 0)
                {
                    if (h4 == 0)
                    {
                        h4 = 3;
                        player4.Play();
                        System.Threading.Thread.Sleep(1000);

                    }
                    else
                    {
                        h4--;
                        m4 = 59;
                        s4 = 59;
                    }
                }
                else
                {
                    m4--;
                    s4 = 59;
                }
            }
            else
            {
                s4--;
            }
            timerH4.Text = Convert.ToString(h4);
            timerM4.Text = Convert.ToString(m4);
            timerS4.Text = Convert.ToString(s4);
        }


        private void timer5_Tick(object sender, EventArgs e)
        {
            if (s5 == 0)
            {
                if (m5 == 0)
                {
                    if (h5 == 0)
                    {
                        h5 = 1;
                        player5.Play();
                        System.Threading.Thread.Sleep(1000);

                    }
                    else
                    {
                        h5--;
                        m5 = 59;
                        s5 = 59;
                    }
                }
                else
                {
                    m5--;
                    s5 = 59;
                }
            }
            else
            {
                s5--;
            }
            timerH5.Text = Convert.ToString(h5);
            timerM5.Text = Convert.ToString(m5);
            timerS5.Text = Convert.ToString(s5);
        }


        private void timer6_Tick(object sender, EventArgs e)
        {
            if (s6 == 0)
            {
                if (m6 == 0)
                {
                    if (h6 == 0)
                    {
                        h6 = 1;
                        player6.Play();
                        System.Threading.Thread.Sleep(1000);

                    }
                    else
                    {
                        h6--;
                        m6 = 59;
                        s6 = 59;
                    }
                }
                else
                {
                    m6--;
                    s6 = 59;
                }
            }
            else
            {
                s6--;
            }
            timerH6.Text = Convert.ToString(h6);
            timerM6.Text = Convert.ToString(m6);
            timerS6.Text = Convert.ToString(s6);
        }


        private void timer7_Tick(object sender, EventArgs e)
        {
            if (s7 == 0)
            {
                if (m7 == 0)
                {
                    if (h7 == 0)
                    {
                        h7 = 1;
                        player7.Play();
                        System.Threading.Thread.Sleep(1000);

                    }
                    else
                    {
                        h7--;
                        m7 = 59;
                        s7 = 59;
                    }
                }
                else
                {
                    m7--;
                    s7 = 59;
                }
            }
            else
            {
                s7--;
            }
            timerH7.Text = Convert.ToString(h7);
            timerM7.Text = Convert.ToString(m7);
            timerS7.Text = Convert.ToString(s7);
        }


        private void timer8_Tick(object sender, EventArgs e)
        {
            if (s8 == 0)
            {
                if (m8 == 0)
                {
                    if (h8 == 0)
                    {
                        h8 = 1;
                        player8.Play();
                        System.Threading.Thread.Sleep(1000);

                    }
                    else
                    {
                        h8--;
                        m8 = 59;
                        s8 = 59;
                    }
                }
                else
                {
                    m8--;
                    s8 = 59;
                }
            }
            else
            {
                s8--;
            }
            timerH8.Text = Convert.ToString(h8);
            timerM8.Text = Convert.ToString(m8);
            timerS8.Text = Convert.ToString(s8);
        }


        private void timer9_Tick(object sender, EventArgs e)
        {
            if (s9 == 0)
            {
                if (m9 == 0)
                {
                    if (h9 == 0)
                    {
                        h9 = 1;
                        player9.Play();
                        System.Threading.Thread.Sleep(1000);

                    }
                    else
                    {
                        h9--;
                        m9 = 59;
                        s9 = 59;
                    }
                }
                else
                {
                    m9--;
                    s9 = 59;
                }
            }
            else
            {
                s9--;
            }
            timerH9.Text = Convert.ToString(h9);
            timerM9.Text = Convert.ToString(m9);
            timerS9.Text = Convert.ToString(s9);
        }


        private void timer10_Tick(object sender, EventArgs e)
        {
            if (s10 == 0)
            {
                if (m10 == 0)
                {
                    if (h10 == 0)
                    {
                        h10 = 2;

                        player10.Play();
                        System.Threading.Thread.Sleep(1000);

                    }
                    else
                    {
                        h10--;
                        m10 = 59;
                        s10 = 59;
                    }
                }
                else
                {
                    m10--;
                    s10 = 59;
                }
            }
            else
            {
                s10--;
            }
            timerH10.Text = Convert.ToString(h10);
            timerM10.Text = Convert.ToString(m10);
            timerS10.Text = Convert.ToString(s10);
        }


        private void timer11_Tick(object sender, EventArgs e)
        {
            if (s11 == 0)
            {
                if (m11 == 0)
                {
                    m11 = 8;
                    s11 = 0;
                    player11.Play();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    m11--;
                    s11 = 59;
                }
            }
            else
            {
                s11--;
            }
            timerH11.Text = Convert.ToString(h11);
            timerM11.Text = Convert.ToString(m11);
            timerS11.Text = Convert.ToString(s11);
        }


        private void timer12_Tick(object sender, EventArgs e)
        {
            if (s12 == 0)
            {
                if (m12 == 0)
                {
                    m12 = 8;
                    s12 = 0;
                    player12.Play();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    m12--;
                    s12 = 59;
                }
            }
            else
            {
                s12--;
            }
            timerH12.Text = Convert.ToString(h12);
            timerM12.Text = Convert.ToString(m12);
            timerS12.Text = Convert.ToString(s12);
        }


        private void timer13_Tick(object sender, EventArgs e)
        {
            if (s13 == 0)
            {
                if (m13 == 0)
                {
                    m13 = 8;
                    player13.Play();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    m13--;
                    s13 = 59;
                }
            }
            else
            {
                s13--;
            }
            timerH13.Text = Convert.ToString(h13);
            timerM13.Text = Convert.ToString(m13);
            timerS13.Text = Convert.ToString(s13);
        }


        private void timer14_Tick(object sender, EventArgs e)
        {
            if (s14 == 0)
            {
                if (m14 == 0)
                {
                    m14 = 8;
                    s14 = 00;
                    player14.Play();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    m14--;
                    s14 = 59;
                }
            }
            else
            {
                s14--;
            }
            timerH14.Text = Convert.ToString(h14);
            timerM14.Text = Convert.ToString(m14);
            timerS14.Text = Convert.ToString(s14);
        }


        private void timer15_Tick(object sender, EventArgs e)
        {
            if (s15 == 0)
            {
                if (m15 == 0)
                {
                    m15 = 10;
                    s15 = 00;
                    player15.Play();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    m15--;
                    s15 = 59;
                }
            }
            else
            {
                s3--;
            }
            timerH15.Text = Convert.ToString(h15);
            timerM15.Text = Convert.ToString(m15);
            timerS15.Text = Convert.ToString(s15);
        }


        private void timer16_Tick(object sender, EventArgs e)
        {
            if (s16 == 0)
            {
                if (m16 == 0)
                {
                    m16 = 10;
                    s16 = 00;
                    player16.Play();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    m16--;
                    s16 = 59;
                }
            }
            else
            {
                s16--;
            }
            timerH16.Text = Convert.ToString(h16);
            timerM16.Text = Convert.ToString(m16);
            timerS16.Text = Convert.ToString(s16);
        }


        private void timer17_Tick(object sender, EventArgs e)
        {
            if (s17 == 0)
            {
                if (m17 == 0)
                {
                    m17 = 0;
                    s17 = 00;
                    player17.Play();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    m17--;
                    s17 = 59;
                }
            }
            else
            {
                s17--;
            }
            timerH17.Text = Convert.ToString(h17);
            timerM17.Text = Convert.ToString(m17);
            timerS17.Text = Convert.ToString(s17);
        }


        private void timer18_Tick(object sender, EventArgs e)
        {
            if (s18 == 0)
            {
                if (m18 == 0)
                {
                    if (h18 == 0)
                    {
                        h18 = 1;
                        player18.Play();
                        System.Threading.Thread.Sleep(1000);

                    }
                    else
                    {
                        h18--;
                        m18 = 59;
                        s18 = 59;
                    }
                }
                else
                {
                    m18--;
                    s18 = 59;
                }
            }
            else
            {
                s18--;
            }
            timerH18.Text = Convert.ToString(h18);
            timerM18.Text = Convert.ToString(m18);
            timerS18.Text = Convert.ToString(s18);
        }


        private void timer19_Tick(object sender, EventArgs e)
        {
            if (s19 == 0)
            {
                if (m19 == 0)
                {
                    if (h19 == 0)
                    {
                        h19 = 1;
                        player19.Play();
                        System.Threading.Thread.Sleep(1000);

                    }
                    else
                    {
                        h19--;
                        m19 = 59;
                        s19 = 59;
                    }
                }
                else
                {
                    m19--;
                    s19 = 59;
                }
            }
            else
            {
                s19--;
            }
            timerH19.Text = Convert.ToString(h19);
            timerM19.Text = Convert.ToString(m19);
            timerS19.Text = Convert.ToString(s19);
        }


        private void timer20_Tick(object sender, EventArgs e)
        {
            if (s20 == 0)
            {
                if (m20 == 0)
                {
                    if (h20 == 0)
                    {
                        h20 = 1;
                        player20.Play();
                        System.Threading.Thread.Sleep(1000);

                    }
                    else
                    {
                        h20--;
                        m20 = 59;
                        s20 = 59;
                    }
                }
                else
                {
                    m20--;
                    s20 = 59;
                }
            }
            else
            {
                s20--;
            }
            timerH20.Text = Convert.ToString(h20);
            timerM20.Text = Convert.ToString(m20);
            timerS20.Text = Convert.ToString(s20);
        }


 


        private void mbutton1_Click(object sender, EventArgs e)
        {
            if (mB1 == 0)
            {
                mbutton1.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB1++;
            }

            else
            {
                mbutton1.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB1--;
            }
        }


        private void mbutton2_Click(object sender, EventArgs e)
        {
            if (mB2 == 0)
            {
                mbutton2.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB2++;

            }

            else
            {
                mbutton2.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB2--;
            }
        }


        private void mbutton3_Click(object sender, EventArgs e)
        {
            if (mB3 == 0)
            {
                mbutton3.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB3++;

            }

            else
            {
                mbutton3.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB3--;
            }
        }


        private void mbutton4_Click(object sender, EventArgs e)
        {
            if (mB4 == 0)
            {
                mbutton4.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB4++;

            }

            else
            {
                mbutton4.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB4--;
            }
        }


        private void mbutton5_Click(object sender, EventArgs e)
        {
            if (mB5 == 0)
            {
                mbutton5.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB5++;

            }

            else
            {
                mbutton5.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB5--;
            }
        }


        private void mbutton6_Click(object sender, EventArgs e)
        {
            if (mB6 == 0)
            {
                mbutton6.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB6++;

            }

            else
            {
                mbutton6.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB6--;
            }
        }


        private void mbutton7_Click(object sender, EventArgs e)
        {
            if (mB7 == 0)
            {
                mbutton7.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB7++;

            }

            else
            {
                mbutton7.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB7--;
            }
        }


        private void mbutton8_Click(object sender, EventArgs e)
        {
            if (mB8 == 0)
            {
                mbutton8.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB8++;

            }

            else
            {
                mbutton8.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB8--;
            }
        }


        private void mbutton9_Click(object sender, EventArgs e)
        {
            if (mB9 == 0)
            {
                mbutton9.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB9++;

            }

            else
            {
                mbutton9.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB9--;
            }
        }


        private void mbutton10_Click(object sender, EventArgs e)
        {
            if (mB10 == 0)
            {
                mbutton10.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB10++;

            }

            else
            {
                mbutton10.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB10--;
            }
        }


        private void mbutton11_Click(object sender, EventArgs e)
        {
            if (mB11 == 0)
            {
                mbutton11.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB11++;

            }

            else
            {
                mbutton11.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB11--;
            }
        }


        private void mbutton12_Click(object sender, EventArgs e)
        {
            if (mB12 == 0)
            {
                mbutton12.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB12++;

            }

            else
            {
                mbutton12.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB12--;
            }
        }


        private void mbutton13_Click(object sender, EventArgs e)
        {
            if (mB13 == 0)
            {
                mbutton13.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB13++;

            }

            else
            {
                mbutton13.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB13--;
            }
        }


        private void mbutton14_Click(object sender, EventArgs e)
        {
            if (mB14 == 0)
            {
                mbutton14.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB14++;

            }

            else
            {
                mbutton14.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB14--;
            }
        }


        private void mbutton15_Click(object sender, EventArgs e)
        {
            if (mB15 == 0)
            {
                mbutton15.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB15++;

            }

            else
            {
                mbutton15.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB15--;
            }
        }


        private void mbutton16_Click(object sender, EventArgs e)
        {
            if (mB16 == 0)
            {
                mbutton16.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB16++;

            }

            else
            {
                mbutton16.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB16--;
            }
        }


        private void mbutton17_Click(object sender, EventArgs e)
        {
            if (mB17 == 0)
            {
                mbutton17.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB17++;

            }

            else
            {
                mbutton17.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB17--;
            }
        }


        private void mbutton18_Click(object sender, EventArgs e)
        {
            if (mB18 == 0)
            {
                mbutton18.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB18++;

            }

            else
            {
                mbutton18.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB18--;
            }
        }


        private void mbutton19_Click(object sender, EventArgs e)
        {
            if (mB19 == 0)
            {
                mbutton19.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB19++;

            }

            else
            {
                mbutton19.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB19--;
            }
        }


        private void mbutton20_Click(object sender, EventArgs e)
        {
            if (mB20 == 0)
            {
                mbutton20.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB20++;

            }

            else
            {
                mbutton20.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB20--;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            playerTest.Play();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.donationalerts.com/r/skout650");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (mB0 == 0)
            {
                button1.Text = "OFF";
                button1.BackColor = Color.FromArgb(255, 255, 100, 100);
                mB0++;
                if (mB1 == 0)
                {
                    timer1.Enabled = false;
                }
                if (mB2 == 0)
                {
                    timer2.Enabled = false;
                }
                if (mB3 == 0)
                {
                    timer3.Enabled = false;
                }
                if (mB4 == 0)
                {
                    timer4.Enabled = false;
                }
                if (mB5 == 0)
                {
                    timer5.Enabled = false;
                }
                if (mB6 == 0)
                {
                    timer6.Enabled = false;
                }
                if (mB7 == 0)
                {
                    timer7.Enabled = false;
                }
                if (mB8 == 0)
                {
                    timer8.Enabled = false;
                }
                if (mB9 == 0)
                {
                    timer9.Enabled = false;
                }
                if (mB10 == 0)
                {
                    timer10.Enabled = false;
                }
                if (mB11 == 0)
                {
                    timer11.Enabled = false;
                }
                if (mB12 == 0)
                {
                    timer12.Enabled = false;
                }
                if (mB13 == 0)
                {
                    timer13.Enabled = false;
                }
                if (mB14 == 0)
                {
                    timer14.Enabled = false;
                }
                if (mB15 == 0)
                {
                    timer15.Enabled = false;
                }
                if (mB16 == 0)
                {
                    timer16.Enabled = false;
                }
                if (mB17 == 0)
                {
                    timer17.Enabled = false;
                }
                if (mB18 == 0)
                {
                    timer18.Enabled = false;
                }
                if (mB19 == 0)
                {
                    timer19.Enabled = false;
                }
                if (mB20 == 0)
                {
                    timer20.Enabled = false;
                }

            }
            else
            {
                button1.Text = "ON";
                button1.BackColor = Color.FromArgb(255, 100, 255, 100);
                mB0--;
                if (mB1 == 0)
                {
                    timer1.Enabled = true;
                }
                if (mB2 == 0)
                {
                    timer2.Enabled = true;
                }
                if (mB3 == 0)
                {
                    timer3.Enabled = true;
                }
                if (mB4 == 0)
                {
                    timer4.Enabled = true;
                }
                if (mB5 == 0)
                {
                    timer5.Enabled = true;
                }
                if (mB6 == 0)
                {
                    timer6.Enabled = true;
                }
                if (mB7 == 0)
                {
                    timer7.Enabled = true;
                }
                if (mB8 == 0)
                {
                    timer8.Enabled = true;
                }
                if (mB9 == 0)
                {
                    timer9.Enabled = true;
                }
                if (mB10 == 0)
                {
                    timer10.Enabled = true;
                }
                if (mB11 == 0)
                {
                    timer11.Enabled = true;
                }
                if (mB12 == 0)
                {
                    timer12.Enabled = true;
                }
                if (mB13 == 0)
                {
                    timer13.Enabled = true;
                }
                if (mB14 == 0)
                {
                    timer14.Enabled = true;
                }
                if (mB15 == 0)
                {
                    timer15.Enabled = true;
                }
                if (mB16 == 0)
                {
                    timer16.Enabled = true;
                }
                if (mB17 == 0)
                {
                    timer17.Enabled = true;
                }
                if (mB18 == 0)
                {
                    timer18.Enabled = true;
                }
                if (mB19 == 0)
                {
                    timer19.Enabled = true;
                }
                if (mB20 == 0)
                {
                    timer20.Enabled = true;
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.donationalerts.com/r/skout650");
        }
    }

}
