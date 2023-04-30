using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static VisionDropdown;


public class ObjectDropdown : MonoBehaviour
{
    public TMPro.TMP_Dropdown objectDropdown;

    // Get the current vision mode
    public TMPro.TMP_Dropdown visionDropdown;
    int visionVal;


    void Start()
    {
        Debug.Log(visionDropdown.value);
        
    }

    // Selects 3D model to visualize
    public void ObjectSelector()
    {
        visionVal = visionDropdown.value;

        // Delete all objects that are already in the scene

        // Spawn rgb color space if the dropdown menu value is 0
        if (objectDropdown.value == 0)
        {   
            // Check which vision mode the user is currently in and call the appropriate vision mode function
            
            // spawn RGB space
            
            
        }
        else if (objectDropdown.value == 1)
        {
            // Check which vision mode the user is currently in
            // spawn CIELAB color space
        }
        // else
        // {
               // Check which vision mode the user is currently in
        //     // spawn something else
        // }
    }

    public void RGBSpawner(int visionVal)
    {
        for (int x = 0; x <= 255; x++)
        {
            for (int y = 0; y <= 255; y++)
            {
                for (int z = 0; z <= 255; z++)
                {
                    GameObject dataPoint = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    dataPoint.GetComponent<Renderer>().material.color =  new Color(x/255, y/255, z/255, 1f);
                    dataPoint.transform.position = new Vector3(x+10, y+10, z+10);
                }
            }
        }
    }

}
