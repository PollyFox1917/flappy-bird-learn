using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBorder : MonoBehaviour
{

    public GameObject borderObj;
    public float size;
    private Vector3 spawn_position;
    public int blockcount;
    // Start is called before the first frame update
    void Start()
    {
        spawn_position = gameObject.transform.position;
        spawn_position.x = spawn_position.x + size / 2;
        Instantiate(borderObj,spawn_position,Quaternion.identity);

        for (int i = 0; i < blockcount; i++)
        {
            spawn_position.x = spawn_position.x + size;
            Instantiate(borderObj, spawn_position, Quaternion.identity);
        }

    }


    //
    }

