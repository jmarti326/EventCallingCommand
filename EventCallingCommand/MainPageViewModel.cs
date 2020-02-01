using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace EventCallingCommand
{
    public class MainPageViewModel
    {
        public bool ToggleState { get; set; }

        public MainPageViewModel()
        {
        }

        public Command OnSwitchStateChange => new Command((state) =>
        {
            this.ToggleState = (bool)state;
        });
    }
}
