using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MineSweeperGUI
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int xPos = int.Parse(textBox1.Text.ToString());
                int yPos = int.Parse(textBox2.Text.ToString());
                int stBomb = int.Parse(textBox3.Text.ToString());

                Form1 Minolovec = new Form1(stBomb, xPos, yPos);
                Minolovec.Size = new System.Drawing.Size((yPos * 35) + 43, (xPos * 36) + 100);
                Minolovec.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: " + ex.Message + ".");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
