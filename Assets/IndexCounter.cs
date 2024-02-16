using TMPro;
using UnityEngine;

public class IndexCounter : MonoBehaviour
{
    public TextMeshProUGUI _test;
    int index = 0;
    private void OnEnable()
    {
        _test.text = index.ToString();
    }

    public void OnClick()
    {
        index++;
        _test.text = index.ToString();
    }
}
