using System;

/*Clasa ArticolInventar
 -in care regasim Greutatea , Volumul si Numele obiectului 
 -va fi folosita ulteriror pentru adaugarea obiectelor in rucsac 
 */
public class ArticolInventar
{
    public float Greutate { get; protected set; }
    public float Volum { get; protected set; }
    public string Nume { get; protected set; }

    public ArticolInventar(float greutate, float volum)
    {
        Greutate = greutate;
        Volum = volum;
    }

    public ArticolInventar(string nume , float greutate , float volum)
    {
        Nume = nume;
        Greutate = greutate;
        Volum = volum;

    }
}
/*
  #Clasele obiectelor noastre care vor fi adaugate in rucsac 
  - se defineste valoarea volumului si greutatii obiectelor
 */
public class Sageata : ArticolInventar
{
    public Sageata() : base(0.1f, 0.05f) { }
}

public class Arc : ArticolInventar
{
    public Arc() : base(1f , 4f) { }
}

public class Franghie : ArticolInventar
{
    public Franghie() : base(2f , 3f) { }
}

public class Portie_de_mancare : ArticolInventar
{
    public Portie_de_mancare() : base(1f , 0.5f) { }
}

public class Sabie : ArticolInventar
{
    public Sabie() : base(5f , 3f ) { }
}

public class Apa : ArticolInventar
{
    public Apa() : base(2f , 3f) { }
}

/*
   #Definim clasa ghiozdan in care avem:
   - volumul maxim , greutatea maxima si numarul maxim de articole care vor fi presetate 
 */
public class Ghiozdan
{
    private readonly int numarMaximArticole;
    private readonly double greutateMaxima;
    private readonly double volumMaxim;
    private ArticolInventar[] articole;
    private int numarArticole;

    //Constructor
    public Ghiozdan(int numarMaximArticole, double greutateMaxima, double volumMaxim)
    {
        this.numarMaximArticole = numarMaximArticole;
        this.greutateMaxima = greutateMaxima;
        this.volumMaxim = volumMaxim;
        articole = new ArticolInventar[numarMaximArticole];
        numarArticole = 0;
    }
    
    //clasa AdaugArticol care se va ocupa de adaugarea articolelor in rucsac 
    public bool AdaugaArticol(ArticolInventar articol)
    {
        //Verificam daca avem loc in rucsac sa mai adaugam articole
        if (numarArticole >= numarMaximArticole || articol.Greutate > greutateMaxima || articol.Volum > volumMaxim)
        {
            return false;
        }
        articole[numarArticole] = articol;
        numarArticole++; //Contorizam nr de articole
        return true;
    }

    public int NumarArticole()
    {
        return numarArticole; //Returnam nr maxim de articole
    }

    public double GreutateTotala()
    {
        double greutateTotala = 0;
        for (int i = 0; i < numarArticole; i++)
        {
            greutateTotala += articole[i].Greutate;
        }
        return greutateTotala;
    }

    public double VolumTotal()
    {
        double volumTotal = 0;
        for (int i = 0; i < numarArticole; i++)
        {
            volumTotal += articole[i].Volum;
        }
        return volumTotal;
    }
}

