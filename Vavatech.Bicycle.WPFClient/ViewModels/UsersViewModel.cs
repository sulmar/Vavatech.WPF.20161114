using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.Bicycle.Interfaces;
using Vavatech.Bicycle.Models;
using Vavatech.Bicycle.WPFClient.ViewModels;
using Vavatech.Bicykle.MockServices;

namespace Vavatech.Bicycle.WPFClient.ViewModels
{
    public class UsersViewModel : ItemsViewModel<User, IUsersService>
    {
        public UsersViewModel()
            : base(new MockUsersService())
        {
        }
    }
}
