using System;

namespace Jaroszek.ProofOfConcept.ExtensionMetodToJson
{
    public sealed class Model : IToJson
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
