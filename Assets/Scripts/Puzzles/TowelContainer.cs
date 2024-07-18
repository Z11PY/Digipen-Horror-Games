using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowelContainer : MonoBehaviour
{
    int towels = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void IncreaseTowelCount()
    {
        towels++;
        Destroy(gameObject);
    }
}
