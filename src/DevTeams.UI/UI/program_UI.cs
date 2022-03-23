using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class program_UI
    {
        //this is our "connection" to ALL of our repositories
        private readonly Developer_Repository _Repository = new Developer_Repository();
        private readonly DevTeam_Repository _Repo2 = new DevTeam_Repository();

        public void Run()
        {
            SeedData();
            RunApplication();
        }

    // private void SeedData()
    // {
    //     throw new NotImplementedException();
    // }
    //Don't put it here, it'd be too crowded

    //Oi, making the beneath too complicated, ask for help on this one.

    private void RunApplication()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                System.Console.WriteLine("=== Komodo Insurance Management Application ===");
                System.Console.WriteLine("Please Make a Selection: /n" +
                "1. Add Developer to Team/n" +
                "2. View All Developers /n" +
                "3. View Developer By ID /n"+
                "4. Update Developer to Team/n"+
                "5. Delete Developer from Team/n"+
                "6. View All Developers/n"+
                "7. View Developer By ID/n"+
                "-----------------/n"+
                "50. Close Application/n"
                );
                  
                var userInput = Console.ReadLine();

            switch (userInput)
            {
                //remember command .
                case "1":
                    AddDevelopertoTeam();
                    break;
                case "2":
                    ViewAllDevelopers();
                    break;
                case "3":
                    ViewDeveloperByID();
                    break;
                case "4":
                    DeleteDeveloperfromTeam();
                    break;
                case "5":
                    AddDevelopertoTeam();
                    break;
                case "6":
                    ViewAllDevelopers();
                    break;
                case "7":
                    ViewDeveloperByID();
                    break;
                case "50":
                    isRunning = CloseApplication();
                    break;
                default:
                    System.Console.WriteLine("Invalid Selection");
                    PressAnyKeyToContinue();
                    break;
            }
        }
    }

    private bool ExitApplication()
    {
        Console.Clear();
        System.Console.WriteLine("Thanks!!!");
        PressAnyKeyToContinue();
        return false;
    }
//////////////////
       private void AddDevelopertoTeam()
    {
        Console.Clear();
        var newDeveloper = new Developer();
        System.Console.WriteLine("=== Developer Addition Form ===/n");

        System.Console.WriteLine("Please enter a Developer First Name:");
        newDeveloper.FirstName = Console.ReadLine();

        System.Console.WriteLine("Please Enter an Employee Last Name:");
        newDeveloper.LastName = Console.ReadLine();

        bool isSuccessful = _Repository.AddDeveloperToRepo(newDeveloper);
        if (isSuccessful)
        {
            System.Console.WriteLine($"{newDeveloper.FirstName} - {newDeveloper.LastName} was Added to the Database.");
        }
        else
        {
            System.Console.WriteLine("Employee Failed to be Added to the Database.");
        }
        PressAnyKeyToContinue();
    }
////////////////////////
        private void ViewAllDevelopers()
    {
        Console.Clear();
        List<Developer> developersInTeam = _Repository.GetAllDevelopers();

        if (developersInTeam.Count > 0)
        {
            foreach (Developer developer in developersInTeam)
            {
                ShowDeveloperDetails(developer);
            }
        }
        else
        {
            System.Console.WriteLine("There are no Developers.");
        }

        PressAnyKeyToContinue();
    }
////////////////////////
    private void ShowDeveloperDetails(Developer developer)
//'the shipping metaphor' This is the tag  ^^       ^^ This is the box^
    {
        throw new NotImplementedException();
    }
////////////////////////
    private void ViewDeveloperByID()
    {
        Console.Clear();
        System.Console.WriteLine("=== Developer Details===/n");
        System.Console.WriteLine("=== Please enter a Developer ID: /n");
        var userInputDeveloperID = int.Parse(Console.ReadLine());

        var developer = _Repository.GetDeveloperByID(userInputDeveloperID);

        if (developer != null)
        {
            ShowDeveloperDetails(developer);
        }
    }

//////////////////////////
        private void DeleteDeveloperfromTeam()
    {
        Console.Clear();
        System.Console.WriteLine("=== Removal Page ===");

        var developers = _Repository.GetAllDevelopers();
        foreach (Developer developer in developers)
        {
            ShowDeveloperListing(developers);
        }

        try{
            System.Console.WriteLine("Please select a Developer by their ID:");
            var userInputDeveloperID = int.Parse(Console.ReadLine());
            bool isSuccessful = _Repository.DeleteDeveloperfromTeam(userInputDeveloperID);
            if (isSuccessful)
            {
                System.Console.WriteLine("Developer was Successfully Fired.");
            }
            else
            {
                System.Console.WriteLine("Developer failed to be Fired.");
            }
        }
        catch
        {
            System.Console.WriteLine("Sorry, invalid.");
        }

        PressAnyKeyToContinue();
    }

    private void ShowDeveloperListing(List<Developer> developers)
    {
        throw new NotImplementedException();
    }

    private void PressAnyKeyToContinue()
    {
        System.Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
    private bool CloseApplication()
    {
        throw new NotImplementedException();
    }
    private void SeedData()
    {
        //create new developers
        var Liam = new Developer("William", "Aderyn");
        var Anya = new Developer("Anya", "Warner");
        var Kyle = new Developer("Kyle", "Hurst");
        var Yuri = new Developer("Yuri", "Auditor");
        //add them to the repo
        _Repo2.AddDevelopertoTeam(Liam);
        _Repo2.AddDevelopertoTeam(Anya);
        _Repo2.AddDevelopertoTeam(Kyle);
        _Repo2.AddDevelopertoTeam(Yuri);
        //create new teams 
        var tidebarer = new DevTeam("Tide-Barers");
        var hollow = new DevTeam("Hollow");
        //add the teams to the repo
        _Repository.AddDevTeamToRepo(tidebarer);
        _Repository.AddDevTeamToRepo(hollow);
        //the ram will automatically put the developers into their teams and test them right on the fly. 
    }
}
