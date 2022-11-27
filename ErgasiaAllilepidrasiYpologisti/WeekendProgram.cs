using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErgasiaAllilepidrasiYpologisti
{
    public partial class WeekendProgram : Form
    {
        public WeekendProgram()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Θέλετε να πάτε στο γυμναστήριο?", "Γυμναστήριο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {



                    if (MessageBox.Show("Θέλετε να πάτε με τα ποδια?", "Γυμναστήριο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process.Start("https://www.google.com/maps/dir//ALTERLIFE+%CE%9D%CE%AD%CE%BF+%CE%A6%CE%AC%CE%BB%CE%B7%CF%81%CE%BF,+%CE%A3%CF%84%CE%AC%CE%B4%CE%B9%CE%BF+%CE%9A%CE%B1%CF%81%CE%B1%CF%8A%CF%83%CE%BA%CE%AC%CE%BA%CE%B7+%CE%98%CF%8D%CF%81%CE%B5%CF%82+15-17,+185+47/@37.9464474,23.6310873,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bb5860363867:0x345f5cb55f109568!2m2!1d23.6661047!2d37.9464519!3e2");
                    }
                    else if (MessageBox.Show("Θέλετε να πάτε με αμάξι?", "Γυμναστήριο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process.Start("https://www.google.com/maps/dir//ALTERLIFE+%CE%9D%CE%AD%CE%BF+%CE%A6%CE%AC%CE%BB%CE%B7%CF%81%CE%BF,+%CE%A3%CF%84%CE%AC%CE%B4%CE%B9%CE%BF+%CE%9A%CE%B1%CF%81%CE%B1%CF%8A%CF%83%CE%BA%CE%AC%CE%BA%CE%B7+%CE%98%CF%8D%CF%81%CE%B5%CF%82+15-17,+185+47/@37.9464474,23.6310873,13z/data=!4m9!4m8!1m0!1m5!1m1!1s0x14a1bb5860363867:0x345f5cb55f109568!2m2!1d23.6661047!2d37.9464519!3e0");
                    }
                    else if (MessageBox.Show("Θέλετε να πάτε με συγκοινωνία?", "Γυμναστήριο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process.Start("https://www.google.com/maps/dir//ALTERLIFE+%CE%9D%CE%AD%CE%BF+%CE%A6%CE%AC%CE%BB%CE%B7%CF%81%CE%BF,+%CE%A3%CF%84%CE%AC%CE%B4%CE%B9%CE%BF+%CE%9A%CE%B1%CF%81%CE%B1%CF%8A%CF%83%CE%BA%CE%AC%CE%BA%CE%B7+%CE%98%CF%8D%CF%81%CE%B5%CF%82+15-17,+185+47/@37.9464474,23.6310873,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bb5860363867:0x345f5cb55f109568!2m2!1d23.6661047!2d37.9464519!3e3");
                    }
                }
            }
        }

        private void panel37_Paint(object sender, PaintEventArgs e)
        {

        }

        private void αρχικήΣελίδαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.ShowDialog();
            this.Close();
        }

        private void εβδομαδιαίοΠρόγραμμαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeekendProgram weekprog = new WeekendProgram();
            weekprog.ShowDialog();
            this.Close();
        }

        private void επίσημαΠαπούτσιαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormalShoes formalshoe = new FormalShoes();
            formalshoe.ShowDialog();
            this.Close();
        }

        private void αθλητικάΠαπούτσιαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CasualShoes casualshoe = new CasualShoes();
            casualshoe.ShowDialog();
            this.Close();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void αθλητικάΠαπούτσιαToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δεν έχετε αθλητικά παπούτσια!");
            {
                if (MessageBox.Show("Θέλετε να αγοράσετε αθλητικά παπούτσια?", "Αθλητικα παπούτσια", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.nike.com/gr/w/running-shoes-37v7jzy7ok");

                }
            }
        }

        private void κατοικίδιοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Katoikidio kat = new Katoikidio();
            kat.ShowDialog();
            this.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {
           
            
             if (MessageBox.Show("Θέλετε να πάτε στο πανεπιστήμιο?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (MessageBox.Show("Θέλετε να πάτε με τα ποδια?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415137,23.6506794,17z/data=!4m16!1m6!3m5!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2zzqDOsc69zrXPgM65z4PPhM6uzrzOuc6_IM6gzrXOuc-BzrHOuc-Oz4I!8m2!3d37.9415137!4d23.6528681!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e2");
                    }
                    else if(MessageBox.Show("Θέλετε να πάτε με αμάξι?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                            Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415085,23.6178486,13z/data=!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e0");
                    }
                    else if (MessageBox.Show("Θέλετε να πάτε με συγκοινωνία?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415085,23.6178486,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e3");
                    }
              }            
        }

        private void label26_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Θέλετε να πάτε στο πανεπιστήμιο?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (MessageBox.Show("Θέλετε να πάτε με τα ποδια?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415137,23.6506794,17z/data=!4m16!1m6!3m5!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2zzqDOsc69zrXPgM65z4PPhM6uzrzOuc6_IM6gzrXOuc-BzrHOuc-Oz4I!8m2!3d37.9415137!4d23.6528681!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e2");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με αμάξι?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415085,23.6178486,13z/data=!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e0");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με συγκοινωνία?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415085,23.6178486,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e3");
                }
            }
        }

        private void label33_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Θέλετε να πάτε στο πανεπιστήμιο?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (MessageBox.Show("Θέλετε να πάτε με τα ποδια?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415137,23.6506794,17z/data=!4m16!1m6!3m5!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2zzqDOsc69zrXPgM65z4PPhM6uzrzOuc6_IM6gzrXOuc-BzrHOuc-Oz4I!8m2!3d37.9415137!4d23.6528681!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e2");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με αμάξι?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415085,23.6178486,13z/data=!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e0");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με συγκοινωνία?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415085,23.6178486,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e3");
                }
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Θέλετε να πάτε στο πανεπιστήμιο?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (MessageBox.Show("Θέλετε να πάτε με τα ποδια?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415137,23.6506794,17z/data=!4m16!1m6!3m5!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2zzqDOsc69zrXPgM65z4PPhM6uzrzOuc6_IM6gzrXOuc-BzrHOuc-Oz4I!8m2!3d37.9415137!4d23.6528681!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e2");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με αμάξι?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415085,23.6178486,13z/data=!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e0");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με συγκοινωνία?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415085,23.6178486,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e3");
                }
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Θέλετε να πάτε στο πανεπιστήμιο?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (MessageBox.Show("Θέλετε να πάτε με τα ποδια?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415137,23.6506794,17z/data=!4m16!1m6!3m5!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2zzqDOsc69zrXPgM65z4PPhM6uzrzOuc6_IM6gzrXOuc-BzrHOuc-Oz4I!8m2!3d37.9415137!4d23.6528681!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e2");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με αμάξι?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415085,23.6178486,13z/data=!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e0");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με συγκοινωνία?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415085,23.6178486,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e3");
                }
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Θέλετε να πάτε στο πανεπιστήμιο?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (MessageBox.Show("Θέλετε να πάτε με τα ποδια?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415137,23.6506794,17z/data=!4m16!1m6!3m5!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2zzqDOsc69zrXPgM65z4PPhM6uzrzOuc6_IM6gzrXOuc-BzrHOuc-Oz4I!8m2!3d37.9415137!4d23.6528681!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e2");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με αμάξι?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415085,23.6178486,13z/data=!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e0");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με συγκοινωνία?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415085,23.6178486,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e3");
                }
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Θέλετε να πάτε στο πανεπιστήμιο?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (MessageBox.Show("Θέλετε να πάτε με τα ποδια?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415137,23.6506794,17z/data=!4m16!1m6!3m5!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2zzqDOsc69zrXPgM65z4PPhM6uzrzOuc6_IM6gzrXOuc-BzrHOuc-Oz4I!8m2!3d37.9415137!4d23.6528681!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e2");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με αμάξι?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415085,23.6178486,13z/data=!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e0");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με συγκοινωνία?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415085,23.6178486,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e3");
                }
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Θέλετε να πάτε στο πανεπιστήμιο?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (MessageBox.Show("Θέλετε να πάτε με τα ποδια?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415137,23.6506794,17z/data=!4m16!1m6!3m5!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2zzqDOsc69zrXPgM65z4PPhM6uzrzOuc6_IM6gzrXOuc-BzrHOuc-Oz4I!8m2!3d37.9415137!4d23.6528681!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e2");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με αμάξι?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415085,23.6178486,13z/data=!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e0");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με συγκοινωνία?", "Πανεπιστήμιο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85+80,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+34/@37.9415085,23.6178486,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe5bb8515a1:0x3e0dce8e58812705!2m2!1d23.6528681!2d37.9415137!3e3");
                }
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Θέλετε να πάτε στο γυμναστήριο?", "Γυμναστήριο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                if (MessageBox.Show("Θέλετε να πάτε με τα ποδια?", "Γυμναστήριο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//ALTERLIFE+%CE%9D%CE%AD%CE%BF+%CE%A6%CE%AC%CE%BB%CE%B7%CF%81%CE%BF,+%CE%A3%CF%84%CE%AC%CE%B4%CE%B9%CE%BF+%CE%9A%CE%B1%CF%81%CE%B1%CF%8A%CF%83%CE%BA%CE%AC%CE%BA%CE%B7+%CE%98%CF%8D%CF%81%CE%B5%CF%82+15-17,+185+47/@37.9464474,23.6310873,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bb5860363867:0x345f5cb55f109568!2m2!1d23.6661047!2d37.9464519!3e2");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με αμάξι?", "Γυμναστήριο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//ALTERLIFE+%CE%9D%CE%AD%CE%BF+%CE%A6%CE%AC%CE%BB%CE%B7%CF%81%CE%BF,+%CE%A3%CF%84%CE%AC%CE%B4%CE%B9%CE%BF+%CE%9A%CE%B1%CF%81%CE%B1%CF%8A%CF%83%CE%BA%CE%AC%CE%BA%CE%B7+%CE%98%CF%8D%CF%81%CE%B5%CF%82+15-17,+185+47/@37.9464474,23.6310873,13z/data=!4m9!4m8!1m0!1m5!1m1!1s0x14a1bb5860363867:0x345f5cb55f109568!2m2!1d23.6661047!2d37.9464519!3e0");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με συγκοινωνία?", "Γυμναστήριο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//ALTERLIFE+%CE%9D%CE%AD%CE%BF+%CE%A6%CE%AC%CE%BB%CE%B7%CF%81%CE%BF,+%CE%A3%CF%84%CE%AC%CE%B4%CE%B9%CE%BF+%CE%9A%CE%B1%CF%81%CE%B1%CF%8A%CF%83%CE%BA%CE%AC%CE%BA%CE%B7+%CE%98%CF%8D%CF%81%CE%B5%CF%82+15-17,+185+47/@37.9464474,23.6310873,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bb5860363867:0x345f5cb55f109568!2m2!1d23.6661047!2d37.9464519!3e3");
                }
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Θέλετε να πάτε στο γυμναστήριο?", "Γυμναστήριο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                if (MessageBox.Show("Θέλετε να πάτε με τα ποδια?", "Γυμναστήριο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//ALTERLIFE+%CE%9D%CE%AD%CE%BF+%CE%A6%CE%AC%CE%BB%CE%B7%CF%81%CE%BF,+%CE%A3%CF%84%CE%AC%CE%B4%CE%B9%CE%BF+%CE%9A%CE%B1%CF%81%CE%B1%CF%8A%CF%83%CE%BA%CE%AC%CE%BA%CE%B7+%CE%98%CF%8D%CF%81%CE%B5%CF%82+15-17,+185+47/@37.9464474,23.6310873,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bb5860363867:0x345f5cb55f109568!2m2!1d23.6661047!2d37.9464519!3e2");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με αμάξι?", "Γυμναστήριο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//ALTERLIFE+%CE%9D%CE%AD%CE%BF+%CE%A6%CE%AC%CE%BB%CE%B7%CF%81%CE%BF,+%CE%A3%CF%84%CE%AC%CE%B4%CE%B9%CE%BF+%CE%9A%CE%B1%CF%81%CE%B1%CF%8A%CF%83%CE%BA%CE%AC%CE%BA%CE%B7+%CE%98%CF%8D%CF%81%CE%B5%CF%82+15-17,+185+47/@37.9464474,23.6310873,13z/data=!4m9!4m8!1m0!1m5!1m1!1s0x14a1bb5860363867:0x345f5cb55f109568!2m2!1d23.6661047!2d37.9464519!3e0");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με συγκοινωνία?", "Γυμναστήριο", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//ALTERLIFE+%CE%9D%CE%AD%CE%BF+%CE%A6%CE%AC%CE%BB%CE%B7%CF%81%CE%BF,+%CE%A3%CF%84%CE%AC%CE%B4%CE%B9%CE%BF+%CE%9A%CE%B1%CF%81%CE%B1%CF%8A%CF%83%CE%BA%CE%AC%CE%BA%CE%B7+%CE%98%CF%8D%CF%81%CE%B5%CF%82+15-17,+185+47/@37.9464474,23.6310873,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bb5860363867:0x345f5cb55f109568!2m2!1d23.6661047!2d37.9464519!3e3");
                }
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Θέλετε να πάτε στο γήπεδο τένις?", "Γήπεδο Τένις", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (MessageBox.Show("Θέλετε να πάτε με τα ποδια?", "Γήπεδο Τένις", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A6%CE%99%CE%9B%CE%99%CE%91%CE%A3+%CE%A3%CE%95%CE%A6,+%CE%A3%CE%A4%CE%91%CE%94%CE%99%CE%9F+%CE%95%CE%99%CE%A1%CE%97%CE%9D%CE%97%CE%A3,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+33/@37.942782,23.6299899,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bb3dd11454c7:0x662870246bfef0c1!2m2!1d23.6650094!2d37.9427872!3e2");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με αμάξι?", "Γήπεδο Τένις", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A6%CE%99%CE%9B%CE%99%CE%91%CE%A3+%CE%A3%CE%95%CE%A6,+%CE%A3%CE%A4%CE%91%CE%94%CE%99%CE%9F+%CE%95%CE%99%CE%A1%CE%97%CE%9D%CE%97%CE%A3,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+33/@37.942782,23.6299899,13z/data=!4m9!4m8!1m0!1m5!1m1!1s0x14a1bb3dd11454c7:0x662870246bfef0c1!2m2!1d23.6650094!2d37.9427872!3e0");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με συγκοινωνία?", "Γήπεδο Τένις", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A6%CE%99%CE%9B%CE%99%CE%91%CE%A3+%CE%A3%CE%95%CE%A6,+%CE%A3%CE%A4%CE%91%CE%94%CE%99%CE%9F+%CE%95%CE%99%CE%A1%CE%97%CE%9D%CE%97%CE%A3,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+33/@37.942782,23.6299899,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bb3dd11454c7:0x662870246bfef0c1!2m2!1d23.6650094!2d37.9427872!3e3");
                }
            }
        }

        private void label35_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Θέλετε να πάτε στο γήπεδο τένις?", "Γήπεδο Τένις", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (MessageBox.Show("Θέλετε να πάτε με τα ποδια?", "Γήπεδο Τένις", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A6%CE%99%CE%9B%CE%99%CE%91%CE%A3+%CE%A3%CE%95%CE%A6,+%CE%A3%CE%A4%CE%91%CE%94%CE%99%CE%9F+%CE%95%CE%99%CE%A1%CE%97%CE%9D%CE%97%CE%A3,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+33/@37.942782,23.6299899,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bb3dd11454c7:0x662870246bfef0c1!2m2!1d23.6650094!2d37.9427872!3e2");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με αμάξι?", "Γήπεδο Τένις", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A6%CE%99%CE%9B%CE%99%CE%91%CE%A3+%CE%A3%CE%95%CE%A6,+%CE%A3%CE%A4%CE%91%CE%94%CE%99%CE%9F+%CE%95%CE%99%CE%A1%CE%97%CE%9D%CE%97%CE%A3,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+33/@37.942782,23.6299899,13z/data=!4m9!4m8!1m0!1m5!1m1!1s0x14a1bb3dd11454c7:0x662870246bfef0c1!2m2!1d23.6650094!2d37.9427872!3e0");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με συγκοινωνία?", "Γήπεδο Τένις", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A6%CE%99%CE%9B%CE%99%CE%91%CE%A3+%CE%A3%CE%95%CE%A6,+%CE%A3%CE%A4%CE%91%CE%94%CE%99%CE%9F+%CE%95%CE%99%CE%A1%CE%97%CE%9D%CE%97%CE%A3,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+33/@37.942782,23.6299899,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bb3dd11454c7:0x662870246bfef0c1!2m2!1d23.6650094!2d37.9427872!3e3");
                }
            }
        }

        private void label30_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Θέλετε να πάτε στην Πάρνηθα?", "Εκδρομή", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (MessageBox.Show("Θέλετε να πάτε με τα ποδια?", "Εκδρομή", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%AC%CF%81%CE%BD%CE%B7%CE%B8%CE%B1,+%CE%91%CF%87%CE%B1%CF%81%CE%BD%CE%AD%CF%82+136+72/@38.1745746,23.6817943,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a10a8a95deeb3b:0x7d1ba5bc209f4934!2m2!1d23.7168138!2d38.1745798!3e2");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με αμάξι?", "Εκδρομή", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%AC%CF%81%CE%BD%CE%B7%CE%B8%CE%B1,+%CE%91%CF%87%CE%B1%CF%81%CE%BD%CE%AD%CF%82+136+72/@38.1745746,23.6817943,13z/data=!4m9!4m8!1m0!1m5!1m1!1s0x14a10a8a95deeb3b:0x7d1ba5bc209f4934!2m2!1d23.7168138!2d38.1745798!3e0");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με συγκοινωνία?", "Εκδρομή", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A0%CE%AC%CF%81%CE%BD%CE%B7%CE%B8%CE%B1,+%CE%91%CF%87%CE%B1%CF%81%CE%BD%CE%AD%CF%82+136+72/@38.1745746,23.6817943,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a10a8a95deeb3b:0x7d1ba5bc209f4934!2m2!1d23.7168138!2d38.1745798!3e3");
                }
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Θέλετε να πάτε στο Σινεμά?", "Σινεμά", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (MessageBox.Show("Θέλετε να πάτε με τα ποδια?", "Σινεμά", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%94%CE%B7%CE%BC%CE%BF%CF%84%CE%B9%CE%BA%CF%8C%CF%82+%CE%9A%CE%B9%CE%BD%CE%B7%CE%BC%CE%B1%CF%84%CE%BF%CE%B3%CF%81%CE%AC%CF%86%CE%BF%CF%82+%CE%A3%CE%B9%CE%BD%CE%B5%CE%AC%CE%BA,+%CE%A0%CE%BB.+%CE%9A%CE%BF%CF%81%CE%B1%CE%AE,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+35/@37.9418875,23.612176,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe85e97bbe9:0x3e2dd06d830b261f!2m2!1d23.6471955!2d37.9418927!3e2");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με αμάξι?", "Σινεμά", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%94%CE%B7%CE%BC%CE%BF%CF%84%CE%B9%CE%BA%CF%8C%CF%82+%CE%9A%CE%B9%CE%BD%CE%B7%CE%BC%CE%B1%CF%84%CE%BF%CE%B3%CF%81%CE%AC%CF%86%CE%BF%CF%82+%CE%A3%CE%B9%CE%BD%CE%B5%CE%AC%CE%BA,+%CE%A0%CE%BB.+%CE%9A%CE%BF%CF%81%CE%B1%CE%AE,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+35/@37.9418875,23.612176,13z/data=!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe85e97bbe9:0x3e2dd06d830b261f!2m2!1d23.6471955!2d37.9418927!3e0");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με συγκοινωνία?", "Σινεμά", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%94%CE%B7%CE%BC%CE%BF%CF%84%CE%B9%CE%BA%CF%8C%CF%82+%CE%9A%CE%B9%CE%BD%CE%B7%CE%BC%CE%B1%CF%84%CE%BF%CE%B3%CF%81%CE%AC%CF%86%CE%BF%CF%82+%CE%A3%CE%B9%CE%BD%CE%B5%CE%AC%CE%BA,+%CE%A0%CE%BB.+%CE%9A%CE%BF%CF%81%CE%B1%CE%AE,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+35/@37.9418875,23.612176,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbe85e97bbe9:0x3e2dd06d830b261f!2m2!1d23.6471955!2d37.9418927!3e3");
                }
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Θέλετε να πάτε για ποτό?", "Club/Bar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (MessageBox.Show("Θέλετε να πάτε με τα ποδια?", "Club/Bar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//Lohan,+30,+%E1%BC%B9%CE%B5%CF%81%CE%AC+%E1%BD%89%CE%B4%CF%8C%CF%82+32,+%CE%91%CE%B8%CE%AE%CE%BD%CE%B1+104+35/@37.9801271,23.6791882,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bcdf1361cf75:0xd93f0d81a48af300!2m2!1d23.7142077!2d37.9801323!3e2");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με αμάξι?", "Club/Bar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//Lohan,+30,+%E1%BC%B9%CE%B5%CF%81%CE%AC+%E1%BD%89%CE%B4%CF%8C%CF%82+32,+%CE%91%CE%B8%CE%AE%CE%BD%CE%B1+104+35/@37.9801271,23.6791882,13z/data=!4m9!4m8!1m0!1m5!1m1!1s0x14a1bcdf1361cf75:0xd93f0d81a48af300!2m2!1d23.7142077!2d37.9801323!3e0");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με συγκοινωνία?", "Club/Bar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//Lohan,+30,+%E1%BC%B9%CE%B5%CF%81%CE%AC+%E1%BD%89%CE%B4%CF%8C%CF%82+32,+%CE%91%CE%B8%CE%AE%CE%BD%CE%B1+104+35/@37.9801271,23.6791882,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bcdf1361cf75:0xd93f0d81a48af300!2m2!1d23.7142077!2d37.9801323!3e3");
                }
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Θέλετε να πάτε στο Γήπεδο?", "Αγώνας", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (MessageBox.Show("Θέλετε να πάτε με τα ποδια?", "Αγώνας", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A3%CF%84%CE%AC%CE%B4%CE%B9%CE%BF+%CE%93%CE%B5%CF%8E%CF%81%CE%B3%CE%B9%CE%BF%CF%82+%CE%9A%CE%B1%CF%81%CE%B1%CF%8A%CF%83%CE%BA%CE%AC%CE%BA%CE%B7%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85,+%CE%A3%CE%BF%CF%86%CE%B9%CE%B1%CE%BD%CE%BF%CF%80%CE%BF%CF%8D%CE%BB%CE%BF%CF%85+%CE%BA%CE%B1%CE%B9,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+47/@37.9463892,23.6293935,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbf4cfae4785:0x344805bc9f0d0b6b!2m2!1d23.664413!2d37.9463944!3e2");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με αμάξι?", "Αγώνας", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A3%CF%84%CE%AC%CE%B4%CE%B9%CE%BF+%CE%93%CE%B5%CF%8E%CF%81%CE%B3%CE%B9%CE%BF%CF%82+%CE%9A%CE%B1%CF%81%CE%B1%CF%8A%CF%83%CE%BA%CE%AC%CE%BA%CE%B7%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85,+%CE%A3%CE%BF%CF%86%CE%B9%CE%B1%CE%BD%CE%BF%CF%80%CE%BF%CF%8D%CE%BB%CE%BF%CF%85+%CE%BA%CE%B1%CE%B9,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+47/@37.9463892,23.6293935,13z/data=!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbf4cfae4785:0x344805bc9f0d0b6b!2m2!1d23.664413!2d37.9463944!3e0");
                }
                else if (MessageBox.Show("Θέλετε να πάτε με συγκοινωνία?", "Άγώνας", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("https://www.google.com/maps/dir//%CE%A3%CF%84%CE%AC%CE%B4%CE%B9%CE%BF+%CE%93%CE%B5%CF%8E%CF%81%CE%B3%CE%B9%CE%BF%CF%82+%CE%9A%CE%B1%CF%81%CE%B1%CF%8A%CF%83%CE%BA%CE%AC%CE%BA%CE%B7%CF%82,+%CE%9A%CE%B1%CF%81%CE%B1%CE%BF%CE%BB%CE%AE+%CE%BA%CE%B1%CE%B9+%CE%94%CE%B7%CE%BC%CE%B7%CF%84%CF%81%CE%AF%CE%BF%CF%85,+%CE%A3%CE%BF%CF%86%CE%B9%CE%B1%CE%BD%CE%BF%CF%80%CE%BF%CF%8D%CE%BB%CE%BF%CF%85+%CE%BA%CE%B1%CE%B9,+%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CE%AC%CF%82+185+47/@37.9463892,23.6293935,13z/data=!3m1!4b1!4m9!4m8!1m0!1m5!1m1!1s0x14a1bbf4cfae4785:0x344805bc9f0d0b6b!2m2!1d23.664413!2d37.9463944!3e3");
                }
            }
        }
    }
}
