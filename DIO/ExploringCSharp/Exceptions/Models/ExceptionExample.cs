using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    public class ExceptionExample
    {
        public void MethodI()
        {
            try
            {
                MethodIV();
            } catch(Exception)
            {
                Console.WriteLine("Exception treated");
            }
        }
        public void MethodII()
        {
            MethodIII();
        }
        public void MethodIII()
        {
            MethodIV();
        }
        public void MethodIV()
        {
            throw new Exception("An exception occurred");
        }
    }
}