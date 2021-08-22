using System;

namespace DependancyInjectionProject.Data.Models
{
    public class Duck : Bird
    {
        public override string Sound() {
            return "Quack!";
        }
    }
}
