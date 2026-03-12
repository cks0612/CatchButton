using static System.Net.Mime.MediaTypeNames;

namespace CatchButton
{
    public partial class Btngame : Form
    {
        private Random random;

        public Btngame()
        {
            InitializeComponent();

            random = new Random();
            run_btn.MouseEnter += button1_MouseEnter;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            int maxX = this.ClientSize.Width - run_btn.Width;
            int maxY = this.ClientSize.Height - run_btn.Height;

            int newX = random.Next(0, maxX);
            int newY = random.Next(0, maxY);

            run_btn.Location = new Point(newX, newY);

            this.Text = $"버튼위치: ({newX}, {newY})";
        }
    }
}
