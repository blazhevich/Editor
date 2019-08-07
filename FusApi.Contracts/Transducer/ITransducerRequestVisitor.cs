using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusApi.Contracts.Transducer
{
    public interface ITransducerRequestVisitor
    {
        void Visit(CanLocateTransducerRequest request);
        void Visit(TransducerLocationRequest request);
        void Visit(LocateTransducerRequest request);
    }
}
