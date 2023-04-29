using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Aqua;
            panel1.BackgroundImage = Properties.Resources.background2;
            this.Size = new Size(1918, 1104);
            this.StartPosition = FormStartPosition.CenterScreen;
            timer1.Stop();
            panel2.Hide();
            panel2.BackColor = Color.Blue;
            this.Controls.Add(panel2);
            this.Controls.SetChildIndex(panel2, 0);
            enemyHitCount = 0;
            this.Controls.Add(panel3);
            this.Controls.SetChildIndex(panel3, 0);
            panel3.Hide();
            panel3.BackColor = Color.Red;
            panel4.Hide();
            panel4.BackColor = Color.LimeGreen;
            nepritel2.SendToBack();
            nepritel3.SendToBack();
            nepritel4.SendToBack();
            nepritel5.SendToBack();
            zivotynepritele2.SendToBack();
            zivotynepritele3.SendToBack();
            zivotynepritele4.SendToBack();
            zivotynepritele5.SendToBack();
            nepritel.Hide();
            nepritel2.Hide();
            nepritel3.Hide();
            nepritel4.Hide();
            nepritel5.Hide();
            zivotynepritele.Hide();
            zivotynepritele2.Hide();
            zivotynepritele3.Hide();
            zivotynepritele4.Hide();
            zivotynepritele5.Hide();
        }

    }
}
