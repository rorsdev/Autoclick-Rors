using System;
using System.Windows.Forms;

class Program
{
  static void Main(string[] args)
  {
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

    Form miVentana = new Form();
    miVentana.Text = "Mi ventana C#";

    Application.Run(miVentana); // Mantiene la ventana abierta
}
}