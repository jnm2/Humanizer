﻿using System;
using System.Collections.Generic;
using Humanizer.Configuration;


namespace Humanizer
{
    /// <summary>
    /// Humanizes an IEnumerable into a human readable list
    /// </summary>
    public static class CollectionHumanizeExtensions
    {
        /// <summary>
        /// Formats the collection for display, calling ToString() on each object and
        /// using the default separator for the current culture.
        /// </summary>
        /// <returns></returns>
        public static string Humanize<T>(this IEnumerable<T> collection, StringJoinOptions options = StringJoinOptions.Default)
        {
            return Configurator.CollectionFormatter.Humanize(collection, options);
        }

        /// <summary>
        /// Formats the collection for display, calling `objectFormatter` on each object
        /// and using the default separator for the current culture.
        /// </summary>
        /// <returns></returns>
        public static string Humanize<T>(this IEnumerable<T> collection, Func<T, string> displayFormatter, StringJoinOptions options = StringJoinOptions.Default)
        {
            if (displayFormatter == null)
                throw new ArgumentNullException(nameof(displayFormatter));

            return Configurator.CollectionFormatter.Humanize(collection, displayFormatter, options);
        }

        /// <summary>
        /// Formats the collection for display, calling ToString() on each object
        /// and using the provided separator.
        /// </summary>
        /// <returns></returns>
        public static string Humanize<T>(this IEnumerable<T> collection, string separator, StringJoinOptions options = StringJoinOptions.Default)
        {

            return Configurator.CollectionFormatter.Humanize(collection, separator, options);
        }

        /// <summary>
        /// Formats the collection for display, calling `objectFormatter` on each object
        /// and using the provided separator.
        /// </summary>
        /// <returns></returns>
        public static string Humanize<T>(this IEnumerable<T> collection, Func<T, string> displayFormatter, string separator, StringJoinOptions options = StringJoinOptions.Default)
        {
            if (displayFormatter == null)
                throw new ArgumentNullException(nameof(displayFormatter));

            return Configurator.CollectionFormatter.Humanize(collection, displayFormatter, separator, options);
        }
    }
}
