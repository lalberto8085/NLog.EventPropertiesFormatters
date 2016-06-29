using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NLog.LayoutRenderers;

namespace NLog.EventPropertiesFormaters
{
    [LayoutRenderer("all-event-properties-json")]
    public class AllEventPropertiesJsonLayoutRenderer : LayoutRenderer
    {
        protected override void Append(StringBuilder builder, LogEventInfo logEvent)
        {
            var serializedString = logEvent.Properties == null || !logEvent.Properties.Any()
                ? null
                : JsonConvert.SerializeObject(logEvent.Properties);

            builder.Append(serializedString);
        }
    }
}
