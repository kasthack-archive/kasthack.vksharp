﻿using System;

namespace VKSharp.Data.Parameters {
    [Flags]
    //DO NOT RENAME!
    public enum FriendSuggestionFilters {
        Mutual=1<<1,
        Contacts=1<<2,
        MutualContacts = 1 << 3,
        Everything=~0
    }
}
