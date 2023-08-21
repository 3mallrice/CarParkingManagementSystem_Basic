using DataObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IBaixeRepository
    {
        public List<Baixe> GetBaiXe();

        List<Baixe> SearchProduct(string keyword, string type);
    }
}
