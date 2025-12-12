using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class ChangeObjects : MonoBehaviour
    {
        [SerializeField]
        [InspectorName("PhysicalObjects")]
        private List<GameObject> _objectsInspector;

        private IList<PhysicalObjectPresentation> _objects;
        private IEnumerator<PhysicalObjectPresentation> _currentEnumerator;

        void Start()
        {
            _objects = new List<PhysicalObjectPresentation>();
            foreach (GameObject item in _objectsInspector)
            {
                if (item != null)
                {
                    _objects.Add(new PhysicalObjectPresentation(item, new PassiveObjectState())); 
                }
            }
            _currentEnumerator = _objects.GetEnumerator();
            MoveNext();
            _currentEnumerator.Current.Select();
        }

        void Update()
        {

        }

        public void PaintToRed()
        {
            _currentEnumerator.Current.PhysicalObject.Paint(Color.red);
        }

        public void PaintToGreen()
        {
            _currentEnumerator.Current.PhysicalObject.Paint(Color.green);
        }

        public void PaintToBlue()
        {
            _currentEnumerator.Current.PhysicalObject.Paint(Color.blue);
        }

        public void Paint(Color color)
        {
            _currentEnumerator.Current.PhysicalObject.Paint(color);
        }

        public void MoveNext()
        {
            if (_objects == null || _objects.Count == 0)
            {
                Debug.LogWarning("Список объектов пуст");
                return;
            }
            Iterate();
            DisplayCurrentObject();
        }

        private void Iterate()
        {
            if (!_currentEnumerator.MoveNext())
            {
                _currentEnumerator.Reset();
                _currentEnumerator.MoveNext();
            }
        }

        private void DisplayCurrentObject()
        {
            _currentEnumerator.Current.PhysicalObject.Paint(Color.lightGray);
        }
    }
}