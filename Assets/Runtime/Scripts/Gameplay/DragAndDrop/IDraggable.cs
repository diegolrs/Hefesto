using UnityEngine.EventSystems;

public interface IDraggable : IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler 
{
}