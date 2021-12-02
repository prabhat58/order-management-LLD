using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagment.Model
{
    public class Chef
    {
        public int ChefId;
        public int GetChefId() { return ChefId; }
        public void SetChefId(int chefId) { ChefId = chefId; }

        public CousineEnum CousineType;
        public CousineEnum GetCousineType() { return CousineType; }
        public void SetCousineType(CousineEnum cousineType) { CousineType = cousineType; }

        public string Name;
        public int GetChefName() { return ChefId; }
        public void SetChefName(string name) { Name = name; }

        public Chef(int chefId, CousineEnum cousineType, string name)
        {
            ChefId = chefId;
            CousineType = cousineType;
            Name = name;
        }
    }
}
