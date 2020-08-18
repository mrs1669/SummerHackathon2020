using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    private int level = 0;
    public int Level { get => level; set => level = value; }
    public void LevelUp() => level++;

    private int countOfHit = 0;
    public int CountOfHit { get => countOfHit; set => countOfHit = value; }
    public void CountUp() => countOfHit++;

    private int time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
