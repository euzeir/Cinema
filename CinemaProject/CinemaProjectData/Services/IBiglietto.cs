﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectData.Services
{
    public interface IBiglietto
    {
        void ApplicaScontoAnziani();
        void CalcolareRiduzioneBambini();
    }
}
