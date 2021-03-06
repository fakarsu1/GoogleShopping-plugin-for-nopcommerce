﻿
namespace Nop.Plugin.Feed.GoogleShopping
{
    /// <summary>
    /// Represents plugin constants
    /// </summary>
    public static class GoogleShoppingDefaults
    {
        /// <summary>
        /// Generic attribute name to hide general settings block on the plugin configuration page
        /// </summary>
        public static string HideGeneralBlock = "GoogleShoppingPage.HideGeneralBlock";

        /// <summary>
        /// Generic attribute name to hide product settings block on the plugin configuration page
        /// </summary>
        public static string HideProductSettingsBlock = "GoogleShoppingPage.HideProductSettingsBlock";

        /// <summary>
        /// Name of the generate feed task
        /// </summary>
        public static string GenerateFeedTaskName => "Google Shopping Generate Feed";

        /// <summary>
        /// Type of the generate feed task
        /// </summary>
        public static string GenerateFeedTask => "Nop.Plugin.Feed.GoogleShopping.Services.GenerateFeedTask, Nop.Plugin.Feed.GoogleShopping";

        /// <summary>
        /// Default synchronization period in hours
        /// </summary>
        public static int DefaultGenerateFeedPeriod => 24;
    }
}