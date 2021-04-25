using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBase.DataAccess
{
     interface IBase
    {
          object Add(object o);
         object Delete(object o);
         object Modify(object o);
         object Get(object o);
        object GetList(object o);
    }
}
