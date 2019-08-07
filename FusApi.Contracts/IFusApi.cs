using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusApi.Contracts
{
    public interface IFusApi
    {
        T ProcessRequest<T>(FusApiRequest request);
        void ProcessRequest(FusApiRequest request);
    }
}
