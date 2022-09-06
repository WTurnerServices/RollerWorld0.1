using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GlobalAchievements.triggerAch02 = true;
    }
}

