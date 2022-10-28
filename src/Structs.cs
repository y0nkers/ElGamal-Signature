namespace ElGamal_Signature
{
    public struct Key
    {
        /// <summary>
        /// Prime number p
        /// </summary>
        public BigInteger p;

        /// <summary>
        /// Primitive root g of p (g < p)
        /// </summary>
        public BigInteger g;

        /// <summary>
        /// public key y = g^x mod p
        /// </summary>
        public BigInteger y;

        /// <summary>
        /// Private key x (1 < x < p - 1)
        /// </summary>
        public BigInteger x; 
    }

    public struct Signature
    {
        /// <summary>
        /// r = g^k mod p
        /// </summary>
        public BigInteger r;

        /// <summary>
        /// s = [(m - xr)*k^(-1)] mod (p - 1)
        /// </summary>
        public BigInteger s;
    }
}
