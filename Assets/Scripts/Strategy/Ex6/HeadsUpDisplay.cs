using System;
using UnityEngine;
using UnityEngine.UI;

namespace Strategy.Ex6
{
  public class HeadsUpDisplay : MonoBehaviour
  {
    [SerializeField] private Button[] buttons;

    private void Start()
    {
      for (var i = 0; i < buttons.Length; i++)
      {
        int index = i;
        buttons[i].onClick.AddListener(() => OnButtonPressed?.Invoke(index));
      }
    }

    public event Action<int> OnButtonPressed;
  }
}