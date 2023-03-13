using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
   public class BaseClass
    {
       
    public void TryCatchKullan(Action _action)
        {
            try
            {
                _action(); 
            }
            catch(Exception ex)
            {
                
            }
        }
    }
}
