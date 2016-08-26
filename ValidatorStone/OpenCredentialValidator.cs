using System;

namespace ValidatorStone
{
    [Serializable]
    public class OpenCredentialValidator : ICredentialValidator
    {
        public bool isValid(Credential c)
        {
            return true;
        }
    }
}
