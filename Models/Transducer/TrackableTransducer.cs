using Contracts;
using Data.Transducer;
using FusApi.Contracts;
using FusApi.Contracts.Transducer;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Transducer
{
    class TrackableTransducer : ILocatable<TransducerLocation>
    {
        private readonly IEventAggregator _eag;
        private readonly IFusApi _fusApi;

        public TrackableTransducer(IEventAggregator eag, IFusApi fusApi)
        {
            _eag = eag;
            _fusApi = fusApi;
        }

        public bool CanLocate => _fusApi.ProcessRequest<bool>(new CanLocateTransducerRequest());

        public TransducerLocation Location => _fusApi.ProcessRequest<TransducerLocation>(new TransducerLocationRequest());

        public event EventHandler CanLocateChanged;
        public event EventHandler LocationChanged;

        public Task<bool> LocateAsync()
        {
            _eag.GetEvent<>
        }
    }
}
