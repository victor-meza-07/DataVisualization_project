using DataVisualizator.Data.local_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataVisualizator.Data.Services
{
    public class ComponentService
    {

        public List<ComponentModel> ComponentList { get; set; }
        public ComponentService()
        {
            ComponentList = new List<ComponentModel>();
            RegisterComponents();
        }


        private void RegisterComponents() 
        {
            ComponentList.Add(new ComponentModel{ModelDisplayName="Linear Search",RelativePageLink="/ac_linearSearch"});
        }


        public void AddToComponentList(ComponentModel component) 
        {
            ComponentList.Add(component);
        } 
    }
}
