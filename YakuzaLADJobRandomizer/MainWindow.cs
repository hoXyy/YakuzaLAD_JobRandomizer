using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YakuzaLADJobRandomizer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string randomized_jobs = "";

            if (checkedListBox1.CheckedItems.Count != 0)
            {
                // If so, loop through all checked items and print results.  
                List<string> checkedBoxes = new List<string>();
                for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                {
                    checkedBoxes.Add(checkedListBox1.CheckedItems[x].ToString());
                }

                if (checkedBoxes.Contains("Ichiban") && checkBox1.Checked)
                {
                    string [] all_ichi_jobs = new string[Jobs.ichi_dlc_jobs.Length + Jobs.ichi_jobs.Length];
                    Array.Copy(Jobs.ichi_jobs, all_ichi_jobs, Jobs.ichi_jobs.Length);
                    Array.Copy(Jobs.ichi_dlc_jobs, 0, all_ichi_jobs, Jobs.ichi_jobs.Length, Jobs.ichi_dlc_jobs.Length);
                    randomized_jobs = randomized_jobs + "Ichiban: " + all_ichi_jobs[random.Next(0, all_ichi_jobs.Length)] + "\n";
                }
                else if (checkedBoxes.Contains("Ichiban") && !checkBox1.Checked)
                {
                    randomized_jobs = randomized_jobs + "Ichiban: " + Jobs.ichi_jobs[random.Next(0, Jobs.ichi_jobs.Length)] + "\n";
                };

                if (checkedBoxes.Contains("Adachi") && checkBox1.Checked)
                {
                    string[] all_adachi_jobs = new string[Jobs.adachi_dlc_jobs.Length + Jobs.adachi_jobs.Length];
                    Array.Copy(Jobs.adachi_jobs, all_adachi_jobs, Jobs.adachi_jobs.Length);
                    Array.Copy(Jobs.adachi_dlc_jobs, 0, all_adachi_jobs, Jobs.adachi_jobs.Length, Jobs.adachi_dlc_jobs.Length);
                    randomized_jobs = randomized_jobs + "Adachi: " + all_adachi_jobs[random.Next(0, all_adachi_jobs.Length)] + "\n";
                }
                else if (checkedBoxes.Contains("Adachi") && !checkBox1.Checked)
                {
                    randomized_jobs = randomized_jobs + "Adachi: " + Jobs.adachi_jobs[random.Next(0, Jobs.adachi_jobs.Length)] + "\n";
                };

                if (checkedBoxes.Contains("Saeko") && checkBox1.Checked)
                {
                    string[] all_saeko_jobs = new string[Jobs.saeko_dlc_jobs.Length + Jobs.saeko_jobs.Length];
                    Array.Copy(Jobs.saeko_jobs, all_saeko_jobs, Jobs.saeko_jobs.Length);
                    Array.Copy(Jobs.saeko_dlc_jobs, 0, all_saeko_jobs, Jobs.saeko_jobs.Length, Jobs.saeko_dlc_jobs.Length);
                    randomized_jobs = randomized_jobs + "Saeko: " + all_saeko_jobs[random.Next(0, all_saeko_jobs.Length)] + "\n";
                }
                else if (checkedBoxes.Contains("Saeko") && !checkBox1.Checked)
                {
                    randomized_jobs = randomized_jobs + "Saeko: " + Jobs.saeko_jobs[random.Next(0, Jobs.saeko_jobs.Length)] + "\n";
                };

                if (checkedBoxes.Contains("Namba") && checkBox1.Checked)
                {
                    string[] all_namba_jobs = new string[Jobs.namba_dlc_jobs.Length + Jobs.namba_jobs.Length];
                    Array.Copy(Jobs.namba_jobs, all_namba_jobs, Jobs.namba_jobs.Length);
                    Array.Copy(Jobs.namba_dlc_jobs, 0, all_namba_jobs, Jobs.namba_jobs.Length, Jobs.namba_dlc_jobs.Length);
                    randomized_jobs = randomized_jobs + "Namba: " + all_namba_jobs[random.Next(0, all_namba_jobs.Length)] + "\n";
                }
                else if (checkedBoxes.Contains("Namba") && !checkBox1.Checked)
                {
                    randomized_jobs = randomized_jobs + "Namba: " + Jobs.namba_jobs[random.Next(0, Jobs.namba_jobs.Length)] + "\n";
                };

                if (checkedBoxes.Contains("Joon-gi Han") && checkBox1.Checked)
                {
                    string[] all_joongi_jobs = new string[Jobs.joongi_dlc_jobs.Length + Jobs.joongi_jobs.Length];
                    Array.Copy(Jobs.joongi_jobs, all_joongi_jobs, Jobs.joongi_jobs.Length);
                    Array.Copy(Jobs.joongi_dlc_jobs, 0, all_joongi_jobs, Jobs.joongi_jobs.Length, Jobs.joongi_dlc_jobs.Length);
                    randomized_jobs = randomized_jobs + "Joon-gi Han: " + all_joongi_jobs[random.Next(0, all_joongi_jobs.Length)] + "\n";
                }
                else if (checkedBoxes.Contains("Joon-gi Han") && !checkBox1.Checked)
                {
                    randomized_jobs = randomized_jobs + "Joon-gi Han: " + Jobs.joongi_jobs[random.Next(0, Jobs.joongi_jobs.Length)] + "\n";
                };

                if (checkedBoxes.Contains("Zhao") && checkBox1.Checked)
                {
                    string[] all_zhao_jobs = new string[Jobs.zhao_dlc_jobs.Length + Jobs.zhao_jobs.Length];
                    Array.Copy(Jobs.zhao_jobs, all_zhao_jobs, Jobs.zhao_jobs.Length);
                    Array.Copy(Jobs.zhao_dlc_jobs, 0, all_zhao_jobs, Jobs.zhao_jobs.Length, Jobs.zhao_dlc_jobs.Length);
                    randomized_jobs = randomized_jobs + "Zhao: " + all_zhao_jobs[random.Next(0, all_zhao_jobs.Length)] + "\n";
                }
                else if (checkedBoxes.Contains("Zhao") && !checkBox1.Checked)
                {
                    randomized_jobs = randomized_jobs + "Zhao: " + Jobs.zhao_jobs[random.Next(0, Jobs.zhao_jobs.Length)] + "\n";
                };

                if (checkedBoxes.Contains("Eri") && checkBox1.Checked)
                {
                    string[] all_eri_jobs = new string[Jobs.eri_dlc_jobs.Length + Jobs.eri_jobs.Length];
                    Array.Copy(Jobs.eri_jobs, all_eri_jobs, Jobs.eri_jobs.Length);
                    Array.Copy(Jobs.eri_dlc_jobs, 0, all_eri_jobs, Jobs.eri_jobs.Length, Jobs.eri_dlc_jobs.Length);
                    randomized_jobs = randomized_jobs + "Eri: " + all_eri_jobs[random.Next(0, all_eri_jobs.Length)] + "\n";
                }
                else if (checkedBoxes.Contains("Eri") && !checkBox1.Checked)
                {
                    randomized_jobs = randomized_jobs + "Eri: " + Jobs.eri_jobs[random.Next(0, Jobs.eri_jobs.Length)] + "\n";
                };
            }

            richTextBox1.Text = randomized_jobs.ToString();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public static class Jobs
    {
        // ichiban
        public static string[] ichi_jobs = { "Part-Timer", "Hero", "Bodyguard", "Host", "Dancer", "Wrecker", "Street Musician", "Chef", "Riot Police", "Fortune Teller" }; // base jobs
        public static string[] ichi_dlc_jobs = { "Devil Rocker" }; // dlc jobs

        // adachi
        public static string[] adachi_jobs = { "Detective", "Bodyguard", "Wrecker", "Riot Police", "Dancer", "Street Musician", "Host", "Chef", "Fortune Teller" };
        public static string[] adachi_dlc_jobs = { "Devil Rocker" };

        // namba
        public static string[] namba_jobs = { "Homeless", "Dancer", "Street Musician", "Bodyguard", "Chef", "Fortune Teller", "Host", "Riot Police", "Wrecker" };
        public static string[] namba_dlc_jobs = { "Devil Rocker" };

        // saeko
        public static string[] saeko_jobs = { "Junior Mistress", "Hostess", "Idol", "Night Queen", "Dealer" };
        public static string[] saeko_dlc_jobs = { "Matriarch" };

        // joon-gi han
        public static string[] joongi_jobs = { "Hitman", "Bodyguard", "Host", "Dancer", "Riot Police", "Wrecker", "Street Musician", "Chef", "Fortune Teller" };
        public static string[] joongi_dlc_jobs = { "Devil Rocker" };

        // zhao
        public static string[] zhao_jobs = { "Mafia", "Street Musician", "Chef", "Host", "Dancer", "Bodyguard", "Fortune Teller", "Wrecker", "Riot Police" };
        public static string[] zhao_dlc_jobs = { "Devil Rocker" };

        // eri
        public static string[] eri_jobs = { "Office Clerk", "Idol", "Dealer", "Hostess", "Night Queen" };
        public static string[] eri_dlc_jobs = { "Matriarch" };
    }
}
