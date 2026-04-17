class Car:
    def __init__(self, brand, model, daily_rate):
        self.brand = brand
        self.model = model
        self.daily_rate = daily_rate

class Rental:
    def __init__(self, car, days):
        self.car = car
        self.days = days
    def calculate_total_cost(self):
        return self.days * self.car.daily_rate

def menu():
    print("\n--Wypożyczalnia samochodów--")
    brand = input("Podaj markę auta: ")
    model = input("Podaj model auta: ")
    rate = float(input("Podaj stawkę za dobę (PLN): "))
    selected_car = Car(brand, model, rate)
    while True:
        print(f"\nWybrano: {selected_car.brand} {selected_car.model}")
        print("1. Oblicz koszt wynajmu")
        print("2. Potwierdź rezerwację")
        print("3. Zmień auto")
        print("4. Zamknij program")
        choice = input("Wybierz opcję: ")
        if choice == "1":
            days = int(input("Na ile dni chcesz wynająć auto? "))
            temp_rental = Rental(selected_car, days)
            print(f"Przewidywany koszt: {temp_rental.calculate_total_cost()} PLN")
        elif choice == "2":
            days = int(input("Ile dni: "))
            final_rental = Rental(selected_car, days)
            print(f"Zarezerwowano! Do zapłaty: {final_rental.calculate_total_cost()} PLN")
            break
        elif choice == "3":
            menu() 
            break
        elif choice == "4":
            break
menu()