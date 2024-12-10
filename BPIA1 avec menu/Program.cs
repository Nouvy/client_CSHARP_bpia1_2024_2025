using System.Text.Json;
using BPIA1_avec_menu;
using static System.Collections.Specialized.BitVector32;

int choix = 0;
bool reponse = true;
int min4 = 0;
int compteur = 1;

Console.WriteLine("===== MENU =====");
Console.WriteLine("1 - Nombre entre 1 et 10");
Console.WriteLine("2 - Calculs monnaie client");
Console.WriteLine("3 - Ecole Méthode Array Fixe");
Console.WriteLine("4 - Ecole Méthode Array Dynamique");
Console.WriteLine("5 - Ecole Méthode Objet");
Console.WriteLine("6 - Login");
Console.WriteLine("0 - Quitter");
choix = Convert.ToInt32(Console.ReadLine());
switch (choix)
{
    case 1:

        int a = 0;
        while (a < 1 || a > 10)
        {
            Console.WriteLine("Merci de saisir un nombre entre 1 et 10");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 1 || a > 10)
            {
                Console.WriteLine("Erreur");
            }
            else
            {
                Console.WriteLine("Succès");
            }
        }
        break;

    case 2:
        int total = 0;
        int prix = 0;
        int paie = 0;
        int reste = 0;
        int euro5 = 0;
        int euro10 = 0;
        int rendu = 0;


        do
        {
            Console.WriteLine("Saisir un nombre");
            prix = Convert.ToInt32(Console.ReadLine());
            total = total + prix;
        } while (prix != 0);

        Console.WriteLine("Le total de vos articles est de " + total.ToString() + "€");


        do
        {
            Console.WriteLine("Combien voulez-vous payer ?");
            paie = Convert.ToInt32(Console.ReadLine());
        } while (paie <= total);

        reste = paie - total;
        rendu = paie - total;

        while (reste >= 10)
        {
            euro10++;
            reste = reste - 10;
        }

        if (reste >= 5)
        {
            euro5 = 1;
            reste = reste - 5;
        }

        Console.WriteLine("Le total de votre commande est de " + total + "€");
        Console.WriteLine("Le paiement que vous avez effectué est de " + paie + "€");
        Console.WriteLine("Le magasin doit vous rendre " + rendu + "€");
        Console.WriteLine("Voici votre monnaie : " + euro10 + " Billets de 10€, " + euro5 + " Billets de 5€ et " + reste + " Pièces de 1€");
        break;

    case 3:
        string[] noms = new string[4];
        int[] ages = new int[4];
        float[] maths = new float[4];
        float[] algos = new float[4];
        float[] devs = new float[4];
        float[] moyennes = new float[4];
        string nom;
        int age = 0;
        float math = 0;
        float algo = 0;
        float dev = 0;

        for (int i=0; i<4; i++)
        {
            Console.WriteLine("Merci de saisir un nom");
            nom = Console.ReadLine();
            noms[i] = nom;

            Console.WriteLine("Merci de saisir un age");
            age = Convert.ToInt32(Console.ReadLine());
            ages[i] = age;

            Console.WriteLine("Merci de saisir la note Maths");
            math = float.Parse(Console.ReadLine());
            maths[i] = math;

            Console.WriteLine("Merci de saisir la note Algo");
            algo = float.Parse(Console.ReadLine());
            algos[i] = algo;

            Console.WriteLine("Merci de saisir la note Dev");
            dev = float.Parse(Console.ReadLine());
            devs[i] = dev;

            moyennes[i] = (maths[i] + algos[i] + devs[i]) / 3;
        }

        for (int i=0; i<4; i++)
        {
            for (int j=i+1; j<4; j++)
            {
                if (moyennes[i] < moyennes[j])
                {
                    float tempMoy = moyennes[i];
                    moyennes[i] = moyennes[j];
                    moyennes[j] = tempMoy;

                    string tempNom = noms[i];
                    noms[i] = noms[j];
                    noms[j] = tempNom;

                    int tempAge = ages[i];
                    ages[i] = ages[j];
                    ages[j] = tempAge;

                    float tempMath = maths[i];
                    maths[i] = maths[j];
                    maths[j] = tempMath;

                    float tempAlgo = algos[i];
                    algos[i] = algos[j];
                    algos[j] = tempAlgo;

                    float tempDev = devs[i];
                    devs[i] = devs[j];
                    devs[j] = tempDev;
                }
            }
        }

        for (int i=0; i<4; i++)
        {
            string mention;
            if (moyennes[i] >= 16) {
                mention = "Excellent";
            } else if (moyennes[i] >= 12 && moyennes[i] <16) {
                mention = "Bon";
            } else if (moyennes[i] >= 10 && moyennes[i] < 12) {
                mention = "Passable";
            } else {
                mention = "Insuffisant";
            }
            Console.WriteLine("L'élève numéro " + (i + 1) + " est " + noms[i] +
                " âgé de " + ages[i] + " ans et qui a eu la moyenne " + moyennes[i] +
                " et donc la mention " + mention);
        }

        break;

    case 4:
        List<List<string>> eleves = new List<List<string>>();
        reponse = true;

        min4 = 0;
        while (reponse)
        {
            List<string> eleve = new List<string>();
            Console.WriteLine("Merci de saisir un nom");
            eleve.Add(Console.ReadLine());

            Console.WriteLine("Merci de saisir un age");
            eleve.Add(Console.ReadLine());

            Console.WriteLine("Merci de saisir la note Maths");
            string mathTemp = Console.ReadLine();
            eleve.Add(mathTemp);

            Console.WriteLine("Merci de saisir la note Algo");
            string algoTemp = Console.ReadLine();
            eleve.Add(algoTemp);
        
            Console.WriteLine("Merci de saisir la note Dev");
            string devTemp = Console.ReadLine();
            eleve.Add(devTemp);

            float moyenne = (float.Parse(mathTemp) + float.Parse(algoTemp) + float.Parse(devTemp)) / 3;
            eleve.Add(Convert.ToString(moyenne));

            string mention;
            if (moyenne >= 16)
            {
                mention = "Excellent";
            }
            else if (moyenne >= 12 && moyenne < 16)
            {
                mention = "Bon";
            }
            else if (moyenne >= 10 && moyenne < 12)
            {
                mention = "Passable";
            }
            else
            {
                mention = "Insuffisant";
            }
            eleve.Add(mention);

            if (min4 >= 3)
            {
                Console.WriteLine("Voulez-vous saisir un nouvel élève ? O/N");
                if (Console.ReadLine() == "N")
                {
                    reponse = false;
                }
            }
            min4++;
            eleves.Add(eleve);

        }

        eleves.Sort((a, b) => 
            float.Parse(b[5]).CompareTo(float.Parse(a[5]))
        );

        compteur = 1;
        foreach (List<string> eleve in eleves)
        {
            Console.WriteLine("L'élève numéro " + compteur + " est " + eleve[0] +
                " âgé de " + eleve[1] + " ans et qui a eu la moyenne " + eleve[5] +
                " et donc la mention " + eleve[6]);
            compteur++;
        }
        

        break;

    case 5:

        List<Eleve> eleveObjets = new List<Eleve>();
        reponse = true;
        min4 = 0;
        while (reponse)
        {
            Eleve eleve = new Eleve();
            Console.WriteLine("Merci de saisir un nom");
            eleve.nom = Console.ReadLine();

            Console.WriteLine("Merci de saisir un age");
            eleve.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Merci de saisir la note Maths");
            eleve.math = float.Parse(Console.ReadLine());

            Console.WriteLine("Merci de saisir la note Algo");
            eleve.algo = float.Parse(Console.ReadLine());

            Console.WriteLine("Merci de saisir la note Dev");
            eleve.dev = float.Parse(Console.ReadLine());

            eleve.moyenne = (eleve.math + eleve.algo + eleve.dev) / 3;

            string mention;
            if (eleve.moyenne >= 16)
            {
                mention = "Excellent";
            }
            else if (eleve.moyenne >= 12 && eleve.moyenne < 16)
            {
                mention = "Bon";
            }
            else if (eleve.moyenne >= 10 && eleve.moyenne < 12)
            {
                mention = "Passable";
            }
            else
            {
                mention = "Insuffisant";
            }

            eleve.mention = mention;
            eleveObjets.Add(eleve);

            if (min4 >= 3)
            {
                Console.WriteLine("Voulez-vous saisir un nouvel élève ? O/N");
                if (Console.ReadLine() == "N")
                {
                    reponse = false;
                }
            }
            min4++;
        }

        eleveObjets.Sort((e1, e2)=>e2.moyenne.CompareTo(e1.moyenne));

        compteur = 1;
        foreach (Eleve eleve in eleveObjets)
        {
            Console.WriteLine("L'élève numéro " + compteur + " est " + eleve.nom +
                " âgé de " + eleve.age + " ans et qui a eu la moyenne " + eleve.moyenne +
                " et donc la mention " + eleve.mention);
            compteur++;
        }
       
        break;

    case 6:
        string email = "";
        string password = "";

        Console.WriteLine("Merci de saisir votre email");
        email = Console.ReadLine();
        Console.WriteLine("Merci de saisir votre mot de passe");
        password = Console.ReadLine();

        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:8000/api/login");
        var content = new MultipartFormDataContent();
        content.Add(new StringContent(email), "email");
        content.Add(new StringContent(password), "password");
        request.Content = content;
        var response2 = await client.SendAsync(request);


        if ((int)response2.StatusCode == 200)
        {
            Console.WriteLine("Bienvenue, vous êtes connecté");

            // Attendez la réponse JSON en tant que chaîne
            string jsonResponse = await response2.Content.ReadAsStringAsync();

            // Désérialisation de la réponse JSON
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            LoginResponse response = JsonSerializer.Deserialize<LoginResponse>(jsonResponse, options);

            if (response != null)
            {
                if (response.Status != "Login successful")
                {
                    Console.WriteLine("Connexion échouée, merci de recommencer");
                }
            }

        }
        else
            Console.WriteLine("Connexion échouée, merci de recommencer");
        
        break;
}