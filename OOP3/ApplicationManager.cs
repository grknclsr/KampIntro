using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void MakeApplication(ICrediManager crediManager,List<ILoggerService> loggerServices)
        {
            
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            crediManager.Calculate();

        }

        public void MakeCreditInformation(List<ICrediManager> credits)
        {
            foreach (var credi in credits)
            {
                credi.Calculate();
            }
        }
    }
}
