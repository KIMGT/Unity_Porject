using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win_scene : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource source;

    private float p_time = 3.0f;
    private float t_time = 0.0f;

    private float hp;
    // Start is called before the first frame update
    void Start()
    {
        source = gameObject.AddComponent<AudioSource>();
        source.clip = clip;
        source.loop = false;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.player_hp <= 0)
        {
            if (p_time < t_time)
            {
                SceneManager.LoadScene("lose");
            }
            t_time += Time.deltaTime;
        }

        if (!GameObject.Find("male"))
        {
            if (p_time < t_time)
            {
                SceneManager.LoadScene("win");
            }
            t_time += Time.deltaTime;
        }
    }
}
