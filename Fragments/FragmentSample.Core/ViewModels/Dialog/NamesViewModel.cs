using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace FragmentSample.Core.ViewModels.Dialog
{
    public class NamesViewModel : BaseViewModel
    {
        private string _firstName;
        private string _lastName;
        private ICommand mCloseCommand;

        public NamesViewModel()
        {
            _firstName = "Mvvm";
            _lastName = "Cross";
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                RaisePropertyChanged(() => FirstName);
                RaisePropertyChanged(() => FullName);
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                RaisePropertyChanged(() => LastName);
                RaisePropertyChanged(() => FullName);
            }
        }

        public string FullName
        {
            get { return string.Format(@"{0} {1}", _firstName, _lastName); }
        }

        public ICommand CloseCommand
        {
            get
            {
                mCloseCommand = mCloseCommand ?? new MvxCommand(CloseDialog);
                return mCloseCommand;
            }
        }

        private void CloseDialog()
        {
            int x = 9;
            x++;
        }

    }
}