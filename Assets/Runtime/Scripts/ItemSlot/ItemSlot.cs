using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IDropHandler 
{
    [SerializeField] TextUI _text;
    [SerializeField] Image _bg;

    Optional<DragDropItemInfo> _itemToHold;
    public bool IsHoldingItem() => _itemToHold.Enabled;

    void Awake()  => ClearSlot();

    public void ClearSlot()
    {
        _bg.color = Color.white;
        _text.ResetText();
        _text.SetColor(Color.black);
        _itemToHold.DiscardValue();
    }

    void SetInfoOnSlot(DragDropItemInfo info)
    {
        _bg.color = info.bgColor;
        _text.SetText(info.text);
        _text.SetColor(info.textColor);
        _itemToHold.SetValue(info);
    }

    public void OnDrop(PointerEventData eventData) 
    {
        Debug.Log("OnDrop");

        if (eventData.pointerDrag != null) 
        {
            if(eventData.pointerDrag.GetComponent<DragDropItem>() is DragDropItem item)
            {
                //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                SetInfoOnSlot(item.GetInfo());
            }
                
        }
    }
}