﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.VK.Entities;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.EntityParsers {
    class VKUserParser:IVKEntityParser<User> {
        private static readonly Lazy<VKUserParser> Lazy = new Lazy<VKUserParser>( () => new VKUserParser() );
        public static VKUserParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        public User ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public User[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
