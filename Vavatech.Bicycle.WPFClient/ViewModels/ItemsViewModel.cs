using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.Bicycle.Interfaces;
using Vavatech.Bicycle.Models;

namespace Vavatech.Bicycle.WPFClient.ViewModels
{
    public abstract class ItemsViewModel<TItem, TItemsService> : BaseViewModel
        where TItem : Base
        where TItemsService : ICrudService<TItem>
    {
        public IList<TItem> Items { get; set; }

        public TItem SelectedItem { get; set; }

        protected readonly TItemsService _Service;

        public ItemsViewModel(TItemsService service)
        {
            _Service = service;

            Items = _Service.Get();
        }
    }
}
