﻿using Library.Data.BaseRepository;
using Library.Framework.ContextModule;
using Library.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework.StudentRegistrationRepositories
{
    public interface IStudentRegistrationRepository : IRepository<StudentRegistration, int, FrameworkContext>
    {
    }
}
