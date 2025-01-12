﻿using System.Collections.Generic;

namespace StreamDanmaku_Server
{
    internal static class ErrorCodeDict
    {
        public static Dictionary<int, string> Content = new()
        {
            { 200, "ok"},
            { 301, "邮箱重复"},
            { 302, "昵称重复"},
            { 303, "用户名或密码错误"},
            { 314, "新密码与旧密码相同"},
            { 304, "密码格式错误"},
            { 305, "邮箱格式错误" },
            { 306, "昵称格式错误" },
            { 307, "用户无效" },
            { 308, "不可创建多个房间" },
            { 309, "密码不匹配" },
            { 310, "房间不存在" },
            { 311, "房间不可加入" },
            { 312, "房间已满" },
            { 313, "房间不存在或不可加入" },
            { 401, "参数格式错误"},
            { 402, "验证码过期或错误"},
            { 403, "验证码冷却"},
            { 404, "验证码不存在"},
            { 501, "Token过期"},
            { 502, "签名无效"},
            { 503, "Token无效"},
            { -100, "未知错误"},
            { 504, "用户已被拉黑"},
            { 505, "用户已被禁言"},
            { 506, "连接未授权"},
            { 507, "操作部分失败"},
            { 508, "已经是好友关系，不可重复添加"},
            { 509, "好友未在任何房间内"},
            { 510, "好友未在线"},
            { 511, "未与此好友建立好友关系"},
            { 512, "要处理的好友请求不存在"},
            { 513, "参数错误"},
        };
    }
}
