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
            model.Name = "Pawel";


            var result = model.ToXml();

            Console.WriteLine(result);




            string jsonText = @"{""Id"":""cea6ee3b-e0b8-46f4-a903-9983923be409"",""Name"":""Pawelllllll""}";


            var modelFromJson = jsonText.FromJson<Model>();

            Console.Write(modelFromJson.Id);
            Console.Write(modelFromJson.Name);


            Console.ReadKey();
        }
    }
}
