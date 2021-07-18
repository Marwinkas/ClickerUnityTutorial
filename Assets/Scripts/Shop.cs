using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private float[] _cost;
    [SerializeField] private int[] _cpscount;
    [SerializeField] private int _clickcount;
    [SerializeField] private int _cps;
    [SerializeField] private float _multiplier;

    [SerializeField] private Text[] _costtext;
    [SerializeField] private Text _cpstext;

    [SerializeField] private GameObject _clickobject;
    public void BuyPerClick()
    {
        if(Click._money >= _cost[0])
        {
            Click._money -= (int)_cost[0];
            _cost[0] *= _multiplier;
            _clickobject.GetComponent<Click>().GetClickCount(_clickcount);
            _costtext[0].text = (int)_cost[0] + "";
        }
    }
    public void BuyPerSecond(int select)
    {
        if(Click._money >= _cost[select])
        {
            Click._money -= (int)_cost[select];
            _cost[select] *= _multiplier;
            _cps += _cpscount[select - 1];
            _costtext[select].text = (int)_cost[select] + "";
        }
    }
    IEnumerator ClickPerSecond()
    {
        while (true)
        {
            Click._money += _cps;
            _cpstext.text = "DPS: " + _cps;
            yield return new WaitForSeconds(1);
        }
    }
    void Start()
    {
        StartCoroutine(ClickPerSecond());
    }
}
