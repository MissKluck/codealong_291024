// the controller connects the data from the model with the disply logic in view
public class Controller
{
    // store references to Model and View objects as controllerModel and controllerView
    Model controllerModel;
    View controllerView;
    // created the constructor that takes Model and View instances as parameters
    public Controller(Model model, View view)
    {
        controllerModel = model;
        controllerView = view;
    }

    // methods
    // prompts the user for a new name and updates controllerModel.Name if input is valid
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
        // we parse the user input as an integer for new age and assigns it to controllerModel.Age if valid. 
        Console.WriteLine("Write a new age:");
        if (int.TryParse(Console.ReadLine(), out int newAge))
        {
            controllerModel.Age = newAge;
        }
    }

    // displays the current model data using controllerView.
    public void DisplayModel()
    {
        controllerView.Display(controllerModel);

    }
}