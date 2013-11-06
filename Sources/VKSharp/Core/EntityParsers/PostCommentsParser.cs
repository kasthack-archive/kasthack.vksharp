﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;
using VKSharp.Core.Entities;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.EntityParsers {
    public class PostCommentsParser:IVKEntityParser<PostComments> {
        private static readonly Lazy<PostCommentsParser> Lazy = new Lazy<PostCommentsParser>( () => new PostCommentsParser() );
        public static PostCommentsParser Instanse {
            get {
                return Lazy.Value;
            }
        }

        private PostCommentsParser() { }


        public PostComments ParseFromXml(XNode node) {
            throw new NotImplementedException();
        }

        public PostComments[] ParseAllFromXml(IEnumerable<XNode> nodes) {
            throw new NotImplementedException();
        }
    }
}
