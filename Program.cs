internal class Program
{
    private static void Main(string[] args)
    {
        int month = 0;
        int year = 0;
        string basePath = @"C:\Users\JuanCarlosAlfonso\WoodsonBozeman\IT - Reports(Master Files)\HVAC Admin\Scorecards\Cards";

        //string folderName = Console.ReadLine();
        //string folderName = "TestFolder";

        month = DateTime.Now.Month;
        year = DateTime.Now.Year;

        string folderName = $"{year}-{month}";
        //string folderName2 = year.ToString() + "-" + month.ToString();
        //string folderName3 = year + "-" + month;


        string fullPath = Path.Combine(basePath, folderName);


        //check if the folder exists
        if (Directory.Exists(fullPath))
        {
            Console.WriteLine($"Folder {folderName} exists");
        }
        else
        {
            Console.WriteLine("Folder does not exist");

            //Create the folder
            Directory.CreateDirectory(fullPath);
        }


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



}








