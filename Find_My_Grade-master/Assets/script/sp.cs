using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sp : MonoBehaviour
{
    public Transform gameObject = null;
    public GameObject emp = null;
    // Start is called before the first frame update
    void Start()
    {
        Transform temp = Instantiate(this.gameObject);

        temp.transform.position = emp.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
