using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers_Part2_Dll_Namespace_Solution_2
{
    internal class Avtomat
    {
        public string ShootMode;
        public int BulletNumber;
        public string RefillGun;
        public void ShooterMode(string shootMode)
        {
            Console.WriteLine("Please Enter Shooting Mode : Single or Multi");
            shootMode = Console.ReadLine().ToLower();
            while (shootMode != "Single".ToLower() && shootMode != "Multi".ToLower())
            {
                Console.WriteLine("Please enter right...");
                shootMode = Console.ReadLine().ToLower();
            }
            ShootMode = shootMode;
        }
        public int Bullet()
        {
            Console.WriteLine("Please Fill Clip With Bullets:");
            int bulletNum = int.Parse(Console.ReadLine());
            int clipSize = 30;
            int bulletsInClip = default;
            if (bulletNum <= clipSize)
            {
                bulletsInClip = bulletNum;
                BulletNumber = bulletsInClip;
            }
            else
            {
                Console.WriteLine("HEEY MAN, HOLD ON! THAT'S TOO MANY BULLETS FOR THE CLIP. REDUCE THE NUMBER :D");
                BulletNumber = bulletNum;
            }
            if (BulletNumber > 30)
                return 0;
            else
            {
                if (ShootMode == "Single".ToLower())
                {
                    while (BulletNumber > 0)
                    {
                        BulletNumber--;
                        if (BulletNumber == 0) { Console.WriteLine($"BANG!! Nice single shot.Refill the gun"); break; }
                        Console.WriteLine($"BANG!! Nice single shot. Still you've {BulletNumber}");
                    }
                }
                else
                {
                    int multiShoot = 3;
                    if (BulletNumber == 1 || BulletNumber == 2)
                    {
                        Console.WriteLine("Please add more bullets");
                        return 0;
                    }
                    while (BulletNumber > 0)
                    {
                        BulletNumber -= multiShoot;
                        if (BulletNumber <= 0 || BulletNumber < 3) { Console.WriteLine($"BANG!! Nice multi shot.Refill the gun"); return 0; }
                        Console.WriteLine($"BANG!! Nice multi shot. Still you've {BulletNumber}");

                    }
                }
            }
            return 0;
        }
        public int Refill(string refill)
        {
            Console.WriteLine("Do you want to refill gun? Write Y/N");
            refill = Console.ReadLine();
            RefillGun = refill;
            if (refill == "Y")
            {
                return Bullet();
            }
            return 0;
        }
    }
}
