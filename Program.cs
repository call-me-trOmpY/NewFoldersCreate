internal class Program
{
    private static void Main(string[] args)
    {
        int month = 0;
        int year = 0;
        string basePath = @"C:\Users\JuanCarlosAlfonso\WoodsonBozeman\IT - Reports (Master Files)\HVAC Admin\Scorecards\Cards";

        //string folderName = Console.ReadLine();
        //string folderName = "TestFolder";

        //create a tm list
        List<TM> tms = new List<TM>();

        //string asd = "this";
        //TM tm = new TM("House Account", 1001);

        tms.Add(new TM("House Account", 1001));
        tms.Add(new TM("Brad Britt", 1007));
        tms.Add(new TM("Kevin Pitcock", 1008));
        tms.Add(new TM("Matt Alexader", 1033));
        tms.Add(new TM("Don Taylor", 2506));
        tms.Add(new TM("Clayton Powell", 2975));
        tms.Add(new TM("Division Summary", 9999));

        //getting month and year
        month = DateTime.Now.AddDays(-20).Month;
        year = DateTime.Now.AddDays(-20).Year;

        string folderName = $"{year}-{month}";
        //string folderName2 = year.ToString() + "-" + month.ToString();
        //string folderName3 = year + "-" + month;


        string fullPath = Path.Combine(basePath, folderName);


        //check if the folder exists
        if (Directory.Exists(fullPath))
        {
            Console.WriteLine($"Folder {folderName} exists");
            //Console.WriteLine(fullPath);
        }
        else
        {


            //Create the folder
            Directory.CreateDirectory(fullPath);
            Console.WriteLine($"Folder {fullPath} created");
        }

        foreach (TM tm in tms)
        {
            tm.CreateFolder(fullPath);
        }

        Console.WriteLine("Press any key to end");
        Console.ReadKey();

    }
}


//TM class
public class TM
{
    public string Name { get; set; }
    public int Id { get; set; }

    public TM(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public override string ToString()
    {
        return $"Name: {Name} Id: {Id}";
    }

    public bool CreateFolder(string folderName)
    {
        string subFolderName = Id + " " + Name;

        string newfolderPath = Path.Combine(folderName, subFolderName);

        if (Directory.Exists(newfolderPath))
        {
            Console.WriteLine($"Folder {subFolderName} exists");
        }
        else
        {
            //Console.WriteLine("Folder does not exist");
            //Create the folder
            Directory.CreateDirectory(newfolderPath);
            Console.WriteLine($"Folder {subFolderName} created");

        }

        return true;
    }


}








