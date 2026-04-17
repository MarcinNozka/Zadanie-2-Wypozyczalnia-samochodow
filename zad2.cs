using System;
    class Car
    {
        public string Brand;
        public string Model;
        public double DailyRate;

        public Car(string brand, string model, double dailyRate)
        {
            Brand = brand;
            Model = model;
            DailyRate = dailyRate;
        }
    }

    class Rental
    {
        public Car SelectedCar;
        public int Days;
        public Rental(Car car, int days)
        {
            SelectedCar = car;
            Days = days;
        }
        public double CalculateTotalCost()
        {
            return Days * SelectedCar.DailyRate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("\n--Wypożyczalnia samochodów--");
            Console.Write("Podaj markę auta: ");
            string brand = Console.ReadLine();
            Console.Write("Podaj model auta: ");
            string model = Console.ReadLine();
            Console.Write("Podaj stawkę za dobę (PLN): ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Car selectedCar = new Car(brand, model, rate);

            while (true)
            {
                Console.WriteLine($"\nWybrano: {selectedCar.Brand} {selectedCar.Model}");
                Console.WriteLine("1. Oblicz koszt wynajmu");
                Console.WriteLine("2. Potwierdź rezerwację");
                Console.WriteLine("3. Zmień auto");
                Console.WriteLine("4. Zamknij program");
                Console.Write("Wybierz opcję: ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.Write("Na ile dni chcesz wynająć auto? ");
                    int days = int.Parse(Console.ReadLine());
                    Rental tempRental = new Rental(selectedCar, days);
                    Console.WriteLine($"Przewidywany koszt: {tempRental.CalculateTotalCost()} PLN");
                }
                else if (choice == "2")
                {
                    Console.Write("Ile dni: ");
                    int days = int.Parse(Console.ReadLine());
                    Rental finalRental = new Rental(selectedCar, days);
                    Console.WriteLine($"Zarezerwowano! Do zapłaty: {finalRental.CalculateTotalCost()} PLN");
                    break; 
                }
                else if (choice == "3")
                {
                    Menu(); 
                    break;
                }
                else if (choice == "4")
                {
                    break;
                }
            }
        }
    }