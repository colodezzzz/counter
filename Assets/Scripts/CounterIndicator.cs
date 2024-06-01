using UnityEngine;
using UnityEngine.UI;

public class CounterIndicator : MonoBehaviour
{
    [SerializeField] private Text _amountText;
    [SerializeField] private Counter _counter;

    private void Update()
    {
        _amountText.text = _counter.Amount.ToString();
    }
}
