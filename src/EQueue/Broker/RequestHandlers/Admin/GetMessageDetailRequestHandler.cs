﻿using System.Collections.Generic;
using ECommon.Components;
using ECommon.Remoting;
using ECommon.Serializing;
using EQueue.Protocols;
using EQueue.Utils;

namespace EQueue.Broker.RequestHandlers.Admin
{
    public class GetMessageDetailRequestHandler : IRequestHandler
    {
        private readonly IMessageStore _messageStore;
        private readonly IBinarySerializer _binarySerializer;

        public GetMessageDetailRequestHandler()
        {
            _messageStore = ObjectContainer.Resolve<IMessageStore>();
            _binarySerializer = ObjectContainer.Resolve<IBinarySerializer>();
        }

        public RemotingResponse HandleRequest(IRequestHandlerContext context, RemotingRequest remotingRequest)
        {
            return null;
            //TODO
            //var request = _binarySerializer.Deserialize<GetMessageDetailRequest>(remotingRequest.Body);
            //var message = _messageStore.FindMessage(request.MessageOffset, request.MessageId);
            //var messages = new List<QueueMessage>();
            //if (message != null)
            //{
            //    messages.Add(message);
            //}
            //return RemotingResponseFactory.CreateResponse(remotingRequest, _binarySerializer.Serialize(messages));
        }
    }
}
