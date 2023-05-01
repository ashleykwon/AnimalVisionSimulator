using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ObjectDropdown;

public class ObjectVisPhoton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ObjectDropdown.RGBSpawner();
        ObjectDropdown.DeuteranopiaSpawner();
        ObjectDropdown.MonochromacySpawner();
    }
}
