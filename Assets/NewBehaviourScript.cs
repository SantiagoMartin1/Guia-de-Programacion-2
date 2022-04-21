using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int counter;
    public int counterMax;
    // Start is called before the first frame update
    void Start()
    {
    while (counter <= counterMax)
    {

    Debug.Log("Esto se esta repitiendo" + counter);
    counter++;

    }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
