using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_scenes : MonoBehaviour
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
        bool b = GameObject.Find("Enemy");
        if (!b)
        {
            if (cs == cube)
            {
                SceneManager.LoadScene(1);
            }
        }
            
        

    }
}
