using System.Threading.Channels;
using Calculator_OOP_xUnitTest._2DShapes;
using Calculator_OOP_xUnitTest._3DShapes;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("-----------------------------");
Console.WriteLine("WELCOME TO OBJECT CALCULATOR");
Console.WriteLine("-----------------------------");
Console.ResetColor();

bool nextCalculation = true;
do
{
    Console.WriteLine("\nWhat object you want to calculate?");
    Console.WriteLine("1 - Square");
    Console.WriteLine("2 - Cube");
    Console.WriteLine("3 - Rectangular");
    Console.WriteLine("4 - Block");
    Console.WriteLine("5 - Circle");
    Console.WriteLine("6 - Sphere");
    Console.WriteLine("0 - EXIT THE PROGRAM");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("YOUR SELECTION (number): ");
    Console.ResetColor();
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSQUARE");
            Console.ResetColor();
            Console.WriteLine("Insert sides");
            Console.Write("SIDE A: ");
            string squareSideAstr = Console.ReadLine().Trim();
            if (Double.TryParse(squareSideAstr, out double squareSideA))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(Initialization.SquareInitialization(squareSideA));
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input");
                Console.ResetColor();
            }
            break;

        case "2":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCUBE");
            Console.ResetColor();
            Console.WriteLine("Insert sides");
            Console.Write("SIDE A: ");
            string cubeSideAstr = Console.ReadLine().Trim();
            if (Double.TryParse(cubeSideAstr, out double cubeSideA))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(Initialization.CubeInitialization(cubeSideA));
                Console.ResetColor();
            }
            else
                Console.WriteLine("Invalid input");
            break;

        case "3":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nRECTANGULAR");
            Console.ResetColor();
            Console.WriteLine("Insert sides");
            Console.Write("SIDE A: ");
            string rectangularSideAstr = Console.ReadLine().Trim();
            Console.Write("SIDE B: ");
            string rectangularSideBstr = Console.ReadLine().Trim();
            if (Double.TryParse(rectangularSideAstr, out double rectangularSideA) &&
                Double.TryParse(rectangularSideBstr, out double rectangularSideB))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(Initialization.RectangularInitialization(rectangularSideA, rectangularSideB));
                Console.ResetColor();
            }
            else
                Console.WriteLine("Wrong input");
            break;

        case "4":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nBLOCK");
            Console.ResetColor();
            Console.WriteLine("Insert sides");
            Console.Write("SIDE A: ");
            string blockSideAstr = Console.ReadLine().Trim();
            Console.Write("SIDE B: ");
            string blockSideBstr = Console.ReadLine().Trim();
            Console.Write("SIDE C: ");
            string blockSideCstr = Console.ReadLine().Trim();
            if (Double.TryParse(blockSideAstr, out double blockSideA) &&
                Double.TryParse(blockSideBstr, out double blockSideB) &&
                Double.TryParse(blockSideCstr, out double blockSideC))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(Initialization.BlockInitialization(blockSideA, blockSideB, blockSideC));
                Console.ResetColor();
            }
            else
                Console.WriteLine("Worng input");
            break;

        case "5":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCIRCLE");
            Console.ResetColor();
            Console.WriteLine("Insert radius");
            Console.Write("RADIUS: ");
            string circleRadiusStr = Console.ReadLine().Trim();
            if (double.TryParse(circleRadiusStr, out double circleRadius))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(Initialization.CircleInitialization(circleRadius));
                Console.ResetColor();
            }
            else
                Console.WriteLine("Wrong input");
            break;

        case "6":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSPHERE");
            Console.ResetColor();
            Console.WriteLine("Insert radius");
            Console.Write("RADIUS: ");
            string sphereRadiusStr = Console.ReadLine().Trim();
            if (double.TryParse(sphereRadiusStr, out double sphereRadius))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(Initialization.SphereInitialization(sphereRadius));
                Console.ResetColor();
            }
            else 
                Console.WriteLine("Wrong Input");
            break;

        case "0":
            Console.WriteLine("Exiting the application...");
            nextCalculation = false;
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "Invalid selection. Please enter a number that corresponds to the object you want to calculate.");
            Console.ResetColor();
            break;
    }

} while (nextCalculation);

public static class Initialization
{
    public static string SquareInitialization(double sideA)
    {
        Square square = new Square();
        return $"Area: {square.AreaCalculate(sideA)}\n" +
               $"Circumference: {square.CircumferenceCalculate(sideA)}";
    }

    public static string CubeInitialization(double sideA)
    {
        Cube cube = new Cube();
        return $"Surface Area: {cube.SurfaceAreaCalculate(sideA)}\n" +
               $"Volume: {cube.VolumeCalculate(sideA)}";
    }

    public static string RectangularInitialization(double sideA, double sideB)
    {
        Rectangular rec = new Rectangular();
        return $"Area: {rec.AreaCalculate(sideA, sideB)}\n" +
               $"Circumference: {rec.CircumferenceCalculate(sideA, sideB)}";
    }

    public static string BlockInitialization(double sideA, double sideB, double sideC)
    {
        Block block = new Block();
        return $"Surface Area: {block.SurfaceAreaCalculate(sideA, sideB, sideC)}\n" +
               $"Volume: {block.VolumeCalculate(sideA, sideB, sideC)}";
    }

    public static string CircleInitialization(double radius)
    {
        Circle circle = new Circle();
        return $"Area: {circle.AreaCalculate(radius)}\n" +
               $"Circumference: {circle.CircumferenceCalculate(radius)}";
    }

    public static string SphereInitialization(double radius)
    {
        Sphere sphere = new Sphere();
        return $"Surface Area: {sphere.SurfaceAreaCalculate(radius)}\n" +
               $"Volume: {sphere.VolumeCalculate(radius)}";
    }
}






