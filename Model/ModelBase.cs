using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBase.Model
{
   public class ModelBase
    {
        private bool _Status;
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }


        private DateTime _CreateDate;

        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

    }
}
