using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TimerContoller : MonoBehaviour
{
    public static TimerContoller instance;
    public Text timeCounter;
    public Text bestTimeCounter;

    private TimeSpan timePlaying;
    private bool timerGoing;
    private float elapsedTime;
    private CharacterController controller;
    private PlayerManager playerManager;

    private void Awake()
    {
        instance = this;
    }
    
    private void Start()
    {
        timeCounter.text = "00:00.00";
        timerGoing = false;
    }

    private void Update()
    {
       
        
    }

    public void BeginTimer()
    {
        timerGoing = true;
//        startTime = Time.time;
        elapsedTime = 0f;
        //PlayerPrefs.GetText ("Time");

        StartCoroutine(UpdateTimer());

    }
    public void EndTimer()
    {
        timerGoing = false;
        //PlayerPrefs.SetText ("Time");
    }
    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
            timeCounter.text = timePlayingStr;

            yield return null;
        }
    }
}
