using MahAppsSamples.Infrastructures;
using System;
using System.Windows.Input;

namespace MahAppsSamples.ViewModels
{
    class ButtonsPageViewModel : MyBindableBase
    {
        public int Counter
        {
            get => _counter;
            private set => SetProperty(ref _counter, value);
        }
        private int _counter;

        public ICommand IncrememtCounterCommand => _incrememtCounterCommand ??=
            new MyCommand(() => ++Counter);
        private ICommand? _incrememtCounterCommand;

        public bool CanUseToggleSwitch
        {
            get => _canUseToggleSwitch;
            set => SetProperty(ref _canUseToggleSwitch, value);
        }
        private bool _canUseToggleSwitch;

        public ButtonsPageViewModel() { }

    }
}
