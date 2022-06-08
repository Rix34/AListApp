using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace AListAppUI.ViewModels
{
    public class ShellViewModel : Conductor<Object>
    {
        LoginFormViewModel _loginVM;

        public ShellViewModel (LoginFormViewModel loginVM)
        {
            _loginVM = loginVM;
            ActivateItemAsync(loginVM);

        }

    }
}
