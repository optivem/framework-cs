﻿using Optivem.Common.Http;
using Optivem.Common.Serialization;

namespace Optivem.Infrastructure.Http.System
{
    public class ValidatedJsonControllerClientFactory : IControllerClientFactory
    {
        public ValidatedJsonControllerClientFactory(IClient client, IJsonSerializationService serializationService)
        {
            Client = client;
            SerializationService = serializationService;
        }

        public IClient Client { get; private set; }

        public IJsonSerializationService SerializationService { get; private set; }

        public IControllerClient Create(string controllerUri)
        {
            return new ValidatedJsonControllerClient(Client, SerializationService, controllerUri);
        }
    }
}