using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Sweepstakes
    {
        //use Dictonary Data Structure
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        int contestantCounter = 0;
        string contestantInformation;


        
        public Sweepstakes(string name)
        {


        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant = UserInterface.GetUserInput(contestant);
            contestant.registrationNumber = contestantCounter; //Assigns registraion number
            contestants.Add(contestantCounter, contestant); //Adds contestant info to list of contestants
            contestantCounter++;
        }

        public string PickWinner(Contestant contestant)
        {
            Random random = new Random();
            int IndexOfWinner = random.Next(0, contestantCounter);
            return contestants[IndexOfWinner].emailAddress;
            
            
            
        }

        public string PrintContestantInfo(Contestant contestant)
        {
            contestantInformation = String.Format(contestant.firstName, contestant.lastName);
            return contestantInformation;
        }
    }
}
