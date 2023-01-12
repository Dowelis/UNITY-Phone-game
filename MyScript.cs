using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    protected Joystick joystick;
    protected JoyButton joybutton;

    protected bool jump;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<JoyButton>();
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joystick.Horizontal * 4f + Input.GetAxis("Horizontal") * 4f,
                                            rigidbody.velocity.y,
                                            joystick.Vertical * 4f + Input.GetAxis("Vertical") * 4f);
    }
}
