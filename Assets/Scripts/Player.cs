
using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : NetworkBehaviour
{


    void HandlePlayerMovement()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        var x = Input.GetAxis("Horizontal") * 0.05f;
        var z = Input.GetAxis("Vertical") * 0.05f;

        transform.Translate(x, 0, z);
    }

    void HandlePlayerRotation()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        var mouseX = Input.GetAxis("Mouse X") * 3f;
        var mouseY = Input.GetAxis("Mouse Y") * 3f;

        transform.Rotate(0, mouseX, 0);
        Camera.main.transform.Rotate(-mouseY, 0, 0);
    }

    void HandlePlayerShoot()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        // if (Input.GetMouseButtonDown(0))
        // {
        //     CmdFire();
        // }
    }

    // [Command]
    // void CmdFire()
    // {
    //     var bullet = Instantiate(Resources.Load("Bullet")) as GameObject;
    //     bullet.transform.position = transform.position + Camera.main.transform.forward;

    //     bullet.GetComponent<Rigidbody>().velocity = Camera.main.transform.forward * 4;

    //     NetworkServer.Spawn(bullet);

    //     Destroy(bullet, 2.0f);
    // }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandlePlayerMovement();
        // HandlePlayerRotation();
        // HandlePlayerShoot();
    }
}
