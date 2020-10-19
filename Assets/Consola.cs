using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Consola : MonoBehaviour
{
    public InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Input value" + ":" + inputField.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
