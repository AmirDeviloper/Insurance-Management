using System;
using System.Collections;
using System.Text;

namespace Accounting_nLayerBusinessLogic.Encryption
{
    public static class EncryptedInformation
    {
        internal static string EncryptedMacAddressFunc(string MacAddress)
        {
            byte[] macAddressBytes = Encoding.ASCII.GetBytes(MacAddress);
            Array.Reverse(macAddressBytes);
            BitArray bit = Converter.ByteToBit_Array(macAddressBytes);
            bit = EncCalculator.macBitEncrypter(bit);
            byte [] ResultByte = Converter.BitToByte_Array(bit);

            EncCalculator.IDGenerator(ResultByte);

            return BitConverter.ToString(ResultByte);

        }
    }
}
