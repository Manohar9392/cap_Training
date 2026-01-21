using System;
using System.Collections;
using model;
public class Program
{
    public static ArrayList YogaMembers=new ArrayList();
    /// <summary>
    /// This method will add yogamembers
    /// </summary>
    /// <param name="id"></param>
    /// <param name="age"></param>
    /// <param name="goal"></param>
    /// <param name="weight"></param>
    /// <param name="height"></param>
    public void AddYogaMenbers(int id,int age,string goal,double weight,double height)
    {
        YogaMembers.Add(new MeditationCenter{MemberId=id,Age=age,Goal=goal,Weight=weight,Height=height});
    }

    public double CalculateBmi(int id)
    {
        double result=0;
        foreach(MeditationCenter v in YogaMembers)
        {
            if(v.MemberId==id)
            {
                v.Bmi=v.Weight/(v.Height*v.Height);
                result=v.Bmi;
            }
        }
        if(result==0)
        {
            return 0;
        }
        return result;
    }

    public int CalculateYogaFee(int id)
    {
        foreach(MeditationCenter v in YogaMembers)
        {
            if(v.MemberId==id)
            {
                if(v.Bmi==0)
                {
                    return -1;
                }
                else
                {
                    if(v.Goal=="Weight Loss")
                    {
                        if(v.Bmi>=25 && v.Bmi<30)
                        {
                            return 2000;
                        }
                        else if(v.Bmi>=30 && v.Bmi<35)
                        {
                            return 2500;
                        }
                        else
                        {
                            return 3000;
                        }
                    }
                    else
                    {
                        return 2500;
                    }
                }
            }
        }
        return -1;
    }
    public static void Main()
    {
        Program p=new Program();
        int id,age;
        double weight,height;
        string goal;
        while(true)
        {
            Console.Write(" 1 for Enter the details or 0 to exit: ");
            int choice=int.Parse(Console.ReadLine());
            if(choice==0)
            {
                break;
            }
            Console.Write("Enter the MemberId: ");
            id=int.Parse(Console.ReadLine());
            Console.Write("Enter the Age: ");
            age=int.Parse(Console.ReadLine());
            Console.Write("Enter the Goal: ");
            goal=Console.ReadLine();
            Console.Write("Enter the Weight in kgs: ");
            weight=double.Parse(Console.ReadLine());
            Console.Write("Enter the Height in meters: ");
            height=double.Parse(Console.ReadLine());

            p.AddYogaMenbers(id,age,goal,weight,height);



        }

        Console.Write("Enter the id calculate Bmi: ");
        int test_id=int.Parse(Console.ReadLine());
        double result=p.CalculateBmi(test_id);
        Console.WriteLine(result.ToString("F2"));

         Console.Write("Enter the id to calculate Yoga Fee: ");
         int fee_id=int.Parse(Console.ReadLine());
         int res1=p.CalculateYogaFee(fee_id);
         if(res1==-1)
        {
            Console.WriteLine("Bmi is not calculated for do that!");
        }
        else
        {
            Console.WriteLine($"Your fee for yoga is {res1}");
        }


        
        
    }
}