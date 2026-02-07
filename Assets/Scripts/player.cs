using UnityEngine;

public class player : MonoBehaviour
{
    public int health = 100;
    public int hpNow;
    public int damage = 10;
    private hpDisplay hpDisplayScript;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hpNow = health;
        hpDisplayScript = GetComponent<hpDisplay>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)) {
            takeDamage(20);
        }
    }

    public void takeDamage(int damageAmount)
    {
        
        hpNow -= damageAmount;
        if (hpNow < 0)
        {
            hpNow = 0;
            Debug.Log("Player is dead.");
            return;
        }
        Debug.Log("Player took damage: " + damageAmount + ", Current HP: " + hpNow);
    }

    public void attackEnemy()
    {
        // Method untuk menyerang musuh
        Debug.Log("Player menyerang dengan damage: " + damage);
        // TODO: Implementasi logic penyerangan ke musuh
    }
}
