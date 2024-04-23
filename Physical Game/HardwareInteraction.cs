using System;
using System.Device.Gpio;

namespace Physical_Game
{
    public class HardwareInteraction
    {
        GpioController controller;
        GpioPin led0;
        GpioPin led1;
        GpioPin led2;
        GpioPin led3;
        GpioPin led4;
        GpioPin led5;
        GpioPin led6;
        GpioPin button0;
        GpioPin button1;
        GpioPin button2;
        GpioPin button3;
        GpioPin button4;
        GpioPin button5;
        GpioPin button6;
        HardwareInteraction()
        {
            controller = new GpioController();
            led0 = controller.OpenPin(4, PinMode.Output);
            led1 = controller.OpenPin(16, PinMode.Output);
            led2 = controller.OpenPin(17, PinMode.Output);
            led3 = controller.OpenPin(5, PinMode.Output);
            led4 = controller.OpenPin(18, PinMode.Output);
            led5 = controller.OpenPin(19, PinMode.Output);
            led6 = controller.OpenPin(21, PinMode.Output);
            button0 = controller.OpenPin(32, PinMode.InputPullDown);
            button1 = controller.OpenPin(33, PinMode.InputPullDown);
            button2 = controller.OpenPin(25, PinMode.InputPullDown);
            button3 = controller.OpenPin(26, PinMode.InputPullDown);
            button4 = controller.OpenPin(27, PinMode.InputPullDown);
            button5 = controller.OpenPin(13, PinMode.InputPullDown);
            button6 = controller.OpenPin(22, PinMode.InputPullDown);
        }

        public void ToggleLed(int ledNumber)
        {
            switch (ledNumber)
            {
                case 0:
                    led0.Toggle();
                    break;
                case 1:
                    led1.Toggle();
                    break;
                case 2:
                    led2.Toggle();
                    break;
                case 3:
                    led3.Toggle();
                    break;
                case 4:
                    led4.Toggle();
                    break;
                case 5:
                    led5.Toggle();
                    break;
                case 6:
                    led6.Toggle();
                    break;
                default:
                    break;
            }
        }
    }
}
