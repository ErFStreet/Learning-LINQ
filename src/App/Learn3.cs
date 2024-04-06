namespace App;

internal class Learn3
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
            .FirstOrDefault(); // null or Ali

        if(name is not null)
            names.Remove(name); // remove name(Ali) of names
    }
}
