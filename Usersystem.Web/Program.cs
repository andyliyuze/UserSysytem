﻿using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usersystem.Web;

namespace UserSystem.Web
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const string uri = "http://localhost:40046/";
                //
                using (WebApp.Start<Startup>(uri))
                {
                    Console.WriteLine("Started listening on " + uri);
                    Console.ReadLine();
                    Console.WriteLine("Shutting down...");
                }
                Console.ReadLine();
            }
            catch (Exception e){ throw e; }
        }
    }
}
