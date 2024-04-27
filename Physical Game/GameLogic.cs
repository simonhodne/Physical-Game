using System;
using System.Threading;
using System.Diagnostics;

namespace Physical_Game
{
    public class GameLogic
    {
        #region Variables
        
        HardwareInteraction hardware;
        Random random;
        Stopwatch stopWatch;
        bool isRunning = true;
        int currentButton;
        int currentTimeLimit = 2000;
        long time;

        #endregion

        #region Functions
        public GameLogic(HardwareInteraction hardwareInstance)
        {
            hardware = hardwareInstance;
            random = new Random();
            StartGame();
        }
        
        void StartGame()
        {
            hardware.ToggleLed(HardwareInteraction.CENTER_LED);
            Thread.Sleep(1000);
            hardware.FlashLed(HardwareInteraction.CENTER_LED, 3, 500, hardware);
            stopWatch = new();
            RunGame();
        }
        void RunGame()
        {
            stopWatch.Start();
            while(isRunning)
            {
                currentButton = random.Next(7);
                hardware.ToggleLed(currentButton);
                time = stopWatch.ElapsedMilliseconds;

                if(hardware.GetInput() != currentButton)
                {
                    isRunning = false;
                }

                if(time + currentTimeLimit < stopWatch.ElapsedMilliseconds)
                {
                    isRunning = false;
                }
                if(currentTimeLimit > 1000)
                {
                    currentTimeLimit -= 50;
                }
                hardware.ToggleLed(currentButton);
                Thread.Sleep(500);
            }
            EndGame();
        }
        void EndGame()
        {
            stopWatch.Stop();
            hardware.FlashLed(HardwareInteraction.TOGGLE_ALL, 2, 500, hardware);
            hardware.ToggleLed(HardwareInteraction.CENTER_LED);
        }
        #endregion
    }
}
