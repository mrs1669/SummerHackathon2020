using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelController : MonoBehaviour
{
    public GameObject level_object = null;
    public GameObject score_object = null;
    int level = 0;

    public void CountUp() => level++;

    string strLevel;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        strLevel = level.ToString();
        level_object.GetComponent<TextMesh>().text = "叩いた回数" + level.ToString();
        //if (TimeController.remianTime == 0)
        //{
        //    level_object.GetComponent<TextMesh>().text = “Time Up”;
        //}
    }
}
