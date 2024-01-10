namespace WinForms_240109_animacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //odczytanie wymiarów formularza Form1
            int x = this.Width;
            int y = this.Height;

            //wielkoœæ pictureBox1
            pictureBox1.Width = 50; 
            pictureBox1.Height = 50;
            
            //ustawiam lewy, górny róg pictureBox1
            //w lewym górnym rogu Form1
            pictureBox1.Location=new Point(0,0);              
        
            //rysuje czerwone kó³ko na pictureBox1
            //dla elipsy,ko³a
            //podajemy ca³kowit¹ szerokoœæ i wysokoœæ
            Graphics g=pictureBox1.CreateGraphics();
            Brush brush=new SolidBrush(Color.Red);
            g.FillEllipse(brush, 0, 0, 
                pictureBox1.Width-1, 
                pictureBox1.Height-1);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(30,30);
            pictureBox.Location=new Point(100,0);
            pictureBox.BackColor= Color.Red;

/*
            //ruch kó³ka
            for (int i = 0; i < x-pictureBox1.Width; i++)
            {
                pictureBox1.Left = i;
                for (double j = 0; j<1e6 ; j++)
                {

                }
            }
*/

        }
    }
}