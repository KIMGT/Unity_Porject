using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    private GameObject gameObject = null;
    public GameObject shoot = null;
    public float power = 100;
    public float time = 3.0f;
    private float min = 0.0f;
    Vector3 v;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        min += Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (min >= time)
            {
                gameObject = GameObject.Find("player") as GameObject;
                v = gameObject.transform.position + new Vector3(0, 0, 11);
                GameObject temp = Instantiate(this.shoot);

                temp.transform.position = v;
                temp.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1) * power);
                min = 0;
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (min >= time)
            {
                gameObject = GameObject.Find("player") as GameObject;
                v = gameObject.transform.position + new Vector3(0, 0, -11);
                GameObject temp = Instantiate(this.shoot);

                temp.transform.position = v;
                temp.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -1) * power);
                min = 0;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (min >= time)
            {
                gameObject = GameObject.Find("player") as GameObject;
                v = gameObject.transform.position + new Vector3(11, 0, 0);
                GameObject temp = Instantiate(this.shoot);

                temp.transform.position = v;
                temp.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 0) * power);
                min = 0;
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (min >= time)
            {
                gameObject = GameObject.Find("player") as GameObject;
                v = gameObject.transform.position + new Vector3(-11, 0, 0);
                GameObject temp = Instantiate(this.shoot);

                temp.transform.position = v;
                temp.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, 0) * power);
                min = 0;
            }
        }
    }
}
