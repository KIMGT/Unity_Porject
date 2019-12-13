using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class go_main_ice : MonoBehaviour
{
    public GameObject cube = null;
    private GameObject cs = null;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        cs = collision.gameObject as GameObject;
        bool b = GameObject.Find("golem");
        bool e = GameObject.Find("Enemy");
        if (!b)
        {
            if (cs == cube&&this.gameObject.tag == "ice")
            {
                SceneManager.LoadScene("M_map");
            }
            if(cs == cube && this.gameObject.tag == "ice_1")
            {
                SceneManager.LoadScene("B_map");
            }
        }
    }
}
