﻿using System.Collections;

namespace UniHouse.FirstVersion
{
    public class PancakeHouseMenu
    {
        public PancakeHouseMenu()
        {
            MenuItems = new ArrayList();
            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles, with your choice blueberries or strawberries", true, 3.59);
        }

        public ArrayList MenuItems { get; }

        public void AddItem(string name, string description, bool isVegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, isVegetarian, price);
            MenuItems.Add(menuItem);
        }
    }
}