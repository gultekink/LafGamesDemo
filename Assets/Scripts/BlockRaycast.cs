using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRaycast : MonoBehaviour
{
    private Rigidbody _rigidbody;

    [SerializeField] private float _distance;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position,gameObject.transform.up);
        if (Physics.Raycast(ray, out hit, _distance))
            {
                _rigidbody.isKinematic = true;
                
            }
        
    }
}
