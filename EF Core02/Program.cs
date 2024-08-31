using EF_Core02.Contexts;
using EF_Core02.Entities;
using System;

namespace EF_Core02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext context = new ITIDbContext();
            //ADD
            //Student student = new Student() { FName = "Nelly", LName = "Mohamed", Age = 18 , Address="Mansoura" };
            //Console.WriteLine(context.Entry(student).State);
            //context.Students.Add(student);
            //Console.WriteLine(context.Entry(student).State);
            //var result = context.SaveChanges();
            //Console.WriteLine(result);
            //Console.WriteLine(context.Entry(student).State);
            ///////////////////////////////////////////
            ///SELECT
            //var Result = context.Students.Where(S=>S.Id==3).FirstOrDefault();
            //Console.WriteLine(Result?.FName);
            //Console.WriteLine(context.Entry(Result).State);
            //Result.FName = "Rana";
            //Console.WriteLine(context.Entry(Result).State);
            //Console.WriteLine(Result?.FName);
            ////////////////////////////////////
            ///UPDATE
            //var Result = context.Students.FirstOrDefault(S => S.Id == 4);
            //Console.WriteLine(context.Entry(Result).State);
            //Result.FName = "Maya";
            //Console.WriteLine(context.Entry(Result).State);
            //Result.FName = "Naya";
            //context.Update(Result);
            //Console.WriteLine(context.Entry(Result).State);
            //context.SaveChanges();
            //Console.WriteLine(context.Entry(Result).State); 
            //////////////////////////////////////
            ///REMOVE
            //var Result = context.Students.FirstOrDefault(S => S.Id == 4);
            //Console.WriteLine(context.Entry(Result).State);
            //context.Students.Remove(Result);
            //Console.WriteLine(context.Entry(Result).State);
            //context.SaveChanges();
            //Console.WriteLine(context.Entry(Result).State);
            //////////////////////////////////
            //Topic topic = new Topic() {Name="Operation"};
            //Console.WriteLine(context.Entry(topic).State);
            //context.Topics.Add(topic);
            //Console.WriteLine(context.Entry(topic).State);
            //var result02=context.SaveChanges();
            //Console.WriteLine(result02);
            //Console.WriteLine(context.Entry(topic).State);
        }
    }
}
