using ShareKernel.Core;
using ShareKernel.Rules;

namespace ShareKernel.ValueObjects
{
    public record PhoneNumberValue : ValueObject
    {
        public string Number { get; }

        public PhoneNumberValue(string number)
        {
            CheckRule(new StringNotNullOrEmptyRule(number));
            if(number.Length > 8)
            {
                throw new BussinessRuleValidationException("PhoneNumber can't be more than 8 characters");
            }
            Number = number;
        }

        public static implicit operator string(PhoneNumberValue value)
        {
            return value.Number;
        }

        public static implicit operator PhoneNumberValue(string number)
        {
            return new PhoneNumberValue(number);
        }
    }
}
