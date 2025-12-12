namespace Assets.Scripts
{
    class PassiveObjectState : ISelectedState
    {
        public void Edit(PhysicalObjectPresentation obj)
        {
            obj.SelectedState = new EditObjectState();
            // TODO
        }

        public void Passive(PhysicalObjectPresentation obj) { }

        public void Select(PhysicalObjectPresentation obj)
        {
            obj.SelectedState = new SelectObjectState();
            // TODO
        }
    }
}
