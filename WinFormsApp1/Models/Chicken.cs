using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WinFormsApp1.Models
{
    public class Chicken : Animal
    {

        public Chicken(ProgressBar? progressBar)
            : base(AnimalType.Chicken, maxAge: 5, progressBar: progressBar)
        {
            //ProductionTime = 3.5;
        }

        public override string Produce()
        {
            if (Age >= MaxAge)
            {
                return string.Empty;
            }
            return "Egg";
        }

    }
}
