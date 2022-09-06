using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpachiveTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GlobalAchievements.triggerAch03 = true;
    }
}
