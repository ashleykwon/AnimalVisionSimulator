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
        TritanopiaSpawner();

    }

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
                    dataPoint.transform.position = new Vector3(x, y, z+800);
                    dataPoint.transform.localScale = new Vector3(10f, 10f, 10f);
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
                    dataPoint.transform.position = new Vector3(x-500, y, z+800);
                    dataPoint.transform.localScale = new Vector3(10f, 10f, 10f);
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
                    dataPoint.transform.position = new Vector3(x+500, y, z+800);
                    dataPoint.transform.localScale = new Vector3(10f, 10f, 10f);
                }
            }
        }
    }

    public void TritanopiaSpawner()
    {
        for (int x = 0; x <= 255; x+=50)
        {
            for (int y = 0; y <= 255; y+=50)
            {
                for (int z = 0; z <= 255; z+=50)
                {
                    GameObject dataPoint = GameObject.CreatePrimitive(PrimitiveType.Sphere);

                    Vector3 RGB = new Vector3(x/255f, y/255f, z/255f);
                    Vector3 XYZ = VisionDropdown.RGBToXYZ(RGB);
                    Vector3 LMS = VisionDropdown.XYZToLMS(XYZ);
                    //Vector3 tritanopiaRGB = VisionDropdown.LMSToRGB(VisionDropdown.TritanopiaSimulator(LMS));
                    Vector3 tritanopiaRGB = VisionDropdown.TritanopiaSimulator(LMS);
                    float cieX = tritanopiaRGB[0]*1.9102f - 1.1121f*tritanopiaRGB[1] + 0.2019f*tritanopiaRGB[2];
                    float cieY = 0.3710f*tritanopiaRGB[0] + 0.6291f*tritanopiaRGB[1];
                    float cieZ = tritanopiaRGB[2];
                    Vector3 newTritanopiaRGB = new Vector3((3.2404f*cieX - 1.5371f*cieY - 0.4985f*cieZ), 
                    (-0.9693f*cieX + 1.8760f*cieY + 0.0416f*cieZ), 
                    (0.0556f*cieX - 0.2040f*cieY + 1.0572f*cieZ));
                    dataPoint.GetComponent<Renderer>().material.color = new Color(newTritanopiaRGB[0], newTritanopiaRGB[1], newTritanopiaRGB[2], 1f);
                    
                    
                    dataPoint.transform.position = new Vector3(x+1000, y, z+800);
                    dataPoint.transform.localScale = new Vector3(10f, 10f, 10f);
                }
            }
        }
    }

}
