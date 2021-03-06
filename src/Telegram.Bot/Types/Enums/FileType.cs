using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Telegram.Bot.Types.Enums
{
    /// <summary>
    /// Type of a <see cref="IInputFile"/>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum FileType
    {
        /// <summary>
        /// FileStream
        /// </summary>
        Stream,

        /// <summary>
        /// FileId
        /// </summary>
        Id,

        /// <summary>
        /// File Url
        /// </summary>
        Url
    }
}