using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQListener
{
    public static class RabbitMQSetting
    {
        //public static string hostName = "35.247.178.47";
        //public static string username = "admin";
        //public static string password = "indocyber";
        //public static string exchangeName = "LOS.E.Direct.Leads";
        public static string queueNameLeads = "LOS.Q.Leads";
        public static string queueNamePerformanceTest7 = "LOS.Q.PerformanceTest.7";
        public static string queueNamePerformanceTest8 = "LOS.Q.PerformanceTest.8";
        //public static string routingKey = "Leads";
        //public static string message = "Test Leads";
    }
}
