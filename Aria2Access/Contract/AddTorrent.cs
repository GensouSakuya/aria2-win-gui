﻿using System;

namespace Aria2Access
{
    internal class AddTorrentRequest : BaseRequest
    {
        public string torrent { get; set; }
        public Options Options { get; set; }
        public int? Position { get; set; }

        protected override string MethodName => "aria2.addTorrent";

        protected override void PrepareParam()
        {
            if (string.IsNullOrWhiteSpace(torrent))
            {
                throw new Exception();
            }
            
            AddParam(torrent);

            if (Options != null)
            {
                AddParam(Options.ToString());
                if (Position.HasValue)
                {
                    AddParam(Position);
                }
            }
        }
    }

    internal class AddTorrentResponse : BaseResponse
    {
        public string GID
        {
            get
            {
                return Result as string;
            }
        }
    }
}