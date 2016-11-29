using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace mySnakeRedo
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thrd = new Thread(new ThreadStart(openGameField));
            thrd.Start();
            this.Close();
        }

        private void openGameField()
        {
            Application.Run(new Form1());
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thrd = new Thread(new ThreadStart(openAboutForm));
            thrd.Start();
        }
        
        private void openAboutForm()
        {
            Application.Run(new AboutForm());
        }
    }
}
