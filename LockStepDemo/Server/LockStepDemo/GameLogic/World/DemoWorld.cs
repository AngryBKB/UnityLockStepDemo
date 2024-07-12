﻿using LockStepDemo.Service.ServiceLogic.System;
using LockStepDemo.ServiceLogic.System;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class DemoWorld : WorldBase
{
    public override Type[] GetSystemTypes()
    {
        return new Type[] {
            typeof(CollisionSystem),
            typeof(MoveSystem),
            typeof(OperationSystem),
            typeof(FireSystem),
            typeof(SkillStatusSystem),
            typeof(SkillSystem),
            typeof(LifeSpanSystem),
            typeof(CollisionSystem),
            typeof(CollisionDamageSystem),
            typeof(InitSystem),
            typeof(BlowFlySystem),

            typeof(ConnectSystem),
            typeof(ServiceSyncSystem),
            typeof(PlayerInputSystem<CommandComponent>),
            typeof(SyncDebugSystem),
        };
    }
}
