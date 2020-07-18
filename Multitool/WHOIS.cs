using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;

namespace Multitool
{
    class WhoIsReponse
    {
        public List<string> queryResults = new List<string>();

        public WhoIsReponse(string whoIsServer, string domain)
        {
            //check for registrar whois server
            var resultsIANA = string.Join("\n", SendQuery(whoIsServer.Trim(), domain).Split('\n').Where(str => str.Contains("refer:")));
            if (resultsIANA.Length > resultsIANA.IndexOf(":") + 1)
            {
                whoIsServer = resultsIANA.Substring(resultsIANA.IndexOf(":") + 1, resultsIANA.Length - (resultsIANA.IndexOf(":") + 1));
            }

            var results = string.Join("\n", SendQuery(whoIsServer.Trim(), domain).Split('\n').Where(str => str.Contains("Registrar WHOIS Server:")));
            if (results.Length > results.IndexOf(":") + 1)
            {
                whoIsServer = results.Substring(results.IndexOf(":") + 1, results.Length - (results.IndexOf(":") + 1));
            }

            queryResults = SendQuery(whoIsServer.Trim(), domain).Split('\n').ToList();
        }

        public static string SendQuery(string whoIsServer, string domain)
        {
            Console.WriteLine($"SENDING QUERY TO {whoIsServer}");
            try
            {
                TcpClient client = new TcpClient(whoIsServer, 43);
                NetworkStream netStream = client.GetStream();
                byte[] domainByte = Encoding.ASCII.GetBytes(domain + "\n");
                netStream.Write(domainByte, 0, domainByte.Length);
                StreamReader reader = new StreamReader(client.GetStream(), Encoding.ASCII);
                string log = "";
                do
                {
                    log += (char)reader.Read();
                } while (netStream.DataAvailable);

                return log;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }
}