using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public static float speed = 30.0f; // unito speed
    public static float damages = 2.0f; // unito damages
    public static float player_hp = 3.0f; // unito hp
    public static Animation ani; // 유니토를 움이기 위한 변수
    public static float fire_interval = 0.5f; // 값이 작을 수록 빠른 사격

    private float a_time = 1.0f; // 무적시간
    private float b_time = 0.0f; // 무적체크 시간
    private bool c = false;

    public Texture2D unito = null;

    // Start is called before the first frame update
    void Start()
    {
        ani = gameObject.GetComponent<Animation>();
        ani.Play("01_Idle");
        player_hp = 3.0f;

    }

    // Update is called once per frame
    void Update()
    {
        if (a_time < b_time)
        {
            c = true;
        }
        else
        {
            b_time += Time.deltaTime;
        }
        
        
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            ani.Play("02_Move");
        }
        if (Input.GetKeyUp(KeyCode.W)&&!Input.anyKey)
        {
            ani.Play("01_Idle");
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * speed * Time.deltaTime);
            ani.Play("02_Move");
        }
        if (Input.GetKeyUp(KeyCode.S) && !Input.anyKey)
        {
            ani.Play("01_Idle");
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * speed * Time.deltaTime);
            ani.Play("02_Move");
        }
        if (Input.GetKeyUp(KeyCode.A) && !Input.anyKey)
        {
            ani.Play("01_Idle");
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * speed * Time.deltaTime);
            ani.Play("02_Move");
        }
        if (Input.GetKeyUp(KeyCode.D) && !Input.anyKey)
        {
            ani.Play("01_Idle");
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ani.Play("02_Move");
        }
        if (Input.GetKeyUp(KeyCode.UpArrow)&&!Input.anyKey)
        {
            ani.Play("01_Idle");
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) && !Input.anyKey)
        {
            ani.Play("01_Idle");
        }
        if(Input.GetKeyUp(KeyCode.RightArrow) && !Input.anyKey)
        {
            ani.Play("01_Idle");
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) && !Input.anyKey)
        {
            ani.Play("01_Idle");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy"||collision.gameObject.tag=="boss")
        {
            if (c)
            {
                player_hp -= 1;
                c = false;
            }
            b_time = 0.0f;
        }
        if (collision.gameObject.tag == "power")
        {
            damages += 3;
        }
        if (collision.gameObject.tag == "speed")
        {
            speed += 30;
        }
        if(collision.gameObject.tag== "Fastshooting")
        {
            fire_interval -= 0.2f;
        }
    }

    private void OnGUI()
    {
        
        GUI.DrawTexture(new Rect(20,Screen.height-210,190,190), unito);
        GUI.color = Color.red;
        GUI.skin.label.fontSize = 40;
        GUI.Label(new Rect(230, Screen.height - 190, 170, 170), "Hp : "+player_hp);
    }

    public void damages_up(float d)
    {
        damages += d;
        Debug.Log(damages);
    }
}
