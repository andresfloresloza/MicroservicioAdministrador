using ShareKernel.Core;
using ShareKernel.Rules;

namespace ShareKernel.ValueObjects
{
    public record TiendaNameValue : ValueObject
    {
        public string Name { get; }

        public TiendaNameValue(string name)
        {
            CheckRule(new StringNotNullOrEmptyRule(name));
            if(name.Length > 500)
            {
                throw new BussinessRuleValidationException("TiendaName can't be more than 500 characters");
            }
            Name = name;
        }

        public static implicit operator string(TiendaNameValue value)
        {
            return value.Name;
        }

        public static implicit operator TiendaNameValue(string name)
        {
            return new TiendaNameValue(name);
        }
    }
}
