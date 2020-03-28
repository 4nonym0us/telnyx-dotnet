﻿namespace Telnyx
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CallControlSpeakService
    /// </summary>
    public class CallControlSpeakService : Service<CallSpeakResponse>,
        INestedCreatableWithIdInMid<CallSpeakResponse, CallControlSpeakCreateOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallControlSpeakService"/> class.
        /// </summary>
        public CallControlSpeakService()
        : base(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallControlSpeakService"/> class.
        /// </summary>
        /// <param name="apiKey">api key</param>
        public CallControlSpeakService(string apiKey)
            : base(apiKey)
        {
        }

        /// <inheritdoc/>
        public override string BasePath => "/calls/{PARENT_ID}/actions/speak";

        /// <inheritdoc/>
        public virtual CallSpeakResponse Create(string id, CallControlSpeakCreateOptions options, string postFix = "actions/speak", RequestOptions requestOptions = null)
        {
            return this.CreateEntity(id, postFix, options, requestOptions);
        }

        /// <inheritdoc/>
        public Task<CallSpeakResponse> CreateAsync(string parentId, CallControlSpeakCreateOptions createOptions, string postFix = "actions/speak", RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(parentId, postFix, createOptions, requestOptions, cancellationToken);
        }
    }
}