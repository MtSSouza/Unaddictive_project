using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Unaddictive_project
{
    class Protection : AbstractReferee
    {
        public bool generate = false;
        private string[] eChars = {"@", "!", "#", "$", "%", "&"};
        public override void Reference()
        {
            if (generate)
            {
                Debug.WriteLine(eChars[3]);
            }
        }
       
    }
}
