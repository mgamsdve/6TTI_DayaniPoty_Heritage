namespace _6TTI_DayaniPoty_Heritage;

class Program
{
    static void Main(string[] args)
    {
        Velo[] velos = new Velo[3];
        velos[0] = new Velo("VTT", false, "Rockrider", "Decathlon", "Noir", 500m);
        velos[1] = new Velo("Route", true, "Specialized", "Specialized", "Rouge", 1200m);
        velos[2] = new Velo("Ville", false , "Brompton", "Brompton", "Gris", 1500m);
        
        Console.WriteLine("Affichage des vélos :");
        foreach (Velo vlo in velos)
        {
            Console.WriteLine(vlo.Affiche());
        }  
        
        Voiture voiture = new Voiture("Essence", true, "Model S", "Tesla", "Rouge", 80000m);
        Console.WriteLine(voiture.Affiche());

        Velo velo = new Velo("VTT", false, "Rockrider", "Decathlon", "Noir", 500m);
        Console.WriteLine(velo.Affiche());
        
        Vehicule vehicule = new Velo("Route", true, "Autre", "autre", "Rouge", 1200m);
        Console.WriteLine(vehicule.Affiche());
    }
}