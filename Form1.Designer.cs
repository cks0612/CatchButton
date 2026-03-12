namespace CatchButton
{
    partial class Btngame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            run_btn = new Button();
            SuspendLayout();
            // 
            // run_btn
            // 
            run_btn.BackColor = Color.Yellow;
            run_btn.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            run_btn.ForeColor = Color.Red;
            run_btn.Location = new Point(209, 156);
            run_btn.Name = "run_btn";
            run_btn.Size = new Size(133, 54);
            run_btn.TabIndex = 0;
            run_btn.Text = "나를 잡아봐 ";
            run_btn.UseVisualStyleBackColor = false;
            run_btn.Click += button1_MouseEnter;
            run_btn.MouseEnter += button1_MouseEnter;
            // 
            // Btngame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 503);
            Controls.Add(run_btn);
            Name = "Btngame";
            Text = "버튼찾기 게임";
            ResumeLayout(false);
        }

        #endregion

        private Button run_btn;
    }
}
