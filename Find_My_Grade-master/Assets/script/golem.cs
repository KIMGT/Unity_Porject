using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golem : MonoBehaviour
{
    public float hp = 100;
    private float damages; // 유저 데미지
    public GameObject posion = null; // posion
    bool b_posion = false; // posion 확인
    float posion_time = 0.0f; // posion 타이머
    float posion_max_time = 6.0f;

    public Texture2D g = null;

    // Start is called before the first frame update
    void Start()
    {
        damages = player.damages;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
        if (b_posion && posion_time < posion_max_time)
        {
            if (3.0f < posion_time)
            {
                hp -= 2f;
            }
            if (hp <= 0)
            {
                Destroy(this.gameObject);
            }
            posion_time += Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "bullet")
        {
            hp -= damages;
        }
        else if (collision.gameObject.tag == "posion")
        {
            hp -= damages;
            b_posion = true;
            posion_time = 0.0f;
        }

    }

    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(Screen.width - 210, Screen.height - 210, 190, 190), g);
        GUI.color = Color.red;
        GUI.skin.label.fontSize = 40;
        GUI.Label(new Rect(1230, Screen.height - 190, 170, 170), "Hp : " + hp);
    }
}
