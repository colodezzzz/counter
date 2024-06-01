using UnityEngine;
using UnityEngine.UI;

public class CounterIndicator : MonoBehaviour
{
    [SerializeField] private Text _amountText;

    public void SetAmount(int amount)
    {
        _amountText.text = amount.ToString();
    }
}
