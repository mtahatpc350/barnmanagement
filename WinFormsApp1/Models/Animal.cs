using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Animal
    {
        public AnimalType Type { get; set; }
        public int Age { get; set; }

        [Browsable(false)]
        public int MaxAge { get; set; }

        public bool IsAlive => Age < MaxAge;

        [DisplayName("Production Process")]
        public ProgressBar ProgressBar { get; set; }

        [Browsable(false)]
        public double ProductionTime { get; set; }

        public Animal(AnimalType type, int maxAge = 5, ProgressBar progressBar = null)
        {
            Type = type;
            Age = 0;
            MaxAge = maxAge;
            ProgressBar = progressBar;
            ProductionTime = 0;
        }
        public virtual string Produce()
        {
                return string.Empty;
        }

        public override string ToString()
        {
            return $"{Type} , Age: {Age}, Alive: {IsAlive}";
        }
    }
    public enum AnimalType
    {
        Chicken,
        Cow
    }

}
