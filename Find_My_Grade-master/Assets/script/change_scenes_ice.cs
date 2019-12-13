using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_scenes_ice : MonoBehaviour
{
    public GameObject cube = null;
    private GameObject cs = null;
    public static ParticleSystem particle_ice = null; // desert particle

    // Start is called before the first frame update
    void Start()
    {
        particle_ice = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clear_check.ice == true)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        cs = collision.gameObject as GameObject;
        if (cs == cube && this.gameObject.tag == "ice")
        {
            SceneManager.LoadScene("B_loding");
        }
    }
}
