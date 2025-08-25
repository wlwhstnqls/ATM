using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RealCash : MonoBehaviour
{
    public int Money;
    public Text MoneyText;

    void Start()
    {
        string UserMoney = string.Format("{0:N0}", Money);
        MoneyText.text = UserMoney;
    }
}
