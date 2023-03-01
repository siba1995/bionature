using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatureBioMarkt
{
    public partial class loadingscreen : Form
    {   //3 erstellen eine neue variable
        private int loadinbarvalue;
        public loadingscreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadingbar_timer.Start();//1 timer starten
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadingbar_timer_Tick(object sender, EventArgs e)
        {
            loadinbarvalue += 1;
            label2.Text = loadinbarvalue.ToString() + "%";
            progressBar1.Value = loadinbarvalue;  //2 wenn der timer läuft füllen wi die value.
            if (loadinbarvalue >= progressBar1.Maximum)
            {
                loadingbar_timer.Stop();
                // finish loading show main menu screen
                mainmanuscreen mainmanuscreen = new mainmanuscreen();
                mainmanuscreen.Show();
                // bei this ich meinte the loadingscreen verschwendet dann ich sehe die hauptmenu
                this.Hide();
            }
        }
       
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        

    }
}
