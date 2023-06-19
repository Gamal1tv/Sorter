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
    public partial class formNum : Form
    {
        public formNum()
        {
            InitializeComponent();
        }

        private void formNum_Paint(object sender, PaintEventArgs e)
        {
            Random rnd = new Random(); //create random instance
            Graphics g = e.Graphics; //creates graphic instance
            Brush white = new SolidBrush(Color.White); //creates brush that colors white
            Brush green = new SolidBrush(Color.Green); //creates brush that colors green
            List<RectangleF> rectList = new List<RectangleF>(); //creates list
            List<int> used = new List<int>(); //creates new list
            List<RectangleF> rectList2 = new List<RectangleF>(); //creates list


            //creates rectangles
            float xPos = 0;
            float yPos = 450;
            float width = 9;
            float height = 10;

            for (int i = 0; i < 46; i++)
            {
                RectangleF rect = new RectangleF(xPos, yPos, width, height);
                rectList.Add(rect);
                xPos += 10;
                yPos -= 10;
                height += 10;
            }
            

            //for list size
            for (int i = 0; i < rectList.Count; i++)
            {
                rndstart: //pointer
                    int newLocation = rnd.Next(0, 46); //get random number 1-45
                    if (used.Contains(newLocation)) //if number is in list
                    {
                        goto rndstart; //go back to rndstart
                    }
                    else //if random number is not in list
                    {
                        float y = rectList[i].Y;
                        float w = rectList[i].Width;
                        float h = rectList[i].Height;
                        rectList[i] = new RectangleF((newLocation * 10), y, w, h);
                        used.Add(newLocation);
                    }
            }

            //for each rectangle in list draw them on screen
            foreach (RectangleF r in rectList)
            {
                g.FillRectangle(white, r);
            }

            Thread.Sleep(1000); //wait 1 second


            g.Clear(Color.Black); //fill screen with black

            bool inOrder = false; //inOrder set to false

            while (inOrder == false) //while inOrder equals false
            {
                for (int i = 0; i < rectList.Count - 1; i++) //loop through list
                {
                    for (int k = i+1; k < rectList.Count; k++) //loop through list
                    {
                        if (rectList[i].X > rectList[k].X) //compare both indexes and move accordingly
                        {
                            float temp = rectList[i].X;
                            rectList[i] = new RectangleF (rectList[k].X, rectList[i].Y, rectList[i].Width, rectList[i].Height);
                            rectList[k] = new RectangleF(temp, rectList[k].Y, rectList[k].Width, rectList[k].Height);
                        }
                        g.Clear(Color.Black);
                        foreach (RectangleF r in rectList)//for each rectangle in list draw them on screen
                        {
                            if (r.Height - 10 == r.X) //if rectangle height - 10 equals rectangles x
                            {
                                g.FillRectangle(green, r); //rectangle is draw green
                            }
                            else //if not
                            {
                                g.FillRectangle(white, r); //rectangle is drawn white
                            }
                        }
                        Thread.Sleep(5);//wait 0.1 for a second
                    }
                }
                int x = 0; //x = 0
                for (int j = 0; j < rectList.Count - 1; j++) //loop through for each index in list
                {
                    if (rectList[j].X == x) //if current index's x value equal x variable
                    {
                        x += 10; //x equals x+10
                        if (x == rectList[rectList.Count - 1].X) //if x equals x value of last index in rectList
                        {
                            inOrder = true; //inOrder set to true
                        }
                    }
                }
            }
        }
    }
}
