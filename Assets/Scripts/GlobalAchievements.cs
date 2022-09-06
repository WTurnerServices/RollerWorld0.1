using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAchievements : MonoBehaviour
{

    //General Variables
    public GameObject achNote;
    public AudioSource achSound;
    public bool achActive = false;

    //Achievement 01 Specific
    public GameObject ach01Image;
    public GameObject ach01Title;
    public GameObject ach01Desc;
    public static int ach01Count;
    public int ach01Trigger = 5;
    public int ach01Code;

    //Achievement 02 Specific
    public GameObject ach02Image;
    public static bool triggerAch02 = false;
    public int ach02Code;

    //Achievement 03 Specific
    public GameObject ach03Image;
    public static bool triggerAch03 = false;
    public int ach03Code;

    void Start(){
        //Reset PlayerPrefs

       // PlayerPrefs.SetInt("Ach01", 0);
       // PlayerPrefs.SetInt("Ach02", 0);
    }

    
    

    // Update is called once per frame
    void Update()
    {
        ach01Code = PlayerPrefs.GetInt("Ach01");
        ach02Code = PlayerPrefs.GetInt("Ach02");
        ach03Code = PlayerPrefs.GetInt("Ach03");
        if(ach01Count == ach01Trigger && ach01Code != 12345)
        {
            StartCoroutine(tigger01Ach());
        }
        if(triggerAch02 == true && ach02Code != 12346)
        {
            StartCoroutine(trigger02Ach());
        }
        if(triggerAch03 == true && ach03Code != 12347)
        {
            StartCoroutine(trigger03Ach());
        }
        
        
    }

    IEnumerator tigger01Ach()
    {
        achActive = true;
        ach01Code = 12345;
        PlayerPrefs.SetInt("Ach01", ach01Code);
        achSound.Play();
        ach01Title.GetComponent<Text>().text = "COLLECTION!";
        ach01Desc.GetComponent<Text>().text = "You have colleted your first 5 coins.";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);

        //Resetting UI

        achNote.SetActive(false);
        ach01Image.SetActive(false);
        ach01Title.GetComponent<Text>().text = "";
        ach01Desc.GetComponent<Text>().text = "";
        achActive = false;
    }

    IEnumerator trigger02Ach()
    {
        achActive = true;
        ach02Code = 12346;
        PlayerPrefs.SetInt("Ach02", ach02Code);
        achSound.Play();
        ach01Title.GetComponent<Text>().text = "ACHIEVEMENT!";
        ach01Desc.GetComponent<Text>().text = "Your first Duck, lot more to go.";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);

        //Resetting UI

        achNote.SetActive(false);
        ach02Image.SetActive(false);
        ach01Title.GetComponent<Text>().text = "";
        ach01Desc.GetComponent<Text>().text = "";
        achActive = false;
    }

    IEnumerator trigger03Ach()
    {
        achActive = true;
        ach03Code = 12347;
        PlayerPrefs.SetInt("Ach03", ach03Code);
        achSound.Play();
        ach01Title.GetComponent<Text>().text = "ACHIEVEMENT!";
        ach01Desc.GetComponent<Text>().text = "Your first Jump, lot more to go.";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);

        //Resetting UI

        achNote.SetActive(false);
        ach03Image.SetActive(false);
        ach01Title.GetComponent<Text>().text = "";
        ach01Desc.GetComponent<Text>().text = "";
        achActive = false;
    }

    
}
