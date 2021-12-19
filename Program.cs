using MyParcer.RuntimeGetParcer.GerParce;
using System;

namespace MyParcer
{
    class Program
    {
        static void Main(string[] args)
        {
            GetRequest request = new GetRequest("https://a.pr-cy.ru/vk.com");
            request.Run();
            Console.WriteLine(request.Response);
        }
    }
}
