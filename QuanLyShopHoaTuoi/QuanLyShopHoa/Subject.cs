using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QuanLyShopHoa
{
    internal class Subject
    {
        private ArrayList observers = new ArrayList();
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }
        public void Detach(String id)
        {
            foreach (Observer observer in observers)
            {
               if (observer.Getdpc().getId() == id)
                {
                    observers.Remove(observer);
                }
            }
            
        }

        public void Excute()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }

    }
}
