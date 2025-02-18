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

        public Cow(AnimalGender gender, ProgressBar? progressBar)
            : base(AnimalType.Cow, gender, maxAge: 10, progressBar: progressBar)
        {

        }
        public override string Produce()
        {
            return "Milk";
        }
    }
}
