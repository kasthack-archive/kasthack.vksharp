﻿using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Geo:IVKEntity<Geo> {
        
        public string Address { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public uint CityId{ get; set; }
        public uint CountryId{ get; set; }
        public uint PlaceId{ get; set; }

        public VKApi Context { get; set; }
    }
}