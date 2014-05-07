﻿using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Note : OwnedEntity<Note> {
        //UserId -> OwnerId
        public override int OwnerId { get; set; }
        public uint Date { get; set; }
        public uint CommentCount { get; set; }
        public uint? ReadCommentCount { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
    }
}