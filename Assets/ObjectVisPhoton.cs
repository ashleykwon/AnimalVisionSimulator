using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ObjectDropdown;

public class ObjectVisPhoton : MonoBehaviour
{
    //public TMP_Text normalVisionTextTemplate;

    // Start is called before the first frame update
    void Start()
    {
        ObjectDropdown.RGBSpawner();
        ObjectDropdown.DeuteranopiaSpawner();
        ObjectDropdown.MonochromacySpawner();

        // TMP_Text normalVisionText = Instantiate(normalVisionTextTemplate);
        // normalVisionText.text = "Normal Vision";
        // normalVisionText.transform.position  = new Vector3(0, -10, 800);
    }
}
