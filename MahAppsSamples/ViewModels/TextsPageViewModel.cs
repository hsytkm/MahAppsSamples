using MahAppsSamples.Infrastructures;
using System;
using System.ComponentModel;

namespace MahAppsSamples.ViewModels
{
    class TextsPageViewModel : MyBindableBase, IDataErrorInfo
    {
        public int? IntegerGreater10Property
        {
            get => _integerGreater10Property;
            set => SetProperty(ref _integerGreater10Property, value);
        }
        private int? _integerGreater10Property;

        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(IntegerGreater10Property))
                {
                    if (IntegerGreater10Property < 10) return "Number is not greater than 10!";
                }
                return "";
            }
        }
        public string Error => "";

        public TextsPageViewModel() { }
    }
}
