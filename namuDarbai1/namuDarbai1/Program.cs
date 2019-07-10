using System;

namespace namuDarbai1
{
    class Program
    {
        static void Main(string[] args)
        {
            TekstasISkaiciu();
        }
        static void TekstasISkaiciu()
        {
            int reziai = IveskiteRezius();
            string ivedimas = IveskiteSkaiciu();
            //string rezultatas = "";
            int skaitmenuSkaicius = SkaitmenuKiekis(ivedimas);
            Console.WriteLine("Ar tekste yra skaicius: " + PatikrintiArSkaicius(ivedimas));
            int skaicius = Konvertavimas(ivedimas, skaitmenuSkaicius);
            Console.WriteLine(skaicius);
            Console.WriteLine("Ar skaicius teisinguose reziuose: " + PatikrintiArTeisingiReziai(skaitmenuSkaicius, reziai));
            Console.WriteLine(SkaiciusITeksta(skaicius, skaitmenuSkaicius));
        }

        // paprasom ivest rezius?
        static int IveskiteRezius()
        {
            Console.WriteLine("Iveskite kiek-zenkli skaiciu tikrinsime (nuo 1 iki 6):");
            int rez = Convert.ToInt32(Console.ReadLine());
            if (rez < 1 || rez > 6)
            {
                Console.WriteLine("klaida");
                IveskiteRezius();
            }
            return rez;
        }

        // papraso ivesti skaiciu
        static string IveskiteSkaiciu()
        {
            Console.WriteLine("Iveskite skaiciu nuo -9 iki 9");
            return Console.ReadLine();
        }

        //patikrina ar ivestoje informacijoje yra bent vienas skaitmuo (??????)
        static bool PatikrintiArSkaicius(string ivedimas)
        {
            for (int i = 0; i < ivedimas.Length; i++)
            {
                if (char.IsNumber(ivedimas[i]))
                {
                    //int skaicius = ivedimas[i];
                    return true;
                }
            }

            return false;
        }

        //paskaiciuoja skaitmenu kieki skaiciuje
        static int SkaitmenuKiekis(string ivedimas)
        {
            int skaitmenuKiekis = 0;
            for (int i = 0; i < ivedimas.Length; i++)
            {
                if (char.IsNumber(ivedimas[i]))
                {
                    skaitmenuKiekis++;
                }
            }
            return skaitmenuKiekis;
        }


        //konvertavimas - veikia
        static int Konvertavimas(string ivedimas, int skaitmenuKiekis)
        {
            int skaicius = 0;

            for (int i = 0; i < ivedimas.Length; i++)
            {
                if (char.IsNumber(ivedimas[i]))
                {
                    skaicius += ((int)ivedimas[i] - '0');
                    int j = i + 1;
                    if (j < ivedimas.Length)
                    {
                        if (char.IsNumber(ivedimas[j]))
                        {
                            skaicius *= 10;
                        }
                    }
                }
            }
            if (ivedimas[0] == '-')
            {
                skaicius *= -1;
            }


            return Convert.ToInt32(skaicius);
        }


