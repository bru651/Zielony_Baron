using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammove : MonoBehaviour

{
    private Vector3 cameraPos;
    [Header("Camera Settings")]
    public float cameraSpeed;
    // Start is called before the first frame update
    void Start()
    {
        cameraPos=this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            cameraPos.y+=cameraSpeed;
        }
        if(Input.GetKey(KeyCode.S))
        {
            cameraPos.y-=cameraSpeed;
        }
        if(Input.GetKey(KeyCode.A))
        {
            cameraPos.x-=cameraSpeed;
        }
        if(Input.GetKey(KeyCode.D))
        {
            cameraPos.x+=cameraSpeed;
        }
        this.transform.position=cameraPos;
    }
}
