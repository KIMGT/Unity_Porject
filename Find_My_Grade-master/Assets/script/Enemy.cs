using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float hp = 10;
    private float damages;
    public GameObject posion = null;
    bool b_posion = false;
    float posion_time = 0.0f;
    float posion_max_time = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        damages = player.damages;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
        if (b_posion && posion_time < posion_max_time)
        {
            if (3.0f < posion_time)
            {
                hp -= 2f;
            }
            if (hp <= 0)
            {
                Destroy(this.gameObject);
            }
            posion_time += Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "bullet")
        {
            hp -= damages;
        }
        else if (collision.gameObject.tag == "posion")
        {
            hp -= damages;
            b_posion = true;
            posion_time = 0.0f;

        }
    }
}
