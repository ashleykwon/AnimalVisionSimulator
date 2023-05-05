using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ObjectDropdown;
using TMPro;

public class ObjectVisPhoton : MonoBehaviour
{
    public TMP_Text normalVisionTextTemplate;
    public GameObject applePrefab;

    // Start is called before the first frame update
    void Start()
    {
        ObjectDropdown.RGBSpawner();
        ObjectDropdown.DeuteranopiaSpawner();
        ObjectDropdown.MonochromacySpawner();

        GameObject RGBApple = Instantiate(applePrefab);
        GameObject DeuteranopiaApple = Instantiate(applePrefab);
        GameObject MonochromacyApple = Instantiate(applePrefab);

        RGBApple.transform.position = new Vector3(500, -100, 800);
        DeuteranopiaApple.transform.position = new Vector3(0, -100, 800);
        MonochromacyApple.transform.position = new Vector3(-500, -100, 800);

        RGBApple.transform.localScale = new Vector3(1000f, 1000f, 1000f);
        DeuteranopiaApple.transform.localScale = new Vector3(1000f, 1000f, 1000f);
        MonochromacyApple.transform.localScale = new Vector3(1000f, 1000f, 1000f);

        TMP_Text normalVisionText = Instantiate(normalVisionTextTemplate);
        normalVisionText.text = "Normal Vision";
        normalVisionText.transform.position  = new Vector3(0, -10, 800);
        normalVisionText.color = new Color(0f, 0f, 0f, 1f);

        TMP_Text deuteranopiaText = Instantiate(normalVisionTextTemplate);
        deuteranopiaText.text = "Green-Blind";
        deuteranopiaText.transform.position  = new Vector3(500, -10, 800);

        TMP_Text monochromacyText = Instantiate(normalVisionTextTemplate);
        monochromacyText.text = "Monochromacy";
        monochromacyText.transform.position  = new Vector3(-500, -10, 800);
    }
}
