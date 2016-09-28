using Outfit_Picker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outfit_Picker.ViewModels
{
    public class OutfitViewmodel
    {
        public Outfit Outfit { get; set; }
        public IEnumerable<SelectListItems> AllAccessories { get; set; }


        private List<int> _selectedAccessories;
        public List<int> SelectedAccessories
        {
            get
            {
                if (_selectedAccessories == null)
                {
                    _selectedAccessories = (from a in Outfit.Accessories
                                            select a.AccessoryId).ToList();
                }
                return _selectedAccessories;
            }
            set { _selectedAccessories = value; }
        }
    }
}