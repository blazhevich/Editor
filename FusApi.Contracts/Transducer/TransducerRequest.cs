using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusApi.Contracts.Transducer
{
    public abstract class TransducerRequest : FusApiRequest<ITransducerRequestVisitor>
    {
    }
}
