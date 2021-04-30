using System;
using System.Collections.Generic;
using System.Text;

namespace Hw3
{
    class CampaignControlManager : IControlManager
    {
        void IControlManager.Delete()
        {
            Console.WriteLine("Kampanya silindi");
        }

        void IControlManager.SignUp()
        {
            Console.WriteLine("Kampanya girişi yapıldı");
        }

        void IControlManager.Update()
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
