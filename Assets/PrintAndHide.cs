using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;

    private int i = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name + ":" + i);
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (gameObject.CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.CompareTag("Blue") && i == Random.Range(150, 251))
        {
            if (rend != null)
            {
                rend.enabled = false;
            }
        }


    }
}
