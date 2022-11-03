namespace ElGamal_Signature
{
    public class ElGamal
    {
        private int keySize;
        private Key key;
        private Signature signature;
        public ElGamal()
        {
            keySize = 256;
            
            key = new Key
            {
                p = new BigInteger(0),
                g = new BigInteger(0),
                y = new BigInteger(0),
                x = new BigInteger(0)
            };

            signature = new Signature
            {
                r = new BigInteger(0),
                s = new BigInteger(0)
            };
        }

        // Create a new key. Integer argument - the required key length:
        public void CreateKey()
        {
            Random random = new Random();

            // Generate prime number p
            key.p = BigInteger.genPseudoPrime(keySize, 16, random);

            // Generate primitive root G and private key X
            key.g = new BigInteger();
            key.g.genRandomBits(keySize - 1, random);

            key.x = new BigInteger();
            key.x.genRandomBits(keySize - 1, random);

            // Compute y = g^x mod p
            key.y = key.g.modPow(key.x, key.p);
        }

        public bool IsEmptyKey()
        {
            return key.p == 0 && key.g == 0 && key.y == 0;
        }

        public void SetKey(Key ks)
        {
            key.p = ks.p;
            key.g = ks.g;
            key.y = ks.y;
            if (ks.x != 0) key.x = ks.x;
        }

        public void SetPrivateKey(BigInteger x)
        {
            key.x = x;
        }

        public Key GetKey()
        {
            return key;
        }

        public bool IsEmptySignature()
        {
            return signature.r == 0 & signature.s == 0;
        }

        public void SetSignature(Signature sig)
        {
            signature.r = sig.r;
            signature.s = sig.s;
        }

        public Signature GetSignature()
        {
            return signature;
        }

        public byte[] Sign(byte[] message_hash)
        {
            if (IsEmptyKey()) CreateKey();
            return CreateSignature(message_hash);
        }

        public bool Verify(byte[] message_hash)
        {
            BigInteger left = mod(key.y.modPow(signature.r, key.p) * signature.r.modPow(signature.s, key.p), key.p);
            BigInteger right = key.g.modPow(new BigInteger(message_hash), key.p);
            if (left == right) return true;
            else return false;
        }

        private static BigInteger mod(BigInteger p_base, BigInteger p_val)
        {
            BigInteger result = p_base % p_val;
            if (result < 0) result += p_val;
            return result;
        }

        private byte[] CreateSignature(byte[] message_digest)
        {
            // p - 1
            BigInteger pMinusOne = key.p - 1;

            // Generate random number k (1 < k < p - 1 and k coprime with p - 1)
            BigInteger k;
            do
            {
                k = new BigInteger();
                k.genRandomBits(key.p.bitCount() - 1, new Random());
            } while (k.gcd(pMinusOne) != 1);

            signature.r = key.g.modPow(k, key.p); // r = g^k mod p
            signature.s = mod(mod(k.modInverse(pMinusOne) * (new BigInteger(message_digest) - key.x * signature.r), pMinusOne), pMinusOne); // s = [(m - xr)*k^(-1)] mod (p - 1)
            //BigInteger s = mod((new BigInteger(message_digest) - keyStruct.X * r) * k.modInverse(pMinusOne), pMinusOne); // s = [(m - xr)*k^(-1)] mod (p - 1)
            byte[] r_bytes = signature.r.getBytes();
            byte[] s_bytes = signature.s.getBytes();

            // Byte Array to contain the ciphertext
            int size = r_bytes.Length + s_bytes.Length;
            byte[] result = new byte[size];

            Array.Copy(r_bytes, 0, result, size / 2 - r_bytes.Length, r_bytes.Length);
            Array.Copy(s_bytes, 0, result, size - s_bytes.Length, s_bytes.Length);

            return result;
        }
        
        public byte[] GetSignatureBytes()
        {
            byte[] r_bytes = signature.r.getBytes();
            byte[] s_bytes = signature.s.getBytes();

            // Byte Array to contain the ciphertext
            int size = r_bytes.Length + s_bytes.Length;
            byte[] result = new byte[size];

            Array.Copy(r_bytes, 0, result, size / 2 - r_bytes.Length, r_bytes.Length);
            Array.Copy(s_bytes, 0, result, size - s_bytes.Length, s_bytes.Length);

            return result;
        }
    }
}