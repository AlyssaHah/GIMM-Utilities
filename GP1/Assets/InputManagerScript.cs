using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //NEED FOR UI


public class InputManagerScript : MonoBehaviour
{

    public Text outText;
    public InputField textIn;
    public Button enterButton;



    // Start is called before the first frame update
    void Start()
    {
        outText.text = "";
    }

    


    public void EnterPressed()
    {
        //outText.text = textIn.text;
        outText.text = Utilites.ProcessText(textIn.text);
    }

}
