using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Sorter
{
    public partial class formLetters : Form
    {
        public formLetters()
        {
            InitializeComponent();
        }

        private void formLetters_Paint(object sender, PaintEventArgs e)
        {

            //Random rnd = new Random(); //create random instance
            //Graphics g = e.Graphics; //creates graphic instance
            //Brush white = new SolidBrush(Color.White); //creates brush that colors white
            //Brush black = new SolidBrush(Color.Black); //creates brush that colors white
            //Brush green = new SolidBrush(Color.Green); //creates brush that colors green
            //List<RectangleF> rectList = new List<RectangleF>(); //creates list
            //List<int> used = new List<int>(); //creates new list
            //char[] arr = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            //RectangleF rectA = new RectangleF(0, 0, 40, 60);
            //RectangleF rectB = new RectangleF(40, 0, 40, 60);
            //RectangleF rectC = new RectangleF(80, 0, 40, 60);
            //RectangleF rectD = new RectangleF(120, 0, 40, 60);
            //RectangleF rectE = new RectangleF(160, 0, 40, 60);
            //RectangleF rectF = new RectangleF(200, 0, 40, 60);
            //RectangleF rectG = new RectangleF(240, 0, 40, 60);
            //RectangleF rectH = new RectangleF(280, 0, 40, 60);
            //RectangleF rectI = new RectangleF(320, 0, 40, 60);
            //RectangleF rectJ = new RectangleF(360, 0, 40, 60);
            //RectangleF rectK = new RectangleF(400, 0, 40, 60);
            //RectangleF rectL = new RectangleF(440, 0, 40, 60);
            //RectangleF rectM = new RectangleF(480, 0, 40, 60);
            //RectangleF rectN = new RectangleF(520, 0, 40, 60);
            //RectangleF rectO = new RectangleF(560, 0, 40, 60);
            //RectangleF rectP = new RectangleF(600, 0, 40, 60);
            //RectangleF rectQ = new RectangleF(640, 0, 40, 60);
            //RectangleF rectR = new RectangleF(680, 0, 40, 60);
            //RectangleF rectS = new RectangleF(720, 0, 40, 60);
            //RectangleF rectT = new RectangleF(760, 0, 40, 60);
            //RectangleF rectU = new RectangleF(800, 0, 40, 60);
            //RectangleF rectV = new RectangleF(840, 0, 40, 60);
            //RectangleF rectW = new RectangleF(880, 0, 40, 60);
            //RectangleF rectX = new RectangleF(920, 0, 40, 60);
            //RectangleF rectY = new RectangleF(960, 0, 40, 60);
            //RectangleF rectZ = new RectangleF(1000, 0, 40, 60);


            //rectList.Add(rectA);
            //rectList.Add(rectB);
            //rectList.Add(rectC);
            //rectList.Add(rectD);
            //rectList.Add(rectE);
            //rectList.Add(rectF);
            //rectList.Add(rectG);
            //rectList.Add(rectH);
            //rectList.Add(rectI);
            //rectList.Add(rectJ);
            //rectList.Add(rectK);
            //rectList.Add(rectL);
            //rectList.Add(rectM);
            //rectList.Add(rectN);
            //rectList.Add(rectO);
            //rectList.Add(rectP);
            //rectList.Add(rectQ);
            //rectList.Add(rectR);
            //rectList.Add(rectS);
            //rectList.Add(rectT);
            //rectList.Add(rectU);
            //rectList.Add(rectV);
            //rectList.Add(rectW);
            //rectList.Add(rectX);
            //rectList.Add(rectY);
            //rectList.Add(rectZ);


            ////for list size
            //for (int i = 0; i < rectList.Count; i++)
            //{
            //    rndstart: //pointer
            //        int newLocation = rnd.Next(0, 26); //get random number 1-25
            //        if (used.Contains(newLocation)) //if number is in list
            //        {
            //            goto rndstart; //go back to rndstart
            //        }
            //        else //if random number is not in list
            //        {
            //            float y = rectList[i].Y;
            //            float w = rectList[i].Width;
            //            float h = rectList[i].Height;
            //            rectList[i] = new RectangleF((newLocation * 40), y, w, h);
            //            used.Add(newLocation);
            //            char s = arr[newLocation];
            //            arr[newLocation] = arr[i];
            //            arr[i] = s;
            //        }
            //}

            ////for each rectangle in list draw them on screen
            //for (int l = 0; l < rectList.Count; l++)
            //{
            //    g.FillRectangle(black, rectList[l]);
            //    g.DrawString(arr[l].ToString(),new Font("Tacoma",30), white, rectList[l]);
            //}

            //g.Clear(Color.Black); //fill screen with black

            //bool inOrder = false;

            //while (inOrder == false)
            //{
            //    for (int i = rectList.Count - 1; i >= 0; i--) //loop through for each index in list backwards
            //    {
            //        if (i != 0) //if i does not equal 0
            //        {
            //            if (rectList[i].Height - 10 == rectList[i].X) //if item in list is in correct order
            //            {
            //                //Thread.Sleep(5);
            //                continue; //continue to next item
            //            }
            //            else if ((int)arr[i] < (int)arr[i - 1]) //if current index's x value is greater than next index's x value
            //            {
            //                char s = arr[i];
            //                arr[i] = arr[i - 1];
            //                arr[i - 1] = s;
            //                RectangleF temp = rectList[i];
            //                rectList[i] = rectList[i - 1];
            //                rectList[i - 1] = temp;
            //            }
            //        }
            //        g.Clear(Color.Black); //fill screen with black

            //    }

            //    int x = 0; //x = 0
            //    for (int j = 0; j < rectList.Count - 1; j++) //loop through for each index in list
            //    {
            //        if (rectList[j].X == x) //if current index's x value equal x variable
            //        {
            //            x += 10; //x equals x+10
            //            if (x == rectList[rectList.Count - 1].X) //if x equals x value of last index in rectList
            //            {
            //                Thread.Sleep(1000);
            //                inOrder = true; //inOrder set to true
            //            }
            //        }
            //    }
            //}
        }

        private void formLetters_Load(object sender, EventArgs e)
        {
            Label[] lblArr = {lblA, lblB, lblC, lblD, lblE, lblF, lblG, lblH, lblI, lblJ, lblK, lblL, lblM, lblN, lblO, lblP, lblQ, lblR, lblS, lblT, lblU, lblV, lblW, lblX, lblY, lblZ };
            int[] xPos = {lblA.Location.X, lblB.Location.X, lblC.Location.X, lblD.Location.X, lblE.Location.X, lblF.Location.X, lblG.Location.X, lblH.Location.X, lblI.Location.X, lblJ.Location.X, lblK.Location.X, lblL.Location.X, lblM.Location.X, lblN.Location.X, lblO.Location.X, lblP.Location.X, lblQ.Location.X, lblR.Location.X, lblS.Location.X, lblT.Location.X, lblU.Location.X, lblV.Location.X, lblW.Location.X, lblX.Location.X, lblY.Location.X, lblZ.Location.X };
            Random rnd = new Random();
            List<int> used = new List<int>();
            int yPos = 15;

            foreach (Label l in lblArr)
            {
            startpoint:
                int randomIndex = rnd.Next(0, xPos.Length);
                int newX = xPos[randomIndex];
                if (!used.Contains(newX))
                {
                    used.Add(newX);
                    l.Location = new Point(newX, yPos);
                }
                else
                {
                    goto startpoint;
                }
            }

            this.Refresh();
            bool inOrder = false;
            while (inOrder == false)
            {
                for (int i = lblArr.Length - 1; i >= 0; i--)
                {
                    if (i != 0)
                    {
                        if ((int)lblArr[i].Location.X < (int)lblArr[i - 1].Location.X)
                        {
                            int temp = lblArr[i].Location.X;
                            lblArr[i].Location = new Point(lblArr[i - 1].Location.X, yPos);
                            lblArr[i - 1].Location = new Point(temp, yPos);
                            this.Refresh();
                            Thread.Sleep(30);
                        }
                        
                    }
                }

                foreach (Label l in lblArr)
                {
                    if (l.Location.X == Convert.ToInt32(l.Tag))
                    {
                        l.ForeColor = Color.Green;
                        
                    }
                }

                int x = 0;
                for (int i = 0; i < lblArr.Length; i++)
                {
                    if (lblArr[i].Location.X == Convert.ToInt32(lblArr[i].Tag))
                    {
                        x++;
                    }
                }
                if (x == 26)
                {
                    inOrder = true;
                }
            }
        }
    }
}
