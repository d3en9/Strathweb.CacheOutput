using WebApi.OutputCache.Core.Time;

namespace WebApi.OutputCache.V2.TimeAttributes
{
    public sealed class CacheOutputUntilToday : CacheOutputAttribute
    {
        /// <summary>
        ///     Cache item until absolute expiration today @ 17h45
        /// </summary>
        /// <param name="hour">17</param>
        /// <param name="minute">45</param>
        /// <param name="second">0</param>
        public CacheOutputUntilToday(int hour = 23,
                                     int minute = 59,
                                     int second = 59)
        {
            CacheTimeQuery = new ThisDay(hour, minute, second);
        }
    }

    public sealed class CacheOutputUntilTodayAllMethods : CacheOutputAllMethodsAttribute
    {
        /// <summary>
        ///     Cache item until absolute expiration today @ 17h45
        /// </summary>
        /// <param name="hour">17</param>
        /// <param name="minute">45</param>
        /// <param name="second">0</param>
        public CacheOutputUntilTodayAllMethods(int hour = 23,
                                     int minute = 59,
                                     int second = 59)
        {
            CacheTimeQuery = new ThisDay(hour, minute, second);
        }
    }
}