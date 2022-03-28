using Reception_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptionApp_2._0.Models
{
    public class MeetingsRepository
    {
        private readonly AppDBContext _context;

        public MeetingsRepository(AppDBContext context)
        {
            _context = context;
        }

        public Meeting CreateMeeting(Meeting newMeeting)
        {
            _context.Meetings.Add(newMeeting);
            _context.SaveChanges();
            return newMeeting;
        }

        public Meeting ReadMeeting(int id)
        {
            return _context.Meetings.Find(id);
        }

        public IEnumerable<Meeting> ReadMeetings()
        {
            return _context.Meetings;
        }

        public Meeting UpdateMeeting(Meeting meetingChanges)
        {
            var meeting = _context.Meetings.Attach(meetingChanges);
            meeting.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return meetingChanges;
        }

        public Meeting DeleteMeeting(int id)
        {
            var meeting = _context.Meetings.Find(id);

            if (meeting != null)
            {
                _context.Meetings.Remove(meeting);
                _context.SaveChanges();
            }

            return meeting;
        }
    }
}
