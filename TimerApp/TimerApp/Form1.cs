using System;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;

namespace TimerApp
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
            try
            {
                Thread thread = new Thread(new ThreadStart(Currenttime));
                thread.Start();
            } catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void Currenttime()
        {
            while (true)
            {
                try {
                    Invoke(new Action(() =>
                    {
                        string dt = DateTime.Now.ToString("HH:mm:ss");
                        label1.Text = $"Time: {dt}"; 
                    }
                    )
                        );
                } catch { return; }
            }
        }



        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ItsPyDevs");
        }
    }
}
