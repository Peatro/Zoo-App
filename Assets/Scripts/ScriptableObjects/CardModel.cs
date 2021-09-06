using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class CardModel : ScriptableObject
{
    public string title;
    public string descriptipon;
    public string exhibit;
    public Sprite animalImage;
}
