using System;
using System.Diagnostics;
using System.Threading;

namespace Physical_Game
{
    public class Program
    {
        static bool isPlaying = true;
        public static void Main()
        {
            HardwareInteraction hardware = new();
            hardware.ToggleLed(HardwareInteraction.TOGGLE_ALL);
            Thread.Sleep(1000);
            hardware.ToggleLed(HardwareInteraction.TOGGLE_ALL);
            hardware.ToggleLed(3);

            while(isPlaying)
            {
                if (hardware.GetInput() == 3)
                {
                    GameLogic game = new GameLogic(hardware);
                }
                else if(hardware.GetInput() == 0)
                {
                    isPlaying = false;
                }
            }

        }
    }
}
