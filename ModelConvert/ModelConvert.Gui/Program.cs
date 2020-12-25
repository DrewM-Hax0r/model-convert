using ModelConvert.Abstractions;
using ModelConvert.Gui.Forms;
using System;
using System.Windows.Forms;

namespace ModelConvert.Gui
{
    static class Program
    {
        internal static IDependencyFactory DependencyFactory { get; } = DependencyResolution.Builder.GetFactory();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ModelConversion());
        }
    }
}