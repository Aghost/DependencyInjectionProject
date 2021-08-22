using System;

namespace DependancyInjectionProject.Data.Models
{
    public class Goose : Bird
    {
        public override string Sound() {
            return "Honk!";
        }
    }
}
