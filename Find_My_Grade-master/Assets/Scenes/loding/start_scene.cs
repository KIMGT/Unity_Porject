using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_scene : MonoBehaviour
{
    public Texture2D loding = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("M_map");
        }
    }

    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, 1650, 950), loding);
    }
}
