using System;
using System.Drawing;
using System.Windows.Forms;
using AutoclickRors.Utils;

namespace AutoclickRors;

public class MainWindow : Form
{

  private Button startButton;
  private Button stopButton;

  private TextBox tittle;
  private TextBox inputClicks;

  public MainWindow()
  {
    // Configuración básica ventana
    Text = AppConstants.AppName;
    Width = 500;
    Height = 500;
    BackColor = ColorPalette.Secundario;

    startButton = new Button();
    startButton.Text = "Start (F6)";
    startButton.Width = 150;
    startButton.Height = 40;
    startButton.Top = 250;
    startButton.Left = 175;
    startButton.BackColor = ColorPalette.Acento;

    stopButton = new Button();
    stopButton.Text = "Stop (F7)";
    stopButton.Width = 150;
    stopButton.Height = 40;
    stopButton.Top = 310;
    stopButton.Left = 175;
    stopButton.BackColor = ColorPalette.Acento;

    tittle = new TextBox();
    tittle.Text = AppConstants.AppName;
    tittle.TextAlign = HorizontalAlignment.Center;
    tittle.Top = 20;
    tittle.Left = 30;
    tittle.Width = 300;
    tittle.Font = new Font(tittle.Font.FontFamily, 25);
    tittle.ReadOnly = true;
    // tittle.

    inputClicks = new TextBox();
    inputClicks.Top = 100;
    inputClicks.Left = 50;
    inputClicks.Width = 250;

    Controls.Add(startButton);
    Controls.Add(stopButton);
    Controls.Add(tittle);
    Controls.Add(inputClicks);
  }
}
