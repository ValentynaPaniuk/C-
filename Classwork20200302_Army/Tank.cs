using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200302_Army
{
    class Tank
    {
        /*Розробити програму, що моделює танковий бій. 
         * У танковому бою беруть участь 5 танків «Т-34» i  5 танків «Pantera». 
         * Кожен танк ( «Т-34» і «Pantera») описуються параметрами: 
         *  «Боєкомплект», 
         *  «Рівень броні», 
         *  «Рівень маневреності». 
         Значення даних параметрів задаються випадковими числами від 0 до 100. 
         Кожен танк бере участь в парній битві, тобто перший танк «Т-34» бореться з першим танком «Pantera» і т.д. 
         Перемога присуджується тому танку, який перевищує противника за двома і більше параметрами з трьох.
         * 
         * 
         * Тип: колёсно-гусеничный быстроходный лёгкий по типу «Кристи», с приводом на 6 колёс по типу «Кристи».
            Боевой вес: 13-14 тонн.
            Скорость движения: на гусеницах и колёсах скорости одинаковые. 
            Максимальная скорость — 70 км/ч, минимальная — 7 км/ч.
            Двигатель: дизель ХПЗ — мощность 400 лошад. сил.
            
            Экипаж: 3 человека.
            Запас хода: 300—400 км на гусеницах.

            Габариты танка: 
            дорожный просвет 0,4 м на гусеницах. 
            Высота танка 2,3 м.
            Удельное давление: 0,5 на гусеницах.*/

        public string NameTank { get; set; } = "NameTank";
        public int Power { get; set; } = 400; // мощьность двигателя
        public int Crew { get; set; } = 3; // екипаж
        
        public double Ground_clearance { get; set; } = 0.4; //дорожный просвет
        public double Height { get; set; } = 2.3; //висота
        public double Specific_pressure { get; set; } = 0.5; //удельное давление

        public int power_reserve; // запас хода
        public int Power_reserve
        {
            get { return power_reserve; }
            set
            {
                if (value > 300 && value < 400) { power_reserve = value; }
                else                            { Console.WriteLine("Enter correct data"); }
            }
        }

        int weight; //вес
        public int Weight
        {
            get { return weight; }
            set {
                if (value >= 13 && value <= 14) { weight = value;}
                else                            { Console.WriteLine("Enter correct data"); }}
          
        }

        int speed; // скорость
        public int Speed
        {
            get { return speed; }
            set { if        (value >= 7 && value <= 70) { speed = value; }
                  else                                  { Console.WriteLine("Enter correct data");} }

        }

        
  
        
        void AddArmament(Armament armament, Tank[] tanks)
        {
            armament.Gun_with_stabilizer = 45;
            armament.Machine_gun_dt = 3;
            armament.Self_defense_flamethrower = 1;
            armament.Gun_76_mm = 1;

            for (int i = 0; i < tanks.Length; i++)
            {
                if (i == 5)
                {
                    armament.Anti_aircraft_installation = 1;
                }
                else
                {
                    armament.Anti_aircraft_installation = 0;
                }
            }
        }

        void AddAmmunition(Ammunition ammunition)
        {
            ammunition.Machine_gun_cartridges = 2500;
            ammunition.Shell = 150;
        }


        void AddReservation(Reservation reservation)
        {
             reservation.Frontal_armor = 25;
             reservation.Conical_tower = 20;
             reservation.Side_armor = 13;
             reservation.Feed = 16;
             reservation.Roof = 10;
             reservation.Bottom = 10;
    }




    }
}
