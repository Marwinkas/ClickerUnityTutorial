using UnityEngine;
using UnityEngine.UI;
public class Click : MonoBehaviour
{
    public static int _money;
    private int _clickcount = 1;
    [SerializeField]private Text _moneytext;
    public void GetClickCount(int clickcount)
    {
        _clickcount += clickcount;
    }
    void Update()
    {
        _moneytext.text = _money + "$";
    }
    public void Clicked()
    {
        _money += _clickcount;
    }
}
