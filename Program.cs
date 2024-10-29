namespace codealong_291024;

class Program
{
    static void Main(string[] args)
    {
        // we initialize new instances of our MVC classes
        Model model = new Model("Lars", 42);
        View view = new View();
        Controller controller = new Controller(model, view);

        // we use the controller, to test our program
        controller.DisplayModel();

        // we can check whether or not our controller methods work
        controller.UpdateName();

        controller.UpdateAge();

        // call the display method again to check if our model was updated
        controller.DisplayModel();

        // use the ReadLine to stall the program and keep it running
        Console.ReadLine();
        // checking how ReadLine and & Convert actually works
        //string? testReadLine = Console.ReadLine();
        //int test = Convert.ToInt32(testReadLine);
        //Console.WriteLine(test.GetType());
    }
}
