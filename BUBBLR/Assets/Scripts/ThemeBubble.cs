using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeBubble : MonoBehaviour
{

    public bool Theme1;
    public bool Theme2;
    public bool Theme3;
    public bool Theme4;    

    public int life;
    
    public float ScaleMin;
    public float ScaleMax;
    private float Scaling;

    public float UpscaleTimer;
    public Animation BubbleBurst;
    public GameObject BubbleToDestroy;

    void Start()
    {
        Scaling = ((ScaleMax - ScaleMin)/16);
        life = 3;
    }

    void Update()
    {
        if(life == 0)
        {
            Debug.Log("GameOver!");
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        BubbleToDestroy = other.gameObject;
        
        //Theme1
        if(Theme1 == true && BubbleToDestroy.GetComponent<MessageBubble>().Theme1 == true)
        {
            if(this.transform.localScale.y != ScaleMax)
            {
                if(BubbleToDestroy.transform.localScale.y > 3.9f && BubbleToDestroy.transform.localScale.y < 5.0f)
                {
                    this.transform.localScale += new Vector3(Scaling,Scaling,Scaling);                    
                    Debug.Log("+1");               }
                else if(BubbleToDestroy.transform.localScale.y >= 5.0f && BubbleToDestroy.transform.localScale.y < 6.0f)
                {
                    this.transform.localScale += new Vector3(Scaling,Scaling,Scaling)*2;
                    Debug.Log("+2");                        
                }else if (BubbleToDestroy.transform.localScale.y >= 6.0f && BubbleToDestroy.transform.localScale.y < 7.0)
                {
                    this.transform.localScale += new Vector3(Scaling,Scaling,Scaling)*3;
                    Debug.Log("+3");  
                }else if(BubbleToDestroy.transform.localScale.y >= 7.0f && BubbleToDestroy.transform.localScale.y <= 8.1)
                {
                    this.transform.localScale += new Vector3(Scaling,Scaling,Scaling)*4;
                    Debug.Log("+4");  
                }
                Destroy(BubbleToDestroy);
            }
            else
            {
            Debug.Log("Win!");
            Destroy(BubbleToDestroy);
            }
        }
        else if(Theme1 == true && BubbleToDestroy.GetComponent<MessageBubble>().Theme1 == false)
        {
            life = life -1;
            Destroy(BubbleToDestroy);
        }

        //Theme2
        if(Theme2 == true && BubbleToDestroy.GetComponent<MessageBubble>().Theme2 == true)
        {
            if(this.transform.localScale.y != ScaleMax)
            {
                if(BubbleToDestroy.transform.localScale.y > 3.9f && BubbleToDestroy.transform.localScale.y < 5.0f)
                {
                    this.transform.localScale += new Vector3(Scaling,Scaling,Scaling);                    
                    Debug.Log("+1");               }
                else if(BubbleToDestroy.transform.localScale.y >= 5.0f && BubbleToDestroy.transform.localScale.y < 6.0f)
                {
                    this.transform.localScale += new Vector3(Scaling,Scaling,Scaling)*2;
                    Debug.Log("+2");                        
                }else if (BubbleToDestroy.transform.localScale.y >= 6.0f && BubbleToDestroy.transform.localScale.y < 7.0)
                {
                    this.transform.localScale += new Vector3(Scaling,Scaling,Scaling)*3;
                    Debug.Log("+3");  
                }else if(BubbleToDestroy.transform.localScale.y >= 7.0f && BubbleToDestroy.transform.localScale.y <= 8.1)
                {
                    this.transform.localScale += new Vector3(Scaling,Scaling,Scaling)*4;
                    Debug.Log("+4");  
                }
                Destroy(BubbleToDestroy);
            }
            else
            {
            Debug.Log("Win!");
            Destroy(BubbleToDestroy); 
            }
        }
        else if((Theme2 == true && BubbleToDestroy.GetComponent<MessageBubble>().Theme2 == false))
        {
            life = life -1;
            Destroy(BubbleToDestroy);
        }

        //Theme3
        if(Theme3 == true && BubbleToDestroy.GetComponent<MessageBubble>().Theme3 == true)
        {
            if(this.transform.localScale.y != ScaleMax)
            {
                if(BubbleToDestroy.transform.localScale.y > 3.9f && BubbleToDestroy.transform.localScale.y < 5.0f)
                {
                    this.transform.localScale += new Vector3(Scaling,Scaling,Scaling);                    
                    Debug.Log("+1");               }
                else if(BubbleToDestroy.transform.localScale.y >= 5.0f && BubbleToDestroy.transform.localScale.y < 6.0f)
                {
                    this.transform.localScale += new Vector3(Scaling,Scaling,Scaling)*2;
                    Debug.Log("+2");                        
                }else if (BubbleToDestroy.transform.localScale.y >= 6.0f && BubbleToDestroy.transform.localScale.y < 7.0)
                {
                    this.transform.localScale += new Vector3(Scaling,Scaling,Scaling)*3;
                    Debug.Log("+3");  
                }else if(BubbleToDestroy.transform.localScale.y >= 7.0f && BubbleToDestroy.transform.localScale.y <= 8.1)
                {
                    this.transform.localScale += new Vector3(Scaling,Scaling,Scaling)*4;
                    Debug.Log("+4");  
                }
                Destroy(BubbleToDestroy);
            }
            else
            {
            Debug.Log("Win!");
            Destroy(BubbleToDestroy);
            }
        }
        else if((Theme3 == true && BubbleToDestroy.GetComponent<MessageBubble>().Theme3 == false))
        {
            life = life -1;
            Destroy(BubbleToDestroy);
        }

        //Theme4
        if(Theme4 == true && BubbleToDestroy.GetComponent<MessageBubble>().Theme4 == true)
        {
            if(this.transform.localScale.y != ScaleMax)
            {
                if(BubbleToDestroy.transform.localScale.y > 3.9f && BubbleToDestroy.transform.localScale.y < 5.0f)
                {
                    this.transform.localScale += new Vector3(Scaling,Scaling,Scaling);                    
                    Debug.Log("+1");               }
                else if(BubbleToDestroy.transform.localScale.y >= 5.0f && BubbleToDestroy.transform.localScale.y < 6.0f)
                {
                    this.transform.localScale += new Vector3(Scaling,Scaling,Scaling)*2;
                    Debug.Log("+2");                        
                }else if (BubbleToDestroy.transform.localScale.y >= 6.0f && BubbleToDestroy.transform.localScale.y < 7.0)
                {
                    this.transform.localScale += new Vector3(Scaling,Scaling,Scaling)*3;
                    Debug.Log("+3");  
                }else if(BubbleToDestroy.transform.localScale.y >= 7.0f && BubbleToDestroy.transform.localScale.y <= 8.1)
                {
                    this.transform.localScale += new Vector3(Scaling,Scaling,Scaling)*4;
                    Debug.Log("+4");  
                }
                Destroy(BubbleToDestroy);
            }
            else
            {
            Debug.Log("Win!");
            Destroy(BubbleToDestroy);
            } 
        }
        else if(Theme4 == true && BubbleToDestroy.GetComponent<MessageBubble>().Theme4 == false)
        {
            life = life -1;
            Destroy(BubbleToDestroy);
        }
    }

    IEnumerator BubbleBurstAnimation()
	{
        //BubbleBurst.Play("");
        this.transform.localScale += new Vector3(0.1f,0.1f,0.1f);
        Destroy(BubbleToDestroy);
        yield return new WaitForSeconds(UpscaleTimer);   
	}
}
