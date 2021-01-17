using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNightClubRPG
{
    enum Skills { Hacking, Psychology, CQC, LieDetection, Persuasion, Sneaking }
    class Character
    {
        //more properties will be added.
        Skills[] SkillSet;
      
        public Character(int charSelected)
        {
            switch(charSelected)
            {
                case 1:
                    {
                       SkillSet = new Skills[] {Skills.Hacking, Skills.CQC, Skills.LieDetection, Skills.Persuasion, Skills.Psychology, Skills.Sneaking};
                    }
                    break;
                    //cases for other characters will go here.
            }
        }

        public bool containsSkill(Skills skill)
        {
             for(int i = 0; i < SkillSet.Length; i++)
            {
                if (SkillSet[i] == skill)
                    return true;
            }

            return false;
        }

     
     }
}
      
