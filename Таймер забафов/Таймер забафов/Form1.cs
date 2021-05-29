using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Таймер_забафов
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int onOff1 = 1;
        int onOff2 = 1;
        int onOff3 = 1;
        int onOff4 = 1;
        int onOff5 = 1;
        int onOff6 = 1;
        int onOff7 = 1;
        int onOff8 = 1;
        int onOff9 = 1;
        int onOff10 = 1;
        int mB0 = 1;
        int mB1 = 1;
        int mB2 = 1;
        int mB3 = 1;
        int mB4 = 1;
        int mB5 = 1;
        int mB6 = 1;
        int mB7 = 1;
        int mB8 = 1;
        int mB9 = 1;
        int mB10 = 1;



        //
        // voice acting
        //

        System.Media.SoundPlayer player1 = new SoundPlayer(Properties.Resources._1);
        System.Media.SoundPlayer player2 = new SoundPlayer(Properties.Resources._2);
        System.Media.SoundPlayer player3 = new SoundPlayer(Properties.Resources._3);
        System.Media.SoundPlayer player4 = new SoundPlayer(Properties.Resources._4);
        System.Media.SoundPlayer player5 = new SoundPlayer(Properties.Resources._5);
        System.Media.SoundPlayer player6 = new SoundPlayer(Properties.Resources._6);
        System.Media.SoundPlayer player7 = new SoundPlayer(Properties.Resources._7);
        System.Media.SoundPlayer player8 = new SoundPlayer(Properties.Resources._8);
        System.Media.SoundPlayer player9 = new SoundPlayer(Properties.Resources._9);
        System.Media.SoundPlayer player10 = new SoundPlayer(Properties.Resources._10);

        //
        //initial value 
        //

        int s1 = 0;
        int m1 = 0;
        int h1 = 1;

        int s2 = 1;
        int m2 = 20;
        int h2 = 0;

         int s3 = 1;
         int m3 = 15;
         int h3 = 0;

         int s4 = 2;
         int m4 = 0;
         int h4 = 3;

         int s5 = 8;
         int m5 = 0;
         int h5 = 1;

         int s6 = 10;
         int m6 = 0;
         int h6 = 1;

         int s7 = 0;
         int m7 = 40;
         int h7 = 1;

         int s8 = 12;
         int m8 = 0;
         int h8 = 1;

         int s9 = 16;
         int m9 = 0;
         int h9 = 1;

         int s10 = 10;
         int m10 = 0;
         int h10 = 2;

        //
        // button on/off
        // 

        //t1

        private void OnOffButton1_Click(object sender, EventArgs e)
        {
            if (onOff1 == 0)
            {
                OnOffButton1.Text = "OFF";
                OnOffButton1.BackColor = Color.Red;
                onOff1++;
                timer1.Enabled = false;
            }

            else
            {
                OnOffButton1.Text = "ON";
                OnOffButton1.BackColor = Color.LimeGreen;
                onOff1--;
                timer1.Enabled = true;

            }
        }

        //t1 end

        //t2


        private void OnOffButton2_Click(object sender, EventArgs e)
        {
            if (onOff2 == 0)
            {
                OnOffButton2.Text = "OFF";
                OnOffButton2.BackColor = Color.Red;
                onOff2++;
                timer2.Enabled = false;
            }

            else
            {
                OnOffButton2.Text = "ON";
                OnOffButton2.BackColor = Color.LimeGreen;
                onOff2--;
                timer2.Enabled = true;
            }
        }

        //t2 end

        //t3

        private void OnOffButton3_Click(object sender, EventArgs e)
        {
            if (onOff3 == 0)
            {
                OnOffButton3.Text = "OFF";
                OnOffButton3.BackColor = Color.Red;
                onOff3++;
                timer3.Enabled = false;
            }

            else
            {
                OnOffButton3.Text = "ON";
                OnOffButton3.BackColor = Color.LimeGreen;
                onOff3--;
                timer3.Enabled = true;
            }
        }

        //3 end

        //t4

        private void OnOffButton4_Click(object sender, EventArgs e)
        {
            if (onOff4 == 0)
            {
                OnOffButton4.Text = "OFF";
                OnOffButton4.BackColor = Color.Red;
                onOff4++;
                timer4.Enabled = false;
            }

            else
            {
                OnOffButton4.Text = "ON";
                OnOffButton4.BackColor = Color.LimeGreen;
                onOff4--;
                timer4.Enabled = true;
            }
        }

        //t4 end

        //t5

        private void OnOffButton5_Click(object sender, EventArgs e)
        {
            if (onOff5 == 0)
            {
                OnOffButton5.Text = "OFF";
                OnOffButton5.BackColor = Color.Red;
                onOff5++;
                timer5.Enabled = false;
            }

            else
            {
                OnOffButton5.Text = "ON";
                OnOffButton5.BackColor = Color.LimeGreen;
                onOff5--;
                timer5.Enabled = true;
            }
        }

        //t5 end

        //t6

        private void OnOffButton6_Click(object sender, EventArgs e)
        {
            if (onOff6 == 0)
            {
                OnOffButton6.Text = "OFF";
                OnOffButton6.BackColor = Color.Red;
                onOff6++;
                timer6.Enabled = false;
            }

            else
            {
                OnOffButton6.Text = "ON";
                OnOffButton6.BackColor = Color.LimeGreen;
                onOff6--;
                timer6.Enabled = true;
            }
        }

        //t6 end

        //t7

        private void OnOffButton7_Click(object sender, EventArgs e)
        {
            if (onOff7 == 0)
            {
                OnOffButton7.Text = "OFF";
                OnOffButton7.BackColor = Color.Red;
                onOff7++;
                timer7.Enabled = false;
            }

            else
            {
                OnOffButton7.Text = "ON";
                OnOffButton7.BackColor = Color.LimeGreen;
                onOff7--;
                timer7.Enabled = true;
            }
        }

        //t7 end

        //t8

        private void OnOffButton8_Click(object sender, EventArgs e)
        {
            if (onOff8 == 0)
            {
                OnOffButton8.Text = "OFF";
                OnOffButton8.BackColor = Color.Red;
                onOff8++;
                timer8.Enabled = false;
            }

            else
            {
                OnOffButton8.Text = "ON";
                OnOffButton8.BackColor = Color.LimeGreen;
                onOff8--;
                timer8.Enabled = true;
            }
        }

        //t8 end

        //t9

        private void OnOffButton9_Click(object sender, EventArgs e)
        {
            if (onOff9 == 0)
            {
                OnOffButton9.Text = "OFF";
                OnOffButton9.BackColor = Color.Red;
                onOff9++;
                timer9.Enabled = false;
            }

            else
            {
                OnOffButton9.Text = "ON";
                OnOffButton9.BackColor = Color.LimeGreen;
                onOff9--;
                timer9.Enabled = true;
            }
        }

        //t9 end

        //t10

        private void OnOffButton10_Click(object sender, EventArgs e)
        {
            if (onOff10 == 0)
            {
                OnOffButton10.Text = "OFF";
                OnOffButton10.BackColor = Color.Red;
                onOff10++;
                timer10.Enabled = false;
            }

            else
            {
                OnOffButton10.Text = "ON";
                OnOffButton10.BackColor = Color.LimeGreen;
                onOff10--;
                timer10.Enabled = true;
            }
        }

        //t10 end 

        //
        //on/off button end
        //



        //
        //timer clock
        //

        //t1

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

        //t1 end

        //t2

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (s2 == 0)
            {
                if (m2 == 0)
                {
                    if (h2 == 0)
                    m2 = 19;
                    s2 = 59;
                    player2.Play();
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

        //t2 end

        //t3

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (s3 == 0)
            {
                if (m3 == 0)
                {
                    m3 = 15;
                    s3 = 00;
                    player3.Play();
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

        //t3 end

        //t4

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

        //t4 end

        //t5

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

        //t5 end

        //t6

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

        //t6 end

        //t7

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (s7 == 0)
            {
                if (m7 == 0)
                {
                    if (h7 == 0)
                    {
                        h7 = 1;
                        m7 = 40;
                        player7.Play();

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

        //t7 end

        //t8

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

        //t8 end

        //t9

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

        //t9 end

        //t10

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

        //t10 end

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.donationalerts.com/r/skout650");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mB0 == 0)
            {
                button1.Text = "OFF";
                button1.BackColor = Color.Red;
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

            }
            else
            {
                button1.Text = "ON";
                button1.BackColor = Color.LimeGreen;
                mB0--;
                if(mB1 == 0)
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
            }
        }

        private void mbutton1_Click(object sender, EventArgs e)
        {
            if (mB1 == 0)
            {
                mbutton1.BackColor = Color.Red;
                mB1++;
            }

            else
            {
                mbutton1.BackColor = Color.LimeGreen;
                mB1--;
            }
        }

        private void mbutton2_Click(object sender, EventArgs e)
        {
            if (mB2 == 0)
            {
                mbutton2.BackColor = Color.Red;
                mB2++;

            }

            else
            {
                mbutton2.BackColor = Color.LimeGreen;
                mB2--;
            }
        }

        private void mbutton3_Click(object sender, EventArgs e)
        {
            if (mB3 == 0)
            {
                mbutton3.BackColor = Color.Red;
                mB3++;

            }

            else
            {
                mbutton3.BackColor = Color.LimeGreen;
                mB3--;
            }
        }

        private void mbutton4_Click(object sender, EventArgs e)
        {
            if (mB4 == 0)
            {
                mbutton4.BackColor = Color.Red;
                mB4++;

            }

            else
            {
                mbutton4.BackColor = Color.LimeGreen;
                mB4--;
            }
        }

        private void mbutton5_Click(object sender, EventArgs e)
        {
            if (mB5 == 0)
            {
                mbutton5.BackColor = Color.Red;
                mB5++;

            }

            else
            {
                mbutton5.BackColor = Color.LimeGreen;
                mB5--;
            }
        }

        private void mbutton6_Click(object sender, EventArgs e)
        {
            if (mB6 == 0)
            {
                mbutton6.BackColor = Color.Red;
                mB6++;

            }

            else
            {
                mbutton6.BackColor = Color.LimeGreen;
                mB6--;
            }
        }

        private void mbutton7_Click(object sender, EventArgs e)
        {
            if (mB7 == 0)
            {
                mbutton7.BackColor = Color.Red;
                mB7++;

            }

            else
            {
                mbutton7.BackColor = Color.LimeGreen;
                mB7--;
            }
        }

        private void mbutton8_Click(object sender, EventArgs e)
        {
            if (mB8 == 0)
            {
                mbutton8.BackColor = Color.Red;
                mB8++;

            }

            else
            {
                mbutton8.BackColor = Color.LimeGreen;
                mB8--;
            }
        }

        private void mbutton9_Click(object sender, EventArgs e)
        {
            if (mB9 == 0)
            {
                mbutton9.BackColor = Color.Red;
                mB9++;

            }

            else
            {
                mbutton9.BackColor = Color.LimeGreen;
                mB9--;
            }
        }

        private void mbutton10_Click(object sender, EventArgs e)
        {
            if (mB10 == 0)
            {
                mbutton10.BackColor = Color.Red;
                mB10++;

            }

            else
            {
                mbutton10.BackColor = Color.LimeGreen;
                mB10--;
            }
        }
    }  
}
