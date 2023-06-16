using System.ComponentModel;

namespace HW_03._06._23_RunningButton
{
    public partial class Form1 : Form
    {
        private int xBtn, yBtn, widthBtn, heightBtn, sizeX, sizeY, randX, randY;
        private Random rand = new Random();
       
        public Form1()
        {
            InitializeComponent();
            xBtn = button1.Location.X;
            yBtn = button1.Location.Y;
            widthBtn = button1.Width;
            heightBtn = button1.Height;
            sizeX = Size.Width;
            sizeY = Size.Height;
            randX = sizeX - button1.Width - 50;
            randY = sizeY - button1.Height - 30;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= xBtn - 1 && e.X <= xBtn + widthBtn && e.Y >= yBtn - 1 && e.Y <= yBtn + heightBtn)
            {
                xBtn = rand.Next(0, randX);
                yBtn = rand.Next(0, randY);
            }
            button1.Location = new Point(xBtn, yBtn);
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            xBtn=rand.Next(0, randX);
            yBtn=rand.Next(0, randY);
            button1.Location =new Point(xBtn, yBtn);
        }
    }
}