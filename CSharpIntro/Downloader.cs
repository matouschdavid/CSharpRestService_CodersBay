using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro
{
    internal class Downloader
    {
        Action<string> registeredHandlers;
        public void StartDownload()
        {
            //Do something
            if (registeredHandlers != null)
                registeredHandlers("Hello");
        }

        public void RegisterForDownloadFinished(Action<string> onFinished)
        {
            registeredHandlers += onFinished;
        }
    }
}
