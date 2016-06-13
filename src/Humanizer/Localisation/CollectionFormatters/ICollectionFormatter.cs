using System;
using System.Collections.Generic;

namespace Humanizer.Localisation.CollectionFormatters
{
    /// <summary>
    /// An interface you should implement to localize Humanize for collections
    /// </summary>
    public interface ICollectionFormatter
    {
        /// <summary>
        /// Formats the collection for display, calling ToString() on each object.
        /// </summary>
        /// <returns></returns>
        string Humanize<T>(IEnumerable<T> collection, StringJoinOptions options = StringJoinOptions.Default);

        /// <summary>
        /// Formats the collection for display, calling `objectFormatter` on each object.
        /// </summary>
        /// <returns></returns>
        string Humanize<T>(IEnumerable<T> collection, Func<T, string> objectFormatter, StringJoinOptions options = StringJoinOptions.Default);

        /// <summary>
        /// Formats the collection for display, calling ToString() on each object
        /// and using `separator` before the final item.
        /// </summary>
        /// <returns></returns>
        string Humanize<T>(IEnumerable<T> collection, string separator, StringJoinOptions options = StringJoinOptions.Default);

        /// <summary>
        /// Formats the collection for display, calling `objectFormatter` on each object
        /// and using `separator` before the final item.
        /// </summary>
        /// <returns></returns>
        string Humanize<T>(IEnumerable<T> collection, Func<T, string> objectFormatter, string separator, StringJoinOptions options = StringJoinOptions.Default);
    }
}
