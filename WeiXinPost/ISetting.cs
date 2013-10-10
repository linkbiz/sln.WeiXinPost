using System;
using System.Collections.Generic;
using System.Text;

namespace WeiXinPost
{
    public interface ISetting
    {
        string LastText { get; set; }
        string LastVoice { get; set; }
        string LastPic { get; set; }
        string LastPositionX { get; set; }
        string LastPositionY { get; set; }
        string LastUrl { get; set; }
        string LastFromName { get; set; }
        string LastToName { get; set; }
        string LastMenu { get; set; }

        void Save();

    }
}
