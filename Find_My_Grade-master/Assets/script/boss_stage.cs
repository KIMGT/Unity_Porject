using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boss_stage : MonoBehaviour
{
    public GameObject cube = null;
    public static ParticleSystem particle_boss = null; // boss paricle

    // Start is called before the first frame update
    void Start()
    {
        particle_boss = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clear_check.fire == true && clear_check.ice == true && clear_check.forest == true && clear_check.desert == true)
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (cube == collision.gameObject)
        {
            SceneManager.LoadScene("boss_loding");
        }
    }
}
