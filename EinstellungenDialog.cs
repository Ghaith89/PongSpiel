using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Pong
{
    public partial class EinstellungenDialog : Form
    {
        //die Methode liefert den ausgewählten Wert
        public Point LiefereWert()
        {
            Point rueckgabe = new Point(0, 0);
            if (radioButton320.Checked == true)
                rueckgabe = new Point(320, 200);
            if (radioButton640.Checked == true)
                rueckgabe = new Point(640, 480);
            if (radioButton1024.Checked == true)
                rueckgabe = new Point(1024, 768);
            if (radioButtonMaximal.Checked == true)
                rueckgabe = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            using(RegistryKey regschlussel = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Einstellungen"))
            {

                //Die werte für die Spielfeld Lagepunkt einsetzen
                regschlussel.SetValue("SizePointX", Convert.ToString(rueckgabe.X));
                regschlussel.SetValue("SizePointY", Convert.ToString(rueckgabe.Y));
                
            }


            return rueckgabe;
        }

        public EinstellungenDialog()
        {
            InitializeComponent();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonUebernehmen_Click(object sender, EventArgs e)
        {
            LiefereWert();
        }
    }
}
