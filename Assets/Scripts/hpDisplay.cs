using UnityEngine;
using UnityEngine.UI;

public class hpDisplay : MonoBehaviour
{
    public Image hpBar;
    public player playerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        // Update HP bar setiap frame berdasarkan hpNow
        float hpRatio = (float)playerScript.hpNow / playerScript.health;
        hpBar.fillAmount = hpRatio; //Use Image if u wanna use fillAmount
    }
}
