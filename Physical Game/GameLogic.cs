using System;
using System.Threading;


namespace Physical_Game
{
    public class GameLogic
    {
        HardwareInteraction hardware;
        Random random;
        bool isRunning = true;
        int currentButton;
        public GameLogic(HardwareInteraction hardwareInstance)
        {
            hardware = hardwareInstance;
            random = new Random();
            StartGame();
        }
        
        void StartGame()
        {
            hardware.ToggleLed(3);
            Thread.Sleep(1000);
            hardware.ToggleLed(3);
            Thread.Sleep(500);
            hardware.ToggleLed(3);
            Thread.Sleep(500);
            hardware.ToggleLed(3);
            Thread.Sleep(500);
            hardware.ToggleLed(3);
            Thread.Sleep(500);
            hardware.ToggleLed(3);
            Thread.Sleep(500);
            hardware.ToggleLed(3);
            RunGame();
        }
        void RunGame()
        {
            while(isRunning)
            {
                currentButton = random.Next(7);
                hardware.ToggleLed(currentButton);
                if(hardware.GetInput() != currentButton)
                {
                    isRunning = false;
                }
                hardware.ToggleLed(currentButton);
                Thread.Sleep(500);
            }
        }
    }
}
