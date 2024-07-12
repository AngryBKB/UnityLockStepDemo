﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class GameUtils
{
    public static string GetEventKey(int entityID, CharacterEventType EventType)
    {
        return entityID + EventType.ToString();
    }
}

public enum DirectionEnum
{
    Forward, //施法者前方
    Backward,//施法者后方
    Leave,//受击者远离施法者方向
    Close,//受击者靠近施法者方向
}
public enum CharacterEventType
{
    Init,   //初始化
    Move,   //移动
    Attack, //攻击
    Damage, //受伤
    Recover,//恢复
    Die,    //死亡
    SKill,  //使用技能
    BeBreak,//被打断
    Resurgence, //复活
    EnterArea,  //进入某区域
    ExitArea,   //离开某区域
    Destroy,
}

