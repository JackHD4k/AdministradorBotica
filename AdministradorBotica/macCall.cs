using System.Net.NetworkInformation;
using System;
using System.Windows.Forms;

namespace AdministradorBotica
{
    class macCall
    {
        static public string GetMacAddresss()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            string sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == string.Empty)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress.ToString();
        }
    }
}
