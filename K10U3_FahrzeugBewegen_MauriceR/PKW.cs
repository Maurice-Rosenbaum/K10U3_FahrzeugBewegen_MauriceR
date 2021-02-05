using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K10U3_FahrzeugBewegen_MauriceR
{
    class PKW : System.Windows.Forms.Button
    {
        private int speed;

        public int Speed { get => speed;
            set
            {
                if (speed+value <= 100 && speed+value >= 0)
                {
                    speed = value;
                }
            }
        
        }
        public void Fahren (Panel p1)
        {
            while (this.Left<=(p1.Width-this.Width))
            { 
                this.Left++;                                            // Alternativ: this.Left=this.Left+1;
                Application.DoEvents();                                // "using System.Windows.Forms;" Hinzufügen
                System.Threading.Thread.Sleep(100 - Speed);
            }
        }
    }
}
