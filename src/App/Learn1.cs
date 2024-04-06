namespace App;

internal class Learn1
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

        var anyAli = names
            .Where(current => current == "Ali")
            .Any();

        Console.WriteLine(anyAli); // Output = True or False
    }
}
