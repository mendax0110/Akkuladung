using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akkuladung
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* BatteryChargeStatus beschreibt den aktuellen Akkuzustand, als Ergebnis wird eine
                Aufzählung zurückgegeben, die, als Strings betrachtet, folgende Werte beinhaltet:
                - High
                - Low
                - Critical
                - Charging
                - No SystemBattery
                - Unknown */
            
            string ChargeStatus = SystemInformation.PowerStatus.BatteryChargeStatus.ToString();
           
            // liest die ungefähre Restkapazität des Akkus in Sekunden aus
            float RemainingSeconds = SystemInformation.PowerStatus.BatteryLifeRemaining;
            // Gibt an, ob der Laptop an den Strom angeschlossen ist (Online) oder über Akku läuft (Offline).
            string OnBattery = System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus.ToString();
            // liest die ungefähre Restkapazität des Akkus in Prozent aus
            float RemainingPercent = SystemInformation.PowerStatus.BatteryLifePercent;
            label1.Text = ChargeStatus +" "+ RemainingPercent*100+"%"+"  "+(RemainingSeconds/60)/60+"  "+ OnBattery;
            pictureBox1.Width = (int)(RemainingPercent * 100)*2;
            pictureBox1.Height = 20;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
            
        }
    }
}
