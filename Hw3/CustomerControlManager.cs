using System;
using System.Collections.Generic;
using System.Text;

namespace Hw3
{
    class CustomerControlManager:IControlManager
    {
        
        void IControlManager.Delete()
        {
            Console.WriteLine("Kullanıcı sistemden silindi");
            
        }

        void IControlManager.SignUp()
        {
            Console.WriteLine("Kullacını sisteme kayıt edildi");
        }

        void IControlManager.Update()
        {
            Console.WriteLine("Kullanıcı bilgileri güncellendi.");
        }
    }
}
