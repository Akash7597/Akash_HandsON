using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Day11.Reflection
{
    interface IPerson
    {
        void ShowPerson();
    }
    class Person:IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string n,int a)
        {
            Name = n;
            Age = a;
        }
        public void ShowPerson()
        {
            Console.WriteLine($"Name:{Name}\n Age:{Age}");
        }
        public void SetPerson(string n,int a)
        {
            Name=n;
            Age = a;
        }
    }
    internal class Reflection
    {
        public static void Main(string[] args)
        {
            Type t=typeof(Person);
            GetTypeDetails(t);
        }
        public static void GetTypeDetails(Type t)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{t.Name} Type Details:");
            sb.AppendLine($"FullName:{t.FullName}");
            sb.AppendLine($"NameSpace:{t.Namespace}");

            var tb = t.BaseType;
            if (tb != null)
                sb.AppendLine($"BaseType:{tb.Name}");
            sb.AppendLine($"Is AbstractClass:{t.IsAbstract}");
            sb.AppendLine($"Is Array:{t.IsArray}");
            sb.AppendLine($"Is Class:{t.IsClass}");

            MethodInfo[] methods = t.GetMethods();
            foreach (var method in methods)
            {
                sb.AppendLine($"{method.Name} ({method.MemberType})-({method.DeclaringType})");
                sb.AppendLine($"Parameter used by method name:{method.Name}");
            }
            //ParameterInfo[] parameters = method.GetParameters();
            //foreach (var parameter in parameters)
            //{
            //    sb.AppendLine($"{parameter.Name}:{parameter.ParameterType}");
            //}
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }  
    }
}
