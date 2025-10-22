using System;
using System.Collections;

namespace Accounting_nLayerBusinessLogic.Encryption
{
    public static class Converter
    {
        internal static BitArray ByteToBit_Array(Byte [] macAddressByte)
        {
            return new BitArray(macAddressByte);
        }
        internal static Byte[] BitToByte_Array(BitArray macAddressBit)
        {

            int num_bytes = macAddressBit.Length / 8;
            if (!(macAddressBit.Length % 8).Equals(0))
            {
                num_bytes++;
            }
            var bytes = new byte[num_bytes];
            macAddressBit.CopyTo(bytes, 0);
            return bytes;
        }
        
    }
}
