using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04_Hospital
{
    public class Department
    {
        private string name;
        private List<Room> rooms;

        public Department(string name)
        {
            this.Name = name;
            this.Rooms = new List<Room>();

            CreateRooms();
        }

        public string Name { get; set; }

        public List<Room> Rooms { get; set; }

        private void CreateRooms()
        {
            for (int i = 0; i < 20; i++)
            {
                this.Rooms.Add(new Room());
            }
        }

        public void AddPatientToRoom(Patient patient)
        {
            Room currentRoom = this.Rooms.FirstOrDefault(r => !r.IsFull);

            if (currentRoom != null)
            {
                currentRoom.Patients.Add(patient);
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var room in this.Rooms)
            {
                foreach (var patient in room.Patients)
                {
                    stringBuilder.AppendLine(patient.Name);
                }
            }

            return stringBuilder.ToString().TrimEnd();
        }

    }
}
