using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Move : MonoBehaviour
{
    [SerializeField] private float forward_speed;

    
    void Update()
    {
        Vector3 turn_right=new Vector3(5,transform.position.y,transform.position.z);
        Vector3 turn_left= new Vector3(-5,transform.position.y,transform.position.z);

        transform.position= new Vector3(Mathf.Clamp(transform.position.x,0,0),transform.position.y,Mathf.Clamp(transform.position.z,-240,445));

        gameObject.transform.Translate(Vector3.forward*Time.deltaTime*forward_speed);
        
    }
}
