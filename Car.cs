namespace MyCarApp;

public enum CarType { Fuel, Electric };

public class Car {
    public required string Make { get; set; }
    public required string Model { get; set; }
    public required int Year { get; set; }
    public required CarType Type { get; set; }

}