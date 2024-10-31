// the place where you define how you want the information conveyed to the client
public class View
{
    public void Display(Model model)
    {
        Console.WriteLine(model.ToString());
    }

    public void DisplayMessage(string message)
    {
        Console.WriteLine($"{message}");
    }
}