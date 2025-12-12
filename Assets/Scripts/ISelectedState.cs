namespace Assets.Scripts
{
    public interface ISelectedState
    {
        public void Select(PhysicalObjectPresentation obj);
        public void Passive(PhysicalObjectPresentation obj);
        public void Edit(PhysicalObjectPresentation obj);
    }
}
