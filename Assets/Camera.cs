using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform _Player;
   public Transform _Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _Camera.position = new Vector3 (_Player.position.x + 8, _Camera.position.y, -10);
    }
}
