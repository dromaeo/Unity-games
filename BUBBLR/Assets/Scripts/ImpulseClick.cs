using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseClick : MonoBehaviour{

    private Vector3 target;

    public float ImpulseForce;
    private Vector2 direction;
    private float distance;
    private float forceRate;

    void Start()
    {
        target = transform.position;
    }

    void Update() 
    {
        if (Input.GetMouseButton(0)) 
        {
            this.GetComponent<CircleCollider2D>().enabled = true;
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Vector3.MoveTowards(transform.position, target, 10000 * Time.deltaTime);
        }
        else
        {
            this.GetComponent<CircleCollider2D>().enabled = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (Input.GetMouseButton(0) && other.gameObject.CompareTag("Bubble"))
        {
            	direction = transform.position - other.transform.position;
				distance = direction.magnitude;
				direction = direction.normalized;
				forceRate = (ImpulseForce/ distance);
				other.GetComponent<Rigidbody2D>().AddForce(-direction * (forceRate / other.GetComponent<Rigidbody2D>().mass));
        }
    }  
}

    
    