namespace App;

internal class Learn6
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
            "1-Hossein",
            "2-Hossein",
            "3-Hossein",
        };

        var result = names
            .Where(current => current.EndsWith('n'))
            .ToList();

        foreach (var item in result)
            Console.WriteLine(item);
    }
}
