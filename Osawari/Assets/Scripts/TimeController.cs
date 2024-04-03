using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeController : MonoBehaviour
{
    public GameObject score_object = null;
    //public AudioSource gOversound;
    int timeLimit;
    float deltaTime;
    int intNowTime;
    int remainTime;
    string strNowTime;
    // Start is called before the first frame update
    void Start()
    {
        timeLimit = 15;
    }
    // Update is called once per frame
    void Update()
    {
        deltaTime += Time.deltaTime;   // 経過時間
        intNowTime = (int)deltaTime;   // 経過時間の整数部分
        remainTime = timeLimit - intNowTime;  // 残り時間
//        Debug.Log(remainTime);
        strNowTime = remainTime.ToString();   // TextMeshのGameObjectに代入するためにString型にする
        score_object.GetComponent<TextMesh>().text = "残り時間" + strNowTime;
        // 制限時間経過時の設定
        if (remainTime <= 0)
        {
            score_object.GetComponent<TextMesh>().text = "Game Over!";
            int goFlag = 0;
            if (goFlag == 0)
            {
                //gOversound.Play();
                goFlag = 1;
            }
        }
 //       Debug.Log(remainTime);
    }

    public void TimeReset()
    {
        deltaTime = 0.0f;
    }
}