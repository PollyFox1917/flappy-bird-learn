using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dumpling : MonoBehaviour
{

    public float jump;
    private Rigidbody2D rb;
    public GameObject gameEndUi;
    public Transform _player_transform;
    float speed = 12.5f;
    bool Dead = false;
    public Text text;
    int _Schet = 0;


    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        
        if (!Dead)
        {
            _player_transform.position += Vector3.right * speed * Time.deltaTime;
            if (Input.anyKeyDown)
            {
                rb.AddForce(Vector2.up * jump);
            }

        }



    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Schet")
        {
            _Schet ++;
            text.text = "Скорость: "+_Schet.ToString();

        }
       else if (!Dead)
        {


            //collision.gameObject.tag 
            Dead = true;
            gameEndUi.SetActive(true);
            if (collision.gameObject.tag == "JumpNiz")
            {
                rb.AddForce(Vector2.up * jump * 2);
            }
            if (collision.gameObject.tag == "NizNiz")
            {
                rb.AddForce(Vector2.down * jump * 3);
            }
            
        }

     
    }
 
}
