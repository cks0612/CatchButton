using static System.Net.Mime.MediaTypeNames;

namespace CatchButton
{
    public partial class Btngame : Form
    {
        private Random random;
        int score = 500;

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

            this.Text = $"점수:({score}) |버튼위치: ({newX}, {newY})";
        }

        private void run_btn_MouseClick(object sender, MouseEventArgs e)
        {

            score += 100;
            MessageBox.Show("버튼을 잡았습니다! +100점", "성공");

            int newWidth = (int)(run_btn.Width * 0.9);
            int newHeight = (int)(run_btn.Height * 0.9);

            if (newWidth < 30) newWidth = 30;
            if (newHeight < 20) newHeight = 20;

            run_btn.Size = new Size(newWidth, newHeight);
        }

        private void Btngame_Click(object sender, EventArgs e)
        {
            score -= 50;
            MessageBox.Show("버튼을 놓쳤습니다! -50점", "실패");

            if (score <= 0)
            {
                var result = MessageBox.Show("게임 오버!\n다시 하시겠습니까?",
                                             "Game Over",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
  
                    score = 500;
                    run_btn.Size = new Size(200, 60);
                    this.Text = $"점수:({score}) | 버튼위치: ({run_btn.Location.X}, {run_btn.Location.Y})";
                }
                else
                {

                    this.Close();
                }
            }
        }
    }
}
