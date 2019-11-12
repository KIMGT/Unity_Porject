using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity_time : MonoBehaviour
{
    private float now = 0.0f;
    public float fu = 1.0f;
    private Collider coll;
    // Start is called before the first frame update
    void Start()
    {
        coll = this.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        now += Time.deltaTime;
        shoot_collider(coll);
    }

    private void shoot_collider(Collider other)
    {
        if (now >= fu)
        {
            other.attachedRigidbody.useGravity = true;
        }else if (now <= fu)
        {
            other.attachedRigidbody.useGravity = false;
        }
    }
}
