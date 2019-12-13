using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class b_loding : MonoBehaviour
{
    public Texture2D loding = null;
    float a = 3.0f;
    float b = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (b > a)
        {
            SceneManager.LoadScene("B_map1");
        }
        b += Time.deltaTime;
    }

    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, 1650, 950), loding);
    }
}
