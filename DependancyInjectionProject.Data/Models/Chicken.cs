using System;

namespace DependancyInjectionProject.Data.Models
{
    public class Chicken : Bird
    {
        public override string Sound() {
            return "Cluck!";
        }
    }
}
