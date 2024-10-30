public class Controller
{
    // inherit the Model and View classes and create the objects _model and _view
    Model controllerModel;
    View controllerView;
    // created the constructor with the Model & View as parameters
    public Controller(Model model, View view)
    {
        controllerModel = model;
        controllerView = view;
    }

    // methods
    public void UpdateName()
    {
        Console.WriteLine("Write a new name:");
        string? newName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(newName))
        {
            Console.WriteLine("Name cannot be empty!\n");
        }
        else
        {
            controllerModel.Name = newName;
        }
    }
    public void UpdateAge()
    {
        // we parse the user input from ReadLine() as an integer, but taking a string input argument, and "getting" new integer output newAge
        Console.WriteLine("Write a new age:");
        if (int.TryParse(Console.ReadLine(), out int newAge))
        {
            controllerModel.Age = newAge;
        }
    }

    public void DisplayModel()
    {
        controllerView.Display(controllerModel);

    }
}