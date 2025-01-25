using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageBubble : MonoBehaviour
{
    public float ScaleMin;
  
    void Start()
    {
        
    }


    void Update()
    {
        if(this.transform.localScale.y > ScaleMin && GameObject.FindGameObjectWithTag ("ImpulseController").GetComponent<ImpulseClick>().OnTrigger == false)
        {
            this.transform.localScale -= new Vector3(0.0015f,0.0015f,0.0015f);
        }
    }
}
