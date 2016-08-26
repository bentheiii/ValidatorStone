using System;

namespace ValidatorStone
{
    public static class throwIfInvalid
    {
        public static void ThrowIfInvalid(this ICredentialValidator v, Credential c)
        {
            if (!v.isValid(c))
                throw new UnauthorizedAccessException("the credentials are not valid");
        }
    }
}
