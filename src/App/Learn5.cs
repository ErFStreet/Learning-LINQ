namespace App;

internal class Learn5
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
            "Hamid",
            "Hossein-1",
            "Hossein-2",
            "Hossein-3",
        };

        var result = names
            .Where(current => current.StartsWith('H'))
            .ToList();

        foreach (var item in result)
            Console.WriteLine(item);
    }
}
