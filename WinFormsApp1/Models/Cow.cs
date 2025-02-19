using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WinFormsApp1.Models
{
    public class Cow : Animal
    {

        public Cow( ProgressBar? progressBar)
            : base(AnimalType.Cow, maxAge: 10, progressBar: progressBar)
        {
            //ProductionTime = 6;
        }
        public override string Produce()
        {
            if(Age >=MaxAge)
            {
                return string.Empty;
            }
            return "Milk";
        }
    }
}
