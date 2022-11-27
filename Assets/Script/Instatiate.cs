using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instatiate : MonoBehaviour
{
    public GameObject spawnable;
    public GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(spawnable, parent.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
