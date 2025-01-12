﻿namespace StreamDanmaku_Server.Enum
{
    /// <summary>
    /// 错误码 其含义由ErrorCodeDict.cs解释
    /// </summary>
    public enum ErrorCode
    {
        OK = 200,
        DuplicateEmail = 301,
        DuplicateUsername = 302,
        WrongUserNameOrPassword = 303,
        OldPasswordEqualNewPassword = 314,
        PasswordFormatError = 304,
        EmailFormatError = 305,
        UserNameFormatError = 306,
        InvalidUser = 307,
        DuplicateRoom = 308,
        WrongRoomPassword = 309,
        RoomNotExist = 310,
        RoomUnenterable = 311,
        RoomFull = 312,
        RoomNotExistOrUnenterable = 313,
        ParamsFormatError = 401,
        CaptchaInvalidOrWrong = 402,
        CaptchaCoolDown = 403,
        CaptchaInvalid = 404,
        TokenExpired = 501,
        SignInvalid = 502,
        TokenInvalid = 503,
        UnknownError = -100,
        UserCanNotStream = 504,
        UserCanNotSendDanmaku = 505,
        NoAuth = 506,
        PartError = 507,
        AlreadyFriend = 508,
        FriendNoRoom = 509,
        FriendNotOnline = 510,
        NoFriend = 511,
        NoFriendRequest = 512,
        InvalidArgs = 513,
    }
}