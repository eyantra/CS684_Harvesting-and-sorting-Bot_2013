using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using AForge.Video;
namespace Autobots
{
    public partial class Form1 : Form
    {
        Capture camera = new Capture(0);
        Communication BOT;
        HSVCOLR upper;
        HSVCOLR lower;
        Image<Gray, byte> filered;
        postprocess process;
        configHandle config = new configHandle(Application.StartupPath+@"\Settings.xml");
        public delegate void InvokeDelegate(string inpput);
        public void UpdateLog(string input)
        {
            tmt_siz.Text = input;
        }
        public void update(string me)
        {
            tmt_siz.BeginInvoke(new InvokeDelegate(UpdateLog), me);
        }
        public delegate void InvokeDelegateRC(string inpput);
        public void UpdateL(string input)
        {
            trmnl.AppendText(input);
        }
        public void updateTmnl(string me)
        {
            tmt_siz.BeginInvoke(new InvokeDelegateRC(UpdateL), me);
        }
        
       
        bool inwindow(tomato t)
        {
           
            if (t.x > nm_leftrMrgn.Value && ((t.x + (t.w / 2)) <= nm_righrMrgn.Value) && ((int)nm_btmmrgn.Value > t.y) && (int)nm_topmrgn.Value < t.y)
                return true;
               
            else
                return false;
        
        }
        MJPEGStream boteye = new MJPEGStream("http://192.168.0.20/video/mjpg.cgi");
      //  MJPEGStream boteye = new MJPEGStream("http://192.168.43.1:8080");
        public Form1()
        {
            InitializeComponent();
            updateRanges();
            videoSourcePlayer1.VideoSource = boteye;
            refreshlist();

        }
        private void updateRanges()
        {
            upper.H = (int)H_H.Value;
            upper.S = (int)H_S.Value;
            upper.V = (int)H_V.Value;
            lower.H = (int)L_H.Value;
            lower.S = (int)L_S.Value;
            lower.V = (int)L_V.Value;
        }
        int count = 0;
        bool inTrough = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(BOT!=null)
            if(BOT.isNew & !inTrough)
            {
                if (BOT.recivstring() == "R")
                {
                    inTrough = true;
                    rcvr.AppendText("\n:-In the Trough");
                }
                        
             
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BOT = new Communication("COM" + comboBox1.Text);
                trmnl.AppendText("\n" + "COM" + comboBox1.Text+" Opened Succsessfully");
            }
            catch (Exception ex)
            {
                trmnl.AppendText("\n" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        

        private void L_H_Scroll(object sender, EventArgs e)
        {
            lb_lowH.Text = L_H.Value.ToString();
            updateRanges();
        }

        private void L_S_Scroll(object sender, EventArgs e)
        {
            lb_lowS.Text = L_S.Value.ToString();
            updateRanges();
        }

        private void L_V_Scroll(object sender, EventArgs e)
        {
            lb_lowV.Text = L_V.Value.ToString();
            updateRanges();
        }

        private void H_H_Scroll(object sender, EventArgs e)
        {
            lb_highH.Text = H_H.Value.ToString();
            updateRanges();
        }

        private void H_S_Scroll(object sender, EventArgs e)
        {
            lb_highS.Text = H_S.Value.ToString();
            updateRanges();
        }

        private void H_V_Scroll(object sender, EventArgs e)
        {
            lb_highV.Text = H_V.Value.ToString();
            updateRanges();
        }

        private void videoSourcePlayer1_Click(object sender, EventArgs e)
        {

        }
        Image<Hsv, byte> main_img;
        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            main_img = new Image<Hsv, byte>(image).Rotate(0, new Hsv(0, 0, 0));
            filered = main_img.InRange(new Hsv(lower.H, lower.S, lower.V), new Hsv(upper.H, upper.S, upper.V));
            main_img.Draw(new LineSegment2D(new Point((int)nm_leftrMrgn.Value, 0), new Point((int)nm_leftrMrgn.Value, 480)), new Hsv(100, 60, 60), 2);
            main_img.Draw(new LineSegment2D(new Point((int)nm_righrMrgn.Value, 0), new Point((int)nm_righrMrgn.Value, 480)), new Hsv(100, 60, 60), 2);
            main_img.Draw(new LineSegment2D(new Point(0, (int)nm_topmrgn.Value), new Point(640, (int)nm_topmrgn.Value)), new Hsv(100, 60, 60), 2);
            main_img.Draw(new LineSegment2D(new Point(0, (int)nm_btmmrgn.Value), new Point(640, (int)nm_btmmrgn.Value)), new Hsv(100, 60, 60), 2);
            process = new postprocess(ref filered, (int)nm_minsize.Value);
            count++;
            process.dilateErode((int)nm_dilate.Value, (int)nm_erode.Value);
            Image<Gray, byte> img = process.getresult();
            if (cb_toogleFrmt.Checked)
            {
                pictureBox1.Image = img.ToBitmap();
            }
            else
            {
                foreach (tomato ek_tamatar in process.sare_tamatr)
                {
                    main_img.Draw(new Rectangle(ek_tamatar.x - ek_tamatar.w / 2, ek_tamatar.y - ek_tamatar.h / 2, ek_tamatar.w, ek_tamatar.h), new Hsv(79, 209, 200), 2);
                    if (inwindow(ek_tamatar))
                    {

                        main_img.Draw(new CircleF(new PointF((float)ek_tamatar.x, (float)ek_tamatar.y), (float)ek_tamatar.w / 2), new Hsv(255, 200, 200), -1);
                        update((ek_tamatar.h * ek_tamatar.w).ToString());
                       if(inTrough)
                           if (ek_tamatar.w * ek_tamatar.h > nm_TS.Value && ek_tamatar.w * ek_tamatar.h<nm_TL.Value)
                                    {
                                        updateTmnl("\nSmall Tomato Detected-"+BOT.write("t") + "---" + (ek_tamatar.w * ek_tamatar.h).ToString());
                                        inTrough = false;
                                        

                                    }
                                    else if (ek_tamatar.w * ek_tamatar.h >= nm_TL.Value)
                                    {
                                        updateTmnl("\nBig Tomato Detected-" + BOT.write("T") + "---" + (ek_tamatar.w * ek_tamatar.h).ToString());
                                        inTrough = false;
                                    }
                                

                            
                    }

                }
                pictureBox1.Image = main_img.ToBitmap();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            videoSourcePlayer1.Start();
        }

        
       
        void sace_conf()
        {
            configuration curren = new configuration();
            curren.name = newTxt.Text;
            curren.Dlt = (int)nm_dilate.Value;
            curren.erd = (int)nm_erode.Value;
            curren.HH = (int)H_H.Value;
            curren.HS = (int)H_S.Value;
            curren.HV = (int)H_V.Value;
            curren.LH = (int)L_H.Value;
            curren.LS = (int)L_S.Value;
            curren.LV = (int)L_V.Value;
            curren.MNM = (int)nm_minsize.Value;
            curren.WD = (int)nm_btmmrgn.Value;
            curren.WU = (int)nm_topmrgn.Value;
            curren.WL = (int)nm_leftrMrgn.Value;
            curren.WR = (int)nm_righrMrgn.Value;
            curren.TL = (int)nm_TL.Value;
            curren.TS = (int)nm_TS.Value;
            config.AddCONGIGDetail(curren);
            refreshlist();
        }
        void refreshlist()
        {
            cmdConf.Items.Clear();
            foreach (string s in config.getallCOnfigName())
            {

                cmdConf.Items.Add(s);
            }


        
        }
        private void sv_conf_Click(object sender, EventArgs e)
        {
            if (newTxt.Text != string.Empty)
            {
                sace_conf();
        



            }
            else
            {
                MessageBox.Show("Give a Name for Configuration");
            
            }
        }
       void load_confo(configuration connf)
        {
            nm_btmmrgn.Value =connf.WD;
            nm_dilate.Value = connf.Dlt;
            nm_erode.Value = connf.erd;
            nm_leftrMrgn.Value = connf.WL;
            nm_righrMrgn.Value = connf.WR;
            nm_topmrgn.Value = connf.WU;
            lb_highH.Text = connf.HH.ToString();
            lb_highS.Text = connf.HS.ToString();
            lb_highV.Text = connf.HV.ToString();
            lb_lowH.Text = connf.LH.ToString();
            lb_lowS.Text = connf.LS.ToString();
            lb_lowV.Text = connf.LV.ToString();
            L_H.Value = connf.LH;
            L_S.Value = connf.LS;
            L_V.Value = connf.LV;
            H_H.Value = connf.HH;
            H_S.Value = connf.HS;
            H_V.Value = connf.HV;
            nm_TL.Value = connf.TL;
            nm_TS.Value = connf.TS;
            updateRanges();
            this.Update();
        }
        private void ld_cnf_Click(object sender, EventArgs e)
        {
            if (cmdConf.Text != string.Empty)
            {
                load_confo(config.GetCOnfig(cmdConf.Text));
                updateTmnl("Selected Profile " + cmdConf.Text);
                
            }
            else
                MessageBox.Show("choose a configuration to load");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (BOT != null)
            {
                trmnl.AppendText(BOT.write(cmd.Text));
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inTrough = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }

}