using System.Linq.Expressions;

string[] zodziai = new string[] { "namas", "sasiuvinis", "parkeris","telefonas","monitorius"  };

Random random = new Random();
string word = spejimas(zodziai.Length);
Console.WriteLine(word.Length + " raidziu zodis");
List<char> Graides = new List<char>();
List<char> Braides = new List<char>();
List<char> check = new List<char>();

char raide;

string laik = vaizdavimas(word);
char[] vaizd = laik.ToCharArray();
int band = 5;

try
{
    while (true)
    {

        piesimas(band);
        Console.WriteLine(vaizd);

        Console.WriteLine("Iveskite raide");
        raide = Convert.ToChar(Console.ReadLine());

        if (word.Contains(raide))
        {


            //char[] ch = vaizd.ToCharArray();
            Console.Write("tinka");
            Graides.Add(raide);
            for (int i = 0; i < vaizd.Length; i++)
            {
                if (word[i].Equals(raide))
                {
                    vaizd[i] = raide;
                    check.Add(raide);
                }

            }



        }
        else
        {
            Console.Write("Netinka");
            Braides.Add(raide);
            band--;
        }


        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Teisingos: ");
        for (int i = 0; i < Graides.Count; i++)
        {
            Console.Write(Graides[i] + " ");
        }
        Console.WriteLine();
        Console.Write("Neteisingos: ");
        for (int i = 0; i < Braides.Count; i++)
        {
            Console.Write(Braides[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Liko bandymu" + band);
        Console.WriteLine("---------------------------");
        if (baigtas(check, band) == true)
        {
            break;
        }



    }
}

catch(Exception) { }
{
    Console.WriteLine("Programa baigta");
    Console.WriteLine("||----------");
    Console.WriteLine("||         |");
    Console.WriteLine("||         ()");
    Console.WriteLine("||         /|\\");
    Console.WriteLine("||         /\\");
}

string spejimas(int ilgis)
{
    string zod = "";
    int rand = random.Next(0, ilgis);
    for (int i = 0; i < ilgis; i++)
    {
        if (i == rand)
        {
            zod = zodziai[i];
            break;
        }
    }

    return zod;
}


string vaizdavimas(string word)
{
    string zo = "";
    for(int i=0;i<word.Length;i++)
    {
        zo += "_";
    }
    return zo;
}

bool baigtas(List<char> sarasas, int band)
{
    bool laik= false;
    string tuscias = "";
    
    if(band == 0)
    {
        laik = true;
    }
    else if (sarasas.Count == word.Length)
    {
        laik = true;
    }
    return laik;


}

void piesimas(int bandymai)
{
    switch(bandymai)
    {
        case 5:
            Console.WriteLine("||----------");
            Console.WriteLine("||         |");
            Console.WriteLine("||         ()");
            Console.WriteLine("||         ");
            Console.WriteLine("||         ");
            break;
        case 4:
            Console.WriteLine("||----------");
            Console.WriteLine("||         |");
            Console.WriteLine("||         ()");
            Console.WriteLine("||         /|");
            Console.WriteLine("||         ");
            break;
        case 3:
            Console.WriteLine("||----------");
            Console.WriteLine("||         |");
            Console.WriteLine("||         ()");
            Console.WriteLine("||         /|\\");
            Console.WriteLine("||");
            break;
        case 2:
            Console.WriteLine("||----------");
            Console.WriteLine("||         |");
            Console.WriteLine("||         ()");
            Console.WriteLine("||         /|\\");
            Console.WriteLine("||         ");
            break;
        case 1:
            Console.WriteLine("||----------");
            Console.WriteLine("||         |");
            Console.WriteLine("||         ()");
            Console.WriteLine("||         /|\\");
            Console.WriteLine("||         /");
            break;
        case 0:
            Console.WriteLine("||----------");
            Console.WriteLine("||         |");
            Console.WriteLine("||         ()");
            Console.WriteLine("||         /|\\");
            Console.WriteLine("||         /\\");

            break;
        default:
            Console.WriteLine("||----------");
            Console.WriteLine("||         |");
            Console.WriteLine("||");
            Console.WriteLine("||");
            Console.WriteLine("||");

            break;
    }

}













