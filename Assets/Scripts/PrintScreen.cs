using UnityEngine;
using System.Collections;


public class PrintScreen : MonoBehaviour
{

    public int printCounter;
    public int increment;

    // Use this for initialization
    void Start()
    {
        printCounter = 0;
        increment = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetButtonDown("Print")))
        {
            if (printCounter < increment)
            {
                printCounter++;
                increment++;
                Application.CaptureScreenshot("Screenshots/Run " + printCounter + ".png");

            }

        }
    }
}
