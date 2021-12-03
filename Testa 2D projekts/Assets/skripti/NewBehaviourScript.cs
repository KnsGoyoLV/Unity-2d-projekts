using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string teksts;

    public GameObject text_input;

    public GameObject Show_text;

    public void text_Save()
    {
        teksts = InputField.GetComponoment<Text>().Text;


    }



}
