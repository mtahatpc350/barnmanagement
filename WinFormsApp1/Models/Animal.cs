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
        public AnimalGender Gender { get; set; }
        public int Age { get; set; }
        [Browsable(false)]
        public int MaxAge { get; set; }
        public bool IsAlive => Age < MaxAge;
        public ProgressBar ProgressBar { get; set; }

        public Animal(AnimalType type, AnimalGender gender, int maxAge = 5, ProgressBar progressBar = null)
        {
            Type = type;
            Gender = gender;
            Age = 0;
            MaxAge = maxAge;
            ProgressBar = progressBar;
        }
        public virtual string Produce() => string.Empty;

        public override string ToString()
        {
            return $"{Type} ({Gender}), Age: {Age}, Alive: {IsAlive}";
        }
    }
    public enum AnimalType
    {
        Chicken,
        Cow
    }
    public enum AnimalGender
    {
        Male,
        Female
    }
}
