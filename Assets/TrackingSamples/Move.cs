using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 0;
    public GameObject _Player;
    private Vector3 moveDirection = Vector3.zero;
    public static bool OtherIstracked = false;
    void Update()
    {        
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            _Player.transform.Translate(moveDirection * Time.deltaTime);

            Vector3 v1 = new Vector3(0, 0, -800.0f);
            Vector3 v2 = new Vector3(0, 0, 800);
            if (OtherIstracked)
            {
                //_Player.transform.position.Set(0, 0, -800);
                if (_Player.transform.position.z != -800)
                {
                    _Player.transform.Translate(v1);
                }                
                Debug.Log("Tracked!");
            }
            else
            {
                //_Player.transform.position.Set(0, 0, 0);                
                if (_Player.transform.position.z != 0)
                {
                    _Player.transform.Translate(v2);
                    
                    Debug.Log("Not Tracked!");
                }
                
            }

            
    }
}
