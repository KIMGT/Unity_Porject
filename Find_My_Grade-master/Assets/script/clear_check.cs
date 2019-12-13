using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clear_check : MonoBehaviour
{
    public static bool fire = false; // fire_map clear check
    public static bool ice = false; // ice_map clear check
    public static bool forest = false; // forest_map clear check
    public static bool desert = false; // desert_map clear check

    

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
        if (collision.gameObject.transform.tag == "fire")
        {
            fire = true;
        }
        if (collision.gameObject.transform.tag == "ice")
        {
            ice = true;
        }
        if (collision.gameObject.transform.tag == "forest")
        {
            forest = true;
        }
        if (collision.gameObject.transform.tag == "desert")
        {
            desert = true;
        }
    }
}
