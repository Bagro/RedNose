using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Schemas;
using Updater.Entities;

namespace Updater.Profiles
{
    public class OpeningHoursResolver : IValueResolver<ButikerOmbudButikOmbud, Store, List<OpenHours>>
    {
        public List<OpenHours> Resolve(ButikerOmbudButikOmbud source, Store destination, List<OpenHours> destMember, ResolutionContext context)
        {
            var openHoursList = new List<OpenHours>();

            foreach (var oppetTid in source.Oppettider.Split(new char[] { '_', '*' }))
            {
                var parts = oppetTid.Split(';');
                parts[1].Equals(parts[2]).Equals("00:00");

                openHoursList.Add(new OpenHours
                {
                    Date = parts[0],
                    From = parts[1],
                    To = parts[2],
                    Closed = parts[1].Equals(parts[2]) && parts[1].Equals("00:00"),
                    SpecialDayName = parts[5].Length > 1 ? parts[5] : string.Empty
                });
            }

            return openHoursList;
        }
    }
}
