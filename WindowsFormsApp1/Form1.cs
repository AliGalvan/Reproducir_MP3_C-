using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        WindowsMediaPlayer sonido;

        public Form1()
        {
            InitializeComponent();
            try
            {
                if (sonido == null)
                {
                    sonido = new WindowsMediaPlayer();
                    sonido.URL = @"C:\";
                    sonido.controls.play();
                    sonido.settings.setMode("loop", true);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay cancion");
            }

        }

        

        /*private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sonido == null)
                {
                    sonido = new WindowsMediaPlayer();
                    sonido.URL = @"C:\Users\aliga\Music\Buttercup.mp3";
                    sonido.controls.play();
                    sonido.settings.setMode("loop", true);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("No hay cancion");
            }

        }*/

    }
}
