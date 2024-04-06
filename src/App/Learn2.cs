namespace App;

internal class Learn2
{
    static void Main(string[] args)
    {
        var names = new List<string>
        {
            "Ali",
            "Reza",
            "Mohammad",
            "Erfan",
            "Morteza",
            "Fariborz",
            "Amir",
            "Mahdi",
            "Hossein",
        };

        var name = names
            .Where(current => current == "Ali")
            .FirstOrDefault();

        Console.WriteLine(name); // Output = if there is => ali 
                                 // Output = if there is not => null or none
    }
}
