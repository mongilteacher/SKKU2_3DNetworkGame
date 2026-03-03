using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UI_Score : MonoBehaviour
{
    private List<UI_ScoreItem> _items;


    private void Start()
    {
        _items = GetComponentsInChildren<UI_ScoreItem>().ToList();
    }
    
    private void Refresh()
    {
        
    }
}
