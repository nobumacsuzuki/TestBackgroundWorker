using System.ComponentModel;

namespace TestBackgroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelProgress.Text = $"Not Started";
        }

        private void OnBgWkrTestProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            labelProgress.Text = $"Progress: {e.ProgressPercentage.ToString()}% completed";
        }

        private void OnBgWkrTestRunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                labelProgress.Text = $"Canceled";
            }
            else if (e.Error != null)
            {
                labelProgress.Text = $"Error: {e.Error.Message}";
            }
            else
            {
                labelProgress.Text = $"Completed";
            }
        }

        private void OnBtnStartClick(object sender, EventArgs e)
        {
            if (backgroundWorkerTest.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorkerTest.RunWorkerAsync();
            }
        }

        private void OnBtlCancelClick(object sender, EventArgs e)
        {
            if (backgroundWorkerTest.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorkerTest.CancelAsync();
            }
        }
    }
}
