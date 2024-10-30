public class Model
{
    // two fields with getters and setters
    public string? Name { get; set; }
    public int Age { get; set; }

    // constructor, that takes two parameters string name & int age
    public Model(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // we override the ToString() method to utilize it in the view class
    public override string ToString()
    {
        return $"Name: {Name} Age: {Age}";
    }
    // TODO: verify that this actually does what we want it to when view is implemented
}