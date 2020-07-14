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
        public List<ComponentModel> DataStructureList { get; set; }
        public ComponentService()
        {
            ComponentList = new List<ComponentModel>();
            DataStructureList = new List<ComponentModel>();
            RegisterComponents();
            RegisterDataStructures();
        }

        private void RegisterDataStructures()
        {
            DataStructureList.Add(new ComponentModel { ModelDisplayName = "Binary Search Tree", RelativePageLink = "/ds_BinarySearchTree"});
        }

        private void RegisterComponents() 
        {
            ComponentList.Add(new ComponentModel {ModelDisplayName="Sequential Search",RelativePageLink="/ac_SequentialSearch"});
            ComponentList.Add(new ComponentModel { ModelDisplayName = "Binary Search", RelativePageLink = "/ac_BinarySearch" });
        }

    }
}
