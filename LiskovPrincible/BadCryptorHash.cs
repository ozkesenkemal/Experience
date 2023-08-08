namespace LiskovPrincible
{
    // hash algorithm is one way encryption algorithm so description for has is useless
    public class BadCryptorHash : BadICryptor
    {
        public void Decrypt()
        {
            throw new NotImplementedException();
        }

        public void Encrypt()
        {
            // encrypt was done
        }
    }
}
