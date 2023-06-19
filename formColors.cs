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
    public partial class formColors : Form
    {
        public formColors()
        {
            InitializeComponent();

        }

        public string colorSelection;

        private void formColors_Paint(object sender, PaintEventArgs e)
        {
            Random rnd = new Random(); //create random instance
            Graphics g = e.Graphics; //creates graphic instance
            Brush white = new SolidBrush(Color.White); //creates brush that colors white
            List<RectangleF> rectList = new List<RectangleF>(); //creates list
            List<int> used = new List<int>(); //creates new list
            List<RectangleF> rectList2 = new List<RectangleF>(); //creates list
            Brush[] brushes = new Brush[52];
            Color[] colors = new Color[52];

            int xPos = 0;
            int yPos = 0;
            int width = 5;
            int height = 460;
            int noChoice = 0;

            elsepointer:

            if (colorSelection == "Red" || noChoice == 1)
            {
                int red;
                int green = 0;
                int blue = 0;

                for (int i = 0; i < 256; i += 5)
                {
                    RectangleF rect = new RectangleF(xPos, yPos, width, height);
                    rectList.Add(rect);
                    xPos += 6;
                }


                for (int i = 0; i < rectList.Count; i++)
                {
                rndstart: //pointer
                    int newColor = rnd.Next(0, 52); //get random number 1-51
                    if (used.Contains(newColor)) //if number is in list
                    {
                        goto rndstart; //go back to rndstart
                    }
                    else //if random number is not in list
                    {
                        red = newColor * 5;
                        Color c = Color.FromArgb(red, green, blue);
                        colors[i] = c;
                        used.Add(newColor);
                    }
                }

                for (int i = 0; i < colors.Length - 1; i++) //loop through list
                {
                    for (int k = i + 1; k < colors.Length; k++) //loop through list
                    {
                        if (colors[i].R > colors[k].R)
                        {
                            int temp = colors[i].R;
                            colors[i] = colors[k];
                            colors[k] = Color.FromArgb(temp, green, blue);
                        }
                        g.Clear(Color.Black);
                        for (int h = 0; h < colors.Length; h++)
                        {

                            brushes[h] = new SolidBrush(colors[h]);
                            brushes[k] = new SolidBrush(colors[k]);

                        }

                        for (int l = 0; l < colors.Length; l++)
                        {
                            g.FillRectangle(brushes[l], rectList[l]);

                        }
                        Thread.Sleep(3);
                    }
                }
            }
            else if (colorSelection == "Green" || noChoice == 2)
            {
                int red = 0;
                int green;
                int blue = 0;

                for (int i = 0; i < 256; i += 5)
                {
                    RectangleF rect = new RectangleF(xPos, yPos, width, height);
                    rectList.Add(rect);
                    xPos += 6;
                }


                for (int i = 0; i < rectList.Count; i++)
                {
                rndstart: //pointer
                    int newColor = rnd.Next(0, 52); //get random number 1-51
                    if (used.Contains(newColor)) //if number is in list
                    {
                        goto rndstart; //go back to rndstart
                    }
                    else //if random number is not in list
                    {
                        green = newColor * 5;
                        Color c = Color.FromArgb(red, green, blue);
                        colors[i] = c;
                        used.Add(newColor);
                    }
                }

                for (int i = 0; i < colors.Length - 1; i++) //loop through list
                {
                    for (int k = i + 1; k < colors.Length; k++) //loop through list
                    {
                        if (colors[i].G > colors[k].G)
                        {
                            int temp = colors[i].G;
                            colors[i] = colors[k];
                            colors[k] = Color.FromArgb(red, temp, blue);
                        }
                        g.Clear(Color.Black);
                        for (int h = 0; h < colors.Length; h++)
                        {

                            brushes[h] = new SolidBrush(colors[h]);
                            brushes[k] = new SolidBrush(colors[k]);

                        }

                        for (int l = 0; l < colors.Length; l++)
                        {
                            g.FillRectangle(brushes[l], rectList[l]);

                        }
                        Thread.Sleep(3);
                    }
                }
            }
            else if (colorSelection == "Blue" || noChoice == 3)
            {
                int red = 0;
                int green = 0;
                int blue;

                for (int i = 0; i < 256; i += 5)
                {
                    RectangleF rect = new RectangleF(xPos, yPos, width, height);
                    rectList.Add(rect);
                    xPos += 6;
                }


                for (int i = 0; i < rectList.Count; i++)
                {
                rndstart: //pointer
                    int newColor = rnd.Next(0, 52); //get random number 1-51
                    if (used.Contains(newColor)) //if number is in list
                    {
                        goto rndstart; //go back to rndstart
                    }
                    else //if random number is not in list
                    {
                        blue = newColor * 5;
                        Color c = Color.FromArgb(red, green, blue);
                        colors[i] = c;
                        used.Add(newColor);
                    }
                }

                for (int i = 0; i < colors.Length - 1; i++) //loop through list
                {
                    for (int k = i + 1; k < colors.Length; k++) //loop through list
                    {
                        if (colors[i].B > colors[k].B)
                        {
                            int temp = colors[i].B;
                            colors[i] = colors[k];
                            colors[k] = Color.FromArgb(red, green, temp);
                        }
                        g.Clear(Color.Black);
                        for (int h = 0; h < colors.Length; h++)
                        {

                            brushes[h] = new SolidBrush(colors[h]);
                            brushes[k] = new SolidBrush(colors[k]);

                        }

                        for (int l = 0; l < colors.Length; l++)
                        {
                            g.FillRectangle(brushes[l], rectList[l]);

                        }
                        Thread.Sleep(3);
                    }
                }
            }
            else
            {
                noChoice = rnd.Next(1, 4);
                goto elsepointer;
            }
        }
    }
}

