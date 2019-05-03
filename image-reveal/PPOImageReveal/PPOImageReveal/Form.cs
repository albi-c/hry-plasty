using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPOImageReveal
{
    public partial class Form : System.Windows.Forms.Form
    {

        int score = 3600/36*10;

        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateScore();

            for(int i = 1;i<=6*6;i++)
            {
                Button buttn = new Button();

                int it;
                if (i % 6 != 0)
                {
                    it = i / 6 + 1;
                }
                else
                {
                    it = i / 6;
                }

                // new Point(i % button_quantity_x * (button_size_x + button_gap_x) + button_align_x, (it * button_size_y) - (button_size_y + button_gap_y) + button_align_y);

                buttn.Location = new Point(i % 6 * (80 + -2) + 12, (it*(80 + -2)) - (80 + -2) + 12);
                buttn.Name = "button"+i;
                buttn.Size = new Size(80, 80);

                if (i % 6 == 0)
                {
                    buttn.TabIndex = i - 5;
                }
                else
                {
                    buttn.TabIndex = i+1;
                }
                
                buttn.Text = buttn.TabIndex.ToString();
                buttn.UseVisualStyleBackColor = true;
                buttn.Click += new EventHandler(buttonClick);

                Controls.Add(buttn);
            }
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Visible = false;
            score -= 100/36*10+8;
            UpdateScore();
        }

        void UpdateScore()
        {
            l_score.Text = "Score: " + score;
        }
    }
}
