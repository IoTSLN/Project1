using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace EventBus.Base.Events
{
    public class IntegrationEvent
    {
        [JsonPropertyName("Id")]
        public Guid Id { get; set; }
        [JsonPropertyName("CreationDate")]
        public DateTime CreationDate { get; set; }

        public IntegrationEvent()
        {
            Id= Guid.NewGuid();
            CreationDate= DateTime.Now;
        }
        [JsonConstructor]
        public IntegrationEvent(Guid id,DateTime CT)
        {
            Id = id;
            CreationDate = CT;
        }
    }
}
