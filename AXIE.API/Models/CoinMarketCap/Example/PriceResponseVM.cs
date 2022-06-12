using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AXIE.API.Models.CoinMarketCap.Example
{
    [DataContract]
    public class PriceResponseVM
    {
        [DataMember]
        [JsonProperty("smooth-love-potion")]
        public SmoothLovePotion smoothLovePotion { get; set; }
        [DataMember]
        [JsonProperty("axie-infinity")]
        public AxieInfinity axieInfinity { get; set; }
        [DataMember]
        [JsonProperty("cybloc-battery-token")]
        public CyblocBatteryToken cyblocBatteryToken { get; set; }
        [DataMember]
        [JsonProperty("starsharks-sea")]
        public StarsharksSea starsharksSea { get; set; }
        [DataMember]
        public Vigorus vigorus { get; set; }
        [DataMember]
        [JsonProperty("treasure-under-sea")]
        public TreasureUnderSea treasureUnderSea { get; set; }

        [DataContract]
        public class AxieInfinity
        {
            [DataMember]
            public double eur { get; set; }
            [DataMember]
            public double usd { get; set; }
        }

        [DataContract]
        public class CyblocBatteryToken
        {
            [DataMember]
            public double eur { get; set; }
            [DataMember]
            public double usd { get; set; }
        }

        [DataContract]
        public class SmoothLovePotion
        {
            [DataMember]
            public double eur { get; set; }
            [DataMember]
            public double usd { get; set; }
        }

        [DataContract]
        public class StarsharksSea
        {
            [DataMember]
            public double eur { get; set; }
            [DataMember]
            public double usd { get; set; }
        }

        [DataContract]
        public class TreasureUnderSea
        {
            [DataMember]
            public double eur { get; set; }
            [DataMember]
            public double usd { get; set; }
        }

        [DataContract]
        public class Vigorus
        {
            [DataMember]
            public double eur { get; set; }
            [DataMember]
            public double usd { get; set; }
        }


    }
}
