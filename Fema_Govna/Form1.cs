namespace Fema_Govna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random Anim_rand_x = new();
            Random Anim_rand_y = new();
            Random EDA_rand_X = new();
            Random EDA_rand_Y = new();

            Bitmap anim = Resource1.BADIM;
            Bitmap EDA = Resource1.≈блище;

            int point = 0;

            do
            {
                int Anim_X = pictureBox1.Location.X + Anim_rand_x.Next(0, pictureBox1.Size.Width - 50);
                int Anim_Y = pictureBox1.Location.Y + Anim_rand_y.Next(0, pictureBox1.Size.Height - 50);

                int tr = Anim_rand_x.Next(0, pictureBox1.Size.Width - 50);

                e.Graphics.DrawImage(anim, new Point(Anim_X, Anim_Y));

                int Eda_X = Anim_X + EDA_rand_X.Next(-50, 50);
                int Eda_Y = Anim_Y + EDA_rand_Y.Next(-50, 50);

                e.Graphics.DrawImage(EDA, new Point(Eda_X, Eda_Y));

                point++;

            } while (point != 10);
        }
    }
}
