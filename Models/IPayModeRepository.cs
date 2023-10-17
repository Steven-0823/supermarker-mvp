using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp1.Models
{
    internal interface IPayModeRepository
    {
        void add(PayModeModel payModeModel);
        void edit(PayModeModel payModeModel);
        void Delete(int id);

        IEnumerable<PayModeModel> GetAll();
        IEnumerable<PayModeModel> GetByValue(string value);
    }
}
