


using FactoryPatternExercise;

Console.WriteLine("Tell me how many tires your vheicle will have and I will build a vheicle based off the number of tires");

int tires =int.Parse(Console.ReadLine());

Ivehicle vehicle= VehicleFactory.GetIvehicle(tires);

vehicle.Drive();