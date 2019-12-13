using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class go_main_fire : MonoBehaviour
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
        bool b = GameObject.Find("ChaDragon");
        bool e = GameObject.Find("Enemy");
        if (!b&&!e)
        {
            if (cs == cube&& this.gameObject.tag == "fire")
            {
                SceneManager.LoadScene("M_map");
            }
            if(cs == cube && this.gameObject.tag == "fire_1")
            {
                SceneManager.LoadScene("A_map");
            }
        }
    }
}
