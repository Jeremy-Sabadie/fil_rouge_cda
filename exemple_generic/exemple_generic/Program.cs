MaListeGenerique<int> maListe = new MaListeGenerique<int>();
2maListe.Ajouter(25);
3maListe.Ajouter(30);
4maListe.Ajouter(5);
5
6Console.WriteLine(maListe.ObtenirElement(0));
7Console.WriteLine(maListe.ObtenirElement(1));
8Console.WriteLine(maListe.ObtenirElement(2));
9
10for(int i = 0; i < 30; i++)
11{
    12    maListe.Ajouter(i);
    13}
