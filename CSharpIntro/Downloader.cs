using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro
{
    internal class Downloader
    {
        //Action<string> is a predefined delegate
        //A delegate is a collection of methods that can be executed with one call.
        Action<string> registeredHandlers;
        public void StartDownload()
        {
            //Do something
            //Check if we have methods registered
            if (registeredHandlers != null)
                //Call all methods
                registeredHandlers("Hello");
        }

        public void RegisterForDownloadFinished(Action<string> onFinished)
        {
            //With += we can add methods to our list of methods
            //With = we would overwrite it and only have the new method stored
            registeredHandlers += onFinished;
        }
    }
}
