using Python.Runtime;

namespace Embedding_Python_Into_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                MessageBox.Show("Setting PythonDLL...");
                Runtime.PythonDLL = @"C:\Users\MinhThanh\AppData\Local\Programs\Python\Python310\python310.dll";

                MessageBox.Show("Setting PythonHome...");
                PythonEngine.PythonHome = @"C:\Users\MinhThanh\AppData\Local\Programs\Python\Python310";

                MessageBox.Show("Setting TCL_LIBRARY...");
                string tclLibraryPath = System.IO.Path.Combine(PythonEngine.PythonHome, "tcl", "tcl8.6");
                Environment.SetEnvironmentVariable("TCL_LIBRARY", tclLibraryPath);

                MessageBox.Show("Setting PythonPath...");
                PythonEngine.PythonPath = string.Join(";", new[] {
                    PythonEngine.PythonHome,
                    System.IO.Path.Combine(PythonEngine.PythonHome, "Lib"),
                    System.IO.Path.Combine(PythonEngine.PythonHome, "DLLs"),
                    System.IO.Path.Combine(PythonEngine.PythonHome, "tcl"),
                    System.IO.Path.Combine(PythonEngine.PythonHome, "Lib", "site-packages")
                });

                MessageBox.Show("Initializing Python...");
                if (!PythonEngine.IsInitialized)
                {
                    PythonEngine.Initialize();
                }
                MessageBox.Show("Python initialized successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to initialize Python: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGenerateChart_Click(object sender, EventArgs e)
        {
            string outputFilePath = "output_chart.png";

            try
            {
                // Ensure Python is initialized before using it
                if (!PythonEngine.IsInitialized)
                {
                    MessageBox.Show("Python is not initialized. Initializing now...");
                    PythonEngine.Initialize();
                }

                // Sử dụng Python runtime để vẽ biểu đồ
                using (Py.GIL())
                {
                    dynamic sys = Py.Import("sys");
                    // Thêm đường dẫn chứa `drawing_script.py`
                    sys.path.append(@"C:\Users\MinhThanh\Desktop\Embedding-Python-Into-Csharp\Embedding-Python-Into-Csharp\Embedding-Python-Into-Csharp\bin\Debug\net8.0-windows");
                    dynamic pyScript = Py.Import("drawing_script");
                    pyScript.draw_chart(outputFilePath); // Gọi hàm Python
                }

                // Hiển thị biểu đồ
                if (System.IO.File.Exists(outputFilePath))
                {
                    pictureBox.Image = Image.FromFile(outputFilePath);
                }
                else
                {
                    MessageBox.Show("Chart generation failed!");
                }
            }
            catch (PythonException pyEx)
            {
                MessageBox.Show($"Python error: {pyEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Any additional initialization code can go here
        }
    }
}
