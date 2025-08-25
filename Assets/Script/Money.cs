using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
   
    public Text MoneyText;

    public void SetMoney(int target)
    {
        string UserMoney = string.Format("{0:N0}",target);
        MoneyText.text = UserMoney;
    }
}
