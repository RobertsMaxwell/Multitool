using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Drawing;
using System.Windows.Forms;

namespace Multitool
{
    class Scanner
    {
        public static bool scanning = false;
        public static int timeoutMS = 100;
        public static int progress = 0;
        public static int barMaximum = 100;

        //begin an asynchronous scan for each port on each address
        public static IPInfo[] Scan(string[] addresses, int[] ports, ProgressBar bar = null, Label eta = null)
        {
            List<IPInfo> returnList = new List<IPInfo>();
            scanning = true;
            barMaximum = addresses.Length * ports.Length;
            bar.Value = 0;
            progress = 0;

            for (int y = 0; y < addresses.Length; y++)
            {
                for (int i = 0; i < ports.Length; i++)
                {
                    TcpClient client = new TcpClient();
                    try
                    {
                        var result = client.BeginConnect(addresses[y], ports[i], null, null);

                        if (result.AsyncWaitHandle.WaitOne(timeoutMS))
                        {
                            returnList.Add(new IPInfo(addresses[y], ports[i].ToString(), "True"));
                        }
                        else
                        {
                            returnList.Add(new IPInfo(addresses[y], ports[i].ToString(), "False"));
                        }

                    }
                    catch (Exception)
                    {
                        returnList.Add(new IPInfo(addresses[y], ports[i].ToString(), "False"));
                    }

                    if (bar.Value < 100)
                    {
                        progress++;
                        bar.Value = (int)((float)progress / barMaximum * 100);
                        eta.Text = "ETA: " + ((timeoutMS * barMaximum - timeoutMS * progress) / 1000).ToString() + " sec";
                    }

                }
            }

            scanning = false;
            return returnList.ToArray();
        }

        public struct IPInfo
        {
            public IPInfo(string address, string port, string status)
            {
                Address = address;
                Port = port;
                Status = status;
            }

            public string Address { get; }
            public string Port { get; }
            public string Status { get; }
        }
    }
}
