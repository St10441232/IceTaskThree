namespace IceTaskThree
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Loop until user chooses to exit
            {
                Console.WriteLine("\nChoose a shape to calculate the area:");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Circle");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Get user input for Rectangle
                    Console.Write("Enter length: ");
                    double length = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter width: ");
                    double width = Convert.ToDouble(Console.ReadLine());

                    // Create and display rectangle
                    Rectangle rect = new Rectangle(length, width);
                    rect.Display();
                }
                else if (choice == "2")
                {
                    // Get user input for Circle
                    Console.Write("Enter radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());

                    // Create and display circle
                    Circle circ = new Circle(radius);
                    circ.Display();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                }
            }
        }
    }
}