using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = MathOperation.Add(120.25, 254.25);
            Console.WriteLine($"120.25 + 254.25 = {result}");

            string id = Guid.NewGuid().ToString();
            var guidId = id.ConvertStringToGuid();

            Console.WriteLine(guidId);

            var min = MathOperation.Minimum(6, 7, 8);

            Console.WriteLine("minimum: " + min);

           // Console.ReadLine();

            var config = new MapperConfiguration(cfg => cfg.AddProfile<SamlingMappingProfile>());
            var mapper = config.CreateMapper();

            var searchResultReadOnly = new List<SearchResultReadOnly>();

            searchResultReadOnly.Add(new SearchResultReadOnly() { Id = 1, Headline = "hello" });
            searchResultReadOnly.Add(new SearchResultReadOnly() { Id = 2, Headline = "hi" });

            var sam = new SamlingReadOnlyModel()
            {
                Id = 100,
                Name = "lars er død",
                SearchResultReadOnly = searchResultReadOnly
            };

            var samList = new List<SamlingReadOnlyModel> { sam,
                new SamlingReadOnlyModel { Id = 3, Name="hello", SearchResultReadOnly =
                new List<SearchResultReadOnly> { new SearchResultReadOnly { Id=5, Headline="this is another" } } }};

            var destination = mapper.Map<List<SamlingDto>>(samList);

            Console.ReadKey();
           




         }
    }
}
