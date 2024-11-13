using System.Windows.Forms;
using Python.Runtime;

namespace Embedding_Python_Into_Csharp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnGenerateChart;
        private PictureBox pictureBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnGenerateChart = new Button();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnGenerateChart
            // 
            btnGenerateChart.Location = new Point(10, 10);
            btnGenerateChart.Name = "btnGenerateChart";
            btnGenerateChart.Size = new Size(150, 34);
            btnGenerateChart.TabIndex = 0;
            btnGenerateChart.Text = "Generate Chart";
            btnGenerateChart.Click += BtnGenerateChart_Click;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(10, 50);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(760, 500);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // Form1
            // 
            ClientSize = new Size(782, 553);
            Controls.Add(btnGenerateChart);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Python.NET WinForms Example";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }
    }
}
