using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MessageBubbleSpawner : MonoBehaviour
{
    public GameObject[] MessageBubblePrefab;
    public Vector2 center;
    public Vector2 size;
    
    public int nBubble;
    public int nBubbleMax;
    public int nBubbleToSpawn;

    private Scene ThisScene;
    public string scene;

    void Start()
    {    
        ThisScene = SceneManager.GetActiveScene();
        scene = ThisScene.name;       
    }

    void Update()
    {
       if(scene == "Level" || scene == "TestScene")
       {
        nBubble = GameObject.FindGameObjectsWithTag("Bubble").Length;
        nBubbleToSpawn = nBubbleMax - nBubble;
            
        if(nBubble < nBubbleMax)
        {
            SpawnMessageBubble();
        }
       }
    }

    void SpawnMessageBubble()
    {
        for(int i = 0; i < nBubbleToSpawn; i++)
        {
        int randomIndex = Random.Range(0, MessageBubblePrefab.Length);
        Vector2 pos0 = new Vector2(Random.Range(-size.x/2, size.x/2), Random.Range(-size.y/2, size.y/2));
        Instantiate(MessageBubblePrefab[randomIndex], pos0, Quaternion.identity);
        }
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1,0,0.5f);
        Gizmos.DrawCube(center,size);
    }
}
