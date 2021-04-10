using System;
using log4net.Core;

namespace Core.CrossCuttingConcerns.Logging.Log4Net
{
    [Serializable]
    public class SerializableLogEvent
    {
        LoggingEvent _loggingEvet;

        public SerializableLogEvent(LoggingEvent loggingEvent)
        {
            _loggingEvet = loggingEvent;
        }

        //bu işi kim yapmış durumları için de bunu kullanabiliriz.
        //username eklenebilir.

        public object Message => _loggingEvet.MessageObject;
    }
}
