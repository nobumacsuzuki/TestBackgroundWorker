using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TestBackgroundWorker
{
    internal class DemandingWork
    {
        static int DummyLoadTimeInMsec = 500;
        static int AmountOfWork = 20;
        public DemandingWork() 
        { }
        public void DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int countWork = 0; countWork < AmountOfWork; countWork++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    System.Threading.Thread.Sleep(DummyLoadTimeInMsec);
                    int progressPercentage = countWork * 100 / AmountOfWork;
                    worker.ReportProgress(progressPercentage);
                }
            }
        }
    }
}
