using System.ComponentModel;

namespace Square.Client.ViewModels
{
    public interface IViewModelBase : INotifyPropertyChanged
    {
        public bool IsBusy { get; set; }
    }
}
