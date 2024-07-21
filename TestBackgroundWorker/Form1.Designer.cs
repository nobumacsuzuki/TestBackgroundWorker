using System.ComponentModel;

namespace TestBackgroundWorker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonStart = new Button();
            buttonCancel = new Button();
            labelProgress = new Label();
            backgroundWorkerTest = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(112, 219);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(112, 34);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += OnBtnStartClick;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(350, 219);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += OnBtlCancelClick;
            // 
            // labelProgress
            // 
            labelProgress.AutoSize = true;
            labelProgress.Location = new Point(86, 43);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(59, 25);
            labelProgress.TabIndex = 2;
            labelProgress.Text = "label1";
            // 
            // backgroundWorkerTest
            // 
            backgroundWorkerTest.WorkerReportsProgress = true;
            backgroundWorkerTest.WorkerSupportsCancellation = true;
            backgroundWorkerTest.DoWork += delegate (object sender, DoWorkEventArgs e)
            {
                demandingWork.DoWork(sender, e);
            };
            backgroundWorkerTest.ProgressChanged += bgWkrTestProgressChanged;
            backgroundWorkerTest.RunWorkerCompleted += bgWkrTestRunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelProgress);
            Controls.Add(buttonCancel);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Backgroundworker Test";
            ResumeLayout(false);
            PerformLayout();
            //
            demandingWork = new DemandingWork();
        }

        #endregion

        private Button buttonStart;
        private Button buttonCancel;
        private Label labelProgress;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTest;
        private DemandingWork demandingWork;
    }
}
