using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public int hpNow;
    public int damage = 5;
    private hpEnemy hpEnemyScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hpNow = health;
        hpEnemyScript = GetComponent<hpEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.U))
        {
            takeDamage(20);
        }
    }

    void takeDamage(int damageAmount)
    {
        hpNow -= damageAmount;
        if(hpNow <= 0)
        {
            hpNow = 0;
            Debug.Log("Enemy is dead.");
            return;
        }
        Debug.Log("Enemy Menerima: " + damageAmount + ", Hp Sekarang: " + hpNow);
    }

    void attackPlayer()
    {
        // Method untuk menyerang player
        Debug.Log("Enemy menyerang dengan damage: " + damage);
    }
}
