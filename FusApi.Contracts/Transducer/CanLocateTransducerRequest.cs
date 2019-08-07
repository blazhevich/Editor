using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusApi.Contracts.Transducer
{
    public class CanLocateTransducerRequest : TransducerRequest
    {
        public override void Accept(ITransducerRequestVisitor v) => v.Visit(this);
    }
}
