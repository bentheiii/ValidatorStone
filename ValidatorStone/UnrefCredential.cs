using System;
using ValidatorStone;

namespace ValidatorStone
{
    [Serializable]
    public class UnRefCredential<T> : Credential
    {
        public UnRefCredential(T value)
        {
            this.value = value;
        }
        public T value { get; }
        public override string ToString()
        {
            return value.ToString();
        }
    }
}
