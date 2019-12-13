using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public Texture2D w = null;
    public AudioClip clip;
    private AudioSource source;

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
        if (Input.anyKey)
        {
            SceneManager.LoadScene("M_map");
        }
    }

    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, 1650, 950), w);
    }
}
