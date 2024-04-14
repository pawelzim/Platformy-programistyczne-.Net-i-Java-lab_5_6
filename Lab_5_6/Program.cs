using Lab_5_6;

namespace Lab_3_4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new MatrixThreadMultiplication());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MatrixThreadMultiplication mainForm = new MatrixThreadMultiplication();
            MatrixParallelMultiplication mainForm2 = new MatrixParallelMultiplication();
            Application.Run(mainForm);

            while (mainForm.NextForm != null)
            {
                Form nextForm = mainForm.NextForm;
                mainForm = null;
                Application.Run(nextForm);
            }
        }
    }
}