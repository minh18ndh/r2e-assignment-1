namespace MyCarApp;

public class InputHandler {
    public string GetValidMake() {
        string make;

        while (true) {
            Console.Write("Enter Make: ");
            make = Console.ReadLine()?.Trim() ?? "";
            if (make != "")  break;
            Console.WriteLine("Invalid! Make must not be blank.");
        }

        return make;
    }

    public string GetValidModel() {
        string model;

        while (true) {
            Console.Write("Enter Model: ");
            model = Console.ReadLine()?.Trim() ?? "";
            if (model != "")  break;
            Console.WriteLine("Invalid! Model must not be blank.");
        }

        return model;
    }

    public int GetValidYear() {
        int year;

        while (true) {
            Console.Write("Enter Year: ");
            if (int.TryParse(Console.ReadLine(), out year) && year > 1900 && year < 2026)  break;
            Console.WriteLine("Invalid! Year must be bigger than 1900 and smaller than 2026.");
        }

        return year;
    }

    public CarType GetValidType() {
        CarType type;

        while (true) {
            Console.Write("Enter car type (Fuel/Electric): ");
            if (Enum.TryParse(Console.ReadLine()?.Trim(), true, out type)) {
                break;
            }
            Console.WriteLine("Invalid! Car type must be fuel or electric.");
        }

        return type;
    }
}