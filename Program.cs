namespace codealong_291024;

class Program
{
    static void Main(string[] args)
    {
        // we create new objects of the Model, View and Controller classes
        Model model = new Model("Lars", 42);
        View view = new View();
        Controller controller = new Controller(model, view);

        // we use the controller to test our program aka to display initial model data
        controller.DisplayModel();

        // test controller's UpdateName and UpdateAge methods work
        controller.UpdateName();

        controller.UpdateAge();

        // call the display method again to check if our model was updated
        controller.DisplayModel();

        // use Console.ReadLine() to pause the program, allowing us to view output before closing
        Console.ReadLine();
        // check how Console.ReadLine() input is converted to int nd its type using Convert
        //string? testReadLine = Console.ReadLine();
        //int test = Convert.ToInt32(testReadLine);
        //Console.WriteLine(test.GetType());
    }
}
