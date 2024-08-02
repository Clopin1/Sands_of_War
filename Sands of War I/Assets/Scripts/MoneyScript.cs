using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class MoneyScript : MonoBehaviour
{
    public GameObject prizeButton;
    
    public static int money;

    private TMP_Text moneyText;

    public float fixedMoneyGain;

    private void Awake()
    {
        moneyText = GetComponent<TMP_Text>();
    }
    private void Start()
    {
        money = 30;
    }

    public void FixedGain()
    {
        if (fixedMoneyGain >= 2.75f)
        {
            money++;
            fixedMoneyGain = 0;
        }
    }

    void Update()
    {
        fixedMoneyGain += Time.deltaTime;

        FixedGain();

        if (money == 400)
        {
            prizeButton.SetActive(true);
        }

        moneyText.text = money.ToString();
    }
}
