using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

    bool rgbMaterialOn = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void switchMaterial()
    {
        rgbMaterialOn = !rgbMaterialOn;

        if (rgbMaterialOn)
        {
            Debug.Log("Enabling Keyword \"RGB_ON\"");
            Shader.EnableKeyword("RGB_ON");
            Shader.DisableKeyword("RGB_OFF");
        }else
        {
            Debug.Log("Disabling Keyword \"RGB_ON\"");
            Shader.EnableKeyword("RGB_OFF");
            Shader.DisableKeyword("RGB_ON");
        }
    }

}
