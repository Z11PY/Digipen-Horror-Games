using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HideAfterXSeconds : MonoBehaviour
{
    public TextMeshProUGUI info;
    
    // Start is called before the first frame update
    void Start()
    {
        info.enabled = true;
        StartCoroutine(HideAfterTime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator HideAfterTime()
    {
        yield return new WaitForSeconds(10);
        info.enabled = false;
    }
}
