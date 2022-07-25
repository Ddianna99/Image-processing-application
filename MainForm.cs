using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ComputerVision
{
    public partial class MainForm : Form
    {
        private string sSourceFileName = "";
        private FastImage workImage;
        private Bitmap image = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            sSourceFileName = openFileDialog.FileName;
            panelSource.BackgroundImage = new Bitmap(sSourceFileName);
            image = new Bitmap(sSourceFileName);
            workImage = new FastImage(image);
        }

        private void buttonGrayscale_Click(object sender, EventArgs e)
        {
            Color color;

            workImage.Lock();
            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    byte average = (byte)((R + G + B) / 3);

                    color = Color.FromArgb(average, average, average);

                    workImage.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();

        }

        private void panelSource_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonNeg_Click(object sender, EventArgs e)
        {
            Color color;

            workImage.Lock();
            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = (byte)(255 - color.R);
                    byte G = (byte)(255 - color.G);
                    byte B = (byte)(255 - color.B);

                    //byte average = (byte)((R + G + B) / 3);

                    color = Color.FromArgb(R, G, B);

                    workImage.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Color color;
            int delta = trackBar2.Value;

            workImage.Lock();
            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = (byte)(delta + color.R);
                    byte G = (byte)(delta + color.G);
                    byte B = (byte)(delta + color.B);
                    if (R > 255)
                        R = 255;
                    else if (R < 0)
                        R = 0;

                    if (G > 255)
                        G = 255;
                    else if (G < 0)
                        G = 0;

                    if (B > 255)
                        B = 255;
                    else if (B < 0)
                        B = 0;

                    //byte average = (byte)((R + G + B) / 3);

                    color = Color.FromArgb(R, G, B);

                    workImage.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            int minR = 255, maxR = 0;
            int minG = 255, maxG = 0;
            int minB = 255, maxB = 0;
            int aR, bR, aG, bG, aB, bB;
            int Rn, Gn, Bn;
            int delta = trackBar3.Value;
            Color color;

            workImage.Lock();
            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;
                    if (R < minR)
                        minR = R;
                    else if (R > maxR)
                        maxR = R;

                    if (G < minG)
                        minG = G;
                    else if (G > maxG)
                        maxG = G;

                    if (B < minB)
                        minB = B;
                    else if (B > maxB)
                        maxB = B;
                    workImage.SetPixel(i, j, color);

                }
            }

            aR = minR - delta;
            bR = maxR + delta;
            aG = minG - delta;
            bG = maxG + delta;
            aB = minB - delta;
            bB = maxB + delta;
            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;
                    Rn = (bR - aR) * (R - minR) / (maxR - minR) + aR;
                    Gn = (bG - aG) * (G - minG) / (maxG - minG) + aG;
                    Bn = (bB - aB) * (B - minB) / (maxB - minB) + aB;
                    if (Rn > 255)
                        Rn = 255;
                    else if (Rn < 0)
                        Rn = 0;

                    if (Gn > 255)
                        Gn = 255;
                    else if (Gn < 0)
                        Gn = 0;

                    if (Bn > 255)
                        Bn = 255;
                    else if (Bn < 0)
                        Bn = 0;

                    color = Color.FromArgb(Rn, Gn, Bn);
                    workImage.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] H = new int[3, 3];
            Color color;
            workImage.Lock();

            for (int i = 1; i < workImage.Width - 1; i++)
            {
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    H[i, j] = 1;
                    int s = 1;
                    for (int row = i - 1; row < i + 2; row++)
                    {
                        for (int col = j - 1; col < j + 2; col++)
                        {
                            color = workImage.GetPixel(row, col);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;
                            byte average = (byte)((R + G + B) / 3);
                            s = s + average * H[row - i + 1, col - j + 1];

                        }
                    }
                    s = s / 9;
                    color = Color.FromArgb(s, s, s);
                    workImage.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void buttonOutlier_Click(object sender, EventArgs e)
        {
            int[,] H = new int[3, 3] {
                { 1 , 1 , 1  },
                { 1 , 0 , 1  },
                { 1 , 1 , 1  } };
            Color color;

            workImage.Lock();
            for (int r = 1; r < workImage.Width - 1; r++)
            {
                for (int c = 1; c < workImage.Height - 1; c++)
                {
                    int Rnew = 0;
                    int Gnew = 0;
                    int Bnew = 0;
                    int Rold = 0;
                    int Gold = 0;
                    int Bold = 0;
                    int epsilon = 10;

                    for (int row = r - 1; row <= r + 1; row++)
                    {
                        for (int col = c - 1; col <= c + 1; col++)
                        {
                            color = workImage.GetPixel(row, col);
                            int R = color.R;
                            int G = color.G;
                            int B = color.B;
                            Rold = Rold + R;
                            Gold = Gold + G;
                            Bold = Bold + B;


                            Rnew = Rnew + R * H[row - r + 1, col - c + 1];
                            Gnew = Gnew + G * H[row - r + 1, col - c + 1];
                            Bnew = Bnew + B * H[row - r + 1, col - c + 1];
                        }
                    }
                    Rnew = Rnew / 8;
                    Gnew = Gnew / 8;
                    Bnew = Bnew / 8;

                    int average = (Rold + Gold + Bold) / 3;
                    int averageNew = (Rnew + Gnew + Bnew) / 3;

                    if (Math.Abs(average - averageNew) > epsilon)
                    {
                        color = Color.FromArgb(Rnew, Gnew, Bnew);
                        workImage.SetPixel(r, c, color);
                    }
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();


        }

        private void buttonMarkov_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonKirsch_Click(object sender, EventArgs e)
        {
            int Rnew = 0, Gnew = 0, Bnew = 0;
            int[,] H1 = new int[3, 3] {
                { -1 , 0 , 1  },
                { -1 , 0 , 1  },
                { -1 , 0 , 1  } };
            int[,] H2 = new int[3, 3] {
                { 1 , 1 , 1  },
                { 0 , 0 , 0  },
                { -1 , -1 , -1  } };
            int[,] H3 = new int[3, 3] {
                { 0 , 1 , 1  },
                { -1 , 0 , 1  },
                { -1 , -1 , 0  } };
            int[,] H4 = new int[3, 3] {
                { 1 , 1 , 0  },
                { 1 , 0 , -1  },
                { 0 , -1 , -1  } };
            Color color;

            workImage.Lock();

            for (int r = 1; r < workImage.Width - 1; r++)
            {
                for (int c = 1; c < workImage.Height - 1; c++)
                {

                    int[,] Rnew1 = new int[4, 4];
                    int[,] Gnew1 = new int[4, 4];
                    int[,] Bnew1 = new int[4, 4];

                    int[,] Rnew2 = new int[4, 4];
                    int[,] Gnew2 = new int[4, 4];
                    int[,] Bnew2 = new int[4, 4];

                    int[,] Rnew3 = new int[4, 4];
                    int[,] Gnew3 = new int[4, 4];
                    int[,] Bnew3 = new int[4, 4];

                    int[,] Rnew4 = new int[4, 4];
                    int[,] Gnew4 = new int[4, 4];
                    int[,] Bnew4 = new int[4, 4];

                    for (int row = r - 1; row <= r + 1; row++)
                    {
                        for (int col = c - 1; col <= c + 1; col++)
                        {
                            color = workImage.GetPixel(row, col);
                            int R = color.R;
                            int G = color.G;
                            int B = color.B;

                            for (int i = 0; i < 4; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    Rnew1[i, j] = Rnew1[i, j] + R * H1[row - r + 1, col - c + 1];
                                    Gnew1[i, j] = Gnew1[i, j] + G * H1[row - r + 1, col - c + 1];
                                    Bnew1[i, j] = Bnew1[i, j] + B * H1[row - r + 1, col - c + 1];

                                    Rnew2[i, j] = Rnew2[i, j] + R * H2[row - r + 1, col - c + 1];
                                    Gnew2[i, j] = Gnew2[i, j] + G * H2[row - r + 1, col - c + 1];
                                    Bnew2[i, j] = Bnew2[i, j] + B * H2[row - r + 1, col - c + 1];

                                    Rnew3[i, j] = Rnew3[i, j] + R * H3[row - r + 1, col - c + 1];
                                    Gnew3[i, j] = Gnew3[i, j] + G * H3[row - r + 1, col - c + 1];
                                    Bnew3[i, j] = Bnew3[i, j] + B * H3[row - r + 1, col - c + 1];

                                    Rnew4[i, j] = Rnew4[i, j] + R * H4[row - r + 1, col - c + 1];
                                    Gnew4[i, j] = Gnew4[i, j] + G * H4[row - r + 1, col - c + 1];
                                    Bnew4[i, j] = Bnew4[i, j] + B * H4[row - r + 1, col - c + 1];

                                }
                            }

                            for (int i = 0; i < 4; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    Rnew = Math.Max(Math.Max(Rnew1[i, j], Rnew2[i, j]), Math.Max(Rnew3[i, j], Rnew4[i, j]));
                                    Gnew = Math.Max(Math.Max(Gnew1[i, j], Gnew2[i, j]), Math.Max(Gnew3[i, j], Gnew4[i, j]));
                                    Bnew = Math.Max(Math.Max(Bnew1[i, j], Bnew2[i, j]), Math.Max(Bnew3[i, j], Bnew4[i, j]));
                                }
                            }
                            if (Rnew > 255)
                                Rnew = 255;
                            else if (Rnew < 0)
                                Rnew = 0;

                            if (Gnew > 255)
                                Gnew = 255;
                            else if (Gnew < 0)
                                Gnew = 0;

                            if (Bnew > 255)
                                Bnew = 255;
                            else if (Bnew < 0)
                                Bnew = 0;
                            color = Color.FromArgb(Rnew, Gnew, Bnew);
                            workImage.SetPixel(r, c, color);

                        }
                    }
                    
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }
        private void buttonWB_Click(object sender, EventArgs e)
        {
            Color color;
            int Count = 1;
            int medie = 0;
            int suma = 0;

            workImage.Lock();
            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    byte average = (byte)((R + G + B) / 3);
                    suma = suma+average;
                    Count++;
                }
            }
            medie = suma / Count;
            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    byte average = (byte)((R + G + B) / 3);
                    if (average < medie)
                        average = 1;
                    else
                        average = 255;

                    color = Color.FromArgb(average, average, average);


                    workImage.SetPixel(i, j, color);

                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();

        }

        private void buttonThreshold_Click(object sender, EventArgs e)
        {
            Color color;

            workImage.Lock();
            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    byte average = (byte)((R + G + B) / 3);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void panelSource_MouseClick(object sender, MouseEventArgs e)
        {
            Queue<int> pozitieX = new Queue<int>();
            Queue<int> pozitieY = new Queue<int>();
            pozitieX.Enqueue((int)e.X);
            pozitieY.Enqueue(e.Y);
            

            /*System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "X", e.X);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Y", e.Y);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MouseClick Event");*/
            
            Color color;
            double contor = 1;
            double medie = 0;
            double suma = 0;


            workImage.Lock();
            //var queueCount = queue.Count;
            // for (int i = 0; i < queueCount; i++) { }


            for (int i = pozitieX.Dequeue(); i < pozitieX.Count; i++)
            {
                for (int j = pozitieY.Dequeue(); j < pozitieY.Count; j++) { 

                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;
                    
                    
                    color = Color.FromArgb(R, G, B);
                    workImage.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();


        }
    }
}