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
            : base(AnimalType.Cow, maxAge: 7, progressBar: progressBar)
        {
            ProductionTime = 0;
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
