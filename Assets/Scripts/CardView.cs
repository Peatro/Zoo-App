using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    [SerializeField] private Text _title;
    [SerializeField] private Text _description;
    [SerializeField] private Text _exhibit;
    [SerializeField] private Image _animalImage;
    [SerializeField] private CardModel[] _cards;

    public void DisplayCard(int cardID)
    {        
        _title.text = _cards[cardID].title;
        _description.text = _cards[cardID].descriptipon;
        _exhibit.text = _cards[cardID].exhibit;
        _animalImage.sprite = _cards[cardID].animalImage;
    }
}
