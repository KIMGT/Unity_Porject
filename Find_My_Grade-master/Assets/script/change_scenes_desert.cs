using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_scenes_desert : MonoBehaviour
{
    public GameObject cube = null;
    private GameObject cs = null;
    public static ParticleSystem particle_desert = null; // desert particle
    // Start is called before the first frame update
    void Start()
    {
        particle_desert = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clear_check.desert == true)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        cs = collision.gameObject as GameObject;
        if (cs == cube && this.gameObject.tag == "desert")
        {
            SceneManager.LoadScene("C_loding");
        }
    }
}
