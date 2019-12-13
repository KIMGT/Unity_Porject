using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject normal = null; // normal
    public GameObject posion = null; // posion
    public static bool posion_check = false;
    public GameObject sp_shoot = null;
    public static float power = 5000;
    public static float elapsed_time = 0.0f;
    float fire_interval_s; // 값이 작을 수록 빠른 사격
    private float rot_angle = 90.0f;
    Vector3 v;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (posion_check)
        {
            normal = posion;
        }

        fire_interval_s = player.fire_interval;
        float current_angle = rot_angle * Time.deltaTime;
        elapsed_time += Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (elapsed_time > fire_interval_s)
            {
                GameObject temp = Instantiate(normal, sp_shoot.transform.position, sp_shoot.transform.rotation);

                temp.GetComponent<Rigidbody>().AddForce(sp_shoot.transform.forward * power);
                elapsed_time = 0.0f;
            }
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0.0f, current_angle, 0.0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0.0f, -current_angle, 0.0f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "posion")
        {
            posion_check = true;

        }
    }
}
