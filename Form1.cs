using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        private List<List<string>> map = new List<List<string>>();
        private bool player_turn = true;
        private Timer t = new Timer();

        public Form1()
        {
            InitializeComponent();
            initialize();
            t.Tick += T_Tick;
            t.Interval = 500;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            t.Stop();
            pc_go();
        }

        public void initialize()
        {
            List<string> row1 = new List<string> { "none", "none", "none" };
            List<string> row2 = new List<string> { "none", "none", "none" };
            List<string> row3 = new List<string> { "none", "none", "none" };

            map.Add(row1);
            map.Add(row2);
            map.Add(row3);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (player_turn)
            {
                if (pictureBox5.Image == null)
                {
                    pictureBox5.Image = Properties.Resources.cross;
                    player_turn = false;
                    map[1][1] = "cross";

                    label1.Text = "Thinking...";
                    t.Start();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (player_turn)
            {
                if (pictureBox4.Image == null)
                {
                    pictureBox4.Image = Properties.Resources.cross;
                    player_turn = false;
                    map[1][0] = "cross";
                    label1.Text = "Thinking...";
                    t.Start();
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (player_turn)
            {
                if (pictureBox7.Image == null)
                {
                    pictureBox7.Image = Properties.Resources.cross;
                    player_turn = false;
                    map[2][0] = "cross";
                    label1.Text = "Thinking...";
                    t.Start();
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (player_turn)
            {
                if (pictureBox8.Image == null)
                {
                    pictureBox8.Image = Properties.Resources.cross;
                    player_turn = false;
                    map[2][1] = "cross";
                    label1.Text = "Thinking...";
                    t.Start();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (player_turn)
            {
                if (pictureBox2.Image == null)
                {
                    pictureBox2.Image = Properties.Resources.cross;
                    player_turn = false;
                    map[0][1] = "cross";
                    label1.Text = "Thinking...";
                    t.Start();
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (player_turn)
            {
                if (pictureBox6.Image == null)
                {
                    pictureBox6.Image = Properties.Resources.cross;
                    player_turn = false;
                    map[1][2] = "cross";
                    label1.Text = "Thinking...";
                    t.Start();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (player_turn)
            {
                if (pictureBox3.Image == null)
                {
                    pictureBox3.Image = Properties.Resources.cross;
                    player_turn = false;
                    map[0][2] = "cross";
                    label1.Text = "Thinking...";
                    t.Start();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (player_turn)
            {
                if (pictureBox1.Image == null)
                {
                    pictureBox1.Image = Properties.Resources.cross;
                    player_turn = false;
                    map[0][0] = "cross";
                    label1.Text = "Thinking...";
                    t.Start();
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (player_turn)

            {
                if (pictureBox9.Image == null)
                {
                    pictureBox9.Image = Properties.Resources.cross;
                    player_turn = false;
                    map[2][2] = "cross";
                    label1.Text = "Thinking...";
                    t.Start();
                }
            }
        }

        public void pc_go()
        {
            bool went = false;
            int cnt = 0;
            int pccnt = 0;
            for (int x = 0; x < 3; x++)
            {
                if (map[0][x] == "cross")
                {
                    cnt++;
                }
                if (map[0][x] == "naught")
                {
                    pccnt++;
                }
            }
            if (cnt == 2)
            {
                for (int x = 0; x < 3; x++)
                {
                    if (map[0][x] == "none")
                    {
                        map[0][x] = "naught";
                        went = true;
                    }
                }
            }
            else if (cnt == 3)
            {
                MessageBox.Show("YOU WON THE GAME!", "WIN");
                Application.Restart();
                Environment.Exit(0);
            }
            if (!went)
            {
                cnt = 0;
                pccnt = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (map[1][x] == "cross")
                    {
                        cnt++;
                    }
                    if (map[1][x] == "naught")
                    {
                        pccnt++;
                    }
                }
                if (cnt == 2)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (map[1][x] == "none")
                        {
                            map[1][x] = "naught";
                            went = true;
                        }
                    }
                }
                else if (cnt == 3)
                {
                    MessageBox.Show("YOU WON THE GAME!", "WIN");
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
            if (!went)
            {
                cnt = 0;
                pccnt = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (map[2][x] == "cross")
                    {
                        cnt++;
                    }
                    if (map[2][x] == "naught")
                    {
                        pccnt++;
                    }
                }
                if (cnt == 2)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (map[2][x] == "none")
                        {
                            map[2][x] = "naught";
                            went = true;
                        }
                    }
                }
                else if (cnt == 3)
                {
                    MessageBox.Show("YOU WON THE GAME!", "WIN");
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
            cnt = 0;
            pccnt = 0;
            if (!went)
            {
                for (int x = 0; x < 3; x++)
                {
                    if (map[x][0] == "cross")
                    {
                        cnt++;
                    }
                    if (map[x][0] == "naught")
                    {
                        pccnt++;
                    }
                }
                if (cnt == 2)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (map[x][0] == "none")
                        {
                            map[x][0] = "naught";
                            went = true;
                        }
                    }
                }
                else if (cnt == 3)
                {
                    MessageBox.Show("YOU WON THE GAME!", "WIN");
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
            if (!went)
            {
                cnt = 0;
                pccnt = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (map[x][1] == "cross")
                    {
                        cnt++;
                    }
                    if (map[x][1] == "naught")
                    {
                        pccnt++;
                    }
                }
                if (cnt == 2)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (map[x][1] == "none")
                        {
                            map[x][1] = "naught";
                            went = true;
                        }
                    }
                }
                else if (cnt == 3)
                {
                    MessageBox.Show("YOU WON THE GAME!", "WIN");
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
            if (!went)
            {
                pccnt = 0;
                cnt = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (map[x][2] == "cross")
                    {
                        cnt++;
                    }
                    if (map[x][2] == "naught")
                    {
                        pccnt++;
                    }
                }
                if (cnt == 2)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (map[x][2] == "none")
                        {
                            map[x][2] = "naught";
                            went = true;
                        }
                    }
                }
                else if (cnt == 3)
                {
                    MessageBox.Show("YOU WON THE GAME!", "WIN");
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
            if (!went)
            {
                cnt = 0;
                pccnt = 0;
                if (map[0][0] == "cross")
                {
                    cnt++;
                }
                if (map[0][0] == "naught")
                {
                    pccnt++;
                }
                if (map[1][1] == "cross")
                {
                    cnt++;
                }
                if (map[1][1] == "naught")
                {
                    pccnt++;
                }
                if (map[2][2] == "cross")
                {
                    cnt++;
                }
                if (map[2][2] == "naught")
                {
                    pccnt++;
                }
                if (cnt == 2)
                {
                    if (map[0][0] != "cross")
                    {
                        map[0][0] = "naught";
                        went = true;
                    }
                    else if (map[1][1] != "cross")
                    {
                        map[1][1] = "naught";
                        went = true;
                    }
                    else if (map[2][2] != "cross")
                    {
                        map[2][2] = "naught";
                        went = true;
                    }
                }
                else if (cnt == 3)
                {
                    MessageBox.Show("YOU WON THE GAME!", "WIN");
                    Application.Restart();
                    Environment.Exit(0);
                }

                if (!went)
                {
                    cnt = 0;
                    pccnt = 0;
                    if (map[0][2] == "cross")
                    {
                        cnt++;
                    }
                    if (map[0][2] == "naught")
                    {
                        pccnt++;
                    }
                    if (map[1][1] == "cross")
                    {
                        cnt++;
                    }
                    if (map[1][1] == "naught")
                    {
                        pccnt++;
                    }
                    if (map[2][0] == "cross")
                    {
                        cnt++;
                    }
                    if (map[2][0] == "naught")
                    {
                        pccnt++;
                    }
                    if (cnt == 2)
                    {
                        if (map[0][2] != "cross")
                        {
                            map[0][2] = "naught";
                            went = true;
                        }
                        else if (map[1][1] != "cross")
                        {
                            map[1][1] = "naught";
                            went = true;
                        }
                        else if (map[2][0] != "cross")
                        {
                            map[2][0] = "naught";
                            went = true;
                        }
                    }
                    else if (cnt == 3)
                    {
                        MessageBox.Show("YOU WON THE GAME!", "WIN");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (!went)
            {
                int cn = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (map[0][x] == "naught")
                    {
                        cn++;
                    }
                }
                if (cn > 0)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (!went)
                        {
                            if (map[0][x] == "none")
                            {
                                map[0][x] = "naught";
                                went = true;
                            }
                        }
                    }
                }

                cn = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (map[1][x] == "naught")
                    {
                        cn++;
                    }
                }
                if (cn > 0)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (!went)
                        {
                            if (map[1][x] == "none")
                            {
                                went = true;
                                map[1][x] = "naught";
                            }
                        }
                    }
                }
                cn = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (map[2][x] == "naught")
                    {
                        cn++;
                    }
                }
                if (cn > 0)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (!went)
                        {
                            if (map[2][x] == "none")
                            {
                                map[2][x] = "naught";
                                went = true;
                            }
                        }
                    }
                }

                cn = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (map[x][0] == "naught")
                    {
                        cn++;
                    }
                }
                if (cn > 0)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (!went)
                        {
                            if (map[x][0] == "none")
                            {
                                map[x][0] = "naught";
                                went = true;
                            }
                        }
                    }
                }

                cn = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (map[x][1] == "naught")
                    {
                        cn++;
                    }
                }
                if (cn > 0)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (!went)
                        {
                            if (map[x][1] == "none")
                            {
                                map[x][1] = "naught";
                                went = true;
                            }
                        }
                    }
                }

                cn = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (map[x][2] == "naught")
                    {
                        cn++;
                    }
                }
                if (cn > 0)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (!went)
                        {
                            if (map[x][2] == "none")
                            {
                                map[x][2] = "naught";
                                went = true;
                            }
                        }
                    }
                }

                cn = 0;
                if (!went)
                {
                    if (map[0][0] == "naught")
                    {
                        cn++;
                    }
                    if (map[1][1] == "naught")
                    {
                        cn++;
                    }
                    if (map[2][2] == "naught")
                    {
                        cn++;
                    }
                    if (cn > 0)
                    {
                        if (map[0][0] == "none")
                        {
                            map[0][0] = "naught";
                            went = true;
                        }
                        else if (map[1][1] == "none")
                        {
                            map[1][1] = "naught";
                            went = true;
                        }
                        else if (map[2][2] == "none")
                        {
                            map[2][2] = "naught";
                            went = true;
                        }
                    }
                }

                cn = 0;
                if (!went)
                {
                    if (map[0][2] == "naught")
                    {
                        cn++;
                    }
                    if (map[1][1] == "naught")
                    {
                        cn++;
                    }
                    if (map[2][0] == "naught")
                    {
                        cn++;
                    }
                    if (cn > 0)
                    {
                        if (map[0][2] == "none")
                        {
                            map[0][2] = "naught";
                            went = true;
                        }
                        else if (map[1][1] == "none")
                        {
                            map[1][1] = "naught";
                            went = true;
                        }
                        else if (map[2][0] == "none")
                        {
                            map[2][0] = "naught";
                            went = true;
                        }
                    }
                }
            }
            if (!went)
            {
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        if (!went)
                        {
                            if (map[x][y] == "none")

                            {
                                went = true;
                                map[x][y] = "naught";
                            }
                        }
                    }
                }
            }

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (map[x][y] == "naught")
                    {
                        if (x == 0)
                        {
                            if (y == 0)
                            {
                                pictureBox1.Image = Properties.Resources.naught;
                            }
                            else if (y == 1)
                            {
                                pictureBox2.Image = Properties.Resources.naught;
                            }
                            else if (y == 2)
                            {
                                pictureBox3.Image = Properties.Resources.naught;
                            }
                        }
                        else if (x == 1)
                        {
                            if (y == 0)
                            {
                                pictureBox4.Image = Properties.Resources.naught;
                            }
                            else if (y == 1)
                            {
                                pictureBox5.Image = Properties.Resources.naught;
                            }
                            else if (y == 2)
                            {
                                pictureBox6.Image = Properties.Resources.naught;
                            }
                        }
                        else if (x == 2)
                        {
                            if (y == 0)
                            {
                                pictureBox7.Image = Properties.Resources.naught;
                            }
                            else if (y == 1)
                            {
                                pictureBox8.Image = Properties.Resources.naught;
                            }
                            else if (y == 2)
                            {
                                pictureBox9.Image = Properties.Resources.naught;
                            }
                        }
                    }
                }
            }

            int cnn = 0;
            for (int x = 0; x < 3; x++)
            {
                if (map[0][x] == "naught")
                {
                    cnn++;
                }
            }
            if (cnn == 3)
            {
                MessageBox.Show("THE PC WINS!", "LOSE");
                Application.Restart();
                Environment.Exit(0);
            }

            cnn = 0;
            for (int x = 0; x < 3; x++)
            {
                if (map[1][x] == "naught")
                {
                    cnn++;
                }
            }
            if (cnn == 3)
            {
                MessageBox.Show("THE PC WINS!", "LOSE");
                Application.Restart();
                Environment.Exit(0);
            }
            cnn = 0;
            for (int x = 0; x < 3; x++)
            {
                if (map[2][x] == "naught")
                {
                    cnn++;
                }
            }

            if (cnn == 3)
            {
                MessageBox.Show("THE PC WINS!", "LOSE");
                Application.Restart();
                Environment.Exit(0);
            }

            cnn = 0;
            for (int x = 0; x < 3; x++)
            {
                if (map[x][0] == "naught")
                {
                    cnn++;
                }
            }

            if (cnn == 3)
            {
                MessageBox.Show("THE PC WINS!", "LOSE");
                Application.Restart();
                Environment.Exit(0);
            }

            cnn = 0;
            for (int x = 0; x < 3; x++)
            {
                if (map[x][1] == "naught")
                {
                    cnn++;
                }
            }

            if (cnn == 3)
            {
                MessageBox.Show("THE PC WINS!", "LOSE");
                Application.Restart();
                Environment.Exit(0);
            }

            cnn = 0;
            for (int x = 0; x < 3; x++)
            {
                if (map[x][2] == "naught")
                {
                    cnn++;
                }
            }
            if (cnn == 3)
            {
                MessageBox.Show("THE PC WINS!", "LOSE");
                Application.Restart();
                Environment.Exit(0);
            }
            cnn = 0;

            if (map[0][0] == "naught")
            {
                cnn++;
            }
            if (map[1][1] == "naught")
            {
                cnn++;
            }
            if (map[2][2] == "naught")
            {
                cnn++;
            }

            if (cnn == 3)
            {
                MessageBox.Show("THE PC WINS!", "LOSE");
                Application.Restart();
                Environment.Exit(0);
            }

            cnn = 0;

            if (map[0][2] == "naught")
            {
                cnn++;
            }
            if (map[1][1] == "naught")
            {
                cnn++;
            }
            if (map[2][0] == "naught")
            {
                cnn++;
            }

            if (cnn == 3)
            {
                MessageBox.Show("THE PC WINS!");
                Application.Restart();
                Environment.Exit(0);
            }

            int chk = 0;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (map[x][y] != "none")
                    {
                        chk++;
                    }
                }
            }
            if (chk == 9)
            {
                MessageBox.Show("THE GAME WAS A TIE!", "TIE");
                Application.Restart();
                Environment.Exit(0);
            }

            label1.Text = "Your turn.";

            player_turn = true;
        }
    }
}