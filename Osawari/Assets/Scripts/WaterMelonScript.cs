using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMelonScript : MonoBehaviour
{
    private int level;

    private int randomLevel;

    private float dx = 0.0f, dy = 0.0f, dz = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
         level = GameObject.Find("PlayerScript").GetComponent<PlayerScript>().Level;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(dx, dy, dz);

        if (level == 0)
        {
            dx = 0.0f;
            dy = 0.0f;
            dz = 0.0f;
        }
        else if (level == 1)
        {
            dx = 0.05f;
            dz = 0.0f;
        }
        else if (level == 2)
        {
            dx = 0.05f;
            dz = 0.0f;
        }
        else if (level == 3)
        {
            dx = 0.0f;
            dz = 0.05f;
        }
        else if (level == 4)
        {
            dx = 0.05f;
            dz = 0.05f;
        }
        else
        {
            dx = 0.04f;
            dz = 0.04f;
        }
    }

    public void Hit()
    {
        Respawn((level > 4) ? true : false); //levelが5以上になると前後方向にもランダムで出現するようになる
        if (level > 1 && level <= 4) gameObject.GetComponent<Rigidbody>().useGravity = false;
        if (level > 4 || level == 0) gameObject.GetComponent<Rigidbody>().useGravity = true;

        randomLevel = Random.Range(0, 6);
        level = randomLevel;
    }

    private void Respawn (bool isHorizontal)
    {
        if (!isHorizontal)
        {
            gameObject.transform.position = new Vector3(Random.Range(-7.5f, -3.2f), 3.0f, 166.0f);
        }
        else
        {
            gameObject.transform.position = new Vector3(Random.Range(-7.0f, -3.0f), Random.Range(3.2f, 4.7f), Random.Range(163.0f, 167.0f));
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Left")
            CollidedReflect(0);
        if (collision.gameObject.name == "Front")
            CollidedReflect(1);
        if (collision.gameObject.name == "Right")
            CollidedReflect(2);
        if (collision.gameObject.name == "Back")
            CollidedReflect(3);

    }

    private void CollidedReflect(int direction) //direction 0:Left 1:Front 2:Right 3:Back
    {
        if (direction == 0 || direction == 2)
            this.dx *= -1;
        else if (direction == 1 || direction == 3)
            this.dz *= -1;
    }
}
