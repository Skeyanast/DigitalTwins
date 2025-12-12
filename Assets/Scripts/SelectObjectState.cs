namespace Assets.Scripts
{
    class SelectObjectState : ISelectedState
    {
        public void Edit(PhysicalObjectPresentation obj)
        {
            obj.SelectedState = new EditObjectState();
            // TODO
        }

        public void Passive(PhysicalObjectPresentation obj)
        {
            obj.SelectedState = new PassiveObjectState();
            // TODO
        }

        public void Select(PhysicalObjectPresentation obj) { }
    }
}
