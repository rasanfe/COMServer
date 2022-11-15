using System;
using System.Runtime.InteropServices;  //Espacio de Nombres

namespace COMServer
{
    [ComVisible(true)]  // Atributos
    [Guid(ContractGuids.ServerClass)]  //Este atributo esta definido en una nuieva clase
    public interface IServer
    {
        public double ComputePi();

    }
}
