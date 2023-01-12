using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerScript : MonoBehaviour
{
    public float Drawerpos;
   

    void Start()
    {
        Drawerpos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {   
        

        transform.position= new Vector3(0, Drawerpos, 0);
    }

    public void Handle(float newDrawerpos)
    {
        Drawerpos = newDrawerpos;
    }
}
