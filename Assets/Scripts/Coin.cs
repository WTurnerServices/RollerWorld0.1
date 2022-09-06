using UnityEngine;

public class Coin : MonoBehaviour
{
    
    void Update()
    {
        transform.Rotate(130 * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GlobalAchievements.ach01Count += 1;
            FindObjectOfType<AudioManager>().PlaySound("PickUpCoin");
          //  PlayerManager.numberOfCoins += 1;
            Destroy(gameObject);
            



        }
    }
}
