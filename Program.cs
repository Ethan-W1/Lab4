using Lab4;

var root = FileRoot.fileRoot;
char dirSep = Path.DirectorySeparatorChar;
var file = root + dirSep + "data.csv";
var newFile = root + dirSep + "data.psv";

var people = new List<Person>();

using (var sr = new StreamReader(file))
{
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        var info = line.Split(",");

        var firstn = info[0];
        var lastn = info[1];
        var addressone = info[2];
        var City = info[3];
        var State = info[4];
        var PostalCode = info[5];

        Address a = new Address(addressone, City, State, PostalCode);

        people.Add(new Person(firstn, lastn, a));
    }

    Console.WriteLine("Sorting...");
    people.Sort();

    Console.WriteLine("Creating PSV File");
    using (var sw = new StreamWriter(newFile, append: false))
    {
        foreach (Person person in people)
        {
            string line = person.ToString();
            sw.WriteLine(line);
        }
    }
}