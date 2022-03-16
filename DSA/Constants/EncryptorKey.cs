namespace Dsa.Constants
{
    public static class EncryptorKey
    {
        private readonly static string Key;

        static EncryptorKey()
        {
            Key = "Dell-SDET-UITest";
        }
        public static string getKeyForEncryption()
        {
            return Key;
        }

    }
}