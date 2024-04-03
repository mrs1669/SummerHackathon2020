using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaberScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource seSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "WaterMelon")
        {
            Hit();
            GameObject.Find("PlayerScript").GetComponent<PlayerScript>().CountUp();
        }
    }

    void Hit()
    {
        Debug.Log("WaterMelonHit");
        GameObject.Find("WaterMelon").GetComponent<WaterMelonScript>().Hit();
        GameObject.Find("TimeText").GetComponent<TimeController>().TimeReset();
        GameObject.Find("LevelText").GetComponent<LevelController>().CountUp();
        //判定音
        seSound.Play();
    }
}
