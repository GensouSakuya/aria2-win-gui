﻿using System;

namespace Aria2Access
{
    internal class PauseAllRequest : BaseRequest
    {
        public string GID { get; set; }

        protected override string MethodName => "aria2.pauseAll";
        protected override void PrepareParam()
        {
            if (string.IsNullOrWhiteSpace(GID))
            {
                throw new Exception();
            }

            AddParam(GID);
        }
    }

    internal class PauseAllResponse : BaseResponse
    {
        public PauseAllResponse(BaseResponse res) : base(res)
        {
        }
    }
}
