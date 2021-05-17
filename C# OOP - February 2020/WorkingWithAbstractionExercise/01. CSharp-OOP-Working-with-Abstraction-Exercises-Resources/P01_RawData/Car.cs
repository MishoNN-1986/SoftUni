using System.Collections.Generic;

namespace P01_RawData
{
    public class Car
    {
        private readonly ICollection<Tire> tires;// всичко което е колекция(то е интерфейс)

        public Car(string model, Engine engine, Cargo cargo, ICollection<Tire> tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.tires = tires;
        }// всичко което е колекция

        public string Model { get; }
        public Engine Engine { get; }
        public Cargo Cargo { get; }

        public IReadOnlyCollection<Tire> Tires //кастваме
        {
            get
            {
                return (IReadOnlyCollection<Tire>)this.tires;
            }
        } //така изнасяме колекциите!
    }
}
