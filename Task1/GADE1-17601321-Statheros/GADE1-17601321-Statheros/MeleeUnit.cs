using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1_17601321_Statheros
{
    class MeleeUnit : Unit
    {
        //Melee Class


        public MeleeUnit(int XPosition, int YPosition, int Health, int MaxHealth, int Speed,
            int Attack, int AttackRange, string team, string symbol, int IsAttacking)
        {
            this.XPosition = XPosition;
            this.YPosition = YPosition;
            this.Health = Health;
            this.MaxHealth = MaxHealth;
            this.Speed = Speed;
            this.Attack = Attack;
            this.AttackRange = AttackRange;
            this.team = team;
            this.Symbol = symbol;
            this.IsAttacking = IsAttacking;

            
        }



    }
}
