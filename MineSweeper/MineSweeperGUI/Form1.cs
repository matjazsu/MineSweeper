using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MineSweeperGUI
{
    public partial class Form1 : Form
    {
        private static Polje[,] btnMatrix;

        private static int SteviloZelenih = 0;

        private static int steviloIzbranih = 0;

        private int steviloBomb = 0;

        public Form1(int _stBomb, int stVrstic, int stStolpcev)
        {
            InitializeComponent();

            steviloBomb = _stBomb;
            btnMatrix = new Polje[stVrstic,stStolpcev];

            CreateGamingField();
        }

        private void CreateGamingField()
        {
            pnlButtons.Controls.Clear();

            SteviloZelenih = btnMatrix.GetLength(0)*btnMatrix.GetLength(1);
            steviloIzbranih = 0;

            int xPos = 0;
            int yPos = 0;
            int Height = 0;
            for (int i = 0; i < btnMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < btnMatrix.GetLength(1); j++)
                {
                    Polje tmp = new Polje();
                    tmp.odkrit = false;
                    tmp.bomba = false;
                    tmp.stevilo = "";
                    tmp.gumb = new Button();

                    btnMatrix[i, j] = tmp;

                    btnMatrix[i, j].gumb.Width = 35;
                    btnMatrix[i, j].gumb.Height = 36;
                    btnMatrix[i, j].gumb.Left = xPos;
                    btnMatrix[i, j].gumb.Top = yPos;

                    pnlButtons.Controls.Add(btnMatrix[i, j].gumb);
                    btnMatrix[i, j].gumb.Text = "";
                    btnMatrix[i, j].gumb.Tag = i.ToString() + "," + j.ToString();
                    xPos = xPos + btnMatrix[i, j].gumb.Width;
                    btnMatrix[i, j].gumb.Click += new EventHandler(ClickButton);
                }
                Height = xPos;
                xPos = 0;
                yPos = yPos + btnMatrix[i, 0].gumb.Height;
            }

            this.pnlButtons.Size = new Size(Height + 7, yPos + 5);
            this.groupBox2.Size = new Size(Height + 15, yPos + 27);

            Random random = new Random();

            for (int i = 0; i < this.steviloBomb; i++)
            {
                bool nasel = false;

                int x = 0;
                int y = 0;

                while (nasel != true)
                {
                    x = random.Next(0, btnMatrix.GetLength(0) - 1);
                    y = random.Next(0, btnMatrix.GetLength(1) - 1);
   
                    if (btnMatrix[x, y].bomba == false)
                    {
                        nasel = true;
                    }
                }

                string tmp = "";

                if (i == 0)
                {
                    tmp += "Koordinate bomb:\r\n";
                    tmp += "\r\n";
                }

                tmp += "[" + x.ToString() + "; " + y.ToString() + "]\r\n";

                if (i == 29)
                {
                    tmp += "\r\n";
                    tmp += "--------------------------------\r\n";
                }

                Polje tmpP = btnMatrix[x, y];
                tmpP.bomba = true;
                btnMatrix[x, y] = tmpP;

                SteviloZelenih--;

                #region UrediStevilo

                if (x - 1 >= 0)
                {
                    if (btnMatrix[x - 1, y].stevilo != "")
                    {
                        int tmp0 = int.Parse(btnMatrix[x - 1, y].stevilo);
                        tmp0++;
                        btnMatrix[x - 1, y].stevilo = tmp0.ToString();
                    }
                    else
                    {
                        btnMatrix[x - 1, y].stevilo = "1";   
                    }
                }
                if (x + 1 < btnMatrix.GetLength(0))
                {
                    if (btnMatrix[x + 1, y].stevilo != "")
                    {
                        int tmp1 = int.Parse(btnMatrix[x + 1, y].stevilo);
                        tmp1++;
                        btnMatrix[x + 1, y].stevilo = tmp1.ToString();
                    }
                    else
                    {
                        btnMatrix[x + 1, y].stevilo = "1";   
                    }
                }
                if (y - 1 >= 0)
                {
                    if (btnMatrix[x, y - 1].stevilo != "")
                    {
                        int tmp2 = int.Parse(btnMatrix[x, y - 1].stevilo);
                        tmp2++;
                        btnMatrix[x, y - 1].stevilo = tmp2.ToString();
                    }
                    else
                    {
                        btnMatrix[x, y - 1].stevilo = "1";   
                    }
                }
                if (y + 1 < btnMatrix.GetLength(1))
                {
                    if (btnMatrix[x, y + 1].stevilo != "")
                    {
                        int tmp3 = int.Parse(btnMatrix[x, y + 1].stevilo);
                        tmp3++;
                        btnMatrix[x, y + 1].stevilo = tmp3.ToString();
                    }
                    else
                    {
                        btnMatrix[x, y + 1].stevilo = "1";  
                    }
                }
                if (x + 1 < btnMatrix.GetLength(0) && y + 1 < btnMatrix.GetLength(1))
                {
                    if (btnMatrix[x + 1, y + 1].stevilo != "")
                    {
                        int tmp4 = int.Parse(btnMatrix[x + 1, y + 1].stevilo);
                        tmp4++;
                        btnMatrix[x + 1, y + 1].stevilo = tmp4.ToString();
                    }
                    else
                    {
                        btnMatrix[x + 1, y + 1].stevilo = "1";   
                    }
                }
                if (x - 1 >= 0 && y - 1 >= 0)
                {
                    if (btnMatrix[x - 1, y - 1].stevilo != "")
                    {
                        int tmp5 = int.Parse(btnMatrix[x - 1, y - 1].stevilo);
                        tmp5++;
                        btnMatrix[x - 1, y - 1].stevilo = tmp5.ToString();
                    }
                    else
                    {
                        btnMatrix[x - 1, y - 1].stevilo = "1";   
                    }
                }
                if (x - 1 >= 0 && y + 1 < btnMatrix.GetLength(1))
                {
                    if (btnMatrix[x - 1, y + 1].stevilo != "")
                    {
                        int tmp6 = int.Parse(btnMatrix[x - 1, y + 1].stevilo);
                        tmp6++;
                        btnMatrix[x - 1, y + 1].stevilo = tmp6.ToString();
                    }
                    else
                    {
                        btnMatrix[x - 1, y + 1].stevilo = "1";   
                    }
                }
                if (x + 1 < btnMatrix.GetLength(0) && y - 1 >= 0)
                {
                    if (btnMatrix[x + 1, y - 1].stevilo != "")
                    {
                        int tmp7 = int.Parse(btnMatrix[x + 1, y - 1].stevilo);
                        tmp7++;
                        btnMatrix[x + 1, y - 1].stevilo = tmp7.ToString();
                    }
                    else
                    {
                        btnMatrix[x + 1, y - 1].stevilo = "1";   
                    }
                }

                #endregion
            }
        }

        public void ClickButton(Object sender, System.EventArgs e)
        {
            Button btn = (Button) sender;

            string[] polje = Regex.Split(btn.Tag.ToString(), @"[,]");

            btnMatrix[int.Parse(polje[0]), int.Parse(polje[1])].odkrit = true;

            if (btnMatrix[int.Parse(polje[0]), int.Parse(polje[1])].bomba == true)
            {
                btn.BackColor = Color.IndianRed;
                btn.Text = "";
            }
            else
            {
                btn.BackColor = Color.DarkSeaGreen;
                btn.Text = btnMatrix[int.Parse(polje[0]), int.Parse(polje[1])].stevilo;
                steviloIzbranih++;
            }

            OsveziGrid(int.Parse(polje[0]), int.Parse(polje[1]));
        }

        private void OsveziGrid(int x, int y)
        {
            if (btnMatrix[x, y].bomba == true)
            {
                PrikaziBombe();
                DialogResult result = MessageBox.Show("Zgubili ste! Želite končati?", "", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Zapri();
                }
                else
                {
                    CreateGamingField();
                }
            }
            else
            {
                if (steviloIzbranih == SteviloZelenih)
                {
                    PrikaziBombe();
                    DialogResult result = MessageBox.Show("Zmagali ste! Želite končati?", "", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        Zapri();
                    }
                    else
                    {
                        CreateGamingField();
                    }
                }
                else
                {
                    #region PregledVrstic

                    int xFreMin = x;
                    while (xFreMin >= 0)
                    {
                        if (btnMatrix[xFreMin, y].bomba == false && btnMatrix[xFreMin, y].stevilo == "")
                        {

                            #region Vrstice

                            int yMin = y;
                            bool yMinEna = false;
                            while (yMin >= 0)
                            {
                                if (btnMatrix[xFreMin, yMin].bomba == false && yMinEna == false)
                                {
                                    if (btnMatrix[xFreMin, yMin].odkrit == false)
                                    {
                                        btnMatrix[xFreMin, yMin].gumb.BackColor = Color.DarkSeaGreen;
                                        btnMatrix[xFreMin, yMin].gumb.Text = btnMatrix[xFreMin, yMin].stevilo;
                                        btnMatrix[xFreMin, yMin].odkrit = true;
                                        steviloIzbranih++;
                                    }
                                    if (btnMatrix[xFreMin, yMin].stevilo != "")
                                    {
                                        yMinEna = true;
                                    }
                                    yMin--;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            int yMax = y;
                            bool yMaxEna = false;
                            while (yMax < btnMatrix.GetLength(1))
                            {
                                if (btnMatrix[xFreMin, yMax].bomba == false && yMaxEna == false)
                                {
                                    if (btnMatrix[xFreMin, yMax].odkrit == false)
                                    {
                                        btnMatrix[xFreMin, yMax].gumb.BackColor = Color.DarkSeaGreen;
                                        btnMatrix[xFreMin, yMax].gumb.Text = btnMatrix[xFreMin, yMax].stevilo;
                                        btnMatrix[xFreMin, yMax].odkrit = true;
                                        steviloIzbranih++;
                                    }
                                    if (btnMatrix[xFreMin, yMax].stevilo != "")
                                    {
                                        yMaxEna = true;
                                    }
                                    yMax++;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            #endregion

                            xFreMin--;
                        }
                        else
                        {
                            break;
                        }
                    }

                    int xFreMax = x;
                    while (xFreMax < btnMatrix.GetLength(0))
                    {
                        if (btnMatrix[xFreMax, y].bomba == false && btnMatrix[xFreMax, y].stevilo == "")
                        {

                            #region Vrstice

                            int yMin = y;
                            bool yMinEna = false;
                            while (yMin >= 0)
                            {
                                if (btnMatrix[xFreMax, yMin].bomba == false && yMinEna == false)
                                {
                                    if (btnMatrix[xFreMax, yMin].odkrit == false)
                                    {
                                        btnMatrix[xFreMax, yMin].gumb.BackColor = Color.DarkSeaGreen;
                                        btnMatrix[xFreMax, yMin].gumb.Text = btnMatrix[xFreMax, yMin].stevilo;
                                        btnMatrix[xFreMax, yMin].odkrit = true;
                                        steviloIzbranih++;
                                    }
                                    if (btnMatrix[xFreMax, yMin].stevilo != "")
                                    {
                                        yMinEna = true;
                                    }
                                    yMin--;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            int yMax = y;
                            bool yMaxEna = false;
                            while (yMax < btnMatrix.GetLength(1))
                            {
                                if (btnMatrix[xFreMax, yMax].bomba == false && yMaxEna == false)
                                {
                                    if (btnMatrix[xFreMax, yMax].odkrit == false)
                                    {
                                        btnMatrix[xFreMax, yMax].gumb.BackColor = Color.DarkSeaGreen;
                                        btnMatrix[xFreMax, yMax].gumb.Text = btnMatrix[xFreMax, yMax].stevilo;
                                        btnMatrix[xFreMax, yMax].odkrit = true;
                                        steviloIzbranih++;
                                    }
                                    if (btnMatrix[xFreMax, yMax].stevilo != "")
                                    {
                                        yMaxEna = true;
                                    }
                                    yMax++;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            #endregion

                            xFreMax++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    #endregion
                    
                    #region PregledStolpci

                    int yFreMin = y;
                    while (yFreMin >= 0)
                    {
                        if (btnMatrix[x, yFreMin].bomba == false && btnMatrix[x, yFreMin].stevilo == "")
                        {

                            #region Vrstice

                            int xMin = x;
                            bool xMinEna = false;
                            while (xMin >= 0)
                            {
                                if (btnMatrix[xMin, yFreMin].bomba == false && xMinEna == false)
                                {
                                    if (btnMatrix[xMin, yFreMin].odkrit == false)
                                    {
                                        btnMatrix[xMin, yFreMin].gumb.BackColor = Color.DarkSeaGreen;
                                        btnMatrix[xMin, yFreMin].gumb.Text = btnMatrix[xMin, yFreMin].stevilo;
                                        btnMatrix[xMin, yFreMin].odkrit = true;
                                        steviloIzbranih++;
                                    }
                                    if (btnMatrix[xMin, yFreMin].stevilo != "")
                                    {
                                        xMinEna = true;
                                    }
                                    xMin--;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            int xMax = x;
                            bool xMaxEna = false;
                            while (xMax < btnMatrix.GetLength(0))
                            {
                                if (btnMatrix[xMax, yFreMin].bomba == false && xMaxEna == false)
                                {
                                    if (btnMatrix[xMax, yFreMin].odkrit == false)
                                    {
                                        btnMatrix[xMax, yFreMin].gumb.BackColor = Color.DarkSeaGreen;
                                        btnMatrix[xMax, yFreMin].gumb.Text = btnMatrix[xMax, yFreMin].stevilo;
                                        btnMatrix[xMax, yFreMin].odkrit = true;
                                        steviloIzbranih++;
                                    }
                                    if (btnMatrix[xMax, yFreMin].stevilo != "")
                                    {
                                        xMaxEna = true;
                                    }
                                    xMax++;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            #endregion

                            yFreMin--;
                        }
                        else
                        {
                            break;
                        }
                    }

                    int yFreMax = y;
                    while (yFreMax < btnMatrix.GetLength(1))
                    {
                        if (btnMatrix[x, yFreMax].bomba == false && btnMatrix[x, yFreMax].stevilo == "")
                        {

                            #region Vrstice

                            int xMin = x;
                            bool xMinEna = false;
                            while (xMin >= 0)
                            {
                                if (btnMatrix[xMin, yFreMax].bomba == false && xMinEna == false)
                                {
                                    if (btnMatrix[xMin, yFreMax].odkrit == false)
                                    {
                                        btnMatrix[xMin, yFreMax].gumb.BackColor = Color.DarkSeaGreen;
                                        btnMatrix[xMin, yFreMax].gumb.Text = btnMatrix[xMin, yFreMax].stevilo;
                                        btnMatrix[xMin, yFreMax].odkrit = true;
                                        steviloIzbranih++;
                                    }
                                    if (btnMatrix[xMin, yFreMax].stevilo != "")
                                    {
                                        xMinEna = true;
                                    }
                                    xMin--;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            int xMax = x;
                            bool xMaxEna = false;
                            while (xMax < btnMatrix.GetLength(0))
                            {
                                if (btnMatrix[xMax, yFreMax].bomba == false && xMaxEna == false)
                                {
                                    if (btnMatrix[xMax, yFreMax].odkrit == false)
                                    {
                                        btnMatrix[xMax, yFreMax].gumb.BackColor = Color.DarkSeaGreen;
                                        btnMatrix[xMax, yFreMax].gumb.Text = btnMatrix[xMax, yFreMax].stevilo;
                                        btnMatrix[xMax, yFreMax].odkrit = true;
                                        steviloIzbranih++;
                                    }
                                    if (btnMatrix[xMax, yFreMax].stevilo != "")
                                    {
                                        xMaxEna = true;
                                    }
                                    xMax++;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            #endregion

                            yFreMax++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    #endregion
                }
            }
        }

        private void PrikaziBombe()
        {

            for (int i = 0; i < btnMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < btnMatrix.GetLength(1); j++)
                {
                    if (btnMatrix[i, j].bomba == true)
                    {
                        btnMatrix[i, j].gumb.Text = "";
                        btnMatrix[i, j].gumb.BackColor = Color.IndianRed;
                    }
                }
            }
        }

        private void Zapri()
        {
            this.Close();
        }

        private void novaIgraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateGamingField();
        }

        private void zapriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prikažiBombeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziBombe();
            DialogResult result = MessageBox.Show("Zgubili ste! Želite končati?", "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Zapri();
            }
            else
            {
                CreateGamingField();
            }
        }
    }
}
