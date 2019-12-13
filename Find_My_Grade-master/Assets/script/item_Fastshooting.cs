using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_Fastshooting : MonoBehaviour
{
    public Transform item = null; // 적용 아이템
    public GameObject posion = null;

    private Vector3 v = new Vector3(0.0f, 5.0f, 0.0f);

    bool find;
    bool boss = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (boss)
        {
            find = GameObject.Find("golem");
        }

        if (!find && boss)
        {
            Instantiate(item, this.transform.position + v, this.transform.rotation);
            item.transform.position = this.transform.position;
            boss = false;
        }
    }
}
