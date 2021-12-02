using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagment.Model
{
    public class Food
    {
        public int FoodId;
        public int GetFoodId() { return FoodId; }
        public void SetFoodId(int foodId) { FoodId = foodId; }

        public string FoodName;
        public string GetFoodName() { return FoodName; }
        public void SetFoodName(string name) { FoodName = name; }

        public CousineEnum CousineType;
        public CousineEnum GetCousineType() { return CousineType; }
        public void SetCousineType(CousineEnum cousineType) { CousineType = cousineType; }

        public Food(int foodId, string foodName, CousineEnum cousineType)
        {
            FoodId = foodId;
            FoodName = foodName;
            CousineType = cousineType;
        }
    }
}
