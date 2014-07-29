﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Enums;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;
using VKSharp.Core.Entities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<StructEntity<bool>> WallDeleteAsync (int ownerId, uint postId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "wall.delete",
                Parameters = new Dictionary<string, string> {
                    { "owner_id", ownerId.ToNCString() },
                    {
                        "post_id",
                        postId.ToNCString()
                    },
                }
            };
            if ( !IsLogged ) throw new InvalidOperationException ( "This method requires auth!" );
            req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }

        public async Task<StructEntity<bool>> WallRestoreAsync (int ownerId, uint postId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "wall.restore",
                Parameters = new Dictionary<string, string> {
                    { "owner_id", ownerId.ToNCString() },
                    {
                        "post_id",
                        postId.ToNCString()
                    },
                }
            };
            if ( !IsLogged )
                throw new InvalidOperationException ( "This method requires auth!" );
            req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }

        public async Task<StructEntity<bool>> WallDeleteCommentAsync (int ownerId, uint commentId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "wall.deleteComment",
                Parameters =
                    new Dictionary<string, string> {
                    { "owner_id", ownerId.ToNCString() },
                    {
                        "comment_id",
                        commentId.ToNCString()
                    },
                }
            };
            if ( !IsLogged )
                throw new InvalidOperationException ( "This method requires auth!" );
            req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }

        public async Task<StructEntity<bool>> WallRestoreCommentAsync (int ownerId, uint commentId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "wall.restoreComment",
                Parameters =
                    new Dictionary<string, string> {
                    { "owner_id", ownerId.ToNCString() },
                    {
                        "comment_id",
                        commentId.ToNCString()
                    },
                }
            };
            if ( !IsLogged )
                throw new InvalidOperationException ( "This method requires auth!" );
            req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }

        public async Task<StructEntity<bool>> WallReportPostAsync (int ownerId, uint postId, ReportReason? reason = null) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "wall.reportPost",
                Parameters =
                    new Dictionary<string, string> {
                    { "owner_id", ownerId.ToNCString() },
                    { "post_id", postId.ToNCString() },
                    { "reason", reason == null ? "" : ( (int)reason ).ToNCString() }
                }
            };
            if ( !IsLogged )
                throw new InvalidOperationException ( "This method requires auth!" );
            req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }

        public async Task<StructEntity<bool>> WallReportCommentAsync (int ownerId, uint commentId, ReportReason? reason = null) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "wall.reportPost",
                Parameters =
                    new Dictionary<string, string> {
                    { "owner_id", ownerId.ToNCString() },
                    { "comment_id", commentId.ToNCString() },
                    { "reason", reason == null ? "" : ( (int)reason ).ToNCString() }
                }
            };
            if ( !IsLogged )
                throw new InvalidOperationException ( "This method requires auth!" );
            req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }

        public async Task<EntityList<Post>> WallGetAsync (int? ownerId, string domain = "",
            int offset = 0, int count = 100, WallPostFilter filter = WallPostFilter.All) {
            var req = new VKRequest<EntityList<Post>> {
                MethodName = "wall.get",
                Parameters = new Dictionary<string, string> {
                    { "owner_id", MiscTools.NullableString( ownerId ) },
                    { "domain", domain },
                    { "offset", offset.ToNCString() },
                    { "count", count.ToNCString() },
                    { "filter", filter.ToNClString().ToSnake() }
                }
            };
            if ( IsLogged ) req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data.FirstOrDefault();
        }
        public async Task<Post[]> WallGetByIdAsync(int copyHistoryDepth = 2, params Tuple<int,uint>[] ids ){
            return await WallGetByIdAsync( copyHistoryDepth, ids.Select( a => a.Item1.ToNCString() + "_" + a.Item2.ToNCString() ).ToArray() );
        }
        public async Task<Post[]> WallGetByIdAsync(int copyHistoryDepth = 2, params string[] ids){
            var req = new VKRequest<Post> {
                MethodName = "wall.getById",
                Parameters = new Dictionary<string, string> {
                    { "posts", String.Join(",", ids) },
                    { "copy_history_depth", copyHistoryDepth.ToNCString() }
                }
            };
            if ( IsLogged ) req.Token = CurrenToken;
            return ( await _executor.ExecAsync( req ) ).Data;
        }

        //public async Task<StructEntity<long>> WallPostAsync(int? ownerId = null,bool friendsOnly = false, ) {
            
        //}
    }
}