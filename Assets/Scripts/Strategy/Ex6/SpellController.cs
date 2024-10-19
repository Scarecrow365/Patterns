using Strategy.Ex6.Strategies;
using UnityEngine;

namespace Strategy.Ex6
{
  public class SpellController : MonoBehaviour
  {
    [SerializeField] private HeadsUpDisplay hud;
    [SerializeField] private SpellStrategy[] spellStrategy;

    private void OnEnable()
    {
      hud.OnButtonPressed += CastSpell;
    }

    private void OnDisable()
    {
      hud.OnButtonPressed -= CastSpell;
    }

    private void CastSpell(int index)
    {
      spellStrategy[index].CastSpell();
    }
  }
}