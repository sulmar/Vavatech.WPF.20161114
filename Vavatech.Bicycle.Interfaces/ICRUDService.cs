using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.Bicycle.Interfaces
{
    public interface ICrudService<TItem>
    {
        IList<TItem> Get();

        Task<IList<TItem>> GetAsync();

        TItem Get(int itemId);

        void Add(TItem item);

        void Update(TItem item);

        void Remove(int itemId);
    }
}
