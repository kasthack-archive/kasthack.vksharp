﻿using System;

namespace VKSharp.Data.Parameters {
    [Flags]
    public enum UserFields:ulong {
        About=1UL<<0,
        Activities = 1UL<<1,
        Bdate=1UL<<2,
        Blacklisted = 1UL << 3,
        Books = 1UL << 4,
        CanPost = 1UL << 5,
        CanSeeAllPosts = 1UL << 6,
        CanSeeAudio = 1UL << 7,
        CanWritePrivateMessage = 1UL << 8,
        City = 1UL << 9,
        CommonCount = 1UL << 10,
        Connections = 1UL << 11,
        Contacts = 1UL << 12,
        Counters = 1UL << 13,
        Country = 1UL << 14,
        Domain = 1UL << 15,
        Education = 1UL << 16,
        Exports = 1UL << 17,
        FollowersCount = 1UL << 18,
        Games = 1UL << 19,
        HasMobile = 1UL << 20,
        HomeTown = 1UL << 21,
        Interests = 1UL << 22,
        LastSeen = 1UL << 23,
        Lists = 1UL << 24,
        Movies = 1UL << 25,
        Music = 1UL << 26,
        Nickname = 1UL << 27,
        Online = 1UL << 28,
        Personal = 1UL << 29,
        Photo100 = 1UL << 30,
        Photo200 = 1UL << 31,
        Photo200Orig = 1UL << 32,
        Photo400Orig = 1UL << 33,
        Photo50 = 1UL << 34,
        PhotoMax = 1UL << 35,
        PhotoMaxOrig = 1UL << 36,
        Quotes = 1UL << 37,
        Relation = 1UL << 38,
        Relatives = 1UL << 39,
        Schools = 1UL << 40,
        Sex = 1UL << 41,
        Site = 1UL << 42,
        Status = 1UL << 43,
        Timezone = 1UL << 44,
        Tv = 1UL << 45,
        Universities = 1UL << 46,
        Verified = 1UL << 47,
        WallComments = 1UL << 48,
        ScreenName = 1UL << 49,
        Occupation = 1UL << 50,
        Everything = ~0UL,
        None = 0UL
    }
}
