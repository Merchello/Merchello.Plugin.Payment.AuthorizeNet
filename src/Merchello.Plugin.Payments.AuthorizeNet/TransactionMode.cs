﻿namespace Merchello.Plugin.Payments.AuthorizeNet
{
    /// <summary>
    /// Represents Authorize.Net payment processor transaction mode
    /// </summary>
    public enum TransactionMode
    {
        /// <summary>
        /// An Authorize transaction
        /// </summary>
        Authorize,

        /// <summary>
        /// An Authorize and Capture transaction
        /// </summary>
        AuthorizeAndCapture
    }
}