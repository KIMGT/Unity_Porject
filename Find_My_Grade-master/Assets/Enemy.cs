using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float hp = 10;
    private float damages;
    // Start is called before the first frame update
    void Start()
    {
        player p = new player();
        damages = p.damages;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject enemy = GameObject.Find("Enemy") as GameObject;

        hp -= damages;
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
        Debug.Log(hp);
    }
}
