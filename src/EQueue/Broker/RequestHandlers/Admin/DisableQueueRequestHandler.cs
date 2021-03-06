﻿using ECommon.Components;
using ECommon.Remoting;
using ECommon.Serializing;
using EQueue.Protocols;
using EQueue.Utils;

namespace EQueue.Broker.RequestHandlers.Admin
{
    public class DisableQueueRequestHandler : IRequestHandler
    {
        private IBinarySerializer _binarySerializer;
        private IQueueStore _queueService;

        public DisableQueueRequestHandler()
        {
            _binarySerializer = ObjectContainer.Resolve<IBinarySerializer>();
            _queueService = ObjectContainer.Resolve<IQueueStore>();
        }

        public RemotingResponse HandleRequest(IRequestHandlerContext context, RemotingRequest remotingRequest)
        {
            var disableQueueRequest = _binarySerializer.Deserialize<DisableQueueRequest>(remotingRequest.Body);
            _queueService.DisableQueue(disableQueueRequest.Topic, disableQueueRequest.QueueId);
            return RemotingResponseFactory.CreateResponse(remotingRequest);
        }
    }
}
