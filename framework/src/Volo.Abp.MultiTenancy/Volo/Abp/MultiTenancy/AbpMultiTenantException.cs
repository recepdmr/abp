using System;
using System.Runtime.Serialization;

namespace Volo.Abp.MultiTenancy.Volo.Abp.MultiTenancy
{
    /// <summary>
    /// Base exception type for those are Abp Multi Tenant.
    /// </summary>
    public class AbpMultiTenantException : AbpException
    {
        /// <summary>
        /// Creates a new <see cref="AbpMultiTenantException"/> object.
        /// </summary>
        public AbpMultiTenantException()
        {

        }

        /// <summary>
        /// Creates a new <see cref="AbpMultiTenantException"/> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        public AbpMultiTenantException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// Creates a new <see cref="AbpMultiTenantException"/> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception</param>
        public AbpMultiTenantException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

        /// <summary>
        /// Constructor for serializing.
        /// </summary>
        public AbpMultiTenantException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {

        }
    }
}
