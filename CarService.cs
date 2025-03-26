namespace MyCarApp;

public class CarService {
    private readonly InputHandler inputHandler = new();
    private readonly List<Car> cars = new();

    public void AddCar() {
        string make = inputHandler.GetValidMake();
        string model = inputHandler.GetValidModel();
        int year = inputHandler.GetValidYear();
        CarType type = inputHandler.GetValidType();

        cars.Add(new Car { Make = make, Model = model, Year = year, Type = type });
        Console.WriteLine("---------------------------");
        Console.WriteLine("| Car added successfully! |");
        Console.WriteLine("---------------------------");
    }

    public void ViewAllCar() {
        if (cars.Count > 0) {
            foreach (Car car in cars) {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year} ({car.Type})");
            }
        }

        else  Console.WriteLine("\nNo car found.");
    }

    public void SearchByMake() {
        string make = inputHandler.GetValidMake();

        var results = cars
            .Where(car => car.Make.Equals(make, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (results.Count > 0) {
            foreach (Car car in results) {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year} ({car.Type})");
            }
        }

        else  Console.WriteLine("\nNo car found.");
    }

    public void FilterByType() {
        CarType type = inputHandler.GetValidType();

        var results = cars.Where(car => car.Type == type).ToList();

        if (results.Count > 0) {
            foreach (Car car in results) {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year} ({car.Type})");
            }
        }

        else  Console.WriteLine("\nNo car found.");
    }

    public void RemoveByModel() {
        string model = inputHandler.GetValidModel();

        int removedNum = cars.RemoveAll(car => car.Model.Equals(model, StringComparison.OrdinalIgnoreCase));

        if (removedNum > 0) {
            Console.WriteLine("\nCar(s) removed successfully.");
        }

        else {
            Console.WriteLine("\nNo car found.");
        }
    }
}