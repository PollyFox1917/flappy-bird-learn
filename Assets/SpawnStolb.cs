using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStolb : MonoBehaviour
   
{
    public GameObject _Stolb_1;
    
    public float _Min;
    public float _Max;
    private float _Size = 10f;
    public int _Spawn_blockcount;
    private Vector3 spawn_position;
   
    void Start()
    {
        
            spawn_position = gameObject.transform.position;
           


        for (int i = 0; i < _Spawn_blockcount; i++)
        {
            spawn_position = new Vector3(spawn_position.x + _Size, Random.Range(_Min,_Max), spawn_position.z) ;
            Instantiate(_Stolb_1, spawn_position, Quaternion.identity);
       
        }

        
    }

    
}
