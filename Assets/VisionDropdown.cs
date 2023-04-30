using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ObjectDropdown;

public class VisionDropdown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static Vector3 RGBToLMS(Vector3 RGBVal) // From https://arxiv.org/pdf/1711.10662.pdf
    {
        float R = RGBVal[0];
        float G = RGBVal[1];
        float B = RGBVal[2];

        float L = 17.8824f*R + 43.5161f*G + 4.1194f*B;
        float M = 3.4557f*R + 27.1554f*G + 3.8671f*B;
        float S = 0.0300f*R + 0.1843f*G + 1.4671f*B;

        Vector3 LMS = new Vector3(L, M, S);
        return LMS;
    }

    public static Vector3 LMSToRGB(Vector3 LMSVal)
    {
        float L = LMSVal[0];
        float M = LMSVal[1];
        float S = LMSVal[2];

        float R = 0.0809f*L - 0.1305f*M + 0.1167f*S;
        float G = -0.0102f*L + 0.0540f*M - 0.1136f*S;
        float B = -0.0004f*L - 0.0041f*M + 0.6935f*S;

        Vector3 RGB = new Vector3(R, G, B);

        return RGB;
    }

    public static Vector3 ProtanopiaSimulator(Vector3 LMSVal)
    {
        float L = LMSVal[0];
        float M = LMSVal[1];
        float S = LMSVal[2];

        float Lp = 2.0234f*M -2.5258f*S;
        float Mp = M;
        float Sp = S;

        Vector3 ProtanopiaVec = new Vector3(Lp, Mp, Sp);
        return ProtanopiaVec;
    }

    public static Vector3 DeuteranopiaSimulator(Vector3 LMSVal)
    {
        float L = LMSVal[0];
        float M = LMSVal[1];
        float S = LMSVal[2];

        float Ld = L;
        float Md = 0.4942f*L + 1.2483f*S;
        float Sd = S;

        Vector3 DeuteranopiaVec = new Vector3(Ld, Md, Sd);
        return DeuteranopiaVec;
    }


}
