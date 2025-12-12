namespace Assets.Scripts
{
    class EditObjectState : ISelectedState
    {
        public void Edit(PhysicalObjectPresentation obj) { }

        public void Passive(PhysicalObjectPresentation obj)
        {
            obj.SelectedState = new PassiveObjectState();
            // TODO
        }

        public void Select(PhysicalObjectPresentation obj)
        {
            obj.SelectedState = new SelectObjectState();
            // TODO
        }
    }
}
