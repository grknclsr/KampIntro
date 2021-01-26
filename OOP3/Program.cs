using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            RequirementManager requirementManager = new RequirementManager();
            TransportCrediManager transportCrediManager = new TransportCrediManager();
            HouseCrediManager houseCrediManager = new HouseCrediManager();
            ArtisanManager artisanManager = new ArtisanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoogerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { smsLoogerService,databaseLoggerService,fileLoggerService };
            List<ICrediManager> credits = new List<ICrediManager>() { requirementManager, transportCrediManager, houseCrediManager, artisanManager };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(artisanManager, loggers);


           
            
            //applicationManager.MakeCreditInformation(credits);
        }
    }
}
