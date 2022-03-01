using System;
using System.Collections;
using System.Collections.Generic;


public class time
{
    int jour,mois,année;
    
    public time(int jour,int mois,int année)
    {
        while(!(1<=jour&&jour<=31)){
                Console.WriteLine("ce jour n'est pas valide, veuillez insérer un chiffre entre 1 et 31");
                jour=Int32.Parse(Console.ReadLine());
        }

        while(!(1<=mois&&mois<=12)){
                Console.WriteLine("ce mois n'est pas valide, veuillez insérer un chiffre entre 1 et 12");
                mois=Int32.Parse(Console.ReadLine());
        }
        while(!(0<=année)){
                Console.WriteLine("ce an n'est pas valide, veuillez insérer un chiffre supérieur à 0");
                année=Int32.Parse(Console.ReadLine());
        }
        this.jour=jour;
        this.mois=mois;
        this.année=année;
    }
    
    public static bool operator == (time a,time b)
    {
       return (a.jour==b.jour)&&(a.mois==b.mois)&&(a.année==b.année);
    }
    public static bool operator != (time a,time b)
    {
       return !((a.jour==b.jour)&&(a.mois==b.mois)&&(a.année==b.année));
    }

    public static IEnumerable<time> mois_pair(time [] a)
    {
        foreach (time b in a)
        {
            if(b.mois%2==0) yield return b;
        }
    }

    public static bool bissextile(time a)
    {
        if((a.année%4==0 && a.année%100!=0)||a.année%400==0){
            return true;
        }
        return false;
    }


    public static void afficher(time a)
    {
        Console.WriteLine("année = "+a.année.ToString());
    }

    
}






public class obligation
{
    
    public static void Main()
    {
        time date=new time(5,4,2000);
        time date_1=new time(5,8,2022);
        time date_2=new time(5,5,1900);
        time date_3=new time(5,6,2000);
        time [] lista=new time[4]{date,date_1,date_2,date_3};
        bool b,b_1,b_2,b_3;
        b=time.bissextile(date);
        b_1=time.bissextile(date_1);
        b_2=time.bissextile(date_2);
        b_3=time.bissextile(date_3);
        Console.WriteLine(b);
        Console.WriteLine(b_1);
        Console.WriteLine(b_2);
        Console.WriteLine(b_3);
        b_1=(date==date_1);
        b_2=(date==date_3);
        Console.WriteLine(b_1);
        Console.WriteLine(b_2);
        foreach(time a in time.mois_pair(lista)){
            time.afficher(a);
        }
    }

    
}

