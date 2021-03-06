using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        private string side = "cross";
        int streak = 0;
        Timer scr_cnt = new Timer();
        private bool has_switched = false;
        private List<List<string>> map = new List<List<string>>();
        private bool player_turn = true;

        private Timer t = new Timer();

        public Form1()
        {
            InitializeComponent();
            initialize();
            t.Tick += T_Tick;
            scr_cnt.Tick += Scr_cnt_Tick;
            scr_cnt.Interval = 2000;
            t.Interval = 200;
            label4.Visible = false;
        }

        private void Scr_cnt_Tick(object sender, EventArgs e)
        {
            label4.Visible = false;
            player_turn = true;
            scr_cnt.Stop();
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
            map.Clear();
            map.Add(row1);
            map.Add(row2);
            map.Add(row3);
            pictureBox1.Image = null;
            pictureBox9.Image = null;
            pictureBox8.Image = null;
            pictureBox7.Image = null;
            pictureBox6.Image = null;
            pictureBox5.Image = null;
            pictureBox4.Image = null;
            pictureBox3.Image = null;
            pictureBox2.Image = null;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (player_turn)
            {
                if (pictureBox5.Image == null)
                {
                    if (side == "cross")
                    {
                        pictureBox5.Image = Properties.Resources.cross;
                    }
                    else
                    {
                        pictureBox5.Image = Properties.Resources.naught;
                    }
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
                    if (side == "cross")
                    {
                        pictureBox4.Image = Properties.Resources.cross;
                    }
                    else
                    {
                        pictureBox4.Image = Properties.Resources.naught;
                    }
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
                    if (side == "cross")
                    {
                        pictureBox7.Image = Properties.Resources.cross;
                    }
                    else
                    {
                        pictureBox7.Image = Properties.Resources.naught;
                    }
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
                    if (side == "cross")
                    {
                        pictureBox8.Image = Properties.Resources.cross;
                    }
                    else
                    {
                        pictureBox8.Image = Properties.Resources.naught;
                    }
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
                    if (side == "cross")
                    {
                        pictureBox2.Image = Properties.Resources.cross;
                    }
                    else
                    {
                        pictureBox2.Image = Properties.Resources.naught;
                    }
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
                    if (side == "cross")
                    {
                        pictureBox6.Image = Properties.Resources.cross;
                    }
                    else
                    {
                        pictureBox6.Image = Properties.Resources.naught;
                    }
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
                    if (side == "cross")
                    {
                        pictureBox3.Image = Properties.Resources.cross;
                    }
                    else
                    {
                        pictureBox3.Image = Properties.Resources.naught;
                    }
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
                    if (side == "cross")
                    {
                        pictureBox1.Image = Properties.Resources.cross;
                    }
                    else
                    {
                        pictureBox1.Image = Properties.Resources.naught;
                    }
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
                    if (side == "cross")
                    {
                        pictureBox9.Image = Properties.Resources.cross;
                    }
                    else
                    {
                        pictureBox9.Image = Properties.Resources.naught;
                    }
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
            if (cnt == 3)
            {
                streak++;
                label3.Text = streak.ToString();
                label4.Visible = true;

                player_turn = false;
                label4.Text = "YOU WIN!";
                scr_cnt.Start();
                List<string> row1 = new List<string> { "none", "none", "none" };
                List<string> row2 = new List<string> { "none", "none", "none" };
                List<string> row3 = new List<string> { "none", "none", "none" };
                map.Clear();
                map.Add(row1);
                map.Add(row2);
                map.Add(row3);
                pictureBox1.Image = null;
                pictureBox9.Image = null;
                pictureBox8.Image = null;
                pictureBox7.Image = null;
                pictureBox6.Image = null;
                pictureBox5.Image = null;
                pictureBox4.Image = null;
                pictureBox3.Image = null;
                pictureBox2.Image = null;
                went = true;
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
                if (cnt == 3)
                {
                    streak++;
                    label3.Text = streak.ToString();
                    label4.Visible = true;
                    player_turn = false;
                    label4.Text = "YOU WIN!";
                    scr_cnt.Start();
                    List<string> row1 = new List<string> { "none", "none", "none" };
                    List<string> row2 = new List<string> { "none", "none", "none" };
                    List<string> row3 = new List<string> { "none", "none", "none" };
                    map.Clear();
                    map.Add(row1);
                    map.Add(row2);
                    map.Add(row3);
                    pictureBox1.Image = null;
                    pictureBox9.Image = null;
                    pictureBox8.Image = null;
                    pictureBox7.Image = null;
                    pictureBox6.Image = null;
                    pictureBox5.Image = null;
                    pictureBox4.Image = null;
                    pictureBox3.Image = null;
                    pictureBox2.Image = null;
                    went = true;
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
                if (cnt == 3)
                {
                    streak++;
                    label3.Text = streak.ToString();
                    label4.Visible = true;
                    player_turn = false;
                    label4.Text = "YOU WIN!";
                    scr_cnt.Start();
                    List<string> row1 = new List<string> { "none", "none", "none" };
                    List<string> row2 = new List<string> { "none", "none", "none" };
                    List<string> row3 = new List<string> { "none", "none", "none" };
                    map.Clear();
                    map.Add(row1);
                    map.Add(row2);
                    map.Add(row3);
                    pictureBox1.Image = null;
                    pictureBox9.Image = null;
                    pictureBox8.Image = null;
                    pictureBox7.Image = null;
                    pictureBox6.Image = null;
                    pictureBox5.Image = null;
                    pictureBox4.Image = null;
                    pictureBox3.Image = null;
                    pictureBox2.Image = null;
                    went = true;
                }
            }
            cnt = 0;
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
                if (cnt == 3)
                {
                    streak++;
                    label3.Text = streak.ToString();
                    label4.Visible = true;
                    player_turn = false;
                    label4.Text = "YOU WIN!";
                    scr_cnt.Start();
                    List<string> row1 = new List<string> { "none", "none", "none" };
                    List<string> row2 = new List<string> { "none", "none", "none" };
                    List<string> row3 = new List<string> { "none", "none", "none" };
                    map.Clear();
                    map.Add(row1);
                    map.Add(row2);
                    map.Add(row3);
                    pictureBox1.Image = null;
                    pictureBox9.Image = null;
                    pictureBox8.Image = null;
                    pictureBox7.Image = null;
                    pictureBox6.Image = null;
                    pictureBox5.Image = null;
                    pictureBox4.Image = null;
                    pictureBox3.Image = null;
                    pictureBox2.Image = null;
                    went = true;
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
                if (cnt == 3)
                {
                    streak++;
                    label3.Text = streak.ToString();
                    label4.Visible = true;
                    player_turn = false;
                    label4.Text = "YOU WIN!";
                    scr_cnt.Start();
                    List<string> row1 = new List<string> { "none", "none", "none" };
                    List<string> row2 = new List<string> { "none", "none", "none" };
                    List<string> row3 = new List<string> { "none", "none", "none" };
                    map.Clear();
                    map.Add(row1);
                    map.Add(row2);
                    map.Add(row3);
                    pictureBox1.Image = null;
                    pictureBox9.Image = null;
                    pictureBox8.Image = null;
                    pictureBox7.Image = null;
                    pictureBox6.Image = null;
                    pictureBox5.Image = null;
                    pictureBox4.Image = null;
                    pictureBox3.Image = null;
                    pictureBox2.Image = null;
                    went = true;
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
                if (cnt == 3)
                {
                    streak++;
                    label3.Text = streak.ToString();
                    label4.Visible = true;
                    player_turn = false;
                    label4.Text = "YOU WIN!";
                    scr_cnt.Start();
                    List<string> row1 = new List<string> { "none", "none", "none" };
                    List<string> row2 = new List<string> { "none", "none", "none" };
                    List<string> row3 = new List<string> { "none", "none", "none" };
                    map.Clear();
                    map.Add(row1);
                    map.Add(row2);
                    map.Add(row3);
                    pictureBox1.Image = null;
                    pictureBox9.Image = null;
                    pictureBox8.Image = null;
                    pictureBox7.Image = null;
                    pictureBox6.Image = null;
                    pictureBox5.Image = null;
                    pictureBox4.Image = null;
                    pictureBox3.Image = null;
                    pictureBox2.Image = null;
                    went = true;
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
                else if (cnt == 3)
                {
                    streak++;
                    label3.Text = streak.ToString();
                    label4.Visible = true;
                    player_turn = false;
                    label4.Text = "YOU WIN!";
                    scr_cnt.Start();
                    List<string> row1 = new List<string> { "none", "none", "none" };
                    List<string> row2 = new List<string> { "none", "none", "none" };
                    List<string> row3 = new List<string> { "none", "none", "none" };
                    map.Clear();
                    map.Add(row1);
                    map.Add(row2);
                    map.Add(row3);
                    pictureBox1.Image = null;
                    pictureBox9.Image = null;
                    pictureBox8.Image = null;
                    pictureBox7.Image = null;
                    pictureBox6.Image = null;
                    pictureBox5.Image = null;
                    pictureBox4.Image = null;
                    pictureBox3.Image = null;             
                    pictureBox2.Image = null;
                    went = true;
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
                    else if (cnt == 3)
                    {
                        streak++;
                        label3.Text = streak.ToString();
                        label4.Visible = true;
                        player_turn = false;
                        label4.Text = "YOU WIN!";
                        scr_cnt.Start();
                        List<string> row1 = new List<string> { "none", "none", "none" };
                        List<string> row2 = new List<string> { "none", "none", "none" };
                        List<string> row3 = new List<string> { "none", "none", "none" };
                        map.Clear();
                        map.Add(row1);
                        map.Add(row2);
                        map.Add(row3);
                        pictureBox1.Image = null;
                        pictureBox9.Image = null;
                        pictureBox8.Image = null;
                        pictureBox7.Image = null;
                        pictureBox6.Image = null;
                        pictureBox5.Image = null;
                        pictureBox4.Image = null;
                        pictureBox3.Image = null;
                        pictureBox2.Image = null;
                        went = true;
                    }
                }

                int qwe = 0;

                for (int x = 0; x < 3; x++)
                {
                    if (map[x][0] == "naught")
                    {
                        qwe++;
                    }
                }
                if (qwe == 2)
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

                qwe = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (map[x][1] == "naught")
                    {
                        qwe++;
                    }
                }
                if (qwe == 2)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (!went)
                        {
                            if (map[x][1] == "none")
                            {
                                went = true;
                                map[x][1] = "naught";
                            }
                        }
                    }
                }

                qwe = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (map[x][2] == "naught")
                    {
                        qwe++;
                    }
                }
                if (qwe == 2)
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

                qwe = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (map[0][x] == "naught")
                    {
                        qwe++;
                    }
                }
                if (qwe == 2)
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

                qwe = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (map[1][x] == "naught")
                    {
                        qwe++;
                    }
                }
                if (qwe == 2)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (!went)
                        {
                            if (map[1][x] == "none")
                            {
                                map[1][x] = "naught";
                                went = true;
                            }
                        }
                    }
                }

                qwe = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (map[2][x] == "naught")
                    {
                        qwe++;
                    }
                }
                if (qwe == 2)
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
                if (!went)
                {
                    qwe = 0;
                    if (map[0][0] == "naught")
                    {
                        qwe++;
                    }
                    if (map[1][1] == "naught")
                    {
                        qwe++;
                    }
                    if (map[2][2] == "naught")
                    {
                        qwe++;
                    }
                    if (qwe == 2)
                    {
                        if (map[0][0] == "none")
                        {
                            map[0][0] = "naught";
                            went = true;
                        }
                        if (!went)
                        {
                            if (map[1][1] == "none")
                            {
                                map[1][1] = "naught";
                                went = true;
                            }
                        }
                        if (!went)
                        {
                            if (map[2][2] == "none")
                            {
                                map[2][2] = "naught";
                                went = true;
                            }
                        }
                    }
                }
                if (!went)
                {
                    qwe = 0;
                    if (map[0][2] == "naught")
                    {
                        qwe++;
                    }
                    if (map[1][1] == "naught")
                    {
                        qwe++;
                    }
                    if (map[2][0] == "naught")
                    {
                        qwe++;
                    }
                    if (qwe == 2)
                    {
                        if (map[0][2] == "none")
                        {
                            map[0][2] = "naught";
                            went = true;
                        }
                        if (!went)
                        {
                            if (map[1][1] == "none")
                            {
                                map[1][1] = "naught";
                                went = true;
                            }
                        }
                        if (!went)
                        {
                            if (map[2][0] == "none")
                            {
                                map[2][0] = "naught";
                                went = true;
                            }
                        }
                    }
                }
            }
            if (!went)
            {
                cnt = 0;
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
            }
            if (!went)
            {
                cnt = 0;
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
                        if (!went)
                        {
                            if (map[1][x] == "none")
                            {
                                map[1][x] = "naught";
                                went = true;
                            }
                        }
                    }
                }
            }
            if (!went)
            {
                cnt = 0;
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
            }
            cnt = 0;
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
            }
            if (!went)
            {
                cnt = 0;
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
            }
            if (!went)
            {
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
            }
            if (!went)
            {
                cnt = 0;
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
                    if (map[0][0] == "none")
                    {
                        map[0][0] = "naught";
                        went = true;
                    }
                    if (!went)
                    {
                        if (map[1][1] == "none")
                        {
                            map[1][1] = "naught";
                            went = true;
                        }
                    }
                    if (!went)
                    {
                        if (map[2][2] == "none")
                        {
                            map[2][2] = "naught";
                            went = true;
                        }
                    }
                }
                if (!went)
                {
                    cnt = 0;
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
                        if (map[0][2] == "none")
                        {
                            map[0][2] = "naught";
                            went = true;
                        }
                        if (!went)
                        {
                            if (map[1][1] == "none")
                            {
                                map[1][1] = "naught";
                                went = true;
                            }
                        }
                        if (!went)
                        {
                            if (map[2][0] == "none")
                            {
                                map[2][0] = "naught";
                                went = true;
                            }
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
            }
            if (!went)
            {
                Random r = new Random();
                bool placed = false;
                int cec = 0;
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        if (map[x][y] != "none")
                        {
                            cec++;
                        }
                    }
                }
                if (cec == 9)
                {
                    placed = true;
                }
                while (!placed)
                {
                    if (!went)
                    {
                        int x = r.Next(0, 3);
                        int y = r.Next(0, 3);
                        if (map[x][y] == "none")
                        {
                            map[x][y] = "naught";
                            placed = true;
                            went = true;
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
                                if (side == "cross")
                                {
                                    pictureBox1.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox1.Image = Properties.Resources.cross;
                                }
                            }
                            else if (y == 1)
                            {
                                if (side == "cross")
                                {
                                    pictureBox2.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox2.Image = Properties.Resources.cross;
                                }
                            }
                            else if (y == 2)
                            {
                                if (side == "cross")
                                {
                                    pictureBox3.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox3.Image = Properties.Resources.cross;
                                }
                            }
                        }
                        else if (x == 1)
                        {
                            if (y == 0)
                            {
                                if (side == "cross")
                                {
                                    pictureBox4.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox4.Image = Properties.Resources.cross;
                                }
                            }
                            else if (y == 1)
                            {
                                if (side == "cross")
                                {
                                    pictureBox5.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox5.Image = Properties.Resources.cross;
                                }
                            }
                            else if (y == 2)
                            {
                                if (side == "cross")
                                {
                                    pictureBox6.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox6.Image = Properties.Resources.cross;
                                }
                            }
                        }
                        else if (x == 2)
                        {
                            if (y == 0)
                            {
                                if (side == "cross")
                                {
                                    pictureBox7.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox7.Image = Properties.Resources.cross;
                                }
                            }
                            else if (y == 1)
                            {
                                if (side == "cross")
                                {
                                    pictureBox8.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox8.Image = Properties.Resources.cross;
                                }
                            }
                            else if (y == 2)
                            {
                                if (side == "cross")
                                {
                                    pictureBox9.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox9.Image = Properties.Resources.cross;
                                }
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
                streak = 0;
                label3.Text = streak.ToString();
                label4.Visible = true;
                player_turn = false;
                label4.Text = "YOU LOSE!";
                scr_cnt.Start();
                List<string> row1 = new List<string> { "none", "none", "none" };
                List<string> row2 = new List<string> { "none", "none", "none" };
                List<string> row3 = new List<string> { "none", "none", "none" };
                map.Clear();
                map.Add(row1);
                map.Add(row2);
                map.Add(row3);
                pictureBox1.Image = null;
                pictureBox9.Image = null;
                pictureBox8.Image = null;
                pictureBox7.Image = null;
                pictureBox6.Image = null;
                pictureBox5.Image = null;
                pictureBox4.Image = null;
                pictureBox3.Image = null;
                pictureBox2.Image = null;
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
                streak = 0;
                label3.Text = streak.ToString();
                label4.Visible = true;
                player_turn = false;

                label4.Text = "YOU LOSE!";
                scr_cnt.Start();
                List<string> row1 = new List<string> { "none", "none", "none" };
                List<string> row2 = new List<string> { "none", "none", "none" };
                List<string> row3 = new List<string> { "none", "none", "none" };
                map.Clear();
                map.Add(row1);
                map.Add(row2);
                map.Add(row3);
                pictureBox1.Image = null;
                pictureBox9.Image = null;
                pictureBox8.Image = null;
                pictureBox7.Image = null;
                pictureBox6.Image = null;
                pictureBox5.Image = null;
                pictureBox4.Image = null;
                pictureBox3.Image = null;
                pictureBox2.Image = null;
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
                streak = 0;
                label3.Text = streak.ToString();
                label4.Visible = true;
                player_turn = false;
                label4.Text = "YOU LOSE!";
                scr_cnt.Start();
                List<string> row1 = new List<string> { "none", "none", "none" };
                List<string> row2 = new List<string> { "none", "none", "none" };
                List<string> row3 = new List<string> { "none", "none", "none" };
                map.Clear();
                map.Add(row1);
                map.Add(row2);
                map.Add(row3);
                pictureBox1.Image = null;
                pictureBox9.Image = null;
                pictureBox8.Image = null;
                pictureBox7.Image = null;
                pictureBox6.Image = null;
                pictureBox5.Image = null;
                pictureBox4.Image = null;
                pictureBox3.Image = null;
                pictureBox2.Image = null;
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
                streak = 0;
                label3.Text = streak.ToString();
                label4.Visible = true;
                player_turn = false;
                label4.Text = "YOU LOSE!";
                scr_cnt.Start();
                List<string> row1 = new List<string> { "none", "none", "none" };
                List<string> row2 = new List<string> { "none", "none", "none" };
                List<string> row3 = new List<string> { "none", "none", "none" };
                map.Clear();
                map.Add(row1);
                map.Add(row2);
                map.Add(row3);
                pictureBox1.Image = null;
                pictureBox9.Image = null;
                pictureBox8.Image = null;
                pictureBox7.Image = null;
                pictureBox6.Image = null;
                pictureBox5.Image = null;
                pictureBox4.Image = null;
                pictureBox3.Image = null;
                pictureBox2.Image = null;
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
                streak = 0;
                label3.Text = streak.ToString();
                label4.Visible = true;
                player_turn = false;
                label4.Text = "YOU LOSE!";
                scr_cnt.Start();
                List<string> row1 = new List<string> { "none", "none", "none" };
                List<string> row2 = new List<string> { "none", "none", "none" };
                List<string> row3 = new List<string> { "none", "none", "none" };
                map.Clear();
                map.Add(row1);
                map.Add(row2);
                map.Add(row3);
                pictureBox1.Image = null;
                pictureBox9.Image = null;
                pictureBox8.Image = null;
                pictureBox7.Image = null;
                pictureBox6.Image = null;
                pictureBox5.Image = null;
                pictureBox4.Image = null;
                pictureBox3.Image = null;
                pictureBox2.Image = null;
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
                streak = 0;
                label3.Text = streak.ToString();
                label4.Visible = true;
                player_turn = false;

                label4.Text = "YOU LOSE!";
                scr_cnt.Start();
                List<string> row1 = new List<string> { "none", "none", "none" };
                List<string> row2 = new List<string> { "none", "none", "none" };
                List<string> row3 = new List<string> { "none", "none", "none" };
                map.Clear();
                map.Add(row1);
                map.Add(row2);
                map.Add(row3);
                pictureBox1.Image = null;
                pictureBox9.Image = null;
                pictureBox8.Image = null;
                pictureBox7.Image = null;
                pictureBox6.Image = null;
                pictureBox5.Image = null;
                pictureBox4.Image = null;
                pictureBox3.Image = null;
                pictureBox2.Image = null;
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
                streak = 0;
                label3.Text = streak.ToString();
                label4.Visible = true;
                player_turn = false;
                label4.Text = "YOU LOSE!";
                scr_cnt.Start();
                List<string> row1 = new List<string> { "none", "none", "none" };
                List<string> row2 = new List<string> { "none", "none", "none" };
                List<string> row3 = new List<string> { "none", "none", "none" };
                map.Clear();
                map.Add(row1);
                map.Add(row2);
                map.Add(row3);
                pictureBox1.Image = null;
                pictureBox9.Image = null;
                pictureBox8.Image = null;
                pictureBox7.Image = null;
                pictureBox6.Image = null;
                pictureBox5.Image = null;
                pictureBox4.Image = null;
                pictureBox3.Image = null;
                pictureBox2.Image = null;
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
                streak = 0;
                label3.Text = streak.ToString();
                label4.Visible = true;
                player_turn = false;
                label4.Text = "YOU LOSE!";
                scr_cnt.Start();
                List<string> row1 = new List<string> { "none", "none", "none" };
                List<string> row2 = new List<string> { "none", "none", "none" };
                List<string> row3 = new List<string> { "none", "none", "none" };
                map.Clear();
                map.Add(row1);
                map.Add(row2);
                map.Add(row3);
                pictureBox1.Image = null;
                pictureBox9.Image = null;
                pictureBox8.Image = null;
                pictureBox7.Image = null;
                pictureBox6.Image = null;
                pictureBox5.Image = null;
                pictureBox4.Image = null;
                pictureBox3.Image = null;
                pictureBox2.Image = null;
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
                label3.Text = streak.ToString();
                label4.Visible = true;
                player_turn = false;
                label4.Text = "TIE!";
                scr_cnt.Start();
                List<string> row1 = new List<string> { "none", "none", "none" };
                List<string> row2 = new List<string> { "none", "none", "none" };
                List<string> row3 = new List<string> { "none", "none", "none" };
                map.Clear();
                
                map.Add(row1);
                map.Add(row2);
                map.Add(row3);
                pictureBox1.Image = null;
                pictureBox9.Image = null;
                pictureBox8.Image = null;
                pictureBox7.Image = null;
                pictureBox6.Image = null;
                pictureBox5.Image = null;
                pictureBox4.Image = null;
                pictureBox3.Image = null;
                pictureBox2.Image = null;
            }

            label1.Text = "Your turn.";

            player_turn = true;
        }

        private void switcher()
        {
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
                                if (side == "cross")
                                {
                                    pictureBox1.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox1.Image = Properties.Resources.cross;
                                }
                            }
                            else if (y == 1)
                            {
                                if (side == "cross")
                                {
                                    pictureBox2.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox2.Image = Properties.Resources.cross;
                                }
                            }
                            else if (y == 2)
                            {
                                if (side == "cross")
                                {
                                    pictureBox3.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox3.Image = Properties.Resources.cross;
                                }
                            }
                        }
                        else if (x == 1)
                        {
                            if (y == 0)
                            {
                                if (side == "cross")
                                {
                                    pictureBox4.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox4.Image = Properties.Resources.cross;
                                }
                            }
                            else if (y == 1)
                            {
                                if (side == "cross")
                                {
                                    pictureBox5.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox5.Image = Properties.Resources.cross;
                                }
                            }
                            else if (y == 2)
                            {
                                if (side == "cross")
                                {
                                    pictureBox6.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox6.Image = Properties.Resources.cross;
                                }
                            }
                        }
                        else if (x == 2)
                        {
                            if (y == 0)
                            {
                                if (side == "cross")
                                {
                                    pictureBox7.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox7.Image = Properties.Resources.cross;
                                }
                            }
                            else if (y == 1)
                            {
                                if (side == "cross")
                                {
                                    pictureBox8.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox8.Image = Properties.Resources.cross;
                                }
                            }
                            else if (y == 2)
                            {
                                if (side == "cross")
                                {
                                    pictureBox9.Image = Properties.Resources.naught;
                                }
                                else
                                {
                                    pictureBox9.Image = Properties.Resources.cross;
                                }
                            }
                        }
                    }














                    if (map[x][y] == "cross")
                    {
                        if (x == 0)
                        {
                            if (y == 0)
                            {
                                if (side == "cross")
                                {
                                    pictureBox1.Image = Properties.Resources.cross;
                                }
                                else
                                {
                                    pictureBox1.Image = Properties.Resources.naught;
                                }
                            }
                            else if (y == 1)
                            {
                                if (side == "cross")
                                {
                                    pictureBox2.Image = Properties.Resources.cross;
                                }
                                else
                                {
                                    pictureBox2.Image = Properties.Resources.naught;
                                }
                            }
                            else if (y == 2)
                            {
                                if (side == "cross")
                                {
                                    pictureBox3.Image = Properties.Resources.cross;
                                }
                                else
                                {
                                    pictureBox3.Image = Properties.Resources.naught;
                                }
                            }
                        }
                        else if (x == 1)
                        {
                            if (y == 0)
                            {
                                if (side == "cross")
                                {
                                    pictureBox4.Image = Properties.Resources.cross;
                                }
                                else
                                {
                                    pictureBox4.Image = Properties.Resources.naught;
                                }
                            }
                            else if (y == 1)
                            {
                                if (side == "cross")
                                {
                                    pictureBox5.Image = Properties.Resources.cross;
                                }
                                else
                                {
                                    pictureBox5.Image = Properties.Resources.naught;
                                }
                            }
                            else if (y == 2)
                            {
                                if (side == "cross")
                                {
                                    pictureBox6.Image = Properties.Resources.cross;
                                }
                                else
                                {
                                    pictureBox6.Image = Properties.Resources.naught;
                                }
                            }
                        }
                        else if (x == 2)
                        {
                            if (y == 0)
                            {
                                if (side == "cross")
                                {
                                    pictureBox7.Image = Properties.Resources.cross;
                                }
                                else
                                {
                                    pictureBox7.Image = Properties.Resources.naught;
                                }
                            }
                            else if (y == 1)
                            {
                                if (side == "cross")
                                {
                                    pictureBox8.Image = Properties.Resources.cross;
                                }
                                else
                                {
                                    pictureBox8.Image = Properties.Resources.naught;
                                }
                            }
                            else if (y == 2)
                            {
                                if (side == "cross")
                                {
                                    pictureBox9.Image = Properties.Resources.cross;
                                }
                                else
                                {
                                    pictureBox9.Image = Properties.Resources.naught;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            has_switched = true;
            if (side == "cross")
            {
                side = "naught";
            }
            else
            {
                side = "cross";
            }
            switcher();
        }
    }
}