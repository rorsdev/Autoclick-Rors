using System.Windows.Forms;
using AutoclickRors;

class Program
{
  static void Main(string[] args)
  {
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

    Form mainWindow = new MainWindow();
    // Mantiene la ventana abierta
    Application.Run(mainWindow); 
  }
}