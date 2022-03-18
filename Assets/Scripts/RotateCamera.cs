using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
   private Vector2 _rotation;
    [SerializeField] public float _speed = 100;
    [SerializeField] public float rotationSpeed = 1f;

    // Update is called once per frame
    private void Update()
    {
        Vector3 forward = transform.forward;
        Debug.DrawRay(transform.position, forward * 10, Color.grey);
        float _rotation = Input.GetAxis("Trigger") * rotationSpeed;
        Debug.Log(_rotation);
        
        transform.Rotate(0, _rotation * _speed * Time.deltaTime, 0);
        
        
            
        //Cursor.UpdateAllNavMesh();//Auto reconfigure navmesh after rotating
    }
}
