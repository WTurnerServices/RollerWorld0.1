using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public Text moneyText;
    public Text highScoreText;

    void Start (){
        moneyText.text = "Money : " + PlayerPrefs.GetFloat("Money");
        highScoreText.text = "HighScore : " + PlayerPrefs.GetFloat("HighScore");
    }

}
