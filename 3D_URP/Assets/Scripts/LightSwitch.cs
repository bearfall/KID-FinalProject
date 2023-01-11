using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light Headlight;
    private bool isOpen = true;


    private void Start()
    {
        Headlight = GameObject.Find("HeadLight").GetComponent<Light>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isOpen)
            {
                Headlight.enabled = false;
                isOpen = false;
            }
            else
            {
                Headlight.enabled = true;
                isOpen = true;
            }
        }
    }
}
