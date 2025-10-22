using System;
using System.Collections;

namespace Accounting_nLayerBusinessLogic.Encryption
{
    public static class EncCalculator
    {
        internal static BitArray macBitEncrypter(BitArray macAddressBits)
        {
            BitArray OneValue = new BitArray(macAddressBits.Count);

            OneValue.Not();
            macAddressBits.Xor(OneValue);
            macAddressBits.Not();


            return macAddressBits;
        }

        internal static void IDGenerator(Byte [] ResultByte)
        {
            double ID = 0;
            for (int i = 0; i < ResultByte.Length; i++)
            {
                if ((i % 2).Equals(0))
                {
                    ID -= ((ResultByte.Length) * Math.Exp(ResultByte.Length)) / (ResultByte[i]);
                }
                else
                {
                    ID += (Math.Exp(ResultByte.Length) / (ResultByte.Length) ) * (ResultByte[i]);
                }
            }
            Subtracter(ResultByte,ID);
        }

        private static void Subtracter(Byte[] ResultByte, double ID)
        {
            byte [] lastID = BitConverter.GetBytes(Math.Abs(Math.Round(ID)));
            BitArray idBit = Converter.ByteToBit_Array(lastID);
            BitArray resultBits;
            int indexer = 0;
            for (int i = 0; i < ResultByte.Length; i++)
            {
                resultBits = new BitArray(ResultByte[i]);
                resultBits = ReversedBits(LastEncryption(resultBits, idBit));
                //ResultByte[i] = Converter.BitToByte(resultBits);
                if (!indexer.Equals(8))
                {
                    ResultByte[i] |= (byte)(1 << (7 - indexer));
                    indexer++;
                }
                else
                {
                    indexer = 0;
                    ResultByte[i] |= (byte)(1 << (7 - indexer));
                }
            }
        }

        private static BitArray LastEncryption(BitArray resultBits, BitArray idBit)
        {
            if (resultBits.Count.Equals(idBit.Count))
            {
                return resultBits.Xor(idBit); 
            }
            else
            {
                if (resultBits.Count < idBit.Count)
                {
                    BitArray newResultBit = new BitArray(idBit.Count);
                    for (int i = 0; i < idBit.Count; i++)
                    {
                        if (i<resultBits.Count)
                        {
                            newResultBit[i] = resultBits[i];
                        }
                        else
                        {
                            if (i % 2 == 0)
                            {
                                newResultBit[i] = false;
                            }
                            else
                            {
                                newResultBit[i] = true;
                            }
                        }
                    }
                    return newResultBit.Xor(idBit);

                }
                if (resultBits.Count > idBit.Count)
                {
                    BitArray newIdBit = new BitArray(resultBits.Count);

                    for (int i = 0; i < resultBits.Count; i++)
                    {
                        if (i < idBit.Count)
                        {
                            newIdBit[i] = idBit[i];
                        }
                        else
                        {
                            if (i % 2 == 0)
                            {
                                newIdBit[i] = false;
                            }
                            else
                            {
                                newIdBit[i] = true;
                            }
                        }
                    }
                    return resultBits.Xor(newIdBit);
                }

            }
            
            return null;
            
        }

        private static BitArray ReversedBits(BitArray resultBits)
        {
            int lenght = resultBits.Length;
            int mid = (lenght / 2);
            bool bit;
            for (int i = 0; i < mid; i++)
            {
                bit = resultBits[i];
                resultBits[i] = resultBits[lenght - i - 1];
                resultBits[lenght - i - 1] = bit;
            }

                return resultBits;
        }
    }
    
}
