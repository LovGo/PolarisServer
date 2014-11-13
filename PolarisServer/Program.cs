﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

using PolarisServer.Resource;

namespace PolarisServer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Arf");
            Logger.WriteInternal("Server started at " + DateTime.Now.ToString());
            ResourceManager.Init();
            Packets.Handlers.PacketHandlers.loadPacketHandlers();
            for (int i = 0; i < 10; i++)
            {
                new QueryServer(QueryMode.ShipList, 12099 + (100 * i));
            }
            new Server().Run();
        }
    }
}
