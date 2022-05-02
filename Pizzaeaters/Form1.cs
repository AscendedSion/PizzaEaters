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
using System.Net.NetworkInformation;
using System.Media;
using System.Net;
using System.Net.Http;

namespace Pizzaeaters
{
    public partial class Form1 : Form
    {
        private object eyoip;
        private object streamreader;

        public Form1()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            string message = "Well done! You're safe. Eat your pizza happily.";
            string title = "Good Answer";
            MessageBox.Show(message, title);
           // Process.Start("cmd.exe", @"/C taskkill /IM cmd.exe");
            Process.Start("cmd.exe", @"/c taskkill /im Pizzaeaters.exe");
           // Process.Start("cmd.exe", @"/C taskkill /IM cmd.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
            Process.Start("cmd", @"/C echo Nice house, it looks like i have planted several IED's inside of it. However, if you find them in time (60 seconds) Nothing will happen. I live in your walls.");
            Process.Start("calc", @"/C taskkill /IM notepad.exe");
            Process.Start("cmd.exe", @"/C ipconfig /all");
            Process.Start("cmd.exe", @"/C 	control netconnections");
            Process.Start("cmd.exe", @"/C route");
            Process.Start("cmd.exe", @"/C 	netstat");
            Process.Start("cmd.exe", @"/C ipconfig");
            Console.WriteLine("Initializing RAT Trojan");
            //Process.Kill("");

            var endpoint = "https://api.ipify.org/";
            using (var client = new HttpClient())
            {
                var externalIP = client.GetStringAsync(endpoint).Result;
                //Console.WriteLine($"external IP {externalIP}");

                // eyoip.Text = externalIP;

                string message = "Monster. You deserve whats coming to you.";
                string title = "AscendedSION";
                MessageBox.Show(message, title);
                Process.Start("cmd.exe", @"/c taskkill /im Pizzaeaters.exe");
                    
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // nothing to see here
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string message = "";
            if (checkBox1.Checked)
            {
                message = "RAT Initialized.";
                //string title = "AscendedSION";

                Process.Start("cmd.exe", @"/C taskkill /IM cmd.exe");
            }

            else
            {
                message = "Rat Uninitialized";

            }


            MessageBox.Show(message);
        }
    }
}

