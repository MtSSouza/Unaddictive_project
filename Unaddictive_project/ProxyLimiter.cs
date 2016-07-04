using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Unaddictive_project
{
    //behaviormodel.org/
    class ProxyLimiter : AbstractReferee
    {
        public override void Reference()
        {
            string date = DateTime.Now.ToString("g");
            if (date == "03/07/2016 22:45")
            {
                Debug.WriteLine("Vai funfar");
            }
        }

        public void loc()
        {
            string allReaded = File.ReadAllText(@"c:\testfolder\passfile");
            Debug.WriteLine(allReaded);
            char[] spliter = { ' ' };

            string[] lines = allReaded.Split(spliter);

            foreach (string l in lines)
            {
                Debug.WriteLine(l);
            }
        }
    }
}