        //patikrina rezius (---)
        static bool PatikrintiArTeisingiReziai(int skaitmenuKiekis, int reziai)
        {
            if (skaitmenuKiekis <= reziai)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //skeliam skaiciu i tukstancius, simtus, desimtys ir konvertuojam i teksta

        static string SkaiciusITeksta(int skaicius, int skaitmenuKiekis)
        {
            string rezultatas = "";
            if (skaicius == 0 && skaitmenuKiekis == 0)
            {
                rezultatas = "nulis ";
            }
            if (skaicius < 0)
            {
                rezultatas = "minus ";
                skaicius *= -1;
            }

            if (skaicius / 100000 != 0)
            {
                if (skaicius / 100000 == 1)
                {
                    rezultatas += "simtas ";
                }
                else
                {
                    rezultatas += PaverstiVienietusTekstu(skaicius / 100000);
                    rezultatas += "simtai ";
                }
            }
            if (skaicius / 10000 % 10 != 0)
            {
                if (skaicius / 10000 % 10 == 1)
                {
                    if (skaicius / 1000 % 10 == 0)
                    {
                        rezultatas += "desimt ";
                    }
                    if (skaicius / 1000 % 10 > 0)
                    {
                        rezultatas += PaverstiVienuolikaTekstu(skaicius / 1000 % 10);
                    }


                }
                else
                {
                    rezultatas += PaverstiDesimtysTekstu(skaicius / 10000 % 10);
                    rezultatas += PaverstiVienietusTekstu(skaicius / 1000 % 10);
                }
            } else if (skaicius / 1000 % 10 != 0)
            {
                rezultatas += PaverstiVienietusTekstu(skaicius / 1000 % 10);
            }



            if (skaicius / 1000 % 10 == 1)
            {
                rezultatas += "tukstantis ";
            }
            else if (skaicius / 1000 % 10 > 1 && skaicius / 1000 % 10 < 10)
            {
                rezultatas += "tukstanciai ";
            }
            else if (skaicius / 1000 > 10)
            {
                rezultatas += "tukstanciu ";
            }

            if (skaicius / 100 % 10 != 0)
            {
                if (skaicius / 100 % 10  == 1)
                {
                    rezultatas += "simtas ";
                }
                else
                {
                    rezultatas += PaverstiVienietusTekstu(skaicius / 100 % 10);
                    rezultatas += "simtai ";
                }
            }
            if (skaicius / 10 % 10 != 0)
            {
                if (skaicius / 10 % 10 == 1)
                {
                    if (skaicius / 10 % 10 == 0)
                    {
                        rezultatas += "desimt ";
                    }
                    if (skaicius / 10 % 10 > 0)
                    {
                        rezultatas += PaverstiVienuolikaTekstu(skaicius / 10 % 10);
                    }


                }
                else
                {
                    rezultatas += PaverstiDesimtysTekstu(skaicius / 10 % 10);
                    rezultatas += PaverstiVienietusTekstu(skaicius  % 10);
                }
            }
            else if (skaicius / 10 % 10 != 0)
            {
                rezultatas += PaverstiVienietusTekstu(skaicius / 10 % 10);
            }

            return rezultatas;
        }


        static string PaverstiVienietusTekstu(int skaicius)
        {
            string rezultatas = "";
            switch (skaicius)
            {

                case 1:
                    rezultatas += "vienas ";
                    break;
                case 2:
                    rezultatas += "du ";
                    break;
                case 3:
                    rezultatas += "trys ";
                    break;
                case 4:
                    rezultatas += "keturi ";
                    break;
                case 5:
                    rezultatas += "penki ";
                    break;
                case 6:
                    rezultatas += "sesi ";
                    break;
                case 7:
                    rezultatas += "septyni ";
                    break;
                case 8:
                    rezultatas += "astuoni ";
                    break;
                case 9:
                    rezultatas += "devyni ";
                    break;

            }
            return rezultatas;

        }

        static string PaverstiDesimtysTekstu(int skaicius)
        {
            string rezultatas = "";
            switch (skaicius)
            {
                //case 0:
                //rezultatas += "nulis";
                //break;
                case 1:
                    rezultatas += "desimt ";
                    break;
                case 2:
                    rezultatas += "dvivesimt ";
                    break;
                case 3:
                    rezultatas += "trisdesimt ";
                    break;
                case 4:
                    rezultatas += "keturiasdesimt ";
                    break;
                case 5:
                    rezultatas += "penkiasdesimt ";
                    break;
                case 6:
                    rezultatas += "sesiasdesimt ";
                    break;
                case 7:
                    rezultatas += "septyniasdesimt ";
                    break;
                case 8:
                    rezultatas += "astuoniasdesimt ";
                    break;
                case 9:
                    rezultatas += "devyniiasdesimt ";
                    break;

            }
            return rezultatas;
        }

        static string PaverstiVienuolikaTekstu(int skaicius)
        {
            string rezultatas = "";
            switch (skaicius)
            {
                //case 0:
                //rezultatas += "nulis";
                //break;
                case 1:
                    rezultatas += "vienuolika ";
                    break;
                case 2:
                    rezultatas += "dvylika ";
                    break;
                case 3:
                    rezultatas += "trylika ";
                    break;
                case 4:
                    rezultatas += "keturiolika ";
                    break;
                case 5:
                    rezultatas += "penkiolika ";
                    break;
                case 6:
                    rezultatas += "sesiolika ";
                    break;
                case 7:
                    rezultatas += "septyniolika ";
                    break;
                case 8:
                    rezultatas += "astuoniolika ";
                    break;
                case 9:
                    rezultatas += "devyniolika ";
                    break;

            }
            return rezultatas;
        }
        
    }
}
