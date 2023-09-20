using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArm : MonoBehaviour
{

    Rigidbody2D myBody;
   // SoundManager mySoundmanager;
    //scripts are also compo0nent, just you made
    float armPower = 200f;

    // Start is called before the first frame update
    void Start()
    {
       // mySoundmanager = GetComponent<SoundManager>();
        myBody = GetComponent<Rigidbody2D>();//same as public&draging obj   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            myBody.AddForce(transform.up * armPower, ForceMode2D.Impulse);
            //mysoundManager.myAudioSource.PlayOneShot(mySoundManager.armSound);
        }
    }
}
