using ShareKernel.Core;
using ShareKernel.Rules;
using System.Xml.Linq;

namespace ShareKernel.ValueObjects
{
    public record VehiculoValue : ValueObject
    {
        public string Name { get; }

        public VehiculoValue(string name)
        {
            CheckRule(new StringNotNullOrEmptyRule(name));
            if(name.Length > 100)
            {
                throw new BussinessRuleValidationException("Vehiculo can't be more than 100 characters");
            }
            Name = name;
        }

        public static implicit operator string(VehiculoValue value)
        {
            return value.Name;
        }

        public static implicit operator VehiculoValue(string name)
        {
            return new VehiculoValue(name);
        }
    }
}
