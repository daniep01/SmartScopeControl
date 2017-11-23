using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Globalization;



namespace SmartScopeControl
{
    public class Scopes
    {
        int ScopePort = 9800;
        Socket syncsender;

        public Boolean connected = false;
        //String deviceName = "";
        //Dictionary<String, String> commandList = new Dictionary<String, String>();
        //List<String> readOnlyGroup = new List<string>();

        public void connect(string address)
        {
            Console.WriteLine("connect...");
            try
            {
                IPAddress ipAddress = IPAddress.Parse(address);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, ScopePort);

                syncsender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                syncsender.SendTimeout = 10;
                syncsender.ReceiveTimeout = 100;

                // establish connection 
                syncsender.Connect(remoteEP);
                syncsendreceive("\n");
                
                connected = true;
            }
        catch(Exception e) {
                Console.WriteLine("error in connection");
                System.Windows.Forms.MessageBox.Show(e.Message);
                }
        }

        public void disconnect()
        {
            // check for connection
            if (syncsender == null || syncsender.Connected == false)
            {
                Console.WriteLine("Not connected");
                return;
            }

            syncsender.Shutdown(SocketShutdown.Both);
            syncsender.Close();
            syncsender = null;
            connected = false;

            Console.WriteLine("Disconnected");
        }

        public void syncsendreceive(string command, int waitTime = 500)
        {
            // check for connection
            if (syncsender == null || syncsender.Connected == false)
            {
                Console.WriteLine("Not connected");
                return;
            }

           try
            {
                // send
                Console.WriteLine("Send > {0}", command);
                
                byte[] msg = Encoding.ASCII.GetBytes(command);
                int bytessent = syncsender.Send(msg);

                // wait
                System.Threading.Thread.Sleep(waitTime);

                // receive
                byte[] bytes = new byte[8192];
                int bytesReceived = 0;
                
                string response = null;

                bytesReceived = syncsender.Receive(bytes);
                Console.WriteLine("bytesReceived {0} bytes", bytesReceived);

                if (bytesReceived > 0)
                {
                    response = Encoding.ASCII.GetString(bytes, 0, bytesReceived);
                    Console.WriteLine(response);
                }

                return;

            }
            catch (Exception e) 
            {
                Console.WriteLine("Error in sync send");
                Console.WriteLine(e.Message);
                return;
            }

        }

    }
}
