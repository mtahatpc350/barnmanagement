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

        public Chicken(AnimalGender gender, ProgressBar? progressBar)
            : base(AnimalType.Chicken, gender, maxAge: 5, progressBar: progressBar)
        {
            
        }

        public override string Produce()
        {
            return "Egg";
        }

    }
}
