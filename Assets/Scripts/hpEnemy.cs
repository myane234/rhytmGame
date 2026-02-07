using UnityEngine;
using UnityEngine.UI;

public class hpEnemy : MonoBehaviour
{
    public Image EnemyHpBar;
    public Enemy enemyScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        float hpRasio = (float)enemyScript.hpNow / enemyScript.health;
        EnemyHpBar.fillAmount = hpRasio;
    }
}
