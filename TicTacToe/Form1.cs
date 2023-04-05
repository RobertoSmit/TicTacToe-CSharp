using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Location = new Point(0,-22);
        }

        //---------------- START SCHERM ----------------
        private void lbDeelnemer1_Start_Click(object sender, EventArgs e)
        {

        }

        private void lbDeelnemer2_Start_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CheckNames();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckNames();
        }

        private void CheckNames()
        {
            if ((tbDeelnemer1.Text != "") && (tbDeelnemer2.Text != ""))
            {
                btStart.Visible = true;
                
            }
            else
            {
                btStart.Visible = false;
               
            };
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            setNames();
            tabControl1.SelectedIndex = 1;
        }

        //---------------- GAME SCHERM ----------------
        private void setNames()
        {
            lbName1.Text = tbDeelnemer1.Text;
            lbName2.Text = tbDeelnemer2.Text;
        }
        
        private void tekenScherm()
        {
            Graphics tekenVeld = pictureBox1.CreateGraphics();
            Pen pencil = new Pen(Color.Black, 4);

            //Horizontaal
            tekenVeld.DrawLine(pencil, 0, 110, 330, 110);
            tekenVeld.DrawLine(pencil, 0, 220, 330, 220);

            //Verticaal
            tekenVeld.DrawLine(pencil, 110, 0, 110, 330);
            tekenVeld.DrawLine(pencil, 220, 0, 220, 330);
        }

        private void lbTitle_Game_Click(object sender, EventArgs e)
        {

        }
        private void lbDeelnemer1_Game_Click_1(object sender, EventArgs e)
        {

        }
        private void lbDeelnemer2_Game_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lbName1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tekenScherm();
        }
    }
}