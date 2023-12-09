using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAnimationTrigger : MonoBehaviour
{
    private Skeleton enemy => GetComponentInParent<Skeleton>();

    private void AnimationTrigger()
    {
        enemy.AnimationTrigger();
    }
}
