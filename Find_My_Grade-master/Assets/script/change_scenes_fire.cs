using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_scenes_fire : MonoBehaviour
{
    public GameObject cube = null;
    private GameObject cs = null;
    public static ParticleSystem particle_fire = null; // fire paricle

    // Start is called before the first frame update
    void Start()
    {
        particle_fire = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clear_check.fire == true)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        cs = collision.gameObject as GameObject;
        if (cs == cube && this.gameObject.tag == "fire")
        {
            SceneManager.LoadScene("AA_loding");
        }
    }
}
