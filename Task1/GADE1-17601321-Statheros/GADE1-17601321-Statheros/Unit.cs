using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1_17601321_Statheros
{

    //17601321 Nicholas Statheros
    //Unique code : Sazu0
    //main Unit class
    class Unit
    {
        protected int XPosition;
        protected int YPosition;
        protected int Health;
        protected int MaxHealth;
        protected int Speed;
        protected int Attack;
        protected int AttackRange;
        protected string team;
        protected string Symbol;
        protected int IsAttacking;

      
        public Unit()
        {

        }

        public abstract void NewPosition();
        public abstract void Combat();
        public abstract void RangeAttack();
        public abstract Unit ReturnPosition();
        public abstract void Death();
        public abstract override string ToString();



    }
}
