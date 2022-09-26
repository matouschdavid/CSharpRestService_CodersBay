using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro
{
    internal class Downloader
    {
        public delegate string OnDownloadFinishedHandler();
        OnDownloadFinishedHandler registeredHandlers;
        public void StartDownload()
        {
            //Do something
            if (registeredHandlers != null)
                registeredHandlers();
        }

        public void RegisterForDownloadFinished(OnDownloadFinishedHandler onFinished)
        {
            registeredHandlers += onFinished;
        }
    }
}
