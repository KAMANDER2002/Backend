using MyParcer.RuntimeGetParcer.GerParce;
using System;

namespace MyParcer
{
    class Program
    {
        static void Main(string[] args)
        {
            GetRequest request = new GetRequest("https://life.ru/");
            request.getClientTimeEnter();
            Console.WriteLine(request.answer);
        }
    }
}
