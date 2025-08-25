using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PopupBank : MonoBehaviour
{
    public GameObject Popup;
    public GameObject Atm;
    public GameObject Deposit;
    public GameObject Withdraw;
    public Button Depositbtn;
    public Button Withdrawbtn;
    public InputField inputFieldDeposit;
    public InputField inputFieldWithdraw;




    public void OnclickDepositButton()
    {
        Deposit.SetActive(true);
        Atm.SetActive(false);
    }

    public void OnclickWithdrawButton()
    {
        Withdraw.SetActive(true);
        Atm.SetActive(false);
    }

    public void ClosePopupButton()
    {
        Deposit.SetActive(false);
        Withdraw.SetActive(false);
        Atm.SetActive(true);
    }

    public void DepositBtn(int amt)
    {
        if (GameManager.instance.userData.Cash < amt)
        {
            Popup.SetActive(true);
            return;
        }
        GameManager.instance.userData.Cash -= amt;
        GameManager.instance.userData.Balance += amt;
        GameManager.instance.Refresh();
        GameManager.instance.SaveUserData();
    }



    public void WithdrawBtn(int amt)
    {
        if (GameManager.instance.userData.Balance < amt)
        {
            Popup.SetActive(true);
            return;
        }
        GameManager.instance.userData.Cash += amt;
        GameManager.instance.userData.Balance -= amt;
        GameManager.instance.Refresh();
        GameManager.instance.SaveUserData();
    }

    public void DepositInputfield()
    {
        DepositBtn(int.Parse(inputFieldDeposit.text));       
    }

    public void WithdrawInputfield()
    {
        WithdrawBtn(int.Parse(inputFieldWithdraw.text));
    }

    public void ClosePopup()
    { 
        Popup.SetActive(false);    
    }        
          
}
