using Accounting_nLayerBusinessLogic.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Insurance_Library.Encryption
{
    internal class Ids
    {
        internal static string GetId()
        {
            string x = GetFirstID() + GetSecondId();
            return GetFirstID() + GetSecondId();
        }
        private static string GetFirstID()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.NetworkInterfaceType.Equals(NetworkInterfaceType.Ethernet) &&
                    nic.OperationalStatus.Equals(OperationalStatus.Up))
                {
                    return EncryptedInformation.EncryptedMacAddressFunc(nic.GetPhysicalAddress().ToString()) + "-";
                }

            }
            return null;
        }
        private static string GetSecondId()
        {
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_processor");
            mbsList = mbs.Get();
            foreach (ManagementObject mo in mbsList)
            {
                return EncryptedInformation.EncryptedMacAddressFunc(mo["ProcessorID"].ToString());
            }
            return null;
        }
    }
}
