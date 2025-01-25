using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RandomText : MonoBehaviour
{
    public TMP_Text[] List;
    public TMP_Text Text;

    void Start()
    {
        
    }

    void Update()
    {
        TMP_Text Text = List[Random.Range(0, List.Length)];
    }
}
