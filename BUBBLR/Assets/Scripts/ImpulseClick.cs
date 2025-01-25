using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ImpulseClick : MonoBehaviour{

private Vector3 target;

public float ImpulseForce;
private Vector2 direction;
private float distance;
private float forceRate;
public float ScaleMax;

public bool OnTrigger;

void Start()
{
   

}

void Update() 
{
    if (Input.GetMouseButton(0)) 
    {
        this.GetComponent<CircleCollider2D>().enabled = true;
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector3.MoveTowards(transform.position, target, 10000 * Time.deltaTime);
    }
    else if((Input.GetMouseButton(1)))
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
        if (Input.GetMouseButton(0) && other.gameObject.tag == "Bubble")
        {
            	direction = transform.position - other.transform.position;
				distance = direction.magnitude;
				direction = direction.normalized;
				forceRate = (ImpulseForce/ distance);
				other.GetComponent<Rigidbody2D>().AddForce(-direction * (forceRate / other.GetComponent<Rigidbody2D>().mass));
        }
    }  
    
    void OnTriggerStay2D (Collider2D other)
    {
        if(Input.GetMouseButton(1) && other.gameObject.tag == "Bubble" &&  other.transform.localScale.y < ScaleMax)
        {         
            other.transform.localScale += new Vector3(0.1f,0.1f,0.1f);
            OnTrigger = true;
        }
        else
        {
            OnTrigger = false;
        }
    }

    void OnTriggerExit2D (Collider2D other)
    {
        if(other.gameObject.tag == "Bubble")
        { 
            OnTrigger = false;
        }
    }
}
