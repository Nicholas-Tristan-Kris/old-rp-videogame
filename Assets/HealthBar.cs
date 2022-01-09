using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DevionGames.InventorySystem;
using DevionGames.StatSystem;

public class HealthBar : MonoBehaviour
{
    private GameObject player;
    private Health playerHealth;
    private Image healthBar;
    [StatPicker]
    [SerializeField]
    private Attribute healthStat;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = this.GetComponent<Image>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<Health>();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(healthStat.CurrentValue);
        Debug.Log(healthStat.MaxValue);
        healthBar.fillAmount = (float) healthStat.CurrentValue / (float) healthStat.MaxValue;
    }
}
