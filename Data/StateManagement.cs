using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Estanteria.Data
{
    public class StateManagement
    {

        public string Property { get; set; } = "Initial value from StateContainer";
        public List<Product> ProductIds {get; set; }
        public event Action OnChange;

        public StateManagement(){
            ProductIds = new List<Product>(1);
        }
        public void SetProperty(string value)
        {
            Property = value;
            NotifyStateChanged();
        }
        public void AddProduct(Product p){
            ProductIds.Add(p);
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}