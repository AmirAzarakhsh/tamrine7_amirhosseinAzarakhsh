List<student> students = new List<student>();
var filename = @"C:\Users\LOQ\Downloads\Telegram Desktop\100 stu name and score.txt";
StreamReader sr = new StreamReader(filename);
Console.WriteLine("kodam yek namayesh dade shavad?");
Console.WriteLine("1_namayesh_moadelkol");
Console.WriteLine("2_grade bandi");
Console.WriteLine("3_moadel_drus");
Console.WriteLine("4_moadel_drus1setare");
Console.WriteLine("5_moadel_drus2stare");
Console.WriteLine("6_adadaval");
Console.WriteLine("7_har4moadel");
Console.WriteLine("8_exit");
while (!sr.EndOfStream)
{
    string line = sr.ReadLine();
    student student = new student();

    student.FName = line.Split(',')[0];
    student.riazi = Convert.ToDouble(line.Split(',')[1]);
    student.pish1 = Convert.ToDouble(line.Split(',')[2]);
    student.pish2 = Convert.ToDouble(line.Split(',')[3]);
    student.tafsir = Convert.ToDouble(line.Split(',')[4]);
    student.kargah = Convert.ToDouble(line.Split(',')[5]);
    student.zaban = Convert.ToDouble(line.Split(',')[6]);
    student.sheygraee = Convert.ToDouble(line.Split(',')[7]);
    student.sistem = Convert.ToDouble(line.Split(',')[8]);
    student.algoritm = Convert.ToDouble(line.Split(',')[9]);
    student.tarbiat = Convert.ToDouble(line.Split(',')[10]);


    students.Add(student);

}
bool exit = false;
do
{
    int x = Convert.ToInt32(Console.ReadLine());

    if (x == 1)
    {
        foreach (var student in students)
        {
            Console.WriteLine(student.FName + ":" + (Math.Round(student.Averagekol(), 2)));
        }
    }
    else if (x == 2)
    {
        foreach (var student in students)
        {
            Console.WriteLine(student.FName + ":" + (student.garde((Math.Round(student.Averagekol(), 2)))));
        }
    }
    else if (x == 3)
    {
        foreach (var student in students)
        { Console.WriteLine(student.FName + ":" + (Math.Round(student.drus(), 2))); }
    }
    else if (x == 4)
    {
        foreach (var student in students)
        {
            Console.WriteLine(student.FName + ":" + Math.Round(student.drus1stare(), 2));
        }
    }
    else if (x == 5)
    {
        foreach (var student in students)
        {
            Console.WriteLine(student.FName + ":" + Math.Round(student.drus2stare(), 2));
        }
    }
    else if (x == 7)
    {
        foreach (var student in students)
        {
            Console.WriteLine(student.FName + ":" + "moadekol" + (Math.Round(student.Averagekol(), 2)) + "//////"
                + "moadel drus0setare" + ":" + (Math.Round(student.drus(), 2)) + "///////"
                + "moadel druse1setare" + ":" + Math.Round(student.drus1stare(), 2) + "//////"
                + "moadel  drus 2 stare" + ":" + Math.Round(student.drus2stare(), 2));
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
        }
    }
    else if (x == 6)
    {
        foreach (var zu in students)
        {
            zu.adadaval(Convert.ToInt32(zu.pish1));
            zu.adadaval(Convert.ToInt32(zu.pish2));
            zu.adadaval(Convert.ToInt32(zu.riazi));
            zu.adadaval(Convert.ToInt32(zu.zaban));
            zu.adadaval(Convert.ToInt32(zu.tarbiat));
            zu.adadaval(Convert.ToInt32(zu.algoritm));
            zu.adadaval(Convert.ToInt32(zu.kargah));
            zu.adadaval(Convert.ToInt32(zu.sheygraee));
            zu.adadaval(Convert.ToInt32(zu.sistem));
            zu.adadaval(Convert.ToInt32(zu.sistem));

        }
    }
    else if (x == 8)
    {
        exit = true;
    }
}
while (!exit);
class student
{
    public string FName { get; set; }
    public double riazi { get; set; }
    public double pish1 { get; set; }
    public double tafsir { get; set; }
    public double kargah { get; set; }
    public double zaban { get; set; }
    public double pish2 { get; set; }
    public double sheygraee { get; set; }
    public double tarbiat { get; set; }
    public double sistem { get; set; }
    public double algoritm { get; set; }


    public double Averagekol()
    {
        return ((riazi * 2) + (pish1 * 3) + tafsir + kargah + (zaban * 2) + (pish2 * 3) + (sheygraee * 3) + tarbiat + (sistem * 3) + (algoritm * 3)) / 21;
    }
    public double drus()
    {
        return (tafsir + (riazi * 2) + kargah + (zaban * 2) + tarbiat) / 6;
    }

    public static string garde(double z)

    {
        switch (z)

        {
            case double n when (n <= 20 && n > 17):
                return "A";
            case double n when (n <= 17 && n > 15):
                return "B";
            case double n when (n <= 15 && n > 13):
                return "C";
            case double n when (n <= 13 && n > 10):
                return "D";
            case double n when (n <= 10 && n > 7):
                return "E";
            case double n when (n <= 7 && n > 3):
                return "F";
            case double n when (n <= 3 && n >= 0):
                return "H";
        }
        return "";
    }
    public double drus1stare()
    {
        return ((sistem * 3) + (algoritm * 3)) / 6;
    }
    public double drus2stare()
    {
        return ((pish1 * 3) + (pish2 * 3) + (sheygraee * 3)) / 9;
    }
    public void adadaval(int adad)
    {
        int sum = 0;
        for (int i = 1; i < adad; i++)
        {
            if (adad % i == 0)
            {
                sum++;
            }
        }
        if (sum < 2 && adad > 1)
            Console.WriteLine(adad);
    }
}

