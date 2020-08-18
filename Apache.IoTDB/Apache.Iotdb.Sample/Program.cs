using System;
using Thrift.Transport;
using Thrift.Protocol;
using Thrift;
using Apache.IoTDB.Service.Rpc.Thrift;
using System.Net.Sockets;
using Thrift.Transport.Client;

namespace Apache.Iotdb.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            startClient();

            Console.ReadKey();
        }


        public async static void startClient()
        {
          

            TTransport transport = null;
            try
            {
                string ip = "127.0.0.1";
                string port = "6667";
                string username = "root";
                string password = "root";
                // Make socket
                transport = new TSocketTransport(ip, int.Parse(port));
                if (!transport.IsOpen) {
                   await transport.OpenAsync();
                }
                TProtocol protocol = new TCompactProtocol(transport);
               
                TSIService.Client client = new TSIService.Client(protocol);

             

                var result = await client.openSessionAsync(new TSOpenSessionReq()
                { 
                    Client_protocol= TSProtocolVersion.IOTDB_SERVICE_PROTOCOL_V2,
                    Username = username,
                    Password =password
                });


                //await client.testInsertTabletAsync(new TSInsertTabletReq()
                //{
                //    DeviceId = "11",
                //    Measurements = new System.Collections.Generic.List<string>()
                //     {
                //          "001"
                //     },
                //    SessionId = result.SessionId,
                //    Size = 10,
                //    Timestamps =new byte[] { Convert.ToByte(DateTime.Now) },
                //    Values = new byte[] { Convert.ToByte(2.33d) }
                //});
                Console.WriteLine("Thrift client result =: " + result.SessionId);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                if (null != transport)
                {
                    //close
                    transport.Close();
                }
            }

        }
    }
}
