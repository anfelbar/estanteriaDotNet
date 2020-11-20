using System;
using System.ComponentModel.DataAnnotations;

namespace Estanteria.Data
{
    public class StateManagement
    {

        public string Property { get; set; } = "Initial value from StateContainer";
        public event Action OnChange;

        public void SetProperty(string value)
        {
            Property = value;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}