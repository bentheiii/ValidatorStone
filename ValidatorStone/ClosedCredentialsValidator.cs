using System;

namespace ValidatorStone
{
    [Serializable]
    public class ClosedCredentialValidator : ICredentialValidator
    {
        public bool isValid(Credential c)
        {
            return false;
        }
    }
}
