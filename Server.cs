using System;
using System.Runtime.InteropServices;

namespace COMServer
{
    [ComVisible(true)]  //---  ATRIBUTO
    [Guid(ContractGuids.ServerClass)] //-->Este Atributo esta definido en una nueva clase
    public class Server : IServer
    {
        public Server() { }   //--------------> MUY IMPORTANTE CONSTRUCTOR VACIO
        /// </summary>
        /// <returns></returns>
        public double ComputePi()
        {
            double sum = 0.0;
            int sign = 1;
            for (int i = 0; i < 1024; ++i)
            {
                sum += sign / (2.0 * i + 1.0);
                sign *= -1;
            }

            return 4.0 * sum;
        }
    }
}
