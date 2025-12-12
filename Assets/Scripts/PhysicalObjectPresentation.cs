using UnityEngine;

namespace Assets.Scripts
{
    public class PhysicalObjectPresentation
    {
        public PhysicalObject PhysicalObject { get; }
        public ISelectedState SelectedState { get; set; }

        public PhysicalObjectPresentation(GameObject gameObject, ISelectedState selectedState)
        {
            PhysicalObject = new PhysicalObject(gameObject);
            SelectedState = selectedState;
        }

        public void Edit()
        {
            SelectedState.Edit(this);
        }

        public void Select()
        {
            SelectedState.Select(this);
        }

        public void Deselect()
        {
            SelectedState.Passive(this);
        }
    }
}
