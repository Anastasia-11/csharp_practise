using System;

namespace _11.Task1.Models
{
    internal class Motorcycle
    {
        public class Engine
        {
            private double _volume;
            private double _power;

            public double Volume
            {
                get => _volume;
                set
                {
                    if(value >= 125 && value <= 3200)
                        _volume = value;
                    else
                        Console.WriteLine("Volume value is incorrect");
                }
            }

            public double Power
            {
                get => _power;
                set
                {
                    if(value >= 50 && value <= 300)
                        _power = value;
                    else 
                        Console.WriteLine("Power value is incorrect");
                }
            }

            public Engine(double volume, double power)
            {
                _volume = volume;
                _power = power;
            }
        }
        
        private Guid _guid;
        private string _model;
        private string _manufacturer;
        private int _releaseYear;
        private double _mileage;
        private Engine _engine;

        public Engine MotoEngine
        {
            get => _engine;
            set => _engine = value;
        }

        public Guid Guid => _guid;

        public string Model
        {
            get => _model;
            set
            {
                if (value.Equals(string.Empty))
                {
                    Console.WriteLine("Model value is incorrect or empty");
                }
                else
                {
                    _model = value;
                }
            }
        }

        public string Manufacturer
        {
            get => _manufacturer;
            set
            {
                if (value.Equals(string.Empty))
                {
                    Console.WriteLine("Manufacturer value is incorrect or empty");
                }
                else
                {
                    _manufacturer = value;
                }
            }
        }

        public int ReleaseYear
        {
            get => _releaseYear;
        }

        public double Mileage
        {
            get => _mileage;
            set => _mileage = value;
        }

        public Motorcycle(string model, string manufacturer, double mileage, Engine engine)
        {
            _guid = Guid.NewGuid();
            _model = model;
            _manufacturer = manufacturer;
            _releaseYear = DateTime.Today.Year;
            _mileage = mileage;
            _engine = engine;
        }

        private void ResetFactorySettings()
        {
            Console.WriteLine("Factory settings have been reseted");
        }
    }
}