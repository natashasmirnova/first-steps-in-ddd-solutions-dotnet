using System;
using System.Collections.Generic;
using HarmelLaw.JusticeApp.Investigation;

namespace HarmelLaw.JusticeApp
{
    public class CriminalCase
    {
        public PNCId PNCId { get; set; }
        public HashSet<Suspect> Suspects { get; set; }
        public HashSet<Defendant> Defendants { get; set; }

        public CriminalCase(PNCId pncId, HashSet<Defendant> defendants)
        {
            PNCId = pncId;
            Defendants = defendants;
        }
    }
}