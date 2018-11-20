using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace practice_w__pantsu
{
    interface IWearable :IItem
    {
        void Wear();
        void Remove();
    }
}
