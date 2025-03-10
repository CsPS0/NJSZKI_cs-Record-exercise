#region 1.fel
using taborok;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("1. feladat");
Console.ResetColor();

List<Tabor> taborok = new();
string[] file = File.ReadAllLines("taborok.txt");

foreach (string line in file)
{
    string[] datas = line.Split('\t');
    taborok.Add(new Tabor(int.Parse(datas[0]), int.Parse(datas[1]), int.Parse(datas[2]), int.Parse(datas[2]), datas[3], datas[4]));
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("A fájl beolvasása sikeres!");
Console.ResetColor();
#endregion

#region 2.fel
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("2. feladat");
Console.ResetColor();

Console.WriteLine($"Összesen {taborok.Count} db adatot tárol a bemeneti fájl, \n illetve az első felvett tábor témája: {taborok[0].CampType} \n és az utolsó felvett tábor témája: {taborok[taborok.Count-1].CampType}");
#endregion

#region 3.fel
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("3. feladat");
Console.ResetColor();

int musicstart = 0;
for (int i = 0; i < taborok.Count; i++)
{
    if (taborok[i].CampType == "zenei")
    {
        Console.WriteLine($"A zenei tábor kezdődik {taborok[i].StartingMonth}. hó, {taborok[i].StartingDay}. napján kezdődik");
    }
    musicstart++;
}
if (musicstart == 0)
{
    Console.WriteLine("Nem volt zenei tábor.");
}
#endregion

#region 4.fel
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("4. feladat");
Console.ResetColor();

int ApplicationsCount = 0;
int MaxCampSize = 0;
int MaxCamp = 0;
string CampNetSite = " ";

for (int i = 0;i < taborok.Count;i++)
{

}
#endregion

#region 5.fel
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("5. feladat");
Console.ResetColor();

#endregion

#region 6.fel
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("6. feladat");
Console.ResetColor();

#endregion

#region 7.fel
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("7. feladat");
Console.ResetColor();

#endregion