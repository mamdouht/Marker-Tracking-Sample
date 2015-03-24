using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
    public Transform Target;
    public Transform Tracker;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //transform.LookAt(Target);
        Vector3 UpVector = Tracker.transform.position.normalized * -1;
        
        Quaternion TargetRotation = Quaternion.LookRotation(Target.position - transform.position, UpVector);
        transform.rotation = Quaternion.Slerp(transform.rotation, TargetRotation, Time.deltaTime * 2);        
	}
}