//Clasa program in care realizam initializarea unui nou rucsac 
class Program
{
    static void Main(string[] args)
    {
        Ghiozdan ghiozdan = new Ghiozdan(10, 20, 30); // se creează un ghiozdan cu limitările date
        bool iesire = false;
        
        while (!iesire)
        {   
            //Meniul nostru 
            Console.WriteLine("1. Adaugă articol");
            Console.WriteLine("2. Verifică greutatea totală");
            Console.WriteLine("3. Verifică volumul total");
            Console.WriteLine("4. Verifica numarul total de articole");
            Console.WriteLine("5. Iesire");
            Console.Write("Alege opțiunea: ");
            string optiune = Console.ReadLine();
            bool ok = false;
            switch (optiune)
            {   //Cazul in care obiectele se regasesc in lista predefinita (Sabie,Apa...etc)
                case "1":
                    Console.Write("Introdu numele articolului: ");
                    string nume_vechi = Console.ReadLine();
                    if (nume_vechi == "Sageata")
                    {
                        Sageata s = new Sageata();
                        float g = s.Greutate;
                        float v = s.Volum;
                        ArticolInventar a = new ArticolInventar(nume_vechi, g, v);
                        if (ghiozdan.AdaugaArticol(a))
                        {
                            Console.WriteLine("Articol adăugat cu succes la ghiozdan.");
                            ok = true;
                        }
                        else
                        {
                            Console.WriteLine("Articolul nu a putut fi adăugat la ghiozdan.");
                        }
                    } 
                    else if (nume_vechi == "Arc")
                    {
                        Arc s = new Arc();
                        float g = s.Greutate;
                        float v = s.Volum;
                        ArticolInventar a = new ArticolInventar(nume_vechi, g, v);
                        if (ghiozdan.AdaugaArticol(a))
                        {
                            Console.WriteLine("Articol adăugat cu succes la ghiozdan.");
                            ok = true;
                        }
                        else
                        {
                            Console.WriteLine("Articolul nu a putut fi adăugat la ghiozdan.");
                            ok = true;
                        }
                    } 
                    else if (nume_vechi == "Franghie")
                    {
                        Franghie s = new Franghie();
                        float g = s.Greutate;
                        float v = s.Volum;
                        ArticolInventar a = new ArticolInventar(nume_vechi, g, v);
                        if (ghiozdan.AdaugaArticol(a))
                        {
                            Console.WriteLine("Articol adăugat cu succes la ghiozdan.");
                            ok = true;
                        }
                        else
                        {
                            Console.WriteLine("Articolul nu a putut fi adăugat la ghiozdan.");
                        }
                    } 
                    else if (nume_vechi == "Apa")
                    {
                        Apa s = new Apa();
                        float g = s.Greutate;
                        float v = s.Volum;
                        ArticolInventar a = new ArticolInventar(nume_vechi, g, v);
                        if (ghiozdan.AdaugaArticol(a))
                        {
                            Console.WriteLine("Articol adăugat cu succes la ghiozdan.");
                            ok = true;
                        }
                        else
                        {
                            Console.WriteLine("Articolul nu a putut fi adăugat la ghiozdan.");
                        }
                    } 
                    else if (nume_vechi == "Portie de mancare")
                    {
                        Portie_de_mancare s = new Portie_de_mancare();
                        float g = s.Greutate;
                        float v = s.Volum;
                        ArticolInventar a = new ArticolInventar(nume_vechi, g, v);
                        if (ghiozdan.AdaugaArticol(a))
                        {
                            Console.WriteLine("Articol adăugat cu succes la ghiozdan.");
                            ok = true;
                        }
                        else
                        {
                            Console.WriteLine("Articolul nu a putut fi adăugat la ghiozdan.");
                        }
                    } 
                    else if (nume_vechi == "Sabie")
                    {
                        Sabie s = new Sabie();
                        float g = s.Greutate;
                        float v = s.Volum;
                        ArticolInventar a = new ArticolInventar(nume_vechi, g, v);
                        if (ghiozdan.AdaugaArticol(a))
                        {
                            Console.WriteLine("Articol adăugat cu succes la ghiozdan.");
                            ok = true;
                        }
                        else
                        {
                            Console.WriteLine("Articolul nu a putut fi adăugat la ghiozdan.");
                        }
                        
                    }
                    else break;
                    if (ok == false)
                    {
                        //Cazul in care adaugam un articol nou
                        Console.Write("Introdu greutatea articolului: ");
                        float greutate = float.Parse(Console.ReadLine());
                        Console.Write("Introdu volumul articolului: ");
                        float volum = float.Parse(Console.ReadLine());
                        ArticolInventar articol = new ArticolInventar(nume_vechi, greutate, volum);
                        if (ghiozdan.AdaugaArticol(articol))
                        {
                            Console.WriteLine("Articol adăugat cu succes la ghiozdan.");
                        }
                        else
                        {
                            Console.WriteLine("Articolul nu a putut fi adăugat la ghiozdan.");
                        }
                    }
                    break;
                case "2":
                    Console.WriteLine("Greutatea totală a ghiozdanului este: " + ghiozdan.GreutateTotala());
                    break;
                case "3":
                    Console.WriteLine("Volumul total al ghiozdanului este: " + ghiozdan.VolumTotal());
                    break;
                case "4":
                    Console.WriteLine("Numarul total de articole este: " + ghiozdan.NumarArticole());
                    break;
                case "5":
                    iesire = true;
                    break;
                default:
                    Console.WriteLine("Opțiune invalidă. Încearcă din nou.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
