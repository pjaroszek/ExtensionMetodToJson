namespace Jaroszek.ProofOfConcept.ExtensionMetodToJson
{
    using System;
    using Extensions;
    using Models;

    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            model.Id = Guid.NewGuid();
            model.Name = "Adam";

            var resultJson = model.ToJson();
            var resultXml = model.ToXml();

            Console.WriteLine(resultJson);
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine(resultXml);


            string jsonText = @"{""Id"":""cea6ee3b-e0b8-46f4-a903-9983923be409"",""Name"":""Wojciech""}";


            var modelFromJson = jsonText.FromJson<Model>();

            Console.WriteLine($"Id: {modelFromJson.Id}");
            Console.WriteLine($"Name: {modelFromJson.Name}");


            Console.ReadKey();
        }
    }
}
