using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static VisionDropdown;


public class ObjectDropdown : MonoBehaviour
{
    // public TMPro.TMP_Dropdown objectDropdown;

    // // Get the current vision mode
    // public TMPro.TMP_Dropdown visionDropdown;
    // int visionVal;


    void Start()
    {
        RGBSpawner();
        RGBProtanopiaSpawner();
        DeuteranopiaSpawner();

    }

    // public void Update()
    // {
    //     bool triggerRight = OVRInput.Get(OVRInput.Button.Two);

    //     if (triggerRight)
    //     {
    //         Debug.Log("Dropdown menu triggered");
    //         ObjectSelector();
    //     }
    // }

  
    public void RGBSpawner()
    {  
        for (int x = 0; x <= 255; x+=50)
        {
            for (int y = 0; y <= 255; y+=50)
            {
                for (int z = 0; z <= 255; z+=50)
                {
                    GameObject dataPoint = GameObject.CreatePrimitive(PrimitiveType.Sphere);

                    dataPoint.GetComponent<Renderer>().material.color = new Color(x/255f, y/255f, z/255f, 1f);
                    dataPoint.transform.position = new Vector3(x, y, z+500);
                    dataPoint.transform.localScale = new Vector3(10f, 10f, 10f);
                    Debug.Log(dataPoint.GetComponent<Renderer>().material.color);
                }
            }
        }
    }

    public void RGBProtanopiaSpawner()
    {
        for (int x = 0; x <= 255; x+=50)
        {
            for (int y = 0; y <= 255; y+=50)
            {
                for (int z = 0; z <= 255; z+=50)
                {
                    GameObject dataPoint = GameObject.CreatePrimitive(PrimitiveType.Sphere);

                    Vector3 RGB = new Vector3(x/255f, y/255f, z/255f);
                    Vector3 LMS = VisionDropdown.RGBToLMS(RGB);
                    Vector3 protanopiaRGB = VisionDropdown.LMSToRGB(VisionDropdown.ProtanopiaSimulator(LMS));

                    dataPoint.GetComponent<Renderer>().material.color = new Color(protanopiaRGB[0], protanopiaRGB[1], protanopiaRGB[2], 1f);
                    dataPoint.transform.position = new Vector3(x-500, y, z+500);
                    dataPoint.transform.localScale = new Vector3(10f, 10f, 10f);
                    Debug.Log(dataPoint.GetComponent<Renderer>().material.color);
                }
            }
        }
    }

    public void DeuteranopiaSpawner()
    {
        for (int x = 0; x <= 255; x+=50)
        {
            for (int y = 0; y <= 255; y+=50)
            {
                for (int z = 0; z <= 255; z+=50)
                {
                    GameObject dataPoint = GameObject.CreatePrimitive(PrimitiveType.Sphere);

                    Vector3 RGB = new Vector3(x/255f, y/255f, z/255f);
                    Vector3 LMS = VisionDropdown.RGBToLMS(RGB);
                    Vector3 deuteranopiaRGB = VisionDropdown.LMSToRGB(VisionDropdown.DeuteranopiaSimulator(LMS));

                    dataPoint.GetComponent<Renderer>().material.color = new Color(deuteranopiaRGB[0], deuteranopiaRGB[1], deuteranopiaRGB[2], 1f);
                    dataPoint.transform.position = new Vector3(x+500, y, z+500);
                    dataPoint.transform.localScale = new Vector3(10f, 10f, 10f);
                    Debug.Log(dataPoint.GetComponent<Renderer>().material.color);
                }
            }
        }
    }

}
