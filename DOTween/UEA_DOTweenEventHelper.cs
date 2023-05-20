using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EA_DOTweenEventHelper
{
    public static void OnDOTweenEvent(IDOTweenEventInfo eventInfo, Action kill, Func<Tweener> tween, Action reset)
    {
        kill();

        if (!eventInfo.Kill)
        {
            var tweener = tween();
            if (eventInfo.DoesLoop())
                tweener.SetLoops(eventInfo.Loops);
        }
        else
            reset();
    }
}
