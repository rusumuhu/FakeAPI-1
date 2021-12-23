﻿using FakeAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeAPI
{
    public class MeetManager
    {
        List<Meet> meets = new List<Meet>();

        public void AddNewMeet(string name, DateTime meetTime)
        {
            Meet newMeet = new Meet() { Name = name, CreateTime = DateTime.Now, MeetTime = meetTime };
            meets.Add(newMeet);
        }
    }
}
