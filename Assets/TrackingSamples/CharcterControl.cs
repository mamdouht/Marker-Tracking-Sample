using UnityEngine;
using System.Collections;

public class CharcterControl : MonoBehaviour
{
    public float WalkSpeed = 70;
    public float RunSpeed = 120;
    public float RotateSpeed = 7;

    CharacterController Controller;
    Animation Anim;
    float Speed;

    void Update()
    {
        Controller = GetComponent<CharacterController>();
        Anim = GetComponent<Animation>();
        Vector3 Ver = transform.TransformDirection(Vector3.forward);
        Vector3 Hor = transform.TransformDirection(Vector3.right);

        if (Input.GetButton("Shift"))
            Speed = RunSpeed;
        else
            Speed = WalkSpeed;

        //Event e = Event.current;
        //if (e.shift)
        //    Speed = RunSpeed;
        //else
        //    Speed = WalkSpeed;

        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
            Anim.Play("idle", PlayMode.StopAll);


        if (Input.GetAxis("Vertical") > 0)
        {
            Controller.Move((Ver * (Speed * Input.GetAxis("Vertical"))) * Time.deltaTime);
            Anim.Play("walk", PlayMode.StopAll);
        }
        else
        {
            Controller.Move((Ver * (Speed * Input.GetAxis("Vertical"))) * Time.deltaTime);
            Anim.Play("walk", PlayMode.StopAll);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * RotateSpeed, 0);
            //    Controller.Move((Hor * (speed * Input.GetAxis("Horizontal"))) * Time.deltaTime);
            Anim.Play("walk", PlayMode.StopAll);
        }
        else
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * RotateSpeed, 0);
            //  Controller.Move((Hor * (speed * Input.GetAxis("Horizontal"))) * Time.deltaTime);
            Anim.Play("walk", PlayMode.StopAll);
        }


    }

}