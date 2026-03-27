
namespace ARM.Core.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _title = "ARM System";

        public string Title 
        { 
            get => _title;  
            set 
            { 
                _title = value;
                OnPropertyChanged();
            } 
        }
    }
}
