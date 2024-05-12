using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SnakeWPF
{
    public class ScoreDisplay
    {
        private MainWindow mainWindow;  // A f�ablak, amelyben a pontsz�m megjelenik
        private Snake snake;  // A k�gy� objektum, amelynek a pontsz�m�t megjelen�tj�k

        public ScoreDisplay(MainWindow mainWindow)  // Konstruktor a ponsz�ml�l�hoz
        {
            this.mainWindow = mainWindow;
            UpdateScoreDisplay();  // Pontsz�m megjelen�t�s�nek friss�t�se a konstruktorban
        }

        public void UpdateScoreDisplay()
        {
            // A f�ablakban l�v� Score TextBox friss�t�se a k�gy� aktu�lis pontsz�m�val
            mainWindow.Score.Text ="Pontsz�m: " + mainWindow.snake.CountSegments().ToString();
        }

    }
}
