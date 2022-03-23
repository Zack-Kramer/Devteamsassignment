using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
    public class DevTeam_Repository
    {
        private readonly List<DevTeam> _DevTeamRepository = new List<DevTeam>();
        private int _count = 0;

    //CRUD: Create
    public bool AddDevTeamToDatabase(DevTeam devTeam)
    {
        if (devTeam != null)
        {
            //increment operator
            _count++;

            //assign _DevTeamRepository to
            devTeam.ID = _count;

            _DevTeamRepository.Add(devTeam);

            return true;
        }
        else{
            return false;
        }
    }

    public List<DevTeam> GetDevTeams(){
        return _DevTeamRepository;
    }

    //read /Gives and returns a devTeam
    public DevTeam GetDevTeamByID(int id)
    {
        foreach (DevTeam devTeam in _DevTeamRepository)
        {
            if (devTeam.ID == id){
                return devTeam;
            }
        }
        return null;
    }

    //update / complete clearing of data, but not the id's (OI! ASK ABOUT THIS ON SATURDAY IF THIS IS COVERED. JUST A RECAP.)
    public bool UpdatedevTeamRoster(int devTeamID, DevTeam newdevTeamRoster){
        DevTeam olddevTeamRoster = GetDevTeamByID(devTeamID);
        if (olddevTeamRoster != null)
        {
            olddevTeamRoster.Developers = olddevTeamRoster.Developers;
            return true;
        }
        else{
            return false;
        }
    }

    //delete
    public bool RemoveDevTeamFromDatabase (int id)
    {
        var devTeam = GetDevTeamByID(id);
        if (devTeam != null){
            _DevTeamRepository.Remove(devTeam);
            return true;
        }
        else{
            return false;
        }
    }

    public void AddDevelopertoTeam(Developer liam)
    {
        throw new NotImplementedException();
    }
}