using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Developer_Repository
    {
      private readonly List<Developer> _developerRepo = new List<Developer>();
      private int _count;
      public bool AddDeveloperToRepo(Developer developer)
      {
          if(developer != null)
          {
              _count++;
              developer.ID=_count;
              _developerRepo.Add(developer);
              return true;
          }
          else
          {
              return false;
          }
      }
      public List<Developer> GetAllDevelopers()
      {
          return _developerRepo;
      }
      public Developer GetDeveloperByID(int id)
      {
          foreach(var developer in _developerRepo)
          {
              if(developer.ID == id)
              {
                  return developer;
              }
          }
          return null;
      }

    public bool DeleteDeveloperfromTeam(int userInputDeveloperID)
    {
        throw new NotImplementedException();
    }

    public void AddDevTeamToRepo(DevTeam tidebarer)
    {
        throw new NotImplementedException();
    }
}